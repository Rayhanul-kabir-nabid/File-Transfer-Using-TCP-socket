namespace File_transfer_SERVER_v1._0
{
    partial class Server_form
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.text_box_ip = new MetroFramework.Controls.MetroTextBox();
            this.text_box_port = new MetroFramework.Controls.MetroTextBox();
            this.text_box_start_server = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.text_box_clientlist = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textbox_noofclient = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(20, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "IP";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 84);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "PORT";
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
            this.text_box_ip.Location = new System.Drawing.Point(13, 47);
            this.text_box_ip.MaxLength = 32767;
            this.text_box_ip.Name = "text_box_ip";
            this.text_box_ip.PasswordChar = '\0';
            this.text_box_ip.ReadOnly = true;
            this.text_box_ip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_box_ip.SelectedText = "";
            this.text_box_ip.SelectionLength = 0;
            this.text_box_ip.SelectionStart = 0;
            this.text_box_ip.Size = new System.Drawing.Size(172, 23);
            this.text_box_ip.TabIndex = 4;
            this.text_box_ip.UseSelectable = true;
            this.text_box_ip.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_box_ip.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.text_box_port.Location = new System.Drawing.Point(13, 119);
            this.text_box_port.MaxLength = 32767;
            this.text_box_port.Name = "text_box_port";
            this.text_box_port.PasswordChar = '\0';
            this.text_box_port.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_box_port.SelectedText = "";
            this.text_box_port.SelectionLength = 0;
            this.text_box_port.SelectionStart = 0;
            this.text_box_port.Size = new System.Drawing.Size(172, 23);
            this.text_box_port.TabIndex = 5;
            this.text_box_port.UseSelectable = true;
            this.text_box_port.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_box_port.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // text_box_start_server
            // 
            this.text_box_start_server.Image = null;
            this.text_box_start_server.Location = new System.Drawing.Point(13, 241);
            this.text_box_start_server.Name = "text_box_start_server";
            this.text_box_start_server.Size = new System.Drawing.Size(172, 48);
            this.text_box_start_server.TabIndex = 6;
            this.text_box_start_server.Text = "Start Server";
            this.text_box_start_server.UseSelectable = true;
            this.text_box_start_server.UseVisualStyleBackColor = true;
            this.text_box_start_server.Click += new System.EventHandler(this.text_box_start_server_Click);
            // 
            // text_box_clientlist
            // 
            // 
            // 
            // 
            this.text_box_clientlist.CustomButton.Image = null;
            this.text_box_clientlist.CustomButton.Location = new System.Drawing.Point(-129, 1);
            this.text_box_clientlist.CustomButton.Name = "";
            this.text_box_clientlist.CustomButton.Size = new System.Drawing.Size(299, 299);
            this.text_box_clientlist.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.text_box_clientlist.CustomButton.TabIndex = 1;
            this.text_box_clientlist.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.text_box_clientlist.CustomButton.UseSelectable = true;
            this.text_box_clientlist.CustomButton.Visible = false;
            this.text_box_clientlist.Lines = new string[0];
            this.text_box_clientlist.Location = new System.Drawing.Point(25, 3);
            this.text_box_clientlist.MaxLength = 32767;
            this.text_box_clientlist.Multiline = true;
            this.text_box_clientlist.Name = "text_box_clientlist";
            this.text_box_clientlist.PasswordChar = '\0';
            this.text_box_clientlist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_box_clientlist.SelectedText = "";
            this.text_box_clientlist.SelectionLength = 0;
            this.text_box_clientlist.SelectionStart = 0;
            this.text_box_clientlist.Size = new System.Drawing.Size(171, 301);
            this.text_box_clientlist.TabIndex = 7;
            this.text_box_clientlist.UseSelectable = true;
            this.text_box_clientlist.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.text_box_clientlist.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 159);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "No of Client";
            // 
            // textbox_noofclient
            // 
            // 
            // 
            // 
            this.textbox_noofclient.CustomButton.Image = null;
            this.textbox_noofclient.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.textbox_noofclient.CustomButton.Name = "";
            this.textbox_noofclient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_noofclient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_noofclient.CustomButton.TabIndex = 1;
            this.textbox_noofclient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_noofclient.CustomButton.UseSelectable = true;
            this.textbox_noofclient.CustomButton.Visible = false;
            this.textbox_noofclient.Lines = new string[0];
            this.textbox_noofclient.Location = new System.Drawing.Point(15, 197);
            this.textbox_noofclient.MaxLength = 32767;
            this.textbox_noofclient.Name = "textbox_noofclient";
            this.textbox_noofclient.PasswordChar = '\0';
            this.textbox_noofclient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_noofclient.SelectedText = "";
            this.textbox_noofclient.SelectionLength = 0;
            this.textbox_noofclient.SelectionStart = 0;
            this.textbox_noofclient.Size = new System.Drawing.Size(170, 23);
            this.textbox_noofclient.TabIndex = 11;
            this.textbox_noofclient.UseSelectable = true;
            this.textbox_noofclient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_noofclient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.textbox_noofclient);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.text_box_start_server);
            this.metroPanel1.Controls.Add(this.text_box_ip);
            this.metroPanel1.Controls.Add(this.text_box_port);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(42, 97);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 301);
            this.metroPanel1.TabIndex = 13;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.text_box_clientlist);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(437, 97);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(214, 309);
            this.metroPanel2.TabIndex = 14;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // Server_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 536);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Server_form";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox text_box_ip;
        private MetroFramework.Controls.MetroTextBox text_box_port;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton text_box_start_server;
        private MetroFramework.Controls.MetroTextBox text_box_clientlist;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox textbox_noofclient;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;


    }
}

