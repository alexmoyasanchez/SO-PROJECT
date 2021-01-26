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
        delegate void DelegadoParaActualizarGrupoPartida();
        List<string> conectados = new List<string>();
        List<string> invitados = new List<string>();
        List<string> grupoPartida = new List<string>();
        InterfazCluedo formPartida = new InterfazCluedo();

        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            empezar.Enabled = false;
            timer1.Enabled = true;
            timer1.Interval = 500;
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
                    switch (opcion)
                    {
                        case 2: //Iniciar sesion
                            if (Convert.ToInt32(trozos[1]) == 1)
                            {
                                MessageBox.Show("Bienvenido, has iniciado sesión correctamente.");
                                string message2 = "7/";
                                byte[] msgL = System.Text.Encoding.ASCII.GetBytes(message2);
                                servidor.Send(msgL);
                                j1.Text = Username.Text;
                            }
                            else
                                MessageBox.Show("No se ha podido iniciar sesión, inténtelo de nuevo.");
                            break;
                        case 3: //Actualizar lista de conectados
                            string[] sConectados = trozos[1].Split(',');
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
                        // Recibe la invitación de la partida
                        case 4:
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result;
                            result = MessageBox.Show(trozos[2], "invitacion", buttons);
                            //acepta la invitación de la partida
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                string message = "9/" + trozos[1] + "/" + Username.Text + "/yes";
                                byte[] msgL = System.Text.Encoding.ASCII.GetBytes(message);
                                servidor.Send(msgL);
                                if(trozos[1] != Username.Text)
                                    grupoPartida.Add(trozos[1]);
                            }
                            //rechaza la invitación de la partida
                            else
                            {
                                string message = "9/" + trozos[1] + "/" + Username.Text + "/no";
                                byte[] msgL = System.Text.Encoding.ASCII.GetBytes(message);
                                servidor.Send(msgL);
                                MessageBox.Show("Has cancelado la partida");
                            }
                            break;
                        //Ha acepatdo la partida
                        //Muestra el nuevo jugador en todos los jugadores
                        case 5:
                            if(grupoPartida.Count <5)
                            {
                                if (grupoPartida.Count == 1)
                                {
                                    j1.Text = trozos[1];
                                    j1.Checked = true;
                                    j2.Text = trozos[2];
                                    j2.Checked = true;
                                    grupoPartida.Add(trozos[2]);
                                }
                                else if (grupoPartida.Count == 2)
                                {
                                    j1.Text = trozos[1];
                                    j1.Checked = true;
                                    j2.Text = trozos[2];
                                    j2.Checked = true;
                                    j3.Text = trozos[3];
                                    j3.Checked = true;
                                    grupoPartida.Add(trozos[3]);
                                }
                                else if (grupoPartida.Count == 3)
                                {
                                    j1.Text = trozos[1];
                                    j1.Checked = true;
                                    j2.Text = trozos[2];
                                    j2.Checked = true;
                                    j3.Text = trozos[3];
                                    j3.Checked = true;
                                    j4.Text = trozos[4];
                                    j4.Checked = true;
                                    grupoPartida.Add(trozos[4]);
                                }
                                else if (grupoPartida.Count == 4)
                                {
                                    j1.Text = trozos[1];
                                    j1.Checked = true;
                                    j2.Text = trozos[2];
                                    j2.Checked = true;
                                    j3.Text = trozos[3];
                                    j3.Checked = true;
                                    j4.Text = trozos[4];
                                    j4.Checked = true;
                                    j5.Text = trozos[5];
                                    j5.Checked = true;
                                    grupoPartida.Add(trozos[5]);
                                }
                                else if (grupoPartida.Count == 5)
                                {
                                    j1.Text = trozos[1];
                                    j1.Checked = true;
                                    j2.Text = trozos[2];
                                    j2.Checked = true;
                                    j3.Text = trozos[3];
                                    j3.Checked = true;
                                    j4.Text = trozos[4];
                                    j4.Checked = true;
                                    j5.Text = trozos[5];
                                    j5.Checked = true;
                                    j6.Text = trozos[6];
                                    j6.Checked = true;
                                    grupoPartida.Add(trozos[6]);
                                }
                                else
                                    MessageBox.Show("Ya no se pueden añadir mas jugadores a la partida, empezad la partida!");
                                }
                            break;
                        //Ha rechazado la partida
                        //Notifica al lider de la partida el invitado que ha rechazado
                        case 6:
                            string invitadorechazado=trozos[1];
                            if (j2.Text == invitadorechazado)
                                j2.Text = "Jugador vacio";
                            else if (j3.Text == invitadorechazado)
                                j3.Text = "Jugador vacio";
                            else if (j4.Text == invitadorechazado)
                                j4.Text = "Jugador vacio";
                            else if (j5.Text == invitadorechazado)
                                j5.Text = "Jugador vacio";
                            else
                                j6.Text = "Jugador vacio";
                            break;
                        //Chat
                        case 7: 
                            string jugadorchat = trozos[1];
                            string datoschat = trozos[2];
                            chat.AppendText(jugadorchat + ":" + datoschat);
                            break;
                        //Preparar partida e iniciar 
                        case 8:
                            formPartida.SetJugadores(Username.Text,grupoPartida);
                            formPartida.Setficha(Convert.ToInt16(trozos[1]));
                            MessageBox.Show("Paso 1: Tira los dados con el boton tirar. Paso 2: Moverte con las flechas por el tablero. ¡Cuidado! si haces un movimiento no podras deshacerlo, asi que ves con cuidado. Paso 3: Cuando entres en una sala y solo si entras en una sala, tendras que escoger a un jugador al cual le preguntaras por un personaje, un arma y un lugar mediante el boton 'preguntar'. Paso 4: cuando tengas seguro la solucion al crimen pulsa 'acusacion final' para proponer la solucion al crimen.");
                            formPartida.SetCartas(trozos[2]);
                            formPartida.ShowDialog();
                            break;
                        //Escoger ficha/Personaje
                        case 9:
                            string[] bloqueos = trozos[2].Split(',');
                            int turno = Convert.ToInt32(trozos[1]) + 1;
                            EscogerPersonaje formpersonajes = new EscogerPersonaje();
                            formpersonajes.Bloqueos(Convert.ToInt32(bloqueos[0]), Convert.ToInt32(bloqueos[1]), Convert.ToInt32(bloqueos[2]), Convert.ToInt32(bloqueos[3]), Convert.ToInt32(bloqueos[4]));
                            formpersonajes.ShowDialog();
                            int newBloq = formpersonajes.GetPersonaje();
                            string enviarbloqueo;
                            if (turno == 1)
                            {
                                enviarbloqueo = newBloq + ",0,0,0,0";
                            }
                            else if (turno == 2)
                            {
                                enviarbloqueo = bloqueos[0] + "," + newBloq + ",0,0,0";
                            }
                            else if (turno == 3)
                            {
                                enviarbloqueo = bloqueos[0] + "," + bloqueos[1] + "," + newBloq + ",0,0";
                            }
                            else if (turno == 4)
                            {
                                enviarbloqueo = bloqueos[0] + "," + bloqueos[1] + "," + bloqueos[2] + "," + newBloq + ",0";
                            }
                            else if (turno == 5)
                            {
                                enviarbloqueo = bloqueos[0] + "," + bloqueos[1] + "," + bloqueos[2] +"," + bloqueos[3] + "," + newBloq;
                            }
                            else 
                            {
                                enviarbloqueo = bloqueos[0] + "," + bloqueos[1] + "," + bloqueos[2] + "," + bloqueos[3] + "," + bloqueos[4] + "," + newBloq;
                            }
                            string mes = "10/" + turno + "/" + enviarbloqueo + "/siguienteturno";
                            byte[] msgP = System.Text.Encoding.ASCII.GetBytes(mes);
                            servidor.Send(msgP);
                            break;
                        //Turnos
                        case 10:
                            formPartida.SetCartas(trozos[1]);
                            break;
                        //Actualizar fichas y movimientos 
                        case 11:
                            
                            break;
                         //Cambiar turno
                        case 12:
                            formPartida.SetTurno(Convert.ToInt32(trozos[1]), Username.Text);
                            string []mov= trozos[2].Split(',');
                            int ldx = Convert.ToInt32(mov[0]);
                            int ldy = Convert.ToInt32(mov[1]);
                            int lgx = Convert.ToInt32(mov[2]);
                            int lgy = Convert.ToInt32(mov[3]);
                            int llx = Convert.ToInt32(mov[4]);
                            int lly = Convert.ToInt32(mov[5]);
                            int lax = Convert.ToInt32(mov[6]);
                            int lay = Convert.ToInt32(mov[7]);
                            int lvx = Convert.ToInt32(mov[8]);
                            int lvy = Convert.ToInt32(mov[9]);
                            int lmx = Convert.ToInt32(mov[10]);
                            int lmy = Convert.ToInt32(mov[11]);
                            MessageBox.Show(Convert.ToString(lax));
                            formPartida.mover(ldx, ldy, lgx, lgy, llx, lly, lax, lay, lvx, lvy, lmx, lmy);
                            break;
                        //Comprobar acusacion final
                        case 13:
                            if (trozos[2] == "ganador")
                            {
                                MessageBox.Show("El ganador de la partida es {0}", trozos[1]);
                                formPartida.Close();
                            }
                            else
                                MessageBox.Show("Aun no hay ganador,seguid investigando!");
                            break;
                        case 14:
                            
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
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9080);
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

            string message = "6/" + Username.Text + "/" + Password.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            servidor.Send(msg);
            Username.Enabled = false;
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
            byte[] msg2 = new byte[80];
            servidor.Receive(msg2);
            message = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show(Username.Text + " ha jugado: " + message + " partidas");
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

        private void enviarchat_Click(object sender, EventArgs e)
        {
            string mensaje = "12/" + Username.Text + "/" + mensajechat.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            servidor.Send(msg);
        }

        //Invitar jugadores seleccionados
        private void invitarButton_Click(object sender, EventArgs e)
        {
            j1.Text = Username.Text;
            grupoPartida.Add(Username.Text);
            empezar.Enabled = true;
            string message = "8/" + Username.Text + "/";
            int i=0;
            while (i < invitados.Count)
            {
                message = message + invitados.ElementAt(i) + "/";
                i = i + 1;
            }
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            servidor.Send(msg);
            if (invitados.Count == 1)
                j2.Text = invitados.ElementAt(0);
            else if (invitados.Count == 2)
            {
                j2.Text = invitados.ElementAt(0);
                j3.Text = invitados.ElementAt(1);
            }
            else if (invitados.Count == 3)
            {
                j2.Text = invitados.ElementAt(0);
                j3.Text = invitados.ElementAt(1);
                j4.Text = invitados.ElementAt(2);
            }
            else if (invitados.Count == 4)
            {
                j2.Text = invitados.ElementAt(0);
                j3.Text = invitados.ElementAt(1);
                j4.Text = invitados.ElementAt(2);
                j5.Text = invitados.ElementAt(3);
            }
            else if (invitados.Count == 5)
            {
                j2.Text = invitados.ElementAt(0);
                j3.Text = invitados.ElementAt(1);
                j4.Text = invitados.ElementAt(2);
                j5.Text = invitados.ElementAt(3);
                j6.Text = invitados.ElementAt(4);
            }
        }

        //DataGidView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string invitado = dataGridView1.CurrentCell.Value.ToString();
            if (invitados.Count < 5)
            {
                bool encontrado = false;
                int k = 0;
                while (k <= (invitados.Count) && !encontrado)
                {
                    if (invitados.Count > 0)
                    {
                        if ((invitado == Username.Text) || (invitados.ElementAt(k) == invitado))
                        {
                            encontrado = true;
                        }
                        else
                            k = k + 1;
                    }
                    else
                    {
                        if (Username.Text == invitado)
                            encontrado = true;
                        k = k + 1;
                    }
                }
                if(encontrado == false)
                    invitados.Add(invitado);
            }
            else
                MessageBox.Show("Ya hay 6 jugadores");
        }
        //Empezar partida
        //Solo lo puede clicar el lider 
        private void empezar_Click(object sender, EventArgs e)
        {
            string message = "10/0/0,0,0,0,0/empezarpartida";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            servidor.Send(msg);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (formPartida.GetFinTurno() == true)
            {
                string posiciones = formPartida.actualizar();
                string message = "14/" + formPartida.GetTurno() + "/" + posiciones;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
                formPartida.SetFinTurno(false);
                servidor.Send(msg);
            }
            if (formPartida.GetRespuesta() == true)
            {
                string pregunta=formPartida.GetPregunta();
                string message = "11/"+ pregunta;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
                servidor.Send(msg);
                formPartida.SetRespuesta(false);
            }
            if (formPartida.GetAcusacionFinal() == true)
            {
                int i = 0;
                bool encontrado = false;
                while ((i < grupoPartida.Count) && (!encontrado))
                {
                    if (grupoPartida.ElementAt(i) == Username.Text)
                        encontrado = true;
                    else
                        i++;
                }
                if ((i - 1) == grupoPartida.Count)
                    i = 0;
                else
                    i++;
                string message = "15/" + i + "/" + formPartida.GetPregunta();
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
                servidor.Send(msg);
                formPartida.SetAcusacionFinal(false);
            }

        }
     
    }
}
