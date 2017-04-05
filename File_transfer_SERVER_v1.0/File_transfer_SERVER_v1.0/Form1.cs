using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Net;
using System.Net.Sockets;
using MetroFramework.Forms;
using MetroFramework;
using System.Threading;

namespace File_transfer_SERVER_v1._0
{
    
    public partial class Server_form : MetroForm
    {
        string ip = "";
        string port = "";
        int no_of_client = 0;
        public Server_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {

                    text_box_ip.Text = address.ToString();
                }
            }
        }

        Socket[] clientSock ;
        Socket sock;
        int i;
        private void text_box_start_server_Click(object sender, EventArgs e)
        {
            
            try
            {
                ip = text_box_ip.Text;
                port = text_box_port.Text;
                no_of_client = Int32.Parse(textbox_noofclient.Text);
                IPEndPoint ipEnd = new IPEndPoint(IPAddress.Any, Int32.Parse(port));
                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sock.Bind(ipEnd);
                sock.Listen(no_of_client);
                clientSock = new Socket[no_of_client];

                MetroMessageBox.Show(this, "Server is running", "Server started", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_box_clientlist.AppendText("Server is running...\n");




                for (i = 0; i < no_of_client; i++)
                {

                    clientSock[i] = sock.Accept();
                    if (clientSock[i].Connected)
                    {
                        MetroMessageBox.Show(this, "New client is connected to the server", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        text_box_clientlist.AppendText(((IPEndPoint)clientSock[i].RemoteEndPoint).Address.ToString() + " is connected\n");
                    }


                    try
                    {

                        //byte[] buffer = new byte[1024];
                        //int response = clientSock[i].Receive(buffer);
                        //char[] chars = new char[response];
                        //System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
                        //int charlen = d.GetChars(buffer, 0, response, chars, 0);
                        //string mess = new string(chars);
                        //text_box_clientlist.AppendText(((IPEndPoint)clientSock[i].RemoteEndPoint).Address.ToString()+" "+mess + "\n");


                        byte[] buffer = new byte[1024];
                        int response = clientSock[i].Receive(buffer);
                        char[] chars = new char[response];
                        System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
                        int charlen = d.GetChars(buffer, 0, response, chars, 0);
                        string fileName = new string(chars);


                        byte[] fileNameByte = Encoding.ASCII.GetBytes(fileName);
                        // MessageBox.Show(fileName);

                        buffer = new byte[1024];
                        response = clientSock[i].Receive(buffer);
                        chars = new char[response];
                        d = System.Text.Encoding.UTF8.GetDecoder();
                        charlen = d.GetChars(buffer, 0, response, chars, 0);
                        string filepath = new string(chars);

                        if (MetroMessageBox.Show(this, "Do you wish to continue", "Send the requested file " + fileName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            byte[] fileData = File.ReadAllBytes(@"" + filepath);
                            MessageBox.Show(Encoding.UTF8.GetString(buffer, 0, buffer.Length));


                            byte[] clientData = new byte[4 + fileNameByte.Length + fileData.Length];
                            byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);

                            fileNameLen.CopyTo(clientData, 0);
                            fileNameByte.CopyTo(clientData, 4);
                            fileData.CopyTo(clientData, 4 + fileNameByte.Length);


                            clientSock[i].Send(clientData);
                            MetroMessageBox.Show(this, "File: " + fileName + " has been sent to " + ((IPEndPoint)clientSock[i].RemoteEndPoint).Address.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            text_box_clientlist.AppendText("File: " + fileName + " has been sent.\n");
                            //Console.WriteLine("File:{0} has been sent.", fileName);

                            text_box_clientlist.AppendText(((IPEndPoint)clientSock[i].RemoteEndPoint).Address.ToString() + " is disconnected\n");

                            clientSock[i].Close();
                        }
                        else
                        {
                            text_box_clientlist.AppendText(((IPEndPoint)clientSock[i].RemoteEndPoint).Address.ToString() + " is disconnected\n");
                            fileName = "";

                            clientSock[i].Close();
                        }

                    }
                    catch (Exception ex)
                    {

                        MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    // MessageBox.Show("paichi ");


                }
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        //void checking_connection()
        //{
        //    for (int i=0; i<no_of_client; i++)
        //    {
        //        clientSock[i] = sock.Accept();
        //        if (clientSock[i].Connected)
        //        {
        //            MetroMessageBox.Show(this, "New client is connected to the server", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            text_box_clientlist.AppendText(((IPEndPoint)clientSock[i].RemoteEndPoint).Address.ToString() + " is connected\n");
        //        }
        //        else
        //        {
        //            continue;
        //        }
        //    }
        //}

        
        

        

        
    }
}
