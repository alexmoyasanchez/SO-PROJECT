using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Questionario : Form
    {
        int jugador;
        int personaje;
        int arma;
        int habitacion;
        string pregunta;
        List<string> jugadores = new List<string>();
        string username;
        public Questionario()
        {
            InitializeComponent();
        }

        private void Questionario_Load(object sender, EventArgs e)
        {
            bool encontrado=false;
            int i=0;
            while ((i < jugadores.Count)&&(!encontrado))
            {
                if (username == jugadores.ElementAt(i))
                    encontrado = true;
                else
                    i = i + 1;
            }
            if (jugadores.Count==2)
            {   
                jugador1.Text = jugadores.ElementAt(0);
                jugador2.Text = jugadores.ElementAt(1);
                jugador3.Text = "";
                jugador4.Text = "";
                jugador5.Text = "";
                jugador6.Text = "";
            }
            else if (jugadores.Count == 3)
            {
                jugador1.Text = jugadores.ElementAt(0);
                jugador2.Text = jugadores.ElementAt(1);
                jugador3.Text = jugadores.ElementAt(2);
                jugador4.Text = "";
                jugador5.Text = "";
                jugador6.Text = "";
            }
            else if(jugadores.Count==4)
            {
                jugador1.Text = jugadores.ElementAt(0);
                jugador2.Text = jugadores.ElementAt(1);
                jugador3.Text = jugadores.ElementAt(2);
                jugador4.Text = jugadores.ElementAt(3);
                jugador5.Text = "";
                jugador6.Text = "";
            }
            else if(jugadores.Count==5)
            {
                jugador1.Text = jugadores.ElementAt(0);
                jugador2.Text = jugadores.ElementAt(1);
                jugador3.Text = jugadores.ElementAt(2);
                jugador4.Text = jugadores.ElementAt(3);
                jugador5.Text = jugadores.ElementAt(4);
                jugador6.Text = "";
            }
            else
            {
                jugador1.Text = jugadores.ElementAt(0);
                jugador2.Text = jugadores.ElementAt(1);
                jugador3.Text = jugadores.ElementAt(2);
                jugador4.Text = jugadores.ElementAt(3);
                jugador5.Text = jugadores.ElementAt(4);
                jugador6.Text = jugadores.ElementAt(5);
            }

            if (jugador1.Text == jugadores.ElementAt(i))
            { 
                jugador1.Enabled = false;
                jugador1.BackColor = Color.Red;
            }
            else if (jugador2.Text == jugadores.ElementAt(i))
            {
                jugador2.Enabled = false;
                jugador2.BackColor = Color.Red;
            }
            else if (jugador3.Text == jugadores.ElementAt(i))
            {
                jugador3.Enabled = false;
                jugador3.BackColor = Color.Red;
            }
            else if (jugador4.Text == jugadores.ElementAt(i))
            {
                jugador4.Enabled = false;
                jugador4.BackColor = Color.Red;
            }
            else if (jugador5.Text == jugadores.ElementAt(i))
            {
                jugador5.Enabled = false;
                jugador5.BackColor = Color.Red;
            }
            else if (jugador6.Text == jugadores.ElementAt(i))
            {
                jugador6.Enabled = false;
                jugador6.BackColor = Color.Red;
            }
        }
        // Seleccionar personaje
        private void rubio_Click(object sender, EventArgs e)
        {
            rubio.Enabled = false;
            mora.Enabled = false;
            prado.Enabled = false;
            celeste.Enabled = false;
            escarlata.Enabled = false;
            blanco.Enabled = false;
            SetPersonaje(1);
        }
        private void mora_Click(object sender, EventArgs e)
        {
            rubio.Enabled = false;
            mora.Enabled = false;
            prado.Enabled = false;
            celeste.Enabled = false;
            escarlata.Enabled = false;
            blanco.Enabled = false;
            SetPersonaje(2);
        }
        private void prado_Click(object sender, EventArgs e)
        {
            rubio.Enabled = false;
            mora.Enabled = false;
            prado.Enabled = false;
            celeste.Enabled = false;
            escarlata.Enabled = false;
            blanco.Enabled = false;
            SetPersonaje(3);
        }
        private void celeste_Click(object sender, EventArgs e)
        {
            rubio.Enabled = false;
            mora.Enabled = false;
            prado.Enabled = false;
            celeste.Enabled = false;
            escarlata.Enabled = false;
            blanco.Enabled = false;
            SetPersonaje(4);
        }
        private void escarlata_Click(object sender, EventArgs e)
        {
            rubio.Enabled = false;
            mora.Enabled = false;
            prado.Enabled = false;
            celeste.Enabled = false;
            escarlata.Enabled = false;
            blanco.Enabled = false;
            SetPersonaje(5);
        }
        private void blanco_Click(object sender, EventArgs e)
        {
            rubio.Enabled = false;
            mora.Enabled = false;
            prado.Enabled = false;
            celeste.Enabled = false;
            escarlata.Enabled = false;
            blanco.Enabled = false;
            SetPersonaje(6);
        }
        //Seleccionar armas
        private void punal_Click(object sender, EventArgs e)
        {
            punal.Enabled = false;
            candelabro.Enabled = false;
            pistola.Enabled = false;
            cuerda.Enabled = false;
            tuberia.Enabled = false;
            herramienta.Enabled = false;
            SetArma(7);
        }

        private void candelabro_Click(object sender, EventArgs e)
        {
            punal.Enabled = false;
            candelabro.Enabled = false;
            pistola.Enabled = false;
            cuerda.Enabled = false;
            tuberia.Enabled = false;
            herramienta.Enabled = false;
            SetArma(8);
        }

        private void pistola_Click(object sender, EventArgs e)
        {
            punal.Enabled = false;
            candelabro.Enabled = false;
            pistola.Enabled = false;
            cuerda.Enabled = false;
            tuberia.Enabled = false;
            herramienta.Enabled = false;
            SetArma(9);
        }

        private void cuerda_Click(object sender, EventArgs e)
        {
            punal.Enabled = false;
            candelabro.Enabled = false;
            pistola.Enabled = false;
            cuerda.Enabled = false;
            tuberia.Enabled = false;
            herramienta.Enabled = false;
            SetArma(10);
        }

        private void tuberia_Click(object sender, EventArgs e)
        {
            punal.Enabled = false;
            candelabro.Enabled = false;
            pistola.Enabled = false;
            cuerda.Enabled = false;
            tuberia.Enabled = false;
            herramienta.Enabled = false;
            SetArma(11);
        }

        private void herramienta_Click(object sender, EventArgs e)
        {
            punal.Enabled = false;
            candelabro.Enabled = false;
            pistola.Enabled = false;
            cuerda.Enabled = false;
            tuberia.Enabled = false;
            herramienta.Enabled = false;
            SetArma(12);
        }

        //Seleccionar habitacion

        private void vestibulo_Click(object sender, EventArgs e)
        {
            vestibulo.Enabled = false;
            salon.Enabled = false;
            comedor.Enabled = false;
            cocina.Enabled = false;
            salademusica.Enabled = false;
            conservatorio.Enabled = false;
            saladebillar.Enabled = false;
            biblioteca.Enabled = false;
            estudio.Enabled = false;
            SetHabitacion(13);
        }

        private void salon_Click(object sender, EventArgs e)
        {
            vestibulo.Enabled = false;
            salon.Enabled = false;
            comedor.Enabled = false;
            cocina.Enabled = false;
            salademusica.Enabled = false;
            conservatorio.Enabled = false;
            saladebillar.Enabled = false;
            biblioteca.Enabled = false;
            estudio.Enabled = false;
            SetHabitacion(14);
        }

        private void comedor_Click(object sender, EventArgs e)
        {
            vestibulo.Enabled = false;
            salon.Enabled = false;
            comedor.Enabled = false;
            cocina.Enabled = false;
            salademusica.Enabled = false;
            conservatorio.Enabled = false;
            saladebillar.Enabled = false;
            biblioteca.Enabled = false;
            estudio.Enabled = false;
            SetHabitacion(15);
        }

        private void cocina_Click(object sender, EventArgs e)
        {
            vestibulo.Enabled = false;
            salon.Enabled = false;
            comedor.Enabled = false;
            cocina.Enabled = false;
            salademusica.Enabled = false;
            conservatorio.Enabled = false;
            saladebillar.Enabled = false;
            biblioteca.Enabled = false;
            estudio.Enabled = false;
            SetHabitacion(16);
        }

        private void salademusica_Click(object sender, EventArgs e)
        {
            vestibulo.Enabled = false;
            salon.Enabled = false;
            comedor.Enabled = false;
            cocina.Enabled = false;
            salademusica.Enabled = false;
            conservatorio.Enabled = false;
            saladebillar.Enabled = false;
            biblioteca.Enabled = false;
            estudio.Enabled = false;
            SetHabitacion(17);
        }

        private void conservatorio_Click(object sender, EventArgs e)
        {
            vestibulo.Enabled = false;
            salon.Enabled = false;
            comedor.Enabled = false;
            cocina.Enabled = false;
            salademusica.Enabled = false;
            conservatorio.Enabled = false;
            saladebillar.Enabled = false;
            biblioteca.Enabled = false;
            estudio.Enabled = false;
            SetHabitacion(18);
        }

        private void saladebillar_Click(object sender, EventArgs e)
        {
            vestibulo.Enabled = false;
            salon.Enabled = false;
            comedor.Enabled = false;
            cocina.Enabled = false;
            salademusica.Enabled = false;
            conservatorio.Enabled = false;
            saladebillar.Enabled = false;
            biblioteca.Enabled = false;
            estudio.Enabled = false;
            SetHabitacion(19);
        }

        private void biblioteca_Click(object sender, EventArgs e)
        {
            vestibulo.Enabled = false;
            salon.Enabled = false;
            comedor.Enabled = false;
            cocina.Enabled = false;
            salademusica.Enabled = false;
            conservatorio.Enabled = false;
            saladebillar.Enabled = false;
            biblioteca.Enabled = false;
            estudio.Enabled = false;
            SetHabitacion(20);
        }

        private void estudio_Click(object sender, EventArgs e)
        {
            vestibulo.Enabled = false;
            salon.Enabled = false;
            comedor.Enabled = false;
            cocina.Enabled = false;
            salademusica.Enabled = false;
            conservatorio.Enabled = false;
            saladebillar.Enabled = false;
            biblioteca.Enabled = false;
            estudio.Enabled = false;
            SetHabitacion(21);
        }

        //Se hará el Set Pregunta cuando le demos al botón, falta poner el jugador que hace la pregunta delante
        public void SetPregunta(int jugador, int personaje, int arma, int habitacion)
        {
            this.pregunta = jugador + "/" + personaje + "/" + arma + "/" + habitacion;
        }

        public string GetPregunta()
        {
            return this.pregunta;
        }
        //Sets y Gets de los parametros
        public void SetJugadores(string usuario,List<string>jugadores)
        {
            this.username = usuario;
            this.jugadores = jugadores;
        }
        public void SetJugador(int jugador)
        {
            this.jugador = jugador;
        }
        public int GetJugador()
        {
            return this.jugador;
        }
        public void SetPersonaje(int personaje)
        {
            this.personaje = personaje;
        }
        public int GetPersonaje()
        {
            return this.personaje;
        }
        public void SetArma(int arma)
        {
            this.arma = arma;
        }
        public int GetArma()
        {
            return this.arma;
        }
        public void SetHabitacion(int habitacion)
        {
            this.habitacion = habitacion;
        }
        public int GetHabitacion()
        {
            return this.habitacion;
        }

        private void jugador1_Click(object sender, EventArgs e)
        {
            jugador1.Enabled = false;
            jugador2.Enabled = false;
            jugador3.Enabled = false;
            jugador4.Enabled = false;
            jugador5.Enabled = false;
            jugador6.Enabled = false;
            SetJugador(0);
        }

        private void jugador2_Click(object sender, EventArgs e)
        {
            jugador1.Enabled = false;
            jugador2.Enabled = false;
            jugador3.Enabled = false;
            jugador4.Enabled = false;
            jugador5.Enabled = false;
            jugador6.Enabled = false;
            SetJugador(1);
        }

        private void jugador3_Click(object sender, EventArgs e)
        {
            jugador1.Enabled = false;
            jugador2.Enabled = false;
            jugador3.Enabled = false;
            jugador4.Enabled = false;
            jugador5.Enabled = false;
            jugador6.Enabled = false;
            SetJugador(2);
        }

        private void jugador4_Click(object sender, EventArgs e)
        {
            jugador1.Enabled = false;
            jugador2.Enabled = false;
            jugador3.Enabled = false;
            jugador4.Enabled = false;
            jugador5.Enabled = false;
            jugador6.Enabled = false;
            SetJugador(3);
        }

        private void jugador5_Click(object sender, EventArgs e)
        {
            jugador1.Enabled = false;
            jugador2.Enabled = false;
            jugador3.Enabled = false;
            jugador4.Enabled = false;
            jugador5.Enabled = false;
            jugador6.Enabled = false;
            SetJugador(4);
        }

        private void jugador6_Click(object sender, EventArgs e)
        {
            jugador1.Enabled = false;
            jugador2.Enabled = false;
            jugador3.Enabled = false;
            jugador4.Enabled = false;
            jugador5.Enabled = false;
            jugador6.Enabled = false;
            SetJugador(5);
        }

        private void Enviarpreguntas_Click(object sender, EventArgs e)
        {
            SetPregunta(this.jugador, this.personaje, this.arma, this.habitacion);
            Close();
        }
    }
}
