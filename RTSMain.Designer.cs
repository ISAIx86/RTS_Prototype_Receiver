namespace RTS_Prototype_Receiver
{
    partial class RTSMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbx_ports = new System.Windows.Forms.ComboBox();
            this.btn_start_end = new System.Windows.Forms.Button();
            this.btn_setreload = new System.Windows.Forms.Button();
            this.btn_unsetreload = new System.Windows.Forms.Button();
            this.btn_execshoot = new System.Windows.Forms.Button();
            this.frametime = new System.Windows.Forms.Timer(this.components);
            this.btn_shootstate = new System.Windows.Forms.Button();
            this.btn_reloadstate = new System.Windows.Forms.Button();
            this.btn_switchstate = new System.Windows.Forms.Button();
            this.tbx_acc_x = new System.Windows.Forms.TextBox();
            this.tbx_acc_y = new System.Windows.Forms.TextBox();
            this.tbx_gyr_x = new System.Windows.Forms.TextBox();
            this.tbx_gyr_y = new System.Windows.Forms.TextBox();
            this.tbx_gyr_z = new System.Windows.Forms.TextBox();
            this.tbx_rot_z = new System.Windows.Forms.TextBox();
            this.tbx_rot_y = new System.Windows.Forms.TextBox();
            this.tbx_rot_x = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pgb_acc_x = new System.Windows.Forms.ProgressBar();
            this.pgb_acc_y = new System.Windows.Forms.ProgressBar();
            this.pgb_gyr_x = new System.Windows.Forms.ProgressBar();
            this.pgb_gyr_y = new System.Windows.Forms.ProgressBar();
            this.pgb_gyr_z = new System.Windows.Forms.ProgressBar();
            this.tbx_acc_z = new System.Windows.Forms.TextBox();
            this.pgb_acc_z = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_dispose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_ports
            // 
            this.cbx_ports.BackColor = System.Drawing.Color.White;
            this.cbx_ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ports.FormattingEnabled = true;
            this.cbx_ports.Location = new System.Drawing.Point(13, 13);
            this.cbx_ports.Name = "cbx_ports";
            this.cbx_ports.Size = new System.Drawing.Size(217, 21);
            this.cbx_ports.TabIndex = 0;
            // 
            // btn_start_end
            // 
            this.btn_start_end.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btn_start_end.Location = new System.Drawing.Point(236, 13);
            this.btn_start_end.Name = "btn_start_end";
            this.btn_start_end.Size = new System.Drawing.Size(53, 21);
            this.btn_start_end.TabIndex = 1;
            this.btn_start_end.Text = "Start";
            this.btn_start_end.UseVisualStyleBackColor = false;
            this.btn_start_end.Click += new System.EventHandler(this.btn_start_end_Click);
            // 
            // btn_setreload
            // 
            this.btn_setreload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btn_setreload.ForeColor = System.Drawing.Color.White;
            this.btn_setreload.Location = new System.Drawing.Point(13, 71);
            this.btn_setreload.Name = "btn_setreload";
            this.btn_setreload.Size = new System.Drawing.Size(86, 38);
            this.btn_setreload.TabIndex = 2;
            this.btn_setreload.Text = "Set Reload";
            this.btn_setreload.UseVisualStyleBackColor = false;
            this.btn_setreload.Click += new System.EventHandler(this.btn_setreload_Click);
            // 
            // btn_unsetreload
            // 
            this.btn_unsetreload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btn_unsetreload.ForeColor = System.Drawing.Color.White;
            this.btn_unsetreload.Location = new System.Drawing.Point(13, 115);
            this.btn_unsetreload.Name = "btn_unsetreload";
            this.btn_unsetreload.Size = new System.Drawing.Size(86, 38);
            this.btn_unsetreload.TabIndex = 3;
            this.btn_unsetreload.Text = "Unset Reload";
            this.btn_unsetreload.UseVisualStyleBackColor = false;
            this.btn_unsetreload.Click += new System.EventHandler(this.btn_unsetreload_Click);
            // 
            // btn_execshoot
            // 
            this.btn_execshoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btn_execshoot.ForeColor = System.Drawing.Color.White;
            this.btn_execshoot.Location = new System.Drawing.Point(13, 313);
            this.btn_execshoot.Name = "btn_execshoot";
            this.btn_execshoot.Size = new System.Drawing.Size(86, 38);
            this.btn_execshoot.TabIndex = 4;
            this.btn_execshoot.Text = "Execute Shoot";
            this.btn_execshoot.UseVisualStyleBackColor = false;
            this.btn_execshoot.Click += new System.EventHandler(this.btn_execshoot_Click);
            // 
            // frametime
            // 
            this.frametime.Enabled = true;
            this.frametime.Interval = 16;
            this.frametime.Tick += new System.EventHandler(this.frametime_Tick);
            // 
            // btn_shootstate
            // 
            this.btn_shootstate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btn_shootstate.ForeColor = System.Drawing.Color.White;
            this.btn_shootstate.Location = new System.Drawing.Point(365, 52);
            this.btn_shootstate.Name = "btn_shootstate";
            this.btn_shootstate.Size = new System.Drawing.Size(79, 82);
            this.btn_shootstate.TabIndex = 5;
            this.btn_shootstate.Text = "Shooting";
            this.btn_shootstate.UseVisualStyleBackColor = false;
            // 
            // btn_reloadstate
            // 
            this.btn_reloadstate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btn_reloadstate.ForeColor = System.Drawing.Color.White;
            this.btn_reloadstate.Location = new System.Drawing.Point(365, 140);
            this.btn_reloadstate.Name = "btn_reloadstate";
            this.btn_reloadstate.Size = new System.Drawing.Size(79, 82);
            this.btn_reloadstate.TabIndex = 6;
            this.btn_reloadstate.Text = "Reloading";
            this.btn_reloadstate.UseVisualStyleBackColor = false;
            // 
            // btn_switchstate
            // 
            this.btn_switchstate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btn_switchstate.ForeColor = System.Drawing.Color.White;
            this.btn_switchstate.Location = new System.Drawing.Point(365, 228);
            this.btn_switchstate.Name = "btn_switchstate";
            this.btn_switchstate.Size = new System.Drawing.Size(79, 82);
            this.btn_switchstate.TabIndex = 7;
            this.btn_switchstate.Text = "Switch";
            this.btn_switchstate.UseVisualStyleBackColor = false;
            // 
            // tbx_acc_x
            // 
            this.tbx_acc_x.Location = new System.Drawing.Point(144, 71);
            this.tbx_acc_x.Name = "tbx_acc_x";
            this.tbx_acc_x.ReadOnly = true;
            this.tbx_acc_x.Size = new System.Drawing.Size(86, 20);
            this.tbx_acc_x.TabIndex = 10;
            // 
            // tbx_acc_y
            // 
            this.tbx_acc_y.Location = new System.Drawing.Point(144, 97);
            this.tbx_acc_y.Name = "tbx_acc_y";
            this.tbx_acc_y.ReadOnly = true;
            this.tbx_acc_y.Size = new System.Drawing.Size(86, 20);
            this.tbx_acc_y.TabIndex = 11;
            // 
            // tbx_gyr_x
            // 
            this.tbx_gyr_x.Location = new System.Drawing.Point(144, 178);
            this.tbx_gyr_x.Name = "tbx_gyr_x";
            this.tbx_gyr_x.ReadOnly = true;
            this.tbx_gyr_x.Size = new System.Drawing.Size(86, 20);
            this.tbx_gyr_x.TabIndex = 12;
            // 
            // tbx_gyr_y
            // 
            this.tbx_gyr_y.Location = new System.Drawing.Point(144, 204);
            this.tbx_gyr_y.Name = "tbx_gyr_y";
            this.tbx_gyr_y.ReadOnly = true;
            this.tbx_gyr_y.Size = new System.Drawing.Size(86, 20);
            this.tbx_gyr_y.TabIndex = 13;
            // 
            // tbx_gyr_z
            // 
            this.tbx_gyr_z.Location = new System.Drawing.Point(144, 230);
            this.tbx_gyr_z.Name = "tbx_gyr_z";
            this.tbx_gyr_z.ReadOnly = true;
            this.tbx_gyr_z.Size = new System.Drawing.Size(86, 20);
            this.tbx_gyr_z.TabIndex = 14;
            // 
            // tbx_rot_z
            // 
            this.tbx_rot_z.Location = new System.Drawing.Point(144, 331);
            this.tbx_rot_z.Name = "tbx_rot_z";
            this.tbx_rot_z.ReadOnly = true;
            this.tbx_rot_z.Size = new System.Drawing.Size(86, 20);
            this.tbx_rot_z.TabIndex = 17;
            // 
            // tbx_rot_y
            // 
            this.tbx_rot_y.Location = new System.Drawing.Point(144, 305);
            this.tbx_rot_y.Name = "tbx_rot_y";
            this.tbx_rot_y.ReadOnly = true;
            this.tbx_rot_y.Size = new System.Drawing.Size(86, 20);
            this.tbx_rot_y.TabIndex = 16;
            // 
            // tbx_rot_x
            // 
            this.tbx_rot_x.Location = new System.Drawing.Point(144, 279);
            this.tbx_rot_x.Name = "tbx_rot_x";
            this.tbx_rot_x.ReadOnly = true;
            this.tbx_rot_x.Size = new System.Drawing.Size(86, 20);
            this.tbx_rot_x.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Acceleration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Gyroscope";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(144, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Rotation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(126, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(126, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(126, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(126, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(126, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "z";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(126, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "z";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(126, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(126, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "x";
            // 
            // pgb_acc_x
            // 
            this.pgb_acc_x.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(108)))), ((int)(((byte)(143)))));
            this.pgb_acc_x.Location = new System.Drawing.Point(236, 71);
            this.pgb_acc_x.Maximum = 50;
            this.pgb_acc_x.Name = "pgb_acc_x";
            this.pgb_acc_x.Size = new System.Drawing.Size(92, 20);
            this.pgb_acc_x.Step = 1;
            this.pgb_acc_x.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgb_acc_x.TabIndex = 29;
            // 
            // pgb_acc_y
            // 
            this.pgb_acc_y.Location = new System.Drawing.Point(236, 97);
            this.pgb_acc_y.Maximum = 50;
            this.pgb_acc_y.Name = "pgb_acc_y";
            this.pgb_acc_y.Size = new System.Drawing.Size(92, 20);
            this.pgb_acc_y.Step = 1;
            this.pgb_acc_y.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgb_acc_y.TabIndex = 30;
            // 
            // pgb_gyr_x
            // 
            this.pgb_gyr_x.Location = new System.Drawing.Point(236, 178);
            this.pgb_gyr_x.Maximum = 50;
            this.pgb_gyr_x.Name = "pgb_gyr_x";
            this.pgb_gyr_x.Size = new System.Drawing.Size(92, 20);
            this.pgb_gyr_x.Step = 1;
            this.pgb_gyr_x.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgb_gyr_x.TabIndex = 31;
            // 
            // pgb_gyr_y
            // 
            this.pgb_gyr_y.Location = new System.Drawing.Point(236, 204);
            this.pgb_gyr_y.Maximum = 50;
            this.pgb_gyr_y.Name = "pgb_gyr_y";
            this.pgb_gyr_y.Size = new System.Drawing.Size(92, 20);
            this.pgb_gyr_y.Step = 1;
            this.pgb_gyr_y.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgb_gyr_y.TabIndex = 32;
            // 
            // pgb_gyr_z
            // 
            this.pgb_gyr_z.Location = new System.Drawing.Point(236, 230);
            this.pgb_gyr_z.Maximum = 50;
            this.pgb_gyr_z.Name = "pgb_gyr_z";
            this.pgb_gyr_z.Size = new System.Drawing.Size(92, 20);
            this.pgb_gyr_z.Step = 1;
            this.pgb_gyr_z.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgb_gyr_z.TabIndex = 33;
            // 
            // tbx_acc_z
            // 
            this.tbx_acc_z.Location = new System.Drawing.Point(144, 123);
            this.tbx_acc_z.Name = "tbx_acc_z";
            this.tbx_acc_z.ReadOnly = true;
            this.tbx_acc_z.Size = new System.Drawing.Size(86, 20);
            this.tbx_acc_z.TabIndex = 34;
            // 
            // pgb_acc_z
            // 
            this.pgb_acc_z.Location = new System.Drawing.Point(236, 123);
            this.pgb_acc_z.Maximum = 50;
            this.pgb_acc_z.Name = "pgb_acc_z";
            this.pgb_acc_z.Size = new System.Drawing.Size(92, 20);
            this.pgb_acc_z.Step = 1;
            this.pgb_acc_z.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgb_acc_z.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(126, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "z";
            // 
            // btn_dispose
            // 
            this.btn_dispose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btn_dispose.Location = new System.Drawing.Point(391, 13);
            this.btn_dispose.Name = "btn_dispose";
            this.btn_dispose.Size = new System.Drawing.Size(53, 21);
            this.btn_dispose.TabIndex = 37;
            this.btn_dispose.Text = "Dispose";
            this.btn_dispose.UseVisualStyleBackColor = false;
            this.btn_dispose.Click += new System.EventHandler(this.btn_dispose_Click);
            // 
            // RTSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(456, 366);
            this.Controls.Add(this.btn_dispose);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pgb_acc_z);
            this.Controls.Add(this.tbx_acc_z);
            this.Controls.Add(this.pgb_gyr_z);
            this.Controls.Add(this.pgb_gyr_y);
            this.Controls.Add(this.pgb_gyr_x);
            this.Controls.Add(this.pgb_acc_y);
            this.Controls.Add(this.pgb_acc_x);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_rot_z);
            this.Controls.Add(this.tbx_rot_y);
            this.Controls.Add(this.tbx_rot_x);
            this.Controls.Add(this.tbx_gyr_z);
            this.Controls.Add(this.tbx_gyr_y);
            this.Controls.Add(this.tbx_gyr_x);
            this.Controls.Add(this.tbx_acc_y);
            this.Controls.Add(this.tbx_acc_x);
            this.Controls.Add(this.btn_switchstate);
            this.Controls.Add(this.btn_reloadstate);
            this.Controls.Add(this.btn_shootstate);
            this.Controls.Add(this.btn_execshoot);
            this.Controls.Add(this.btn_unsetreload);
            this.Controls.Add(this.btn_setreload);
            this.Controls.Add(this.btn_start_end);
            this.Controls.Add(this.cbx_ports);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RTSMain";
            this.Text = "RTS Bluetooth Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RTSMain_FormClosing);
            this.Load += new System.EventHandler(this.RTSMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_ports;
        private System.Windows.Forms.Button btn_start_end;
        private System.Windows.Forms.Button btn_setreload;
        private System.Windows.Forms.Button btn_unsetreload;
        private System.Windows.Forms.Button btn_execshoot;
        private System.Windows.Forms.Timer frametime;
        private System.Windows.Forms.Button btn_shootstate;
        private System.Windows.Forms.Button btn_reloadstate;
        private System.Windows.Forms.Button btn_switchstate;
        private System.Windows.Forms.TextBox tbx_acc_x;
        private System.Windows.Forms.TextBox tbx_acc_y;
        private System.Windows.Forms.TextBox tbx_gyr_x;
        private System.Windows.Forms.TextBox tbx_gyr_y;
        private System.Windows.Forms.TextBox tbx_gyr_z;
        private System.Windows.Forms.TextBox tbx_rot_z;
        private System.Windows.Forms.TextBox tbx_rot_y;
        private System.Windows.Forms.TextBox tbx_rot_x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar pgb_acc_x;
        private System.Windows.Forms.ProgressBar pgb_acc_y;
        private System.Windows.Forms.ProgressBar pgb_gyr_x;
        private System.Windows.Forms.ProgressBar pgb_gyr_y;
        private System.Windows.Forms.ProgressBar pgb_gyr_z;
        private System.Windows.Forms.TextBox tbx_acc_z;
        private System.Windows.Forms.ProgressBar pgb_acc_z;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_dispose;
    }
}

