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
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Iniciar sesión
        private void button2_Click(object sender, EventArgs e)
        {
            IPAddress direc = IPAddress.Parse("192.168.1.104");
            IPEndPoint ipep = new IPEndPoint(direc, 9050);
            //Crear el socket
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);
                this.BackColor = Color.Green;
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Cannot connect with the server");
                return;
            }
        }
        //Crear cuenta
        private void button1_Click(object sender, EventArgs e)
        {
            //Enviamos la petición al servidor
            string player = Username.Text;
            string password = Password.Text;
            string message = "0/"+player+"/"+ password;
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
            string player = Username.Text;
            string password = Password.Text;
            string message = "0/" + player + "/" + password;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            server.Send(msg);
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            message = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show("New user accepted.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Enviamos la petición al servidor
            string player = Username.Text;
            string message = "2/" + player;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            server.Send(msg);
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            message = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show("Ha ganado {0} partidas", message);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Enviamos la petición al servidor
            string player = Username.Text;
            string message = "3/" + player;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            server.Send(msg);
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            message = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show("Ha ganado {0}% de partidas jugadas.", message);
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }
        



    }
}
