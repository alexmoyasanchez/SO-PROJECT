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
using System.Threading;


namespace WindowsFormsApplication1
{
    public partial class PantallaInicio : Form
    {
        Socket servidor;
        Thread atender;
        delegate void DelegadoParaEscribir(string text);
        delegate void DelegadoParaActualizarLista(string[] nombres, int num);
        delegate void DelegadoParaGroupBox();
        delegate void DelegadoParaCerrar();
        List<string> conectados = new List<string>();
        List<string> invitados = new List<string>();

        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
        //Atender al servidor
        private void AtenderServidor()
        {
            while (true)
            {
                byte[] msg = new byte[500];
                servidor.Receive(msg);
                string[] trozos = Encoding.ASCII.GetString(msg).Split('/');
                try
                {
                    int opcion = Convert.ToInt32(trozos[0]);
                    string mensaje = trozos[1];
                    switch (opcion)
                    {
                        case 1: //Crear cuenta
                            if (mensaje =="1")
                            {
                                MessageBox.Show("Usuario registrado correctamente");
                            }
                            else
                            {
                                MessageBox.Show("El nombre de usuario no está disponible");

                            }
                            break;

                        case 2: //Iniciar sesion
                            if (Convert.ToInt32(mensaje) == 1)
                            {
                                MessageBox.Show("Bienvenido, has iniciado sesión correctamente.");
                                string message2 = "7/";
                                byte[] msgL = System.Text.Encoding.ASCII.GetBytes(message2);
                                servidor.Send(msgL);
                            }
                            else
                                MessageBox.Show("No se ha podido iniciar sesión, inténtelo de nuevo.");
                            break;
                        case 3: //Actualizar lista de conectados
                            string[] sConectados = mensaje.Split(',');
                            int n = Convert.ToInt32(sConectados[0]);
                                dataGridView1.RowCount = n;
                                dataGridView1.ColumnCount = 1;
                                int j = 1;
                                for (int i = 0; i < n; i++)
                                {
                                    dataGridView1[0, i].Value = sConectados[j];
                                    j++;
                                }
                            break;
                    }
                }
                catch (FormatException)
                {
                    this.Invoke(new DelegadoParaCerrar(Close), new object[] { });
                    break;
                }
            }
        }
        //Conectar con el servidor
        private void Conectar_Click(object sender, EventArgs e)
        {
            IPAddress direc = IPAddress.Parse("147.83.117.22");
            IPEndPoint ipep = new IPEndPoint(direc, 50010);
            servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                servidor.Connect(ipep);
                this.BackColor = Color.Green;
                MessageBox.Show("Bienvenido");
            }
            catch (SocketException)
            {
                MessageBox.Show("Cannot connect with the server");
                return;
            }
            ThreadStart ts = delegate { AtenderServidor(); };
            atender = new Thread(ts);
            atender.Start();
        }

        // Iniciar sesión
        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            string message = "6/"+ Username.Text +"/"+ Password.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            servidor.Send(msg);
            //AtenderServidor();
        }
        // Crear cuenta
        private void CrearCuenta_Click(object sender, EventArgs e)
        {
            string message = "5/"+ Username.Text +"/"+ Password.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            servidor.Send(msg);
           // AtenderServidor();
        }

        private void PorcentajeGanadas_Click(object sender, EventArgs e)
        {
            string message = "2/" + Username.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            servidor.Send(msg);
            byte[] msg2 = new byte[80];
            servidor.Receive(msg2);
            message = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show(Username.Text + " ha ganado el " + message + "% de las partidas");
        }

        private void PartidasGanadas_Click(object sender, EventArgs e)
        {
            string message = "3/" + Username.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            servidor.Send(msg);
            byte[] msg2 = new byte[80];
            servidor.Receive(msg2);
            message = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show(Username.Text + " ha ganado: " + message + " partidas");
        }

        private void PartidasJugadas_Click(object sender, EventArgs e)
        {
            string message = "4/" + Username.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            servidor.Send(msg);
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            servidor.Receive(msg2);
            message = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show(Username.Text + " ha jugado: " + message + " partidas");
        }


        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "0/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            servidor.Send(msg);

            this.BackColor = Color.Gray;
            servidor.Shutdown(SocketShutdown.Both);
            servidor.Close();
        }

        private void verAmigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Enviamos la petición al servidor
            string message = "1/" + Username.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            servidor.Send(msg);
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            servidor.Receive(msg2);
            message = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show("Los amigos de " + Username.Text + " son " + message);
        }



    }
}
