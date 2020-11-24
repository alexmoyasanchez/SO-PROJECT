using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;
        Thread atender;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AtenderServidor()
        {
            while (true)
            {
                //Recibimos mensaje del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                string[] trozos = Encoding.ASCII.GetString(msg2).Split('/');
                int codigo = Convert.ToInt32(trozos[0]);
                string message = message = trozos[1].Split('\0')[0];

                switch (codigo)
                {
                    case 1:
                        MessageBox.Show(message);
                        break;

                    case 2:
                        MessageBox.Show(message);
                        break;

                    case 3:
                        MessageBox.Show(message);
                        break;

                    case 4:     
                        MessageBox.Show(message);
                        break;

                    case 5:
                        MessageBox.Show("New User accepted");
                        break;

                    case 6:
                        MessageBox.Show(message);
                        break;

                    case 7:
                        MessageBox.Show(message);
                        break;

                    case 8:
                        MessageBox.Show(message);
                        break;

                    case 9:
                        contLbl.Text = message;
                        break;
                }
            }
        }

        //Iniciar sesión
        private void button2_Click(object sender, EventArgs e)
        {
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9080);
            //Crear el socket
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);
                this.BackColor = Color.Green;
                MessageBox.Show("Conexion establecida");
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Cannot connect with the server");
                return;
            }

            //pongo en marcha el thread que atenderá los mensajes del servidor
            ThreadStart ts = delegate { AtenderServidor(); };
            atender = new Thread(ts);
            atender.Start();

        }
        //Crear cuenta
        private void button1_Click(object sender, EventArgs e)
        {
            //Enviamos la petición al servidor
            string message = "5/"+ Username.Text +"/"+ Password.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            server.Send(msg);
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            message = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show("New user accepted.");
         }

        private void button3_Click(object sender, EventArgs e)
        {
            //Enviamos la petición al servidor
            string message = "1/" + Username.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            server.Send(msg);
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            message = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show("Los amigos de " + Username.Text + " son " + message);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Enviamos la petición al servidor
            string message = "2/" + Username.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            server.Send(msg);
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            message = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show(Username.Text + " ha ganado el " + message + "% de las partidas");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Enviamos la petición al servidor
            string message = "3/" + Username.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            server.Send(msg);
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            message = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show(Username.Text + " ha ganado: " + message + " partidas");
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            string mensaje = "0/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string message = "4/" + Username.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            server.Send(msg);
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            message = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show(Username.Text + " ha jugado: " + message + " partidas");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string message = "6/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            server.Send(msg);
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            message = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show("El número de conectados y el nombre de estos es: " + message );
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Enviamos la petición al servidor
            string message = "7/" + Username.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            server.Send(msg);
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            message = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show(message);
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Enviamos la petición al servidor
            string message = "8/" + Username.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            server.Send(msg);
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            message = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show(message);
        }




    }
}
