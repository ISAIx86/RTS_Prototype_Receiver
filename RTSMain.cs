using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;
using Newtonsoft.Json;
using System.Threading;
using System.Collections.Generic;

namespace RTS_Prototype_Receiver
{

    public partial class RTSMain : Form
    {

        SerialPort serialport = null;

        int btbaudrate = 115200;
        int btwait = 500;

        char cmd_getState = 'g';
        char cmd_setReloading = 'r';
        char cmd_unsetReloading = 'f';
        char cmd_executeShoot = 'e';

        bool isClosed = false;

        Thread rtsDataListener = null;

        private List<char> send_buffer = new List<char>();

        Color RTSBtnBackColor = Color.FromArgb(45, 49, 51);
        Color RTSFontColor = Color.White;

        private void initializePort(string portname, int baudrate, int readtimeout)
        {
            if (serialport != null) return;
            serialport = new SerialPort();
            serialport.PortName = portname;
            serialport.BaudRate = baudrate;
            serialport.ReadTimeout = readtimeout;
            //serialport.DataReceived += eventReceiveBT;

            //serialport.Dispose();
            serialport.Open();
        }
        private void releasePort()
        {
            if (serialport == null) return;
            serialport.Close();
            serialport.Dispose();
            serialport = null;
        }
        private void initializeReadingThread()
        {
            rtsDataListener = new Thread(listenSerial);
            rtsDataListener.Start();
        }
        private void releaseReadingThread()
        {
            rtsDataListener?.Abort();
            rtsDataListener = null;
        }
        private void setAppIcon()
        {
            Bitmap h_icon = (Bitmap)Image.FromFile("icon.png");
            this.Icon = Icon.FromHandle(h_icon.GetHicon());
        }
        private void getPorts()
        {
            string[] portnames = SerialPort.GetPortNames();
            foreach (string port in portnames)
            {
                cbx_ports.Items.Add(port);
            }
        }

        private void sendCommand(char command)
        {
            if (serialport != null && serialport.IsOpen)
            {
                byte[] commandbytes = { Convert.ToByte(command) };
                serialport.Write(commandbytes, 0, commandbytes.Length);
            }
        }

        private void RTSMain_Load(object sender, EventArgs e)
        {
            setAppIcon();
            getPorts();
        }
        private void btn_start_end_Click(object sender, EventArgs e)
        {

            if (cbx_ports.SelectedIndex == -1) return;

            if (serialport == null)
            {

                try
                {
                    initializePort(
                        cbx_ports.SelectedItem.ToString(),
                        btbaudrate,
                        btwait
                     );
                    //serialport.Dispose();
                    //serialport.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show("No se pudo emparejar el dispositivo. " + ex.Message, "Fallo de emparejamiento");
                    releasePort();
                    return;
                }

                initializeReadingThread();

                btn_start_end.Text = "Stop";
                btn_start_end.BackColor = Color.PaleGreen;
                btn_start_end.ForeColor = Color.Black;

            } else
            {

                try
                {
                    isClosed = true;
                    releasePort();
                } catch
                {
                    MessageBox.Show("No se pudo desconectar.", "Fallo de emparejamiento");
                    serialport.Dispose();
                    return;
                }

                btn_start_end.Text = "Start";
                btn_start_end.BackColor = RTSBtnBackColor;
                btn_start_end.ForeColor = RTSFontColor;

            }
            
        }
        private void frametime_Tick(object sender, EventArgs e)
        {
            if (!(serialport != null && serialport.IsOpen)) return;

            send_buffer.Add(cmd_getState);

            foreach (char command in send_buffer)
            {
                sendCommand(command);
            }

            send_buffer.Clear();

        }
        private void RTSMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                releasePort();
                releaseReadingThread();
            } catch
            {

            }
        }
        private void eventReceiveBT (object sender, EventArgs e)
        {
            try
            {
                string buffer = serialport.ReadTo("\n");

            } catch (TimeoutException)
            {
            }
        }

        private void btn_execshoot_Click(object sender, EventArgs e)
        {
            send_buffer.Add(cmd_executeShoot);
        }
        private void btn_setreload_Click(object sender, EventArgs e)
        {
            send_buffer.Add(cmd_setReloading);
        }
        private void btn_unsetreload_Click(object sender, EventArgs e)
        {
            send_buffer.Add(cmd_unsetReloading);
        }
        private void btn_getstate_Click(object sender, EventArgs e)
        {
            send_buffer.Add(cmd_getState);
        }
        private void btn_dispose_Click(object sender, EventArgs e)
        {
            serialport.Dispose();
        }

        private void listenSerial()
        {
            while (!isClosed)
            {
                try
                {

                    if (serialport == null) return;

                    string buffer = serialport.ReadLine();
                    string[] data = buffer.Split(',');

                    if (data.Length != 13) continue;
                
                    btn_shootstate.Invoke(new MethodInvoker(
                        delegate
                        {
                            if (data[0] == "1")
                            {
                                btn_shootstate.BackColor = Color.Red;
                            }
                            else
                            {
                                btn_shootstate.BackColor = RTSBtnBackColor;
                            }
                        }
                    ));

                    btn_reloadstate.Invoke(new MethodInvoker(
                        delegate
                        {
                            if (data[1] == "1")
                            {
                                btn_reloadstate.BackColor = Color.Yellow;
                                btn_reloadstate.ForeColor = Color.Black;
                            }
                            else
                            {
                                btn_reloadstate.BackColor = RTSBtnBackColor;
                                btn_reloadstate.ForeColor = RTSFontColor;
                            }
                        }
                    ));

                    btn_switchstate.Invoke(new MethodInvoker(
                        delegate
                        {
                            if (data[2] == "1")
                            {
                                btn_switchstate.BackColor = Color.Green;
                            }
                            else
                            {
                                btn_switchstate.BackColor = RTSBtnBackColor;
                            }
                        }
                    ));

                    tbx_acc_x.Invoke(new MethodInvoker(
                        delegate
                        {
                            tbx_acc_x.Text = data[4];
                            int value = Math.Abs(Convert.ToInt32(Convert.ToDouble(data[4]) * 15));
                            pgb_acc_x.Value = value < 0 ? 0 : (value > 50 ? 50 : value);
                        }
                    ));

                    tbx_acc_y.Invoke(new MethodInvoker(
                        delegate
                        {
                            tbx_acc_y.Text = data[5];
                            int value = Math.Abs(Convert.ToInt32(Convert.ToDouble(data[5]) * 15));
                            pgb_acc_y.Value = value < 0 ? 0 : (value > 50 ? 50 : value);
                        }
                    ));

                    tbx_acc_z.Invoke(new MethodInvoker(
                        delegate
                        {
                            tbx_acc_z.Text = data[6];
                            int value = Math.Abs(Convert.ToInt32(Convert.ToDouble(data[6]) * 15));
                            pgb_acc_z.Value = value < 0 ? 0 : (value > 50 ? 50 : value);
                        }
                    ));

                    tbx_gyr_x.Invoke(new MethodInvoker(
                        delegate
                        {
                            tbx_gyr_x.Text = data[7];
                            int value = Math.Abs(Convert.ToInt32(Convert.ToDouble(data[7])));
                            pgb_gyr_x.Value = value < 0 ? 0 : (value > 50 ? 50 : value);
                        }
                    ));

                    tbx_gyr_y.Invoke(new MethodInvoker(
                        delegate
                        {
                            tbx_gyr_y.Text = data[8];
                            int value = Math.Abs(Convert.ToInt32(Convert.ToDouble(data[8])));
                            pgb_gyr_y.Value = value < 0 ? 0 : (value > 50 ? 50 : value);
                        }
                    ));

                    tbx_gyr_z.Invoke(new MethodInvoker(
                        delegate
                        {
                            tbx_gyr_z.Text = data[9];
                            int value = Math.Abs(Convert.ToInt32(Convert.ToDouble(data[9])));
                            pgb_gyr_z.Value = value < 0 ? 0 : (value > 50 ? 50 : value);
                        }
                    ));

                    tbx_rot_x.Invoke(new MethodInvoker(
                        delegate
                        {
                            tbx_rot_x.Text = data[10];
                        }
                    ));

                    tbx_rot_y.Invoke(new MethodInvoker(
                        delegate
                        {
                            tbx_rot_y.Text = data[11];
                        }
                    ));

                    tbx_rot_z.Invoke(new MethodInvoker(
                        delegate
                        {
                            tbx_rot_z.Text = data[12];
                        }
                    ));

                }
                catch (JsonReaderException je)
                {
                    Console.WriteLine(je.Message);
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        public RTSMain()
        {
            InitializeComponent();
        }

        
    }
}
