namespace File_transfer_CLIENT_v1._0
{
    partial class Client_form
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
            this.button_connect_server = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.text_box_port = new MetroFramework.Controls.MetroTextBox();
            this.text_box_ip = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_send_request_to_save = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.SuspendLayout();
            // 
            // button_connect_server
            // 
            this.button_connect_server.Image = null;
            this.button_connect_server.Location = new System.Drawing.Point(61, 268);
            this.button_connect_server.Name = "button_connect_server";
            this.button_connect_server.Size = new System.Drawing.Size(172, 48);
            this.button_connect_server.TabIndex = 11;
            this.button_connect_server.Text = "Connect to Server";
            this.button_connect_server.UseSelectable = true;
            this.button_connect_server.UseVisualStyleBackColor = true;
            this.button_connect_server.Click += new System.EventHandler(this.button_connect_server_Click);
            // 
            // text_box_port
            // 
            // 
            // 
            // 
            this.text_box_port.CustomButton.Image = null;
            this.text_box_port.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.text_box_port.CustomButton.Name = "";
            this.text_box_port.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.text_box_port.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.text_box_port.CustomButton.TabIndex = 1;
            this.text_box_port.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.text_box_port.CustomButton.UseSelectable = true;
            this.text_box_port.CustomButton.Visible = false;
            this.text_box_port.Lines = new string[0];
            this.text_box_port.Location = new System.Drawing.Point(61, 200);
            this.text_box_port.MaxLength = 32767;
            this.text_box_port.Name = "text_box_port";
            this.text_box_port.PasswordChar = '\0';
            this.text_box_port.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_box_port.SelectedText = "";
            this.text_box_port.SelectionLength = 0;
            this.text_box_port.SelectionStart = 0;
            this.text_box_port.Size = new System.Drawing.Size(172, 23);
            this.text_box_port.TabIndex = 10;
            this.text_box_port.UseSelectable = true;
            this.text_box_port.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_box_port.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // text_box_ip
            // 
            // 
            // 
            // 
            this.text_box_ip.CustomButton.Image = null;
            this.text_box_ip.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.text_box_ip.CustomButton.Name = "";
            this.text_box_ip.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.text_box_ip.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.text_box_ip.CustomButton.TabIndex = 1;
            this.text_box_ip.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.text_box_ip.CustomButton.UseSelectable = true;
            this.text_box_ip.CustomButton.Visible = false;
            this.text_box_ip.Lines = new string[0];
            this.text_box_ip.Location = new System.Drawing.Point(61, 128);
            this.text_box_ip.MaxLength = 32767;
            this.text_box_ip.Name = "text_box_ip";
            this.text_box_ip.PasswordChar = '\0';
            this.text_box_ip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_box_ip.SelectedText = "";
            this.text_box_ip.SelectionLength = 0;
            this.text_box_ip.SelectionStart = 0;
            this.text_box_ip.Size = new System.Drawing.Size(172, 23);
            this.text_box_ip.TabIndex = 9;
            this.text_box_ip.UseSelectable = true;
            this.text_box_ip.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_box_ip.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(61, 165);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "PORT";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(61, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(20, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "IP";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(279, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Choose file to save";
            // 
            // metroButton1
            // 
            this.metroButton1.AutoSize = true;
            this.metroButton1.Location = new System.Drawing.Point(279, 128);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(172, 23);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "Browse folder........";
            this.metroButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(279, 165);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(148, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Choose location to save";
            // 
            // metroButton2
            // 
            this.metroButton2.AutoSize = true;
            this.metroButton2.Location = new System.Drawing.Point(279, 200);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(172, 23);
            this.metroButton2.TabIndex = 15;
            this.metroButton2.Text = "Browse..............";
            this.metroButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_send_request_to_save
            // 
            this.button_send_request_to_save.Image = null;
            this.button_send_request_to_save.Location = new System.Drawing.Point(279, 268);
            this.button_send_request_to_save.Name = "button_send_request_to_save";
            this.button_send_request_to_save.Size = new System.Drawing.Size(172, 48);
            this.button_send_request_to_save.TabIndex = 16;
            this.button_send_request_to_save.Text = "Send Request to Save";
            this.button_send_request_to_save.UseSelectable = true;
            this.button_send_request_to_save.UseVisualStyleBackColor = true;
            this.button_send_request_to_save.Click += new System.EventHandler(this.button_send_request_to_save_Click);
            // 
            // Client_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 536);
            this.Controls.Add(this.button_send_request_to_save);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.button_connect_server);
            this.Controls.Add(this.text_box_port);
            this.Controls.Add(this.text_box_ip);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Name = "Client_form";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton button_connect_server;
        private MetroFramework.Controls.MetroTextBox text_box_port;
        private MetroFramework.Controls.MetroTextBox text_box_ip;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton button_send_request_to_save;
    }
}

