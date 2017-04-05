using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;
using MetroFramework.Forms;
using MetroFramework;


namespace File_transfer_CLIENT_v1._0
{
    public partial class Client_form : MetroForm
    {
        public Client_form()
        {
            InitializeComponent();
        }
        string ip = "";
        string port = "";
        string file = "";
        string path = "";
        byte[] clientData = new byte[1024 * 5000];
        string receivedPath = "";
        Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) 
            {
                file = openFileDialog1.SafeFileName;
                path = @""+openFileDialog1.FileName;
                metroButton1.Text = path;
            }
          
        }

        private void button_send_request_to_save_Click(object sender, EventArgs e)
        {
            if (file != "" && path != "" && receivedPath != "")
            {
                try
                {
                   // MessageBox.Show(file.Length.ToString() + " " + path.Length.ToString());
                    
                    byte[] bydata = System.Text.Encoding.ASCII.GetBytes(file);
                    clientSock.Send(bydata);
                    
                    //MessageBox.Show("Geche 2");
                    bydata = System.Text.Encoding.ASCII.GetBytes(path);
                    clientSock.Send(bydata);
                   
                   // MessageBox.Show("Geche 3");
                    int receivedBytesLen = clientSock.Receive(clientData);

                    int fileNameLen = BitConverter.ToInt32(clientData, 0);
                    
                    string fileName = Encoding.ASCII.GetString(clientData, 4, fileNameLen);


                    BinaryWriter bWrite = new BinaryWriter(File.Open(receivedPath + fileName, FileMode.Append)); ;
                    bWrite.Write(clientData, 4 + fileNameLen, receivedBytesLen - 4 - fileNameLen);

                    MetroMessageBox.Show(this, "File: " + fileName + " received && saved at path: " + receivedPath + "\n", "Confirmation\n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bWrite.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Request rejected\n"+ex.ToString(), "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                //MessageBox.Show("Fulfill the requirement at first");
                MetroMessageBox.Show(this, "Fulfill every requirement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //clientSock.Close();
            //Console.ReadLine();
        }
        
        private void metroButton2_Click(object sender, EventArgs e)
        {


            DialogResult result1 = folderBrowserDialog1.ShowDialog();
            if (result1 == DialogResult.OK)
            {
                string f = folderBrowserDialog1.SelectedPath.ToString()+"\\";
                receivedPath = @""+f;
                metroButton2.Text = receivedPath;
               // MessageBox.Show(receivedPath);

            }
        }
        

        private void button_connect_server_Click(object sender, EventArgs e)
        {
            ip = text_box_ip.Text;
            port = text_box_port.Text;
            try
            {
                IPAddress[] ipAddress = Dns.GetHostAddresses(ip);
                IPEndPoint ipEnd = new IPEndPoint(ipAddress[0], Int32.Parse(port));
                clientSock.Connect(ipEnd);
                MetroMessageBox.Show(this, "Connected", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
                
            }

        }
    }
}
