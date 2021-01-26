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
    public partial class InterfazCluedo : Form
    {
        string usuario;
        List<string>jugadores=new List<string>();
        string pregunta;
        int turnoactual;
        bool finturno = false;
        bool respuesta = false;
        bool acusacion = false;
        public InterfazCluedo()
        {
            InitializeComponent();
        }
        private void TirarDados_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(1,7);
            int b = rnd.Next(1, 7);
            int c = a + b;
            movimientos.Text = c.ToString();
            if (a == 1)
                dado1.Image = Properties.Resources._1;
            if (a == 2)
                dado1.Image = Properties.Resources._2;
            if (a == 3)
                dado1.Image = Properties.Resources._3;
            if (a == 4)
                dado1.Image = Properties.Resources._4;
            if (a == 5)
                dado1.Image = Properties.Resources._5;
            if (a == 6)
                dado1.Image = Properties.Resources._6;
            if (b == 1)
                dado2.Image = Properties.Resources._1;
            if (b == 2)
                dado2.Image = Properties.Resources._2;
            if (b == 3)
                dado2.Image = Properties.Resources._3;
            if (b == 4)
                dado2.Image = Properties.Resources._4;
            if (b == 5)
                dado2.Image = Properties.Resources._5;
            if (b == 6)
                dado2.Image = Properties.Resources._6;
            TirarDados.Enabled = false;
        }
        private void mover_izquierda_Click_1(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(vficha.Text);

            if (num == 1 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_dorada.Location.X.Equals(126) && ficha_dorada.Location.Y.Equals(145))
                {
                    ficha_dorada.Left -= 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_dorada.Location.X.Equals(186) && ficha_dorada.Location.Y.Equals(85))
                {
                    ficha_dorada.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt32(movimientos.Text) - 1);
                }
                else if (ficha_dorada.Location.X.Equals(111) && ficha_dorada.Location.Y.Equals(250))
                {
                    ficha_dorada.Left -= 45;
                    ficha_dorada.Top -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_dorada.Location.X.Equals(96) && ficha_dorada.Location.Y.Equals(310))
                {
                    ficha_dorada.Left -= 30;
                    ficha_dorada.Top += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_dorada.Location.X.Equals(261) && ficha_dorada.Location.Y.Equals(310))
                {
                    ficha_dorada.Left -= 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(340))
                {
                    ficha_dorada.Left += 255;
                    ficha_dorada.Top -= 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_dorada.Location.X.Equals(201) && ficha_dorada.Location.Y.Equals(310))
                {
                    ficha_dorada.Left -= 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_dorada.Location.X.Equals(321) && ficha_dorada.Location.Y.Equals(205))
                {
                    ficha_dorada.Left -= 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(40))
                {
                    ficha_dorada.Left += 270;
                    ficha_dorada.Top += 285;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else
                {
                    int r = 0;
                    for (int i = 205; i <= 235; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(111) && ficha_dorada.Location.Y.Equals(i))
                            r++;
                    if (ficha_dorada.Location.X.Equals(261) && ficha_dorada.Location.Y.Equals(25))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(111) && ficha_dorada.Location.Y.Equals(i))
                            r++;
                    if (ficha_dorada.Location.X.Equals(21) && ficha_dorada.Location.Y.Equals(100))
                        r++;
                    for (int i = 25; i <= 70; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(126) && ficha_dorada.Location.Y.Equals(i))
                            r++;
                    for (int i = 145; i <= 235; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(231) && ficha_dorada.Location.Y.Equals(i))
                            r++;
                    for (int i = 40; i <= 115; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(246) && ficha_dorada.Location.Y.Equals(i))
                            r++;
                    if (ficha_dorada.Location.X.Equals(21) && ficha_dorada.Location.Y.Equals(295))
                        r++;
                    if (ficha_dorada.Location.X.Equals(156) && ficha_dorada.Location.Y.Equals(385))
                        r++;
                    for (int i = 280; i <= 295; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(261) && ficha_dorada.Location.Y.Equals(i))
                            r++;
                    if (ficha_dorada.Location.X.Equals(231) && ficha_dorada.Location.Y.Equals(385))
                        r++;
                    if (ficha_dorada.Location.X.Equals(36) && ficha_dorada.Location.Y.Equals(85))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(261) && ficha_dorada.Location.Y.Equals(i))
                            r++;
                    if (ficha_dorada.Location.X.Equals(36) && ficha_dorada.Location.Y.Equals(190))
                        r++;
                    if (ficha_dorada.Location.X.Equals(36) && ficha_dorada.Location.Y.Equals(280))
                        r++;
                    if (ficha_dorada.Location.X.Equals(111) && ficha_dorada.Location.Y.Equals(115))
                        r++;
                    if (ficha_dorada.Location.X.Equals(111) && ficha_dorada.Location.Y.Equals(175))
                        r++;
                    if (ficha_dorada.Location.X.Equals(111) && ficha_dorada.Location.Y.Equals(265))
                        r++;
                    if (ficha_dorada.Location.X.Equals(126) && ficha_dorada.Location.Y.Equals(370))
                        r++;
                    if (ficha_dorada.Location.X.Equals(231) && ficha_dorada.Location.Y.Equals(370))
                        r++;
                    if (ficha_dorada.Location.X.Equals(321) && ficha_dorada.Location.Y.Equals(70))
                        r++;
                    if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(145))
                        r++;
                    if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(220))
                        r++;
                    if (ficha_dorada.Location.X.Equals(336) && ficha_dorada.Location.Y.Equals(325))
                        r++;
                    if (r == 0)
                    {
                        ficha_dorada.Left -= 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }

                ldx.Text = Convert.ToString(ficha_dorada.Location.X);
                ldy.Text = Convert.ToString(ficha_dorada.Location.Y);
            }
            else if (num == 5 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_granate.Location.X.Equals(126) && ficha_granate.Location.Y.Equals(145))
                {
                    ficha_granate.Left -= 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_granate.Location.X.Equals(186) && ficha_granate.Location.Y.Equals(85))
                {
                    ficha_granate.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt32(movimientos.Text) - 1);
                }
                else if (ficha_granate.Location.X.Equals(111) && ficha_granate.Location.Y.Equals(250))
                {
                    ficha_granate.Left -= 45;
                    ficha_granate.Top -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_granate.Location.X.Equals(96) && ficha_granate.Location.Y.Equals(310))
                {
                    ficha_granate.Left -= 30;
                    ficha_granate.Top += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_granate.Location.X.Equals(261) && ficha_granate.Location.Y.Equals(310))
                {
                    ficha_granate.Left -= 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(340))
                {
                    ficha_granate.Left += 255;
                    ficha_granate.Top -= 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_granate.Location.X.Equals(201) && ficha_granate.Location.Y.Equals(310))
                {
                    ficha_granate.Left -= 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_granate.Location.X.Equals(321) && ficha_granate.Location.Y.Equals(205))
                {
                    ficha_granate.Left -= 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(40))
                {
                    ficha_granate.Left += 270;
                    ficha_granate.Top += 285;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else
                {
                    int r = 0;
                    for (int i = 205; i <= 235; i = i + 15)
                        if (ficha_granate.Location.X.Equals(111) && ficha_granate.Location.Y.Equals(i))
                            r++;
                    if (ficha_granate.Location.X.Equals(261) && ficha_granate.Location.Y.Equals(25))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_granate.Location.X.Equals(111) && ficha_granate.Location.Y.Equals(i))
                            r++;
                    if (ficha_granate.Location.X.Equals(21) && ficha_granate.Location.Y.Equals(100))
                        r++;
                    for (int i = 25; i <= 70; i = i + 15)
                        if (ficha_granate.Location.X.Equals(126) && ficha_granate.Location.Y.Equals(i))
                            r++;
                    for (int i = 145; i <= 235; i = i + 15)
                        if (ficha_granate.Location.X.Equals(231) && ficha_granate.Location.Y.Equals(i))
                            r++;
                    for (int i = 40; i <= 115; i = i + 15)
                        if (ficha_granate.Location.X.Equals(246) && ficha_granate.Location.Y.Equals(i))
                            r++;
                    if (ficha_granate.Location.X.Equals(21) && ficha_granate.Location.Y.Equals(295))
                        r++;
                    if (ficha_granate.Location.X.Equals(156) && ficha_granate.Location.Y.Equals(385))
                        r++;
                    for (int i = 280; i <= 295; i = i + 15)
                        if (ficha_granate.Location.X.Equals(261) && ficha_granate.Location.Y.Equals(i))
                            r++;
                    if (ficha_granate.Location.X.Equals(231) && ficha_granate.Location.Y.Equals(385))
                        r++;
                    if (ficha_granate.Location.X.Equals(36) && ficha_granate.Location.Y.Equals(85))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_granate.Location.X.Equals(261) && ficha_granate.Location.Y.Equals(i))
                            r++;
                    if (ficha_granate.Location.X.Equals(36) && ficha_granate.Location.Y.Equals(190))
                        r++;
                    if (ficha_granate.Location.X.Equals(36) && ficha_granate.Location.Y.Equals(280))
                        r++;
                    if (ficha_granate.Location.X.Equals(111) && ficha_granate.Location.Y.Equals(115))
                        r++;
                    if (ficha_granate.Location.X.Equals(111) && ficha_granate.Location.Y.Equals(175))
                        r++;
                    if (ficha_granate.Location.X.Equals(111) && ficha_granate.Location.Y.Equals(265))
                        r++;
                    if (ficha_granate.Location.X.Equals(126) && ficha_granate.Location.Y.Equals(370))
                        r++;
                    if (ficha_granate.Location.X.Equals(231) && ficha_granate.Location.Y.Equals(370))
                        r++;
                    if (ficha_granate.Location.X.Equals(321) && ficha_granate.Location.Y.Equals(70))
                        r++;
                    if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(145))
                        r++;
                    if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(220))
                        r++;
                    if (ficha_granate.Location.X.Equals(336) && ficha_granate.Location.Y.Equals(325))
                        r++;
                    if (r == 0)
                    {
                        ficha_granate.Left -= 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                lgx.Text = Convert.ToString(ficha_granate.Location.X);
                lgy.Text = Convert.ToString(ficha_granate.Location.Y);
            }
            else if (num == 4 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_lila.Location.X.Equals(126) && ficha_lila.Location.Y.Equals(145))
                {
                    ficha_lila.Left -= 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_lila.Location.X.Equals(186) && ficha_lila.Location.Y.Equals(85))
                {
                    ficha_lila.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt32(movimientos.Text) - 1);
                }
                else if (ficha_lila.Location.X.Equals(111) && ficha_lila.Location.Y.Equals(250))
                {
                    ficha_lila.Left -= 45;
                    ficha_lila.Top -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_lila.Location.X.Equals(96) && ficha_lila.Location.Y.Equals(310))
                {
                    ficha_lila.Left -= 30;
                    ficha_lila.Top += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_lila.Location.X.Equals(261) && ficha_lila.Location.Y.Equals(310))
                {
                    ficha_lila.Left -= 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(340))
                {
                    ficha_lila.Left += 255;
                    ficha_lila.Top -= 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_lila.Location.X.Equals(201) && ficha_lila.Location.Y.Equals(310))
                {
                    ficha_lila.Left -= 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_lila.Location.X.Equals(321) && ficha_lila.Location.Y.Equals(205))
                {
                    ficha_lila.Left -= 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(40))
                {
                    ficha_lila.Left += 270;
                    ficha_lila.Top += 285;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else
                {
                    int r = 0;
                    for (int i = 205; i <= 235; i = i + 15)
                        if (ficha_lila.Location.X.Equals(111) && ficha_lila.Location.Y.Equals(i))
                            r++;
                    if (ficha_lila.Location.X.Equals(261) && ficha_lila.Location.Y.Equals(25))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_lila.Location.X.Equals(111) && ficha_lila.Location.Y.Equals(i))
                            r++;
                    if (ficha_lila.Location.X.Equals(21) && ficha_lila.Location.Y.Equals(100))
                        r++;
                    for (int i = 25; i <= 70; i = i + 15)
                        if (ficha_lila.Location.X.Equals(126) && ficha_lila.Location.Y.Equals(i))
                            r++;
                    for (int i = 145; i <= 235; i = i + 15)
                        if (ficha_lila.Location.X.Equals(231) && ficha_lila.Location.Y.Equals(i))
                            r++;
                    for (int i = 40; i <= 115; i = i + 15)
                        if (ficha_lila.Location.X.Equals(246) && ficha_lila.Location.Y.Equals(i))
                            r++;
                    if (ficha_lila.Location.X.Equals(21) && ficha_lila.Location.Y.Equals(295))
                        r++;
                    if (ficha_lila.Location.X.Equals(156) && ficha_lila.Location.Y.Equals(385))
                        r++;
                    for (int i = 280; i <= 295; i = i + 15)
                        if (ficha_lila.Location.X.Equals(261) && ficha_lila.Location.Y.Equals(i))
                            r++;
                    if (ficha_lila.Location.X.Equals(231) && ficha_lila.Location.Y.Equals(385))
                        r++;
                    if (ficha_lila.Location.X.Equals(36) && ficha_lila.Location.Y.Equals(85))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_lila.Location.X.Equals(261) && ficha_lila.Location.Y.Equals(i))
                            r++;
                    if (ficha_lila.Location.X.Equals(36) && ficha_lila.Location.Y.Equals(190))
                        r++;
                    if (ficha_lila.Location.X.Equals(36) && ficha_lila.Location.Y.Equals(280))
                        r++;
                    if (ficha_lila.Location.X.Equals(111) && ficha_lila.Location.Y.Equals(115))
                        r++;
                    if (ficha_lila.Location.X.Equals(111) && ficha_lila.Location.Y.Equals(175))
                        r++;
                    if (ficha_lila.Location.X.Equals(111) && ficha_lila.Location.Y.Equals(265))
                        r++;
                    if (ficha_lila.Location.X.Equals(126) && ficha_lila.Location.Y.Equals(370))
                        r++;
                    if (ficha_lila.Location.X.Equals(231) && ficha_lila.Location.Y.Equals(370))
                        r++;
                    if (ficha_lila.Location.X.Equals(321) && ficha_lila.Location.Y.Equals(70))
                        r++;
                    if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(145))
                        r++;
                    if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(220))
                        r++;
                    if (ficha_lila.Location.X.Equals(336) && ficha_lila.Location.Y.Equals(325))
                        r++;
                    if (r == 0)
                    {
                        ficha_lila.Left -= 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");

                }
                llx.Text = Convert.ToString(ficha_lila.Location.X);
                lly.Text = Convert.ToString(ficha_lila.Location.Y);
            }
            else if (num == 6 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_azul.Location.X.Equals(126) && ficha_azul.Location.Y.Equals(145))
                {
                    ficha_azul.Left -= 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_azul.Location.X.Equals(186) && ficha_azul.Location.Y.Equals(85))
                {
                    ficha_azul.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt32(movimientos.Text) - 1);
                }
                else if (ficha_azul.Location.X.Equals(111) && ficha_azul.Location.Y.Equals(250))
                {
                    ficha_azul.Left -= 45;
                    ficha_azul.Top -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_azul.Location.X.Equals(96) && ficha_azul.Location.Y.Equals(310))
                {
                    ficha_azul.Left -= 30;
                    ficha_azul.Top += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_azul.Location.X.Equals(261) && ficha_azul.Location.Y.Equals(310))
                {
                    ficha_azul.Left -= 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(340))
                {
                    ficha_azul.Left += 255;
                    ficha_azul.Top -= 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_azul.Location.X.Equals(201) && ficha_azul.Location.Y.Equals(310))
                {
                    ficha_azul.Left -= 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_azul.Location.X.Equals(321) && ficha_azul.Location.Y.Equals(205))
                {
                    ficha_azul.Left -= 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(40))
                {
                    ficha_azul.Left += 270;
                    ficha_azul.Top += 285;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else
                {
                    int r = 0;
                    for (int i = 205; i <= 235; i = i + 15)
                        if (ficha_azul.Location.X.Equals(111) && ficha_azul.Location.Y.Equals(i))
                            r++;
                    if (ficha_azul.Location.X.Equals(261) && ficha_azul.Location.Y.Equals(25))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_azul.Location.X.Equals(111) && ficha_azul.Location.Y.Equals(i))
                            r++;
                    if (ficha_azul.Location.X.Equals(21) && ficha_azul.Location.Y.Equals(100))
                        r++;
                    for (int i = 25; i <= 70; i = i + 15)
                        if (ficha_azul.Location.X.Equals(126) && ficha_azul.Location.Y.Equals(i))
                            r++;
                    for (int i = 145; i <= 235; i = i + 15)
                        if (ficha_azul.Location.X.Equals(231) && ficha_azul.Location.Y.Equals(i))
                            r++;
                    for (int i = 40; i <= 115; i = i + 15)
                        if (ficha_azul.Location.X.Equals(246) && ficha_azul.Location.Y.Equals(i))
                            r++;
                    if (ficha_azul.Location.X.Equals(21) && ficha_azul.Location.Y.Equals(295))
                        r++;
                    if (ficha_azul.Location.X.Equals(156) && ficha_azul.Location.Y.Equals(385))
                        r++;
                    for (int i = 280; i <= 295; i = i + 15)
                        if (ficha_azul.Location.X.Equals(261) && ficha_azul.Location.Y.Equals(i))
                            r++;
                    if (ficha_azul.Location.X.Equals(231) && ficha_azul.Location.Y.Equals(385))
                        r++;
                    if (ficha_azul.Location.X.Equals(36) && ficha_azul.Location.Y.Equals(85))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_azul.Location.X.Equals(261) && ficha_azul.Location.Y.Equals(i))
                            r++;
                    if (ficha_azul.Location.X.Equals(36) && ficha_azul.Location.Y.Equals(190))
                        r++;
                    if (ficha_azul.Location.X.Equals(36) && ficha_azul.Location.Y.Equals(280))
                        r++;
                    if (ficha_azul.Location.X.Equals(111) && ficha_azul.Location.Y.Equals(115))
                        r++;
                    if (ficha_azul.Location.X.Equals(111) && ficha_azul.Location.Y.Equals(175))
                        r++;
                    if (ficha_azul.Location.X.Equals(111) && ficha_azul.Location.Y.Equals(265))
                        r++;
                    if (ficha_azul.Location.X.Equals(126) && ficha_azul.Location.Y.Equals(370))
                        r++;
                    if (ficha_azul.Location.X.Equals(231) && ficha_azul.Location.Y.Equals(370))
                        r++;
                    if (ficha_azul.Location.X.Equals(321) && ficha_azul.Location.Y.Equals(70))
                        r++;
                    if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(145))
                        r++;
                    if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(220))
                        r++;
                    if (ficha_azul.Location.X.Equals(336) && ficha_azul.Location.Y.Equals(325))
                        r++;
                    if (r == 0)
                    {
                        ficha_azul.Left -= 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                lax.Text = Convert.ToString(ficha_azul.Location.X);
                lay.Text = Convert.ToString(ficha_azul.Location.Y);
            }
            else if (num == 3 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_verde.Location.X.Equals(126) && ficha_verde.Location.Y.Equals(145))
                {
                    ficha_verde.Left -= 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_verde.Location.X.Equals(186) && ficha_verde.Location.Y.Equals(85))
                {
                    ficha_verde.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt32(movimientos.Text) - 1);
                }
                else if (ficha_verde.Location.X.Equals(111) && ficha_verde.Location.Y.Equals(250))
                {
                    ficha_verde.Left -= 45;
                    ficha_verde.Top -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_verde.Location.X.Equals(96) && ficha_verde.Location.Y.Equals(310))
                {
                    ficha_verde.Left -= 30;
                    ficha_verde.Top += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_verde.Location.X.Equals(261) && ficha_verde.Location.Y.Equals(310))
                {
                    ficha_verde.Left -= 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(340))
                {
                    ficha_verde.Left += 255;
                    ficha_verde.Top -= 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_verde.Location.X.Equals(201) && ficha_verde.Location.Y.Equals(310))
                {
                    ficha_verde.Left -= 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_verde.Location.X.Equals(321) && ficha_verde.Location.Y.Equals(205))
                {
                    ficha_verde.Left -= 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(40))
                {
                    ficha_verde.Left += 270;
                    ficha_verde.Top += 285;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else
                {
                    int r = 0;
                    for (int i = 205; i <= 235; i = i + 15)
                        if (ficha_verde.Location.X.Equals(111) && ficha_verde.Location.Y.Equals(i))
                            r++;
                    if (ficha_verde.Location.X.Equals(261) && ficha_verde.Location.Y.Equals(25))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_verde.Location.X.Equals(111) && ficha_verde.Location.Y.Equals(i))
                            r++;
                    if (ficha_verde.Location.X.Equals(21) && ficha_verde.Location.Y.Equals(100))
                        r++;
                    for (int i = 25; i <= 70; i = i + 15)
                        if (ficha_verde.Location.X.Equals(126) && ficha_verde.Location.Y.Equals(i))
                            r++;
                    for (int i = 145; i <= 235; i = i + 15)
                        if (ficha_verde.Location.X.Equals(231) && ficha_verde.Location.Y.Equals(i))
                            r++;
                    for (int i = 40; i <= 115; i = i + 15)
                        if (ficha_verde.Location.X.Equals(246) && ficha_verde.Location.Y.Equals(i))
                            r++;
                    if (ficha_verde.Location.X.Equals(21) && ficha_verde.Location.Y.Equals(295))
                        r++;
                    if (ficha_verde.Location.X.Equals(156) && ficha_verde.Location.Y.Equals(385))
                        r++;
                    for (int i = 280; i <= 295; i = i + 15)
                        if (ficha_verde.Location.X.Equals(261) && ficha_verde.Location.Y.Equals(i))
                            r++;
                    if (ficha_verde.Location.X.Equals(231) && ficha_verde.Location.Y.Equals(385))
                        r++;
                    if (ficha_verde.Location.X.Equals(36) && ficha_verde.Location.Y.Equals(85))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_verde.Location.X.Equals(261) && ficha_verde.Location.Y.Equals(i))
                            r++;
                    if (ficha_verde.Location.X.Equals(36) && ficha_verde.Location.Y.Equals(190))
                        r++;
                    if (ficha_verde.Location.X.Equals(36) && ficha_verde.Location.Y.Equals(280))
                        r++;
                    if (ficha_verde.Location.X.Equals(111) && ficha_verde.Location.Y.Equals(115))
                        r++;
                    if (ficha_verde.Location.X.Equals(111) && ficha_verde.Location.Y.Equals(175))
                        r++;
                    if (ficha_verde.Location.X.Equals(111) && ficha_verde.Location.Y.Equals(265))
                        r++;
                    if (ficha_verde.Location.X.Equals(126) && ficha_verde.Location.Y.Equals(370))
                        r++;
                    if (ficha_verde.Location.X.Equals(231) && ficha_verde.Location.Y.Equals(370))
                        r++;
                    if (ficha_verde.Location.X.Equals(321) && ficha_verde.Location.Y.Equals(70))
                        r++;
                    if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(145))
                        r++;
                    if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(220))
                        r++;
                    if (ficha_verde.Location.X.Equals(336) && ficha_verde.Location.Y.Equals(325))
                        r++;
                    if (r == 0)
                    {
                        ficha_verde.Left -= 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                lvx.Text = Convert.ToString(ficha_verde.Location.X);
                lvy.Text = Convert.ToString(ficha_verde.Location.Y);
            }
            else if (num == 2 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_marron.Location.X.Equals(126) && ficha_marron.Location.Y.Equals(145))
                {
                    ficha_marron.Left -= 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_marron.Location.X.Equals(186) && ficha_marron.Location.Y.Equals(85))
                {
                    ficha_marron.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt32(movimientos.Text) - 1);
                }
                else if (ficha_marron.Location.X.Equals(111) && ficha_marron.Location.Y.Equals(250))
                {
                    ficha_marron.Left -= 45;
                    ficha_marron.Top -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_marron.Location.X.Equals(96) && ficha_marron.Location.Y.Equals(310))
                {
                    ficha_marron.Left -= 30;
                    ficha_marron.Top += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_marron.Location.X.Equals(261) && ficha_marron.Location.Y.Equals(310))
                {
                    ficha_marron.Left -= 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(340))
                {
                    ficha_marron.Left += 255;
                    ficha_marron.Top -= 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_marron.Location.X.Equals(201) && ficha_marron.Location.Y.Equals(310))
                {
                    ficha_marron.Left -= 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_marron.Location.X.Equals(321) && ficha_marron.Location.Y.Equals(205))
                {
                    ficha_marron.Left -= 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(40))
                {
                    ficha_marron.Left += 270;
                    ficha_marron.Top += 285;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else
                {
                    int r = 0;
                    for (int i = 205; i <= 235; i = i + 15)
                        if (ficha_marron.Location.X.Equals(111) && ficha_marron.Location.Y.Equals(i))
                            r++;
                    if (ficha_marron.Location.X.Equals(261) && ficha_marron.Location.Y.Equals(25))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_marron.Location.X.Equals(111) && ficha_marron.Location.Y.Equals(i))
                            r++;
                    if (ficha_marron.Location.X.Equals(21) && ficha_marron.Location.Y.Equals(100))
                        r++;
                    for (int i = 25; i <= 70; i = i + 15)
                        if (ficha_marron.Location.X.Equals(126) && ficha_marron.Location.Y.Equals(i))
                            r++;
                    for (int i = 145; i <= 235; i = i + 15)
                        if (ficha_marron.Location.X.Equals(231) && ficha_marron.Location.Y.Equals(i))
                            r++;
                    for (int i = 40; i <= 115; i = i + 15)
                        if (ficha_marron.Location.X.Equals(246) && ficha_marron.Location.Y.Equals(i))
                            r++;
                    if (ficha_marron.Location.X.Equals(21) && ficha_marron.Location.Y.Equals(295))
                        r++;
                    if (ficha_marron.Location.X.Equals(156) && ficha_marron.Location.Y.Equals(385))
                        r++;
                    for (int i = 280; i <= 295; i = i + 15)
                        if (ficha_marron.Location.X.Equals(261) && ficha_marron.Location.Y.Equals(i))
                            r++;
                    if (ficha_marron.Location.X.Equals(231) && ficha_marron.Location.Y.Equals(385))
                        r++;
                    if (ficha_marron.Location.X.Equals(36) && ficha_marron.Location.Y.Equals(85))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_marron.Location.X.Equals(261) && ficha_marron.Location.Y.Equals(i))
                            r++;
                    if (ficha_marron.Location.X.Equals(36) && ficha_marron.Location.Y.Equals(190))
                        r++;
                    if (ficha_marron.Location.X.Equals(36) && ficha_marron.Location.Y.Equals(280))
                        r++;
                    if (ficha_marron.Location.X.Equals(111) && ficha_marron.Location.Y.Equals(115))
                        r++;
                    if (ficha_marron.Location.X.Equals(111) && ficha_marron.Location.Y.Equals(175))
                        r++;
                    if (ficha_marron.Location.X.Equals(111) && ficha_marron.Location.Y.Equals(265))
                        r++;
                    if (ficha_marron.Location.X.Equals(126) && ficha_marron.Location.Y.Equals(370))
                        r++;
                    if (ficha_marron.Location.X.Equals(231) && ficha_marron.Location.Y.Equals(370))
                        r++;
                    if (ficha_marron.Location.X.Equals(321) && ficha_marron.Location.Y.Equals(70))
                        r++;
                    if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(145))
                        r++;
                    if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(220))
                        r++;
                    if (ficha_marron.Location.X.Equals(336) && ficha_marron.Location.Y.Equals(325))
                        r++;
                    if (r == 0)
                    {
                        ficha_marron.Left -= 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                lmx.Text = Convert.ToString(ficha_marron.Location.X);
                lmy.Text = Convert.ToString(ficha_marron.Location.Y);
            }


        }

        private void mover_abajo_Click_1(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(vficha.Text);

            if (num == 1 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_dorada.Location.X.Equals(36) && ficha_dorada.Location.Y.Equals(190))
                {
                    ficha_dorada.Top += 30;
                    ficha_dorada.Left += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_dorada.Location.X.Equals(156) && ficha_dorada.Location.Y.Equals(265))
                {
                    ficha_dorada.Left += 45;
                    ficha_dorada.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_dorada.Location.X.Equals(231) && ficha_dorada.Location.Y.Equals(265))
                {
                    ficha_dorada.Left -= 30;
                    ficha_dorada.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_dorada.Location.X.Equals(306) && ficha_dorada.Location.Y.Equals(280))
                {
                    ficha_dorada.Left += 30;
                    ficha_dorada.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_dorada.Location.X.Equals(276) && ficha_dorada.Location.Y.Equals(145))
                {
                    ficha_dorada.Left += 45;
                    ficha_dorada.Top += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(40))
                {
                    ficha_dorada.Left += 45;
                    ficha_dorada.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_dorada.Location.X.Equals(186) && ficha_dorada.Location.Y.Equals(85))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    string pregunta = "¿Por que puerta de abajo quieres salir? ¿La de la izquierda?";
                    result = MessageBox.Show(pregunta, "Escoger puerta", buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                        ficha_dorada.Top += 45;
                    else
                    {
                        ficha_dorada.Top += 45;
                        ficha_dorada.Left += 15;
                    }
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_dorada.Location.X.Equals(321) && ficha_dorada.Location.Y.Equals(70))
                {
                    ficha_dorada.Top += 45;
                    ficha_dorada.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(145))
                {
                    ficha_dorada.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else
                {
                    int r = 0;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(100))
                            r++;
                    if (ficha_dorada.Location.X.Equals(111) && ficha_dorada.Location.Y.Equals(115))
                        r++;
                    for (int i = 156; i <= 216; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(130))
                            r++;
                    if (ficha_dorada.Location.X.Equals(261) && ficha_dorada.Location.Y.Equals(145))
                        r++;
                    for (int i = 291; i <= 351; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(145))
                            r++;
                    for (int i = 51; i <= 96; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(190))
                            r++;
                    for (int i = 36; i <= 81; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(295))
                            r++;
                    if (ficha_dorada.Location.X.Equals(96) && ficha_dorada.Location.Y.Equals(310))
                        r++;
                    if (ficha_dorada.Location.X.Equals(111) && ficha_dorada.Location.Y.Equals(355))
                        r++;
                    for (int i = 126; i <= 156; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(370))
                            r++;
                    if (ficha_dorada.Location.X.Equals(156) && ficha_dorada.Location.Y.Equals(385))
                        r++;
                    if (ficha_dorada.Location.X.Equals(231) && ficha_dorada.Location.Y.Equals(385))
                        r++;
                    for (int i = 231; i <= 261; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(370))
                            r++;
                    if (ficha_dorada.Location.X.Equals(276) && ficha_dorada.Location.Y.Equals(355))
                        r++;
                    if (ficha_dorada.Location.X.Equals(141) && ficha_dorada.Location.Y.Equals(265))
                        r++;
                    for (int i = 171; i <= 216; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(265))
                            r++;
                    if (ficha_dorada.Location.X.Equals(246) && ficha_dorada.Location.Y.Equals(265))
                        r++;
                    if (ficha_dorada.Location.X.Equals(291) && ficha_dorada.Location.Y.Equals(280))
                        r++;
                    if (ficha_dorada.Location.X.Equals(321) && ficha_dorada.Location.Y.Equals(205))
                        r++;
                    if (ficha_dorada.Location.X.Equals(336) && ficha_dorada.Location.Y.Equals(325))
                        r++;
                    if (ficha_dorada.Location.X.Equals(201) && ficha_dorada.Location.Y.Equals(310))
                        r++;
                    if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(340))
                        r++;
                    if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(220))
                        r++;
                    for (int i = 321; i <= 351; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(280))
                            r++;
                    if (ficha_dorada.Location.X.Equals(231) && ficha_dorada.Location.Y.Equals(385))
                        r++;
                    if (ficha_dorada.Location.X.Equals(21) && ficha_dorada.Location.Y.Equals(295))
                        r++;
                    if (ficha_dorada.Location.X.Equals(21) && ficha_dorada.Location.Y.Equals(100))
                        r++;
                    if (ficha_dorada.Location.X.Equals(366) && ficha_dorada.Location.Y.Equals(130))
                        r++;
                    if (r == 0)
                    {
                        ficha_dorada.Top += 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                ldx.Text = Convert.ToString(ficha_dorada.Location.X);
                ldy.Text = Convert.ToString(ficha_dorada.Location.Y);
            }
            else if (num == 5 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_granate.Location.X.Equals(36) && ficha_granate.Location.Y.Equals(190))
                {
                    ficha_granate.Top += 30;
                    ficha_granate.Left += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_granate.Location.X.Equals(156) && ficha_granate.Location.Y.Equals(265))
                {
                    ficha_granate.Left += 45;
                    ficha_granate.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_granate.Location.X.Equals(231) && ficha_granate.Location.Y.Equals(265))
                {
                    ficha_granate.Left -= 30;
                    ficha_granate.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_granate.Location.X.Equals(306) && ficha_granate.Location.Y.Equals(280))
                {
                    ficha_granate.Left += 30;
                    ficha_granate.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_granate.Location.X.Equals(276) && ficha_granate.Location.Y.Equals(145))
                {
                    ficha_granate.Left += 45;
                    ficha_granate.Top += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(40))
                {
                    ficha_granate.Left += 45;
                    ficha_granate.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_granate.Location.X.Equals(186) && ficha_granate.Location.Y.Equals(85))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    string pregunta = "¿Por que puerta de abajo quieres salir? ¿La de la izquierda?";
                    result = MessageBox.Show(pregunta, "Escoger puerta", buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                        ficha_granate.Top += 45;
                    else
                    {
                        ficha_granate.Top += 45;
                        ficha_granate.Left += 15;
                    }
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_granate.Location.X.Equals(321) && ficha_granate.Location.Y.Equals(70))
                {
                    ficha_granate.Top += 45;
                    ficha_granate.Left -= 45;
                }
                else if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(145))
                {
                    ficha_granate.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else
                {
                    int r = 0;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(100))
                            r++;
                    if (ficha_granate.Location.X.Equals(111) && ficha_granate.Location.Y.Equals(115))
                        r++;
                    for (int i = 156; i <= 216; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(130))
                            r++;
                    if (ficha_granate.Location.X.Equals(261) && ficha_granate.Location.Y.Equals(145))
                        r++;
                    for (int i = 291; i <= 351; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(145))
                            r++;
                    for (int i = 51; i <= 96; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(190))
                            r++;
                    for (int i = 36; i <= 81; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(295))
                            r++;
                    if (ficha_granate.Location.X.Equals(96) && ficha_granate.Location.Y.Equals(310))
                        r++;
                    if (ficha_granate.Location.X.Equals(111) && ficha_granate.Location.Y.Equals(355))
                        r++;
                    for (int i = 126; i <= 156; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(370))
                            r++;
                    if (ficha_granate.Location.X.Equals(156) && ficha_granate.Location.Y.Equals(385))
                        r++;
                    if (ficha_granate.Location.X.Equals(231) && ficha_granate.Location.Y.Equals(385))
                        r++;
                    for (int i = 231; i <= 261; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(370))
                            r++;
                    if (ficha_granate.Location.X.Equals(276) && ficha_granate.Location.Y.Equals(355))
                        r++;
                    if (ficha_granate.Location.X.Equals(141) && ficha_granate.Location.Y.Equals(265))
                        r++;
                    for (int i = 171; i <= 216; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(265))
                            r++;
                    if (ficha_granate.Location.X.Equals(246) && ficha_granate.Location.Y.Equals(265))
                        r++;
                    if (ficha_granate.Location.X.Equals(291) && ficha_granate.Location.Y.Equals(280))
                        r++;
                    if (ficha_granate.Location.X.Equals(321) && ficha_granate.Location.Y.Equals(205))
                        r++;
                    if (ficha_granate.Location.X.Equals(336) && ficha_granate.Location.Y.Equals(325))
                        r++;
                    if (ficha_granate.Location.X.Equals(201) && ficha_granate.Location.Y.Equals(310))
                        r++;
                    if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(340))
                        r++;
                    if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(220))
                        r++;
                    for (int i = 321; i <= 351; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(280))
                            r++;
                    if (ficha_granate.Location.X.Equals(231) && ficha_granate.Location.Y.Equals(385))
                        r++;
                    if (ficha_granate.Location.X.Equals(21) && ficha_granate.Location.Y.Equals(295))
                        r++;
                    if (ficha_granate.Location.X.Equals(21) && ficha_granate.Location.Y.Equals(100))
                        r++;
                    if (ficha_granate.Location.X.Equals(366) && ficha_granate.Location.Y.Equals(130))
                        r++;
                    if (r == 0)
                    {
                        ficha_granate.Top += 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                lgx.Text = Convert.ToString(ficha_granate.Location.X);
                lgy.Text = Convert.ToString(ficha_granate.Location.Y);
            }
            else if (num == 4 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_lila.Location.X.Equals(36) && ficha_lila.Location.Y.Equals(190))
                {
                    ficha_lila.Top += 30;
                    ficha_lila.Left += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_lila.Location.X.Equals(156) && ficha_lila.Location.Y.Equals(265))
                {
                    ficha_lila.Left += 45;
                    ficha_lila.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_lila.Location.X.Equals(231) && ficha_lila.Location.Y.Equals(265))
                {
                    ficha_lila.Left -= 30;
                    ficha_lila.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_lila.Location.X.Equals(306) && ficha_lila.Location.Y.Equals(280))
                {
                    ficha_lila.Left += 30;
                    ficha_lila.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_lila.Location.X.Equals(276) && ficha_lila.Location.Y.Equals(145))
                {
                    ficha_lila.Left += 45;
                    ficha_lila.Top += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(40))
                {
                    ficha_lila.Left += 45;
                    ficha_lila.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_lila.Location.X.Equals(186) && ficha_lila.Location.Y.Equals(85))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    string pregunta = "¿Por que puerta de abajo quieres salir? ¿La de la izquierda?";
                    result = MessageBox.Show(pregunta, "Escoger puerta", buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                        ficha_lila.Top += 45;
                    else
                    {
                        ficha_lila.Top += 45;
                        ficha_lila.Left += 15;
                    }
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_lila.Location.X.Equals(321) && ficha_lila.Location.Y.Equals(70))
                {
                    ficha_lila.Top += 45;
                    ficha_lila.Left -= 45;
                }
                else if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(145))
                {
                    ficha_lila.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else
                {
                    int r = 0;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(100))
                            r++;
                    if (ficha_lila.Location.X.Equals(111) && ficha_lila.Location.Y.Equals(115))
                        r++;
                    for (int i = 156; i <= 216; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(130))
                            r++;
                    if (ficha_lila.Location.X.Equals(261) && ficha_lila.Location.Y.Equals(145))
                        r++;
                    for (int i = 291; i <= 351; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(145))
                            r++;
                    for (int i = 51; i <= 96; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(190))
                            r++;
                    for (int i = 36; i <= 81; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(295))
                            r++;
                    if (ficha_lila.Location.X.Equals(96) && ficha_lila.Location.Y.Equals(310))
                        r++;
                    if (ficha_lila.Location.X.Equals(111) && ficha_lila.Location.Y.Equals(355))
                        r++;
                    for (int i = 126; i <= 156; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(370))
                            r++;
                    if (ficha_lila.Location.X.Equals(156) && ficha_lila.Location.Y.Equals(385))
                        r++;
                    if (ficha_lila.Location.X.Equals(231) && ficha_lila.Location.Y.Equals(385))
                        r++;
                    for (int i = 231; i <= 261; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(370))
                            r++;
                    if (ficha_lila.Location.X.Equals(276) && ficha_lila.Location.Y.Equals(355))
                        r++;
                    if (ficha_lila.Location.X.Equals(141) && ficha_lila.Location.Y.Equals(265))
                        r++;
                    for (int i = 171; i <= 216; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(265))
                            r++;
                    if (ficha_lila.Location.X.Equals(246) && ficha_lila.Location.Y.Equals(265))
                        r++;
                    if (ficha_lila.Location.X.Equals(291) && ficha_lila.Location.Y.Equals(280))
                        r++;
                    if (ficha_lila.Location.X.Equals(321) && ficha_lila.Location.Y.Equals(205))
                        r++;
                    if (ficha_lila.Location.X.Equals(336) && ficha_lila.Location.Y.Equals(325))
                        r++;
                    if (ficha_lila.Location.X.Equals(201) && ficha_lila.Location.Y.Equals(310))
                        r++;
                    if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(340))
                        r++;
                    if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(220))
                        r++;
                    for (int i = 321; i <= 351; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(280))
                            r++;
                    if (ficha_lila.Location.X.Equals(231) && ficha_lila.Location.Y.Equals(385))
                        r++;
                    if (ficha_lila.Location.X.Equals(21) && ficha_lila.Location.Y.Equals(295))
                        r++;
                    if (ficha_lila.Location.X.Equals(21) && ficha_lila.Location.Y.Equals(100))
                        r++;
                    if (ficha_lila.Location.X.Equals(366) && ficha_lila.Location.Y.Equals(130))
                        r++;
                    if (r == 0)
                    {
                        ficha_lila.Top += 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                llx.Text = Convert.ToString(ficha_lila.Location.X);
                lly.Text = Convert.ToString(ficha_lila.Location.Y);
            }
            else if (num == 6 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_azul.Location.X.Equals(36) && ficha_azul.Location.Y.Equals(190))
                {
                    ficha_azul.Top += 30;
                    ficha_azul.Left += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_azul.Location.X.Equals(156) && ficha_azul.Location.Y.Equals(265))
                {
                    ficha_azul.Left += 45;
                    ficha_azul.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_azul.Location.X.Equals(231) && ficha_azul.Location.Y.Equals(265))
                {
                    ficha_azul.Left -= 30;
                    ficha_azul.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_azul.Location.X.Equals(306) && ficha_azul.Location.Y.Equals(280))
                {
                    ficha_azul.Left += 30;
                    ficha_azul.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_azul.Location.X.Equals(276) && ficha_azul.Location.Y.Equals(145))
                {
                    ficha_azul.Left += 45;
                    ficha_azul.Top += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(40))
                {
                    ficha_azul.Left += 45;
                    ficha_azul.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_azul.Location.X.Equals(186) && ficha_azul.Location.Y.Equals(85))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    string pregunta = "¿Por que puerta de abajo quieres salir? ¿La de la izquierda?";
                    result = MessageBox.Show(pregunta, "Escoger puerta", buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                        ficha_azul.Top += 45;
                    else
                    {
                        ficha_azul.Top += 45;
                        ficha_azul.Left += 15;
                    }
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_azul.Location.X.Equals(321) && ficha_azul.Location.Y.Equals(70))
                {
                    ficha_azul.Top += 45;
                    ficha_azul.Left -= 45;
                }
                else if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(145))
                {
                    ficha_azul.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else
                {
                    int r = 0;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(100))
                            r++;
                    if (ficha_azul.Location.X.Equals(111) && ficha_azul.Location.Y.Equals(115))
                        r++;
                    for (int i = 156; i <= 216; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(130))
                            r++;
                    if (ficha_azul.Location.X.Equals(261) && ficha_azul.Location.Y.Equals(145))
                        r++;
                    for (int i = 291; i <= 351; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(145))
                            r++;
                    for (int i = 51; i <= 96; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(190))
                            r++;
                    for (int i = 36; i <= 81; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(295))
                            r++;
                    if (ficha_azul.Location.X.Equals(96) && ficha_azul.Location.Y.Equals(310))
                        r++;
                    if (ficha_azul.Location.X.Equals(111) && ficha_azul.Location.Y.Equals(355))
                        r++;
                    for (int i = 126; i <= 156; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(370))
                            r++;
                    if (ficha_azul.Location.X.Equals(156) && ficha_azul.Location.Y.Equals(385))
                        r++;
                    if (ficha_azul.Location.X.Equals(231) && ficha_azul.Location.Y.Equals(385))
                        r++;
                    for (int i = 231; i <= 261; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(370))
                            r++;
                    if (ficha_azul.Location.X.Equals(276) && ficha_azul.Location.Y.Equals(355))
                        r++;
                    if (ficha_azul.Location.X.Equals(141) && ficha_azul.Location.Y.Equals(265))
                        r++;
                    for (int i = 171; i <= 216; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(265))
                            r++;
                    if (ficha_azul.Location.X.Equals(246) && ficha_azul.Location.Y.Equals(265))
                        r++;
                    if (ficha_azul.Location.X.Equals(291) && ficha_azul.Location.Y.Equals(280))
                        r++;
                    if (ficha_azul.Location.X.Equals(321) && ficha_azul.Location.Y.Equals(205))
                        r++;
                    if (ficha_azul.Location.X.Equals(336) && ficha_azul.Location.Y.Equals(325))
                        r++;
                    if (ficha_azul.Location.X.Equals(201) && ficha_azul.Location.Y.Equals(310))
                        r++;
                    if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(340))
                        r++;
                    if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(220))
                        r++;
                    for (int i = 321; i <= 351; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(280))
                            r++;
                    if (ficha_azul.Location.X.Equals(231) && ficha_azul.Location.Y.Equals(385))
                        r++;
                    if (ficha_azul.Location.X.Equals(21) && ficha_azul.Location.Y.Equals(295))
                        r++;
                    if (ficha_azul.Location.X.Equals(21) && ficha_azul.Location.Y.Equals(100))
                        r++;
                    if (ficha_azul.Location.X.Equals(366) && ficha_azul.Location.Y.Equals(130))
                        r++;
                    if (r == 0)
                    {
                        ficha_azul.Top += 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                lax.Text = Convert.ToString(ficha_azul.Location.X);
                lay.Text = Convert.ToString(ficha_azul.Location.Y);
            }
            else if (num == 3 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_verde.Location.X.Equals(36) && ficha_verde.Location.Y.Equals(190))
                {
                    ficha_verde.Top += 30;
                    ficha_verde.Left += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_verde.Location.X.Equals(156) && ficha_verde.Location.Y.Equals(265))
                {
                    ficha_verde.Left += 45;
                    ficha_verde.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_verde.Location.X.Equals(231) && ficha_verde.Location.Y.Equals(265))
                {
                    ficha_verde.Left -= 30;
                    ficha_verde.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_verde.Location.X.Equals(306) && ficha_verde.Location.Y.Equals(280))
                {
                    ficha_verde.Left += 30;
                    ficha_verde.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_verde.Location.X.Equals(276) && ficha_verde.Location.Y.Equals(145))
                {
                    ficha_verde.Left += 45;
                    ficha_verde.Top += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(40))
                {
                    ficha_verde.Left += 45;
                    ficha_verde.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_verde.Location.X.Equals(186) && ficha_verde.Location.Y.Equals(85))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    string pregunta = "¿Por que puerta de abajo quieres salir? ¿La de la izquierda?";
                    result = MessageBox.Show(pregunta, "Escoger puerta", buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                        ficha_verde.Top += 45;
                    else
                    {
                        ficha_verde.Top += 45;
                        ficha_verde.Left += 15;
                    }
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_verde.Location.X.Equals(321) && ficha_verde.Location.Y.Equals(70))
                {
                    ficha_verde.Top += 45;
                    ficha_verde.Left -= 45;
                }
                else if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(145))
                {
                    ficha_verde.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else
                {
                    int r = 0;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(100))
                            r++;
                    if (ficha_verde.Location.X.Equals(111) && ficha_verde.Location.Y.Equals(115))
                        r++;
                    for (int i = 156; i <= 216; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(130))
                            r++;
                    if (ficha_verde.Location.X.Equals(261) && ficha_verde.Location.Y.Equals(145))
                        r++;
                    for (int i = 291; i <= 351; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(145))
                            r++;
                    for (int i = 51; i <= 96; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(190))
                            r++;
                    for (int i = 36; i <= 81; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(295))
                            r++;
                    if (ficha_verde.Location.X.Equals(96) && ficha_verde.Location.Y.Equals(310))
                        r++;
                    if (ficha_verde.Location.X.Equals(111) && ficha_verde.Location.Y.Equals(355))
                        r++;
                    for (int i = 126; i <= 156; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(370))
                            r++;
                    if (ficha_verde.Location.X.Equals(156) && ficha_verde.Location.Y.Equals(385))
                        r++;
                    if (ficha_verde.Location.X.Equals(231) && ficha_verde.Location.Y.Equals(385))
                        r++;
                    for (int i = 231; i <= 261; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(370))
                            r++;
                    if (ficha_verde.Location.X.Equals(276) && ficha_verde.Location.Y.Equals(355))
                        r++;
                    if (ficha_verde.Location.X.Equals(141) && ficha_verde.Location.Y.Equals(265))
                        r++;
                    for (int i = 171; i <= 216; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(265))
                            r++;
                    if (ficha_verde.Location.X.Equals(246) && ficha_verde.Location.Y.Equals(265))
                        r++;
                    if (ficha_verde.Location.X.Equals(291) && ficha_verde.Location.Y.Equals(280))
                        r++;
                    if (ficha_verde.Location.X.Equals(321) && ficha_verde.Location.Y.Equals(205))
                        r++;
                    if (ficha_verde.Location.X.Equals(336) && ficha_verde.Location.Y.Equals(325))
                        r++;
                    if (ficha_verde.Location.X.Equals(201) && ficha_verde.Location.Y.Equals(310))
                        r++;
                    if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(340))
                        r++;
                    if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(220))
                        r++;
                    for (int i = 321; i <= 351; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(280))
                            r++;
                    if (ficha_verde.Location.X.Equals(231) && ficha_verde.Location.Y.Equals(385))
                        r++;
                    if (ficha_verde.Location.X.Equals(21) && ficha_verde.Location.Y.Equals(295))
                        r++;
                    if (ficha_verde.Location.X.Equals(21) && ficha_verde.Location.Y.Equals(100))
                        r++;
                    if (ficha_verde.Location.X.Equals(366) && ficha_verde.Location.Y.Equals(130))
                        r++;
                    if (r == 0)
                    {
                        ficha_verde.Top += 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                lvx.Text = Convert.ToString(ficha_verde.Location.X);
                lvy.Text = Convert.ToString(ficha_verde.Location.Y);
            }
            else if (num == 2 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_marron.Location.X.Equals(36) && ficha_marron.Location.Y.Equals(190))
                {
                    ficha_marron.Top += 30;
                    ficha_marron.Left += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_marron.Location.X.Equals(156) && ficha_marron.Location.Y.Equals(265))
                {
                    ficha_marron.Left += 45;
                    ficha_marron.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_marron.Location.X.Equals(231) && ficha_marron.Location.Y.Equals(265))
                {
                    ficha_marron.Left -= 30;
                    ficha_marron.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }

                else if (ficha_marron.Location.X.Equals(306) && ficha_marron.Location.Y.Equals(280))
                {
                    ficha_marron.Left += 30;
                    ficha_marron.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_marron.Location.X.Equals(276) && ficha_marron.Location.Y.Equals(145))
                {
                    ficha_marron.Left += 45;
                    ficha_marron.Top += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(40))
                {
                    ficha_marron.Left += 45;
                    ficha_marron.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_marron.Location.X.Equals(186) && ficha_marron.Location.Y.Equals(85))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    string pregunta = "¿Por que puerta de abajo quieres salir? ¿La de la izquierda?";
                    result = MessageBox.Show(pregunta, "Escoger puerta", buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                        ficha_marron.Top += 45;
                    else
                    {
                        ficha_marron.Top += 45;
                        ficha_marron.Left += 15;
                    }
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_marron.Location.X.Equals(321) && ficha_marron.Location.Y.Equals(70))
                {
                    ficha_marron.Top += 45;
                    ficha_marron.Left -= 45;
                }
                else if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(145))
                {
                    ficha_marron.Top += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else
                {
                    int r = 0;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(100))
                            r++;
                    if (ficha_marron.Location.X.Equals(111) && ficha_marron.Location.Y.Equals(115))
                        r++;
                    for (int i = 156; i <= 216; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(130))
                            r++;
                    if (ficha_marron.Location.X.Equals(261) && ficha_marron.Location.Y.Equals(145))
                        r++;
                    for (int i = 291; i <= 351; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(145))
                            r++;
                    for (int i = 51; i <= 96; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(190))
                            r++;
                    for (int i = 36; i <= 81; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(295))
                            r++;
                    if (ficha_marron.Location.X.Equals(96) && ficha_marron.Location.Y.Equals(310))
                        r++;
                    if (ficha_marron.Location.X.Equals(111) && ficha_marron.Location.Y.Equals(355))
                        r++;
                    for (int i = 126; i <= 156; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(370))
                            r++;
                    if (ficha_marron.Location.X.Equals(156) && ficha_marron.Location.Y.Equals(385))
                        r++;
                    if (ficha_marron.Location.X.Equals(231) && ficha_marron.Location.Y.Equals(385))
                        r++;
                    for (int i = 231; i <= 261; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(370))
                            r++;
                    if (ficha_marron.Location.X.Equals(276) && ficha_marron.Location.Y.Equals(355))
                        r++;
                    if (ficha_marron.Location.X.Equals(141) && ficha_marron.Location.Y.Equals(265))
                        r++;
                    for (int i = 171; i <= 216; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(265))
                            r++;
                    if (ficha_marron.Location.X.Equals(246) && ficha_marron.Location.Y.Equals(265))
                        r++;
                    if (ficha_marron.Location.X.Equals(291) && ficha_marron.Location.Y.Equals(280))
                        r++;
                    if (ficha_marron.Location.X.Equals(321) && ficha_marron.Location.Y.Equals(205))
                        r++;
                    if (ficha_marron.Location.X.Equals(336) && ficha_marron.Location.Y.Equals(325))
                        r++;
                    if (ficha_marron.Location.X.Equals(201) && ficha_marron.Location.Y.Equals(310))
                        r++;
                    if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(340))
                        r++;
                    if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(220))
                        r++;
                    for (int i = 321; i <= 351; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(280))
                            r++;
                    if (ficha_marron.Location.X.Equals(231) && ficha_marron.Location.Y.Equals(385))
                        r++;
                    if (ficha_marron.Location.X.Equals(21) && ficha_marron.Location.Y.Equals(295))
                        r++;
                    if (ficha_marron.Location.X.Equals(21) && ficha_marron.Location.Y.Equals(100))
                        r++;
                    if (ficha_marron.Location.X.Equals(366) && ficha_marron.Location.Y.Equals(130))
                        r++;
                    if (r == 0)
                    {
                        ficha_marron.Top += 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                lmx.Text = Convert.ToString(ficha_marron.Location.X);
                lmy.Text = Convert.ToString(ficha_marron.Location.Y);
            }
        }

        private void mover_derecha_Click_1(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(vficha.Text);

            if (num == 1 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_dorada.Location.X.Equals(141) && ficha_dorada.Location.Y.Equals(85))
                {
                    ficha_dorada.Left += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_dorada.Location.X.Equals(126) && ficha_dorada.Location.Y.Equals(310))
                {
                    ficha_dorada.Left += 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_dorada.Location.X.Equals(201) && ficha_dorada.Location.Y.Equals(310))
                {
                    ficha_dorada.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_dorada.Location.X.Equals(321) && ficha_dorada.Location.Y.Equals(70))
                {
                    ficha_dorada.Left -= 255;
                    ficha_dorada.Top += 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(145))
                {
                    ficha_dorada.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(220))
                {
                    ficha_dorada.Left += 45;
                    ficha_dorada.Top += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(340))
                {
                    ficha_dorada.Left += 30;
                    ficha_dorada.Top -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_dorada.Location.X.Equals(201) && ficha_dorada.Location.Y.Equals(310))
                {
                    ficha_dorada.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_dorada.Location.X.Equals(336) && ficha_dorada.Location.Y.Equals(325))
                {
                    ficha_dorada.Top -= 285;
                    ficha_dorada.Left -= 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_dorada.Location.X.Equals(246) && ficha_dorada.Location.Y.Equals(205))
                {
                    ficha_dorada.Left += 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else
                {
                    int r = 0;
                    for (int i = 100; i <= 115; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(141) && ficha_dorada.Location.Y.Equals(i))
                            r++;
                    if (ficha_dorada.Location.X.Equals(366) && ficha_dorada.Location.Y.Equals(130))
                        r++;
                    for (int i = 40; i <= 70; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(141) && ficha_dorada.Location.Y.Equals(i))
                            r++;
                    if (ficha_dorada.Location.X.Equals(231) && ficha_dorada.Location.Y.Equals(385))
                        r++;
                    for (int i = 25; i <= 100; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(261) && ficha_dorada.Location.Y.Equals(i))
                            r++;
                    for (int i = 115; i <= 145; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(351) && ficha_dorada.Location.Y.Equals(i))
                            r++;
                    for (int i = 145; i <= 235; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(141) && ficha_dorada.Location.Y.Equals(i))
                            r++;
                    if (ficha_dorada.Location.X.Equals(156) && ficha_dorada.Location.Y.Equals(385))
                        r++;
                    if (ficha_dorada.Location.X.Equals(321) && ficha_dorada.Location.Y.Equals(205))
                        r++;
                    for (int i = 280; i <= 295; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(126) && ficha_dorada.Location.Y.Equals(i))
                            r++;
                    if (ficha_dorada.Location.X.Equals(186) && ficha_dorada.Location.Y.Equals(85))
                        r++;
                    if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(40))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(126) && ficha_dorada.Location.Y.Equals(i))
                            r++;
                    if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(340))
                        r++;
                    if (ficha_dorada.Location.X.Equals(126) && ficha_dorada.Location.Y.Equals(25))
                        r++;
                    for (int i = 310; i <= 355; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(276) && ficha_dorada.Location.Y.Equals(i))
                            r++;
                    if (ficha_dorada.Location.X.Equals(156) && ficha_dorada.Location.Y.Equals(370))
                        r++;
                    if (ficha_dorada.Location.X.Equals(261) && ficha_dorada.Location.Y.Equals(370))
                        r++;
                    if (ficha_dorada.Location.X.Equals(366) && ficha_dorada.Location.Y.Equals(280))
                        r++;
                    if (ficha_dorada.Location.X.Equals(351) && ficha_dorada.Location.Y.Equals(265))
                        r++;
                    if (ficha_dorada.Location.X.Equals(291) && ficha_dorada.Location.Y.Equals(250))
                        r++;
                    if (ficha_dorada.Location.X.Equals(351) && ficha_dorada.Location.Y.Equals(115))
                        r++;
                    if (ficha_dorada.Location.X.Equals(351) && ficha_dorada.Location.Y.Equals(145))
                        r++;
                    for (int i = 220; i <= 235; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(276) && ficha_dorada.Location.Y.Equals(i))
                            r++;
                    for (int i = 160; i <= 190; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(246) && ficha_dorada.Location.Y.Equals(i))
                            r++;
                    if (r == 0)
                    {
                        ficha_dorada.Left += 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                ldx.Text = Convert.ToString(ficha_dorada.Location.X);
                ldy.Text = Convert.ToString(ficha_dorada.Location.Y);
            }
            else if (num == 5 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_granate.Location.X.Equals(141) && ficha_granate.Location.Y.Equals(85))
                {
                    ficha_granate.Left += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_granate.Location.X.Equals(126) && ficha_granate.Location.Y.Equals(310))
                {
                    ficha_granate.Left += 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_granate.Location.X.Equals(201) && ficha_granate.Location.Y.Equals(310))
                {
                    ficha_granate.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_granate.Location.X.Equals(321) && ficha_granate.Location.Y.Equals(70))
                {
                    ficha_granate.Left -= 255;
                    ficha_granate.Top += 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(145))
                {
                    ficha_granate.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(220))
                {
                    ficha_granate.Left += 45;
                    ficha_granate.Top += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(340))
                {
                    ficha_granate.Left += 30;
                    ficha_granate.Top -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_granate.Location.X.Equals(201) && ficha_granate.Location.Y.Equals(310))
                {
                    ficha_granate.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_granate.Location.X.Equals(336) && ficha_granate.Location.Y.Equals(325))
                {
                    ficha_granate.Top -= 285;
                    ficha_granate.Left -= 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_granate.Location.X.Equals(246) && ficha_granate.Location.Y.Equals(205))
                {
                    ficha_granate.Left += 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else
                {
                    int r = 0;
                    for (int i = 100; i <= 115; i = i + 15)
                        if (ficha_granate.Location.X.Equals(141) && ficha_granate.Location.Y.Equals(i))
                            r++;
                    if (ficha_granate.Location.X.Equals(366) && ficha_granate.Location.Y.Equals(130))
                        r++;
                    for (int i = 40; i <= 70; i = i + 15)
                        if (ficha_granate.Location.X.Equals(141) && ficha_granate.Location.Y.Equals(i))
                            r++;
                    if (ficha_granate.Location.X.Equals(231) && ficha_granate.Location.Y.Equals(385))
                        r++;
                    for (int i = 25; i <= 100; i = i + 15)
                        if (ficha_granate.Location.X.Equals(261) && ficha_granate.Location.Y.Equals(i))
                            r++;
                    for (int i = 115; i <= 145; i = i + 15)
                        if (ficha_granate.Location.X.Equals(351) && ficha_granate.Location.Y.Equals(i))
                            r++;
                    for (int i = 145; i <= 235; i = i + 15)
                        if (ficha_granate.Location.X.Equals(141) && ficha_granate.Location.Y.Equals(i))
                            r++;
                    if (ficha_granate.Location.X.Equals(156) && ficha_granate.Location.Y.Equals(385))
                        r++;
                    if (ficha_granate.Location.X.Equals(321) && ficha_granate.Location.Y.Equals(205))
                        r++;
                    for (int i = 280; i <= 295; i = i + 15)
                        if (ficha_granate.Location.X.Equals(126) && ficha_granate.Location.Y.Equals(i))
                            r++;
                    if (ficha_granate.Location.X.Equals(186) && ficha_granate.Location.Y.Equals(85))
                        r++;
                    if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(40))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_granate.Location.X.Equals(126) && ficha_granate.Location.Y.Equals(i))
                            r++;
                    if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(340))
                        r++;
                    if (ficha_granate.Location.X.Equals(126) && ficha_granate.Location.Y.Equals(25))
                        r++;
                    for (int i = 310; i <= 355; i = i + 15)
                        if (ficha_granate.Location.X.Equals(276) && ficha_granate.Location.Y.Equals(i))
                            r++;
                    if (ficha_granate.Location.X.Equals(156) && ficha_granate.Location.Y.Equals(370))
                        r++;
                    if (ficha_granate.Location.X.Equals(261) && ficha_granate.Location.Y.Equals(370))
                        r++;
                    if (ficha_granate.Location.X.Equals(366) && ficha_granate.Location.Y.Equals(280))
                        r++;
                    if (ficha_granate.Location.X.Equals(351) && ficha_granate.Location.Y.Equals(265))
                        r++;
                    if (ficha_granate.Location.X.Equals(291) && ficha_granate.Location.Y.Equals(250))
                        r++;
                    if (ficha_granate.Location.X.Equals(351) && ficha_granate.Location.Y.Equals(115))
                        r++;
                    if (ficha_granate.Location.X.Equals(351) && ficha_granate.Location.Y.Equals(145))
                        r++;
                    for (int i = 220; i <= 235; i = i + 15)
                        if (ficha_granate.Location.X.Equals(276) && ficha_granate.Location.Y.Equals(i))
                            r++;
                    for (int i = 160; i <= 190; i = i + 15)
                        if (ficha_granate.Location.X.Equals(246) && ficha_granate.Location.Y.Equals(i))
                            r++;
                    if (r == 0)
                    {
                        ficha_granate.Left += 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                lgx.Text = Convert.ToString(ficha_granate.Location.X);
                lgy.Text = Convert.ToString(ficha_granate.Location.Y);
            }
            else if (num == 4 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_lila.Location.X.Equals(141) && ficha_lila.Location.Y.Equals(85))
                {
                    ficha_lila.Left += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_lila.Location.X.Equals(126) && ficha_lila.Location.Y.Equals(310))
                {
                    ficha_lila.Left += 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_lila.Location.X.Equals(201) && ficha_lila.Location.Y.Equals(310))
                {
                    ficha_lila.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_lila.Location.X.Equals(321) && ficha_lila.Location.Y.Equals(70))
                {
                    ficha_lila.Left -= 255;
                    ficha_lila.Top += 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(145))
                {
                    ficha_lila.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(220))
                {
                    ficha_lila.Left += 45;
                    ficha_lila.Top += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(340))
                {
                    ficha_lila.Left += 30;
                    ficha_lila.Top -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_lila.Location.X.Equals(201) && ficha_lila.Location.Y.Equals(310))
                {
                    ficha_lila.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_lila.Location.X.Equals(336) && ficha_lila.Location.Y.Equals(325))
                {
                    ficha_lila.Top -= 285;
                    ficha_lila.Left -= 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_lila.Location.X.Equals(246) && ficha_lila.Location.Y.Equals(205))
                {
                    ficha_lila.Left += 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else
                {
                    int r = 0;
                    for (int i = 100; i <= 115; i = i + 15)
                        if (ficha_lila.Location.X.Equals(141) && ficha_lila.Location.Y.Equals(i))
                            r++;
                    if (ficha_lila.Location.X.Equals(366) && ficha_lila.Location.Y.Equals(130))
                        r++;
                    for (int i = 40; i <= 70; i = i + 15)
                        if (ficha_lila.Location.X.Equals(141) && ficha_lila.Location.Y.Equals(i))
                            r++;
                    if (ficha_lila.Location.X.Equals(231) && ficha_lila.Location.Y.Equals(385))
                        r++;
                    for (int i = 25; i <= 100; i = i + 15)
                        if (ficha_lila.Location.X.Equals(261) && ficha_lila.Location.Y.Equals(i))
                            r++;
                    for (int i = 115; i <= 145; i = i + 15)
                        if (ficha_lila.Location.X.Equals(351) && ficha_lila.Location.Y.Equals(i))
                            r++;
                    for (int i = 145; i <= 235; i = i + 15)
                        if (ficha_lila.Location.X.Equals(141) && ficha_lila.Location.Y.Equals(i))
                            r++;
                    if (ficha_lila.Location.X.Equals(156) && ficha_lila.Location.Y.Equals(385))
                        r++;
                    if (ficha_lila.Location.X.Equals(321) && ficha_lila.Location.Y.Equals(205))
                        r++;
                    for (int i = 280; i <= 295; i = i + 15)
                        if (ficha_lila.Location.X.Equals(126) && ficha_lila.Location.Y.Equals(i))
                            r++;
                    if (ficha_lila.Location.X.Equals(186) && ficha_lila.Location.Y.Equals(85))
                        r++;
                    if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(40))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_lila.Location.X.Equals(126) && ficha_lila.Location.Y.Equals(i))
                            r++;
                    if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(340))
                        r++;
                    if (ficha_lila.Location.X.Equals(126) && ficha_lila.Location.Y.Equals(25))
                        r++;
                    for (int i = 310; i <= 355; i = i + 15)
                        if (ficha_lila.Location.X.Equals(276) && ficha_lila.Location.Y.Equals(i))
                            r++;
                    if (ficha_lila.Location.X.Equals(156) && ficha_lila.Location.Y.Equals(370))
                        r++;
                    if (ficha_lila.Location.X.Equals(261) && ficha_lila.Location.Y.Equals(370))
                        r++;
                    if (ficha_lila.Location.X.Equals(366) && ficha_lila.Location.Y.Equals(280))
                        r++;
                    if (ficha_lila.Location.X.Equals(351) && ficha_lila.Location.Y.Equals(265))
                        r++;
                    if (ficha_lila.Location.X.Equals(291) && ficha_lila.Location.Y.Equals(250))
                        r++;
                    if (ficha_lila.Location.X.Equals(351) && ficha_lila.Location.Y.Equals(115))
                        r++;
                    if (ficha_lila.Location.X.Equals(351) && ficha_lila.Location.Y.Equals(145))
                        r++;
                    for (int i = 220; i <= 235; i = i + 15)
                        if (ficha_lila.Location.X.Equals(276) && ficha_lila.Location.Y.Equals(i))
                            r++;
                    for (int i = 160; i <= 190; i = i + 15)
                        if (ficha_lila.Location.X.Equals(246) && ficha_lila.Location.Y.Equals(i))
                            r++;
                    if (r == 0)
                    {
                        ficha_lila.Left += 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                llx.Text = Convert.ToString(ficha_lila.Location.X);
                lly.Text = Convert.ToString(ficha_lila.Location.Y);
            }
            else if (num == 6 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_azul.Location.X.Equals(141) && ficha_azul.Location.Y.Equals(85))
                {
                    ficha_azul.Left += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_azul.Location.X.Equals(126) && ficha_azul.Location.Y.Equals(310))
                {
                    ficha_azul.Left += 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_azul.Location.X.Equals(201) && ficha_azul.Location.Y.Equals(310))
                {
                    ficha_azul.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_azul.Location.X.Equals(321) && ficha_azul.Location.Y.Equals(70))
                {
                    ficha_azul.Left -= 255;
                    ficha_azul.Top += 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(145))
                {
                    ficha_azul.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(220))
                {
                    ficha_azul.Left += 45;
                    ficha_azul.Top += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(340))
                {
                    ficha_azul.Left += 30;
                    ficha_azul.Top -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_azul.Location.X.Equals(201) && ficha_azul.Location.Y.Equals(310))
                {
                    ficha_azul.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_azul.Location.X.Equals(336) && ficha_azul.Location.Y.Equals(325))
                {
                    ficha_azul.Top -= 285;
                    ficha_azul.Left -= 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_azul.Location.X.Equals(246) && ficha_azul.Location.Y.Equals(205))
                {
                    ficha_azul.Left += 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else
                {
                    int r = 0;
                    for (int i = 100; i <= 115; i = i + 15)
                        if (ficha_azul.Location.X.Equals(141) && ficha_azul.Location.Y.Equals(i))
                            r++;
                    if (ficha_azul.Location.X.Equals(366) && ficha_azul.Location.Y.Equals(130))
                        r++;
                    for (int i = 40; i <= 70; i = i + 15)
                        if (ficha_azul.Location.X.Equals(141) && ficha_azul.Location.Y.Equals(i))
                            r++;
                    if (ficha_azul.Location.X.Equals(231) && ficha_azul.Location.Y.Equals(385))
                        r++;
                    for (int i = 25; i <= 100; i = i + 15)
                        if (ficha_azul.Location.X.Equals(261) && ficha_azul.Location.Y.Equals(i))
                            r++;
                    for (int i = 115; i <= 145; i = i + 15)
                        if (ficha_azul.Location.X.Equals(351) && ficha_azul.Location.Y.Equals(i))
                            r++;
                    for (int i = 145; i <= 235; i = i + 15)
                        if (ficha_azul.Location.X.Equals(141) && ficha_azul.Location.Y.Equals(i))
                            r++;
                    if (ficha_azul.Location.X.Equals(156) && ficha_azul.Location.Y.Equals(385))
                        r++;
                    if (ficha_azul.Location.X.Equals(321) && ficha_azul.Location.Y.Equals(205))
                        r++;
                    for (int i = 280; i <= 295; i = i + 15)
                        if (ficha_azul.Location.X.Equals(126) && ficha_azul.Location.Y.Equals(i))
                            r++;
                    if (ficha_azul.Location.X.Equals(186) && ficha_azul.Location.Y.Equals(85))
                        r++;
                    if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(40))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_azul.Location.X.Equals(126) && ficha_azul.Location.Y.Equals(i))
                            r++;
                    if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(340))
                        r++;
                    if (ficha_azul.Location.X.Equals(126) && ficha_azul.Location.Y.Equals(25))
                        r++;
                    for (int i = 310; i <= 355; i = i + 15)
                        if (ficha_azul.Location.X.Equals(276) && ficha_azul.Location.Y.Equals(i))
                            r++;
                    if (ficha_azul.Location.X.Equals(156) && ficha_azul.Location.Y.Equals(370))
                        r++;
                    if (ficha_azul.Location.X.Equals(261) && ficha_azul.Location.Y.Equals(370))
                        r++;
                    if (ficha_azul.Location.X.Equals(366) && ficha_azul.Location.Y.Equals(280))
                        r++;
                    if (ficha_azul.Location.X.Equals(351) && ficha_azul.Location.Y.Equals(265))
                        r++;
                    if (ficha_azul.Location.X.Equals(291) && ficha_azul.Location.Y.Equals(250))
                        r++;
                    if (ficha_azul.Location.X.Equals(351) && ficha_azul.Location.Y.Equals(115))
                        r++;
                    if (ficha_azul.Location.X.Equals(351) && ficha_azul.Location.Y.Equals(145))
                        r++;
                    for (int i = 220; i <= 235; i = i + 15)
                        if (ficha_azul.Location.X.Equals(276) && ficha_azul.Location.Y.Equals(i))
                            r++;
                    for (int i = 160; i <= 190; i = i + 15)
                        if (ficha_azul.Location.X.Equals(246) && ficha_azul.Location.Y.Equals(i))
                            r++;
                    if (r == 0)
                    {
                        ficha_azul.Left += 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                lax.Text = Convert.ToString(ficha_azul.Location.X);
                lay.Text = Convert.ToString(ficha_azul.Location.Y);
            }
            else if (num == 3 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_verde.Location.X.Equals(141) && ficha_verde.Location.Y.Equals(85))
                {
                    ficha_verde.Left += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_verde.Location.X.Equals(126) && ficha_verde.Location.Y.Equals(310))
                {
                    ficha_verde.Left += 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_verde.Location.X.Equals(201) && ficha_verde.Location.Y.Equals(310))
                {
                    ficha_verde.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_verde.Location.X.Equals(321) && ficha_verde.Location.Y.Equals(70))
                {
                    ficha_verde.Left -= 255;
                    ficha_verde.Top += 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(145))
                {
                    ficha_verde.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(220))
                {
                    ficha_verde.Left += 45;
                    ficha_verde.Top += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(340))
                {
                    ficha_verde.Left += 30;
                    ficha_verde.Top -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_verde.Location.X.Equals(201) && ficha_verde.Location.Y.Equals(310))
                {
                    ficha_verde.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_verde.Location.X.Equals(336) && ficha_verde.Location.Y.Equals(325))
                {
                    ficha_verde.Top -= 285;
                    ficha_verde.Left -= 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_verde.Location.X.Equals(246) && ficha_verde.Location.Y.Equals(205))
                {
                    ficha_verde.Left += 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else
                {
                    int r = 0;
                    for (int i = 100; i <= 115; i = i + 15)
                        if (ficha_verde.Location.X.Equals(141) && ficha_verde.Location.Y.Equals(i))
                            r++;
                    if (ficha_verde.Location.X.Equals(366) && ficha_verde.Location.Y.Equals(130))
                        r++;
                    for (int i = 40; i <= 70; i = i + 15)
                        if (ficha_verde.Location.X.Equals(141) && ficha_verde.Location.Y.Equals(i))
                            r++;
                    if (ficha_verde.Location.X.Equals(231) && ficha_verde.Location.Y.Equals(385))
                        r++;
                    for (int i = 25; i <= 100; i = i + 15)
                        if (ficha_verde.Location.X.Equals(261) && ficha_verde.Location.Y.Equals(i))
                            r++;
                    for (int i = 115; i <= 145; i = i + 15)
                        if (ficha_verde.Location.X.Equals(351) && ficha_verde.Location.Y.Equals(i))
                            r++;
                    for (int i = 145; i <= 235; i = i + 15)
                        if (ficha_verde.Location.X.Equals(141) && ficha_verde.Location.Y.Equals(i))
                            r++;
                    if (ficha_verde.Location.X.Equals(156) && ficha_verde.Location.Y.Equals(385))
                        r++;
                    if (ficha_verde.Location.X.Equals(321) && ficha_verde.Location.Y.Equals(205))
                        r++;
                    for (int i = 280; i <= 295; i = i + 15)
                        if (ficha_verde.Location.X.Equals(126) && ficha_verde.Location.Y.Equals(i))
                            r++;
                    if (ficha_verde.Location.X.Equals(186) && ficha_verde.Location.Y.Equals(85))
                        r++;
                    if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(40))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_verde.Location.X.Equals(126) && ficha_verde.Location.Y.Equals(i))
                            r++;
                    if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(340))
                        r++;
                    if (ficha_verde.Location.X.Equals(126) && ficha_verde.Location.Y.Equals(25))
                        r++;
                    for (int i = 310; i <= 355; i = i + 15)
                        if (ficha_verde.Location.X.Equals(276) && ficha_verde.Location.Y.Equals(i))
                            r++;
                    if (ficha_verde.Location.X.Equals(156) && ficha_verde.Location.Y.Equals(370))
                        r++;
                    if (ficha_verde.Location.X.Equals(261) && ficha_verde.Location.Y.Equals(370))
                        r++;
                    if (ficha_verde.Location.X.Equals(366) && ficha_verde.Location.Y.Equals(280))
                        r++;
                    if (ficha_verde.Location.X.Equals(351) && ficha_verde.Location.Y.Equals(265))
                        r++;
                    if (ficha_verde.Location.X.Equals(291) && ficha_verde.Location.Y.Equals(250))
                        r++;
                    if (ficha_verde.Location.X.Equals(351) && ficha_verde.Location.Y.Equals(115))
                        r++;
                    if (ficha_verde.Location.X.Equals(351) && ficha_verde.Location.Y.Equals(145))
                        r++;
                    for (int i = 220; i <= 235; i = i + 15)
                        if (ficha_verde.Location.X.Equals(276) && ficha_verde.Location.Y.Equals(i))
                            r++;
                    for (int i = 160; i <= 190; i = i + 15)
                        if (ficha_verde.Location.X.Equals(246) && ficha_verde.Location.Y.Equals(i))
                            r++;
                    if (r == 0)
                    {
                        ficha_verde.Left += 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                lvx.Text = Convert.ToString(ficha_verde.Location.X);
                lvy.Text = Convert.ToString(ficha_verde.Location.Y);
            }
            else if (num == 2 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_marron.Location.X.Equals(141) && ficha_marron.Location.Y.Equals(85))
                {
                    ficha_marron.Left += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_marron.Location.X.Equals(126) && ficha_marron.Location.Y.Equals(310))
                {
                    ficha_marron.Left += 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_marron.Location.X.Equals(201) && ficha_marron.Location.Y.Equals(310))
                {
                    ficha_marron.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_marron.Location.X.Equals(321) && ficha_marron.Location.Y.Equals(70))
                {
                    ficha_marron.Left -= 255;
                    ficha_marron.Top += 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(145))
                {
                    ficha_marron.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(220))
                {
                    ficha_marron.Left += 45;
                    ficha_marron.Top += 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(340))
                {
                    ficha_marron.Left += 30;
                    ficha_marron.Top -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_marron.Location.X.Equals(201) && ficha_marron.Location.Y.Equals(310))
                {
                    ficha_marron.Left += 60;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_marron.Location.X.Equals(336) && ficha_marron.Location.Y.Equals(325))
                {
                    ficha_marron.Top -= 285;
                    ficha_marron.Left -= 270;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_marron.Location.X.Equals(246) && ficha_marron.Location.Y.Equals(205))
                {
                    ficha_marron.Left += 75;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else
                {
                    int r = 0;
                    for (int i = 100; i <= 115; i = i + 15)
                        if (ficha_marron.Location.X.Equals(141) && ficha_marron.Location.Y.Equals(i))
                            r++;
                    if (ficha_marron.Location.X.Equals(366) && ficha_marron.Location.Y.Equals(130))
                        r++;
                    for (int i = 40; i <= 70; i = i + 15)
                        if (ficha_marron.Location.X.Equals(141) && ficha_marron.Location.Y.Equals(i))
                            r++;
                    if (ficha_marron.Location.X.Equals(231) && ficha_marron.Location.Y.Equals(385))
                        r++;
                    for (int i = 25; i <= 100; i = i + 15)
                        if (ficha_marron.Location.X.Equals(261) && ficha_marron.Location.Y.Equals(i))
                            r++;
                    for (int i = 115; i <= 145; i = i + 15)
                        if (ficha_marron.Location.X.Equals(351) && ficha_marron.Location.Y.Equals(i))
                            r++;
                    for (int i = 145; i <= 235; i = i + 15)
                        if (ficha_marron.Location.X.Equals(141) && ficha_marron.Location.Y.Equals(i))
                            r++;
                    if (ficha_marron.Location.X.Equals(156) && ficha_marron.Location.Y.Equals(385))
                        r++;
                    if (ficha_marron.Location.X.Equals(321) && ficha_marron.Location.Y.Equals(205))
                        r++;
                    for (int i = 280; i <= 295; i = i + 15)
                        if (ficha_marron.Location.X.Equals(126) && ficha_marron.Location.Y.Equals(i))
                            r++;
                    if (ficha_marron.Location.X.Equals(186) && ficha_marron.Location.Y.Equals(85))
                        r++;
                    if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(40))
                        r++;
                    for (int i = 325; i <= 355; i = i + 15)
                        if (ficha_marron.Location.X.Equals(126) && ficha_marron.Location.Y.Equals(i))
                            r++;
                    if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(340))
                        r++;
                    if (ficha_marron.Location.X.Equals(126) && ficha_marron.Location.Y.Equals(25))
                        r++;
                    for (int i = 310; i <= 355; i = i + 15)
                        if (ficha_marron.Location.X.Equals(276) && ficha_marron.Location.Y.Equals(i))
                            r++;
                    if (ficha_marron.Location.X.Equals(156) && ficha_marron.Location.Y.Equals(370))
                        r++;
                    if (ficha_marron.Location.X.Equals(261) && ficha_marron.Location.Y.Equals(370))
                        r++;
                    if (ficha_marron.Location.X.Equals(366) && ficha_marron.Location.Y.Equals(280))
                        r++;
                    if (ficha_marron.Location.X.Equals(351) && ficha_marron.Location.Y.Equals(265))
                        r++;
                    if (ficha_marron.Location.X.Equals(291) && ficha_marron.Location.Y.Equals(250))
                        r++;
                    if (ficha_marron.Location.X.Equals(351) && ficha_marron.Location.Y.Equals(115))
                        r++;
                    if (ficha_marron.Location.X.Equals(351) && ficha_marron.Location.Y.Equals(145))
                        r++;
                    for (int i = 220; i <= 235; i = i + 15)
                        if (ficha_marron.Location.X.Equals(276) && ficha_marron.Location.Y.Equals(i))
                            r++;
                    for (int i = 160; i <= 190; i = i + 15)
                        if (ficha_marron.Location.X.Equals(246) && ficha_marron.Location.Y.Equals(i))
                            r++;
                    if (r == 0)
                    {
                        ficha_marron.Left += 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                lmx.Text = Convert.ToString(ficha_marron.Location.X);
                lmy.Text = Convert.ToString(ficha_marron.Location.Y);
            }
        }

        private void mover_arriba_Click_1(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(vficha.Text);

            if (num == 1 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_dorada.Location.X.Equals(111) && ficha_dorada.Location.Y.Equals(85))
                {
                    ficha_dorada.Top -= 45;
                    ficha_dorada.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }

                else if (ficha_dorada.Location.X.Equals(186) && ficha_dorada.Location.Y.Equals(130))
                {
                    ficha_dorada.Top -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_dorada.Location.X.Equals(201) && ficha_dorada.Location.Y.Equals(130))
                {
                    ficha_dorada.Top -= 45;
                    ficha_dorada.Left -= 15;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_dorada.Location.X.Equals(276) && ficha_dorada.Location.Y.Equals(115))
                {
                    ficha_dorada.Top -= 45;
                    ficha_dorada.Left += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(190))
                {
                    ficha_dorada.Top -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(220))
                {
                    ficha_dorada.Top -= 30;
                    ficha_dorada.Left -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_dorada.Location.X.Equals(201) && ficha_dorada.Location.Y.Equals(310))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    string pregunta = "¿Por que puerta de arriba quieres salir? ¿La de la izquierda?";
                    result = MessageBox.Show(pregunta, "Escoger puerta", buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        ficha_dorada.Top -= 45;
                        ficha_dorada.Left -= 45;
                    }
                    else
                    {
                        ficha_dorada.Top -= 45;
                        ficha_dorada.Left += 30;
                    }
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_dorada.Location.X.Equals(336) && ficha_dorada.Location.Y.Equals(325))
                {
                    ficha_dorada.Top -= 45;
                    ficha_dorada.Left -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_dorada.Location.X.Equals(321) && ficha_dorada.Location.Y.Equals(205))
                {
                    ficha_dorada.Top -= 60;
                    ficha_dorada.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else
                {
                    int r = 0;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(85))
                            r++;
                    if (ficha_dorada.Location.X.Equals(366) && ficha_dorada.Location.Y.Equals(130))
                        r++;
                    for (int i = 156; i <= 171; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(130))
                            r++;
                    if (ficha_dorada.Location.X.Equals(261) && ficha_dorada.Location.Y.Equals(25))
                        r++;
                    for (int i = 216; i <= 231; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(130))
                            r++;
                    for (int i = 291; i <= 351; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(115))
                            r++;
                    for (int i = 36; i <= 51; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(190))
                            r++;
                    if (ficha_dorada.Location.X.Equals(21) && ficha_dorada.Location.Y.Equals(100))
                        r++;
                    if (ficha_dorada.Location.X.Equals(21) && ficha_dorada.Location.Y.Equals(295))
                        r++;
                    for (int i = 81; i <= 96; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(190))
                            r++;
                    if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(40))
                        r++;
                    if (ficha_dorada.Location.X.Equals(186) && ficha_dorada.Location.Y.Equals(85))
                        r++;
                    for (int i = 156; i <= 216; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(250))
                            r++;
                    if (ficha_dorada.Location.X.Equals(321) && ficha_dorada.Location.Y.Equals(70))
                        r++;
                    if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(145))
                        r++;
                    for (int i = 261; i <= 291; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(250))
                            r++;
                    if (ficha_dorada.Location.X.Equals(66) && ficha_dorada.Location.Y.Equals(340))
                        r++;
                    if (ficha_dorada.Location.X.Equals(126) && ficha_dorada.Location.Y.Equals(25))
                        r++;
                    if (ficha_dorada.Location.X.Equals(141) && ficha_dorada.Location.Y.Equals(40))
                        r++;
                    if (ficha_dorada.Location.X.Equals(261) && ficha_dorada.Location.Y.Equals(40))
                        r++;
                    if (ficha_dorada.Location.X.Equals(246) && ficha_dorada.Location.Y.Equals(40))
                        r++;
                    if (ficha_dorada.Location.X.Equals(111) && ficha_dorada.Location.Y.Equals(175))
                        r++;
                    if (ficha_dorada.Location.X.Equals(366) && ficha_dorada.Location.Y.Equals(280))
                        r++;
                    for (int i = 306; i <= 351; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(265))
                            r++;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(280))
                            r++;
                    for (int i = 141; i <= 156; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(370))
                            r++;
                    for (int i = 231; i <= 246; i = i + 15)
                        if (ficha_dorada.Location.X.Equals(i) && ficha_dorada.Location.Y.Equals(370))
                            r++;
                    if (r == 0)
                    {
                        ficha_dorada.Top -= 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                ldx.Text = Convert.ToString(ficha_dorada.Location.X);
                ldy.Text = Convert.ToString(ficha_dorada.Location.Y);
            }
            else if (num == 5 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_granate.Location.X.Equals(111) && ficha_granate.Location.Y.Equals(85))
                {
                    ficha_granate.Top -= 45;
                    ficha_granate.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }

                else if (ficha_granate.Location.X.Equals(186) && ficha_granate.Location.Y.Equals(130))
                {
                    ficha_granate.Top -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_granate.Location.X.Equals(201) && ficha_granate.Location.Y.Equals(130))
                {
                    ficha_granate.Top -= 45;
                    ficha_granate.Left -= 15;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_granate.Location.X.Equals(276) && ficha_granate.Location.Y.Equals(115))
                {
                    ficha_granate.Top -= 45;
                    ficha_granate.Left += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(190))
                {
                    ficha_granate.Top -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(220))
                {
                    ficha_granate.Top -= 30;
                    ficha_granate.Left -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_granate.Location.X.Equals(201) && ficha_granate.Location.Y.Equals(310))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    string pregunta = "¿Por que puerta de arriba quieres salir? ¿La de la izquierda?";
                    result = MessageBox.Show(pregunta, "Escoger puerta", buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        ficha_granate.Top -= 45;
                        ficha_granate.Left -= 45;
                    }
                    else
                    {
                        ficha_granate.Top -= 45;
                        ficha_granate.Left += 30;
                    }
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_granate.Location.X.Equals(336) && ficha_granate.Location.Y.Equals(325))
                {
                    ficha_granate.Top -= 45;
                    ficha_granate.Left -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_granate.Location.X.Equals(321) && ficha_granate.Location.Y.Equals(205))
                {
                    ficha_granate.Top -= 60;
                    ficha_granate.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else
                {
                    int r = 0;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(85))
                            r++;
                    if (ficha_granate.Location.X.Equals(366) && ficha_granate.Location.Y.Equals(130))
                        r++;
                    for (int i = 156; i <= 171; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(130))
                            r++;
                    if (ficha_granate.Location.X.Equals(261) && ficha_granate.Location.Y.Equals(25))
                        r++;
                    for (int i = 216; i <= 231; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(130))
                            r++;
                    for (int i = 291; i <= 351; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(115))
                            r++;
                    for (int i = 36; i <= 51; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(190))
                            r++;
                    if (ficha_granate.Location.X.Equals(21) && ficha_granate.Location.Y.Equals(100))
                        r++;
                    if (ficha_granate.Location.X.Equals(21) && ficha_granate.Location.Y.Equals(295))
                        r++;
                    for (int i = 81; i <= 96; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(190))
                            r++;
                    if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(40))
                        r++;
                    if (ficha_granate.Location.X.Equals(186) && ficha_granate.Location.Y.Equals(85))
                        r++;
                    for (int i = 156; i <= 216; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(250))
                            r++;
                    if (ficha_granate.Location.X.Equals(321) && ficha_granate.Location.Y.Equals(70))
                        r++;
                    if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(145))
                        r++;
                    for (int i = 261; i <= 291; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(250))
                            r++;
                    if (ficha_granate.Location.X.Equals(66) && ficha_granate.Location.Y.Equals(340))
                        r++;
                    if (ficha_granate.Location.X.Equals(126) && ficha_granate.Location.Y.Equals(25))
                        r++;
                    if (ficha_granate.Location.X.Equals(141) && ficha_granate.Location.Y.Equals(40))
                        r++;
                    if (ficha_granate.Location.X.Equals(261) && ficha_granate.Location.Y.Equals(40))
                        r++;
                    if (ficha_granate.Location.X.Equals(246) && ficha_granate.Location.Y.Equals(40))
                        r++;
                    if (ficha_granate.Location.X.Equals(111) && ficha_granate.Location.Y.Equals(175))
                        r++;
                    if (ficha_granate.Location.X.Equals(366) && ficha_granate.Location.Y.Equals(280))
                        r++;
                    for (int i = 306; i <= 351; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(265))
                            r++;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(280))
                            r++;
                    for (int i = 141; i <= 156; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(370))
                            r++;
                    for (int i = 231; i <= 246; i = i + 15)
                        if (ficha_granate.Location.X.Equals(i) && ficha_granate.Location.Y.Equals(370))
                            r++;
                    if (r == 0)
                    {
                        ficha_granate.Top -= 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                lgx.Text = Convert.ToString(ficha_granate.Location.X);
                lgy.Text = Convert.ToString(ficha_granate.Location.Y);
            }
            else if (num == 4 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_lila.Location.X.Equals(111) && ficha_lila.Location.Y.Equals(85))
                {
                    ficha_lila.Top -= 45;
                    ficha_lila.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }

                else if (ficha_lila.Location.X.Equals(186) && ficha_lila.Location.Y.Equals(130))
                {
                    ficha_lila.Top -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_lila.Location.X.Equals(201) && ficha_lila.Location.Y.Equals(130))
                {
                    ficha_lila.Top -= 45;
                    ficha_lila.Left -= 15;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_lila.Location.X.Equals(276) && ficha_lila.Location.Y.Equals(115))
                {
                    ficha_lila.Top -= 45;
                    ficha_lila.Left += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(190))
                {
                    ficha_lila.Top -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(220))
                {
                    ficha_lila.Top -= 30;
                    ficha_lila.Left -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_lila.Location.X.Equals(201) && ficha_lila.Location.Y.Equals(310))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    string pregunta = "¿Por que puerta de arriba quieres salir? ¿La de la izquierda?";
                    result = MessageBox.Show(pregunta, "Escoger puerta", buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        ficha_lila.Top -= 45;
                        ficha_lila.Left -= 45;
                    }
                    else
                    {
                        ficha_lila.Top -= 45;
                        ficha_lila.Left += 30;
                    }
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_lila.Location.X.Equals(336) && ficha_lila.Location.Y.Equals(325))
                {
                    ficha_lila.Top -= 45;
                    ficha_lila.Left -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_lila.Location.X.Equals(321) && ficha_lila.Location.Y.Equals(205))
                {
                    ficha_lila.Top -= 60;
                    ficha_lila.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else
                {
                    int r = 0;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(85))
                            r++;
                    if (ficha_lila.Location.X.Equals(366) && ficha_lila.Location.Y.Equals(130))
                        r++;
                    for (int i = 156; i <= 171; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(130))
                            r++;
                    if (ficha_lila.Location.X.Equals(261) && ficha_lila.Location.Y.Equals(25))
                        r++;
                    for (int i = 216; i <= 231; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(130))
                            r++;
                    for (int i = 291; i <= 351; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(115))
                            r++;
                    for (int i = 36; i <= 51; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(190))
                            r++;
                    if (ficha_lila.Location.X.Equals(21) && ficha_lila.Location.Y.Equals(100))
                        r++;
                    if (ficha_lila.Location.X.Equals(21) && ficha_lila.Location.Y.Equals(295))
                        r++;
                    for (int i = 81; i <= 96; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(190))
                            r++;
                    if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(40))
                        r++;
                    if (ficha_lila.Location.X.Equals(186) && ficha_lila.Location.Y.Equals(85))
                        r++;
                    for (int i = 156; i <= 216; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(250))
                            r++;
                    if (ficha_lila.Location.X.Equals(321) && ficha_lila.Location.Y.Equals(70))
                        r++;
                    if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(145))
                        r++;
                    for (int i = 261; i <= 291; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(250))
                            r++;
                    if (ficha_lila.Location.X.Equals(66) && ficha_lila.Location.Y.Equals(340))
                        r++;
                    if (ficha_lila.Location.X.Equals(126) && ficha_lila.Location.Y.Equals(25))
                        r++;
                    if (ficha_lila.Location.X.Equals(141) && ficha_lila.Location.Y.Equals(40))
                        r++;
                    if (ficha_lila.Location.X.Equals(261) && ficha_lila.Location.Y.Equals(40))
                        r++;
                    if (ficha_lila.Location.X.Equals(246) && ficha_lila.Location.Y.Equals(40))
                        r++;
                    if (ficha_lila.Location.X.Equals(111) && ficha_lila.Location.Y.Equals(175))
                        r++;
                    if (ficha_lila.Location.X.Equals(366) && ficha_lila.Location.Y.Equals(280))
                        r++;
                    for (int i = 306; i <= 351; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(265))
                            r++;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(280))
                            r++;
                    for (int i = 141; i <= 156; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(370))
                            r++;
                    for (int i = 231; i <= 246; i = i + 15)
                        if (ficha_lila.Location.X.Equals(i) && ficha_lila.Location.Y.Equals(370))
                            r++;
                    if (r == 0)
                    {
                        ficha_lila.Top -= 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                llx.Text = Convert.ToString(ficha_lila.Location.X);
                lly.Text = Convert.ToString(ficha_lila.Location.Y);
            }
            else if (num == 6 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_azul.Location.X.Equals(111) && ficha_azul.Location.Y.Equals(85))
                {
                    ficha_azul.Top -= 45;
                    ficha_azul.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }

                else if (ficha_azul.Location.X.Equals(186) && ficha_azul.Location.Y.Equals(130))
                {
                    ficha_azul.Top -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_azul.Location.X.Equals(201) && ficha_azul.Location.Y.Equals(130))
                {
                    ficha_azul.Top -= 45;
                    ficha_azul.Left -= 15;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_azul.Location.X.Equals(276) && ficha_azul.Location.Y.Equals(115))
                {
                    ficha_azul.Top -= 45;
                    ficha_azul.Left += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(190))
                {
                    ficha_azul.Top -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(220))
                {
                    ficha_azul.Top -= 30;
                    ficha_azul.Left -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_azul.Location.X.Equals(201) && ficha_azul.Location.Y.Equals(310))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    string pregunta = "¿Por que puerta de arriba quieres salir? ¿La de la izquierda?";
                    result = MessageBox.Show(pregunta, "Escoger puerta", buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        ficha_azul.Top -= 45;
                        ficha_azul.Left -= 45;
                    }
                    else
                    {
                        ficha_azul.Top -= 45;
                        ficha_azul.Left += 30;
                    }
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_azul.Location.X.Equals(336) && ficha_azul.Location.Y.Equals(325))
                {
                    ficha_azul.Top -= 45;
                    ficha_azul.Left -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_azul.Location.X.Equals(321) && ficha_azul.Location.Y.Equals(205))
                {
                    ficha_azul.Top -= 60;
                    ficha_azul.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else
                {
                    int r = 0;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(85))
                            r++;
                    if (ficha_azul.Location.X.Equals(366) && ficha_azul.Location.Y.Equals(130))
                        r++;
                    for (int i = 156; i <= 171; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(130))
                            r++;
                    if (ficha_azul.Location.X.Equals(261) && ficha_azul.Location.Y.Equals(25))
                        r++;
                    for (int i = 216; i <= 231; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(130))
                            r++;
                    for (int i = 291; i <= 351; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(115))
                            r++;
                    for (int i = 36; i <= 51; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(190))
                            r++;
                    if (ficha_azul.Location.X.Equals(21) && ficha_azul.Location.Y.Equals(100))
                        r++;
                    if (ficha_azul.Location.X.Equals(21) && ficha_azul.Location.Y.Equals(295))
                        r++;
                    for (int i = 81; i <= 96; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(190))
                            r++;
                    if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(40))
                        r++;
                    if (ficha_azul.Location.X.Equals(186) && ficha_azul.Location.Y.Equals(85))
                        r++;
                    for (int i = 156; i <= 216; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(250))
                            r++;
                    if (ficha_azul.Location.X.Equals(321) && ficha_azul.Location.Y.Equals(70))
                        r++;
                    if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(145))
                        r++;
                    for (int i = 261; i <= 291; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(250))
                            r++;
                    if (ficha_azul.Location.X.Equals(66) && ficha_azul.Location.Y.Equals(340))
                        r++;
                    if (ficha_azul.Location.X.Equals(126) && ficha_azul.Location.Y.Equals(25))
                        r++;
                    if (ficha_azul.Location.X.Equals(141) && ficha_azul.Location.Y.Equals(40))
                        r++;
                    if (ficha_azul.Location.X.Equals(261) && ficha_azul.Location.Y.Equals(40))
                        r++;
                    if (ficha_azul.Location.X.Equals(246) && ficha_azul.Location.Y.Equals(40))
                        r++;
                    if (ficha_azul.Location.X.Equals(111) && ficha_azul.Location.Y.Equals(175))
                        r++;
                    if (ficha_azul.Location.X.Equals(366) && ficha_azul.Location.Y.Equals(280))
                        r++;
                    for (int i = 306; i <= 351; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(265))
                            r++;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(280))
                            r++;
                    for (int i = 141; i <= 156; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(370))
                            r++;
                    for (int i = 231; i <= 246; i = i + 15)
                        if (ficha_azul.Location.X.Equals(i) && ficha_azul.Location.Y.Equals(370))
                            r++;
                    if (r == 0)
                    {
                        ficha_azul.Top -= 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                lax.Text = Convert.ToString(ficha_azul.Location.X);
                lay.Text = Convert.ToString(ficha_azul.Location.Y);
            }
            else if (num == 3 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_verde.Location.X.Equals(111) && ficha_verde.Location.Y.Equals(85))
                {
                    ficha_verde.Top -= 45;
                    ficha_verde.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }

                else if (ficha_verde.Location.X.Equals(186) && ficha_verde.Location.Y.Equals(130))
                {
                    ficha_verde.Top -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_verde.Location.X.Equals(201) && ficha_verde.Location.Y.Equals(130))
                {
                    ficha_verde.Top -= 45;
                    ficha_verde.Left -= 15;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_verde.Location.X.Equals(276) && ficha_verde.Location.Y.Equals(115))
                {
                    ficha_verde.Top -= 45;
                    ficha_verde.Left += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(190))
                {
                    ficha_verde.Top -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(220))
                {
                    ficha_verde.Top -= 30;
                    ficha_verde.Left -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_verde.Location.X.Equals(201) && ficha_verde.Location.Y.Equals(310))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    string pregunta = "¿Por que puerta de arriba quieres salir? ¿La de la izquierda?";
                    result = MessageBox.Show(pregunta, "Escoger puerta", buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        ficha_verde.Top -= 45;
                        ficha_verde.Left -= 45;
                    }
                    else
                    {
                        ficha_verde.Top -= 45;
                        ficha_verde.Left += 30;
                    }
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_verde.Location.X.Equals(336) && ficha_verde.Location.Y.Equals(325))
                {
                    ficha_verde.Top -= 45;
                    ficha_verde.Left -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_verde.Location.X.Equals(321) && ficha_verde.Location.Y.Equals(205))
                {
                    ficha_verde.Top -= 60;
                    ficha_verde.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else
                {
                    int r = 0;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(85))
                            r++;
                    if (ficha_verde.Location.X.Equals(366) && ficha_verde.Location.Y.Equals(130))
                        r++;
                    for (int i = 156; i <= 171; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(130))
                            r++;
                    if (ficha_verde.Location.X.Equals(261) && ficha_verde.Location.Y.Equals(25))
                        r++;
                    for (int i = 216; i <= 231; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(130))
                            r++;
                    for (int i = 291; i <= 351; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(115))
                            r++;
                    for (int i = 36; i <= 51; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(190))
                            r++;
                    if (ficha_verde.Location.X.Equals(21) && ficha_verde.Location.Y.Equals(100))
                        r++;
                    if (ficha_verde.Location.X.Equals(21) && ficha_verde.Location.Y.Equals(295))
                        r++;
                    for (int i = 81; i <= 96; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(190))
                            r++;
                    if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(40))
                        r++;
                    if (ficha_verde.Location.X.Equals(186) && ficha_verde.Location.Y.Equals(85))
                        r++;
                    for (int i = 156; i <= 216; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(250))
                            r++;
                    if (ficha_verde.Location.X.Equals(321) && ficha_verde.Location.Y.Equals(70))
                        r++;
                    if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(145))
                        r++;
                    for (int i = 261; i <= 291; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(250))
                            r++;
                    if (ficha_verde.Location.X.Equals(66) && ficha_verde.Location.Y.Equals(340))
                        r++;
                    if (ficha_verde.Location.X.Equals(126) && ficha_verde.Location.Y.Equals(25))
                        r++;
                    if (ficha_verde.Location.X.Equals(141) && ficha_verde.Location.Y.Equals(40))
                        r++;
                    if (ficha_verde.Location.X.Equals(261) && ficha_verde.Location.Y.Equals(40))
                        r++;
                    if (ficha_verde.Location.X.Equals(246) && ficha_verde.Location.Y.Equals(40))
                        r++;
                    if (ficha_verde.Location.X.Equals(111) && ficha_verde.Location.Y.Equals(175))
                        r++;
                    if (ficha_verde.Location.X.Equals(366) && ficha_verde.Location.Y.Equals(280))
                        r++;
                    for (int i = 306; i <= 351; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(265))
                            r++;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(280))
                            r++;
                    for (int i = 141; i <= 156; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(370))
                            r++;
                    for (int i = 231; i <= 246; i = i + 15)
                        if (ficha_verde.Location.X.Equals(i) && ficha_verde.Location.Y.Equals(370))
                            r++;
                    if (r == 0)
                    {
                        ficha_verde.Top -= 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                lvx.Text = Convert.ToString(ficha_verde.Location.X);
                lvy.Text = Convert.ToString(ficha_verde.Location.Y);
            }
            else if (num == 2 && Convert.ToInt32(movimientos.Text) > 0)
            {
                if (ficha_marron.Location.X.Equals(111) && ficha_marron.Location.Y.Equals(85))
                {
                    ficha_marron.Top -= 45;
                    ficha_marron.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }

                else if (ficha_marron.Location.X.Equals(186) && ficha_marron.Location.Y.Equals(130))
                {
                    ficha_marron.Top -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_marron.Location.X.Equals(201) && ficha_marron.Location.Y.Equals(130))
                {
                    ficha_marron.Top -= 45;
                    ficha_marron.Left -= 15;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_marron.Location.X.Equals(276) && ficha_marron.Location.Y.Equals(115))
                {
                    ficha_marron.Top -= 45;
                    ficha_marron.Left += 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(190))
                {
                    ficha_marron.Top -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - Convert.ToInt16(movimientos.Text));
                }
                else if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(220))
                {
                    ficha_marron.Top -= 30;
                    ficha_marron.Left -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_marron.Location.X.Equals(201) && ficha_marron.Location.Y.Equals(310))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    string pregunta = "¿Por que puerta de arriba quieres salir? ¿La de la izquierda?";
                    result = MessageBox.Show(pregunta, "Escoger puerta", buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        ficha_marron.Top -= 45;
                        ficha_marron.Left -= 45;
                    }
                    else
                    {
                        ficha_marron.Top -= 45;
                        ficha_marron.Left += 30;
                    }
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_marron.Location.X.Equals(336) && ficha_marron.Location.Y.Equals(325))
                {
                    ficha_marron.Top -= 45;
                    ficha_marron.Left -= 30;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else if (ficha_marron.Location.X.Equals(321) && ficha_marron.Location.Y.Equals(205))
                {
                    ficha_marron.Top -= 60;
                    ficha_marron.Left -= 45;
                    movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                }
                else
                {
                    int r = 0;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(85))
                            r++;
                    if (ficha_marron.Location.X.Equals(366) && ficha_marron.Location.Y.Equals(130))
                        r++;
                    for (int i = 156; i <= 171; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(130))
                            r++;
                    if (ficha_marron.Location.X.Equals(261) && ficha_marron.Location.Y.Equals(25))
                        r++;
                    for (int i = 216; i <= 231; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(130))
                            r++;
                    for (int i = 291; i <= 351; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(115))
                            r++;
                    for (int i = 36; i <= 51; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(190))
                            r++;
                    if (ficha_marron.Location.X.Equals(21) && ficha_marron.Location.Y.Equals(100))
                        r++;
                    if (ficha_marron.Location.X.Equals(21) && ficha_marron.Location.Y.Equals(295))
                        r++;
                    for (int i = 81; i <= 96; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(190))
                            r++;
                    if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(40))
                        r++;
                    if (ficha_marron.Location.X.Equals(186) && ficha_marron.Location.Y.Equals(85))
                        r++;
                    for (int i = 156; i <= 216; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(250))
                            r++;
                    if (ficha_marron.Location.X.Equals(321) && ficha_marron.Location.Y.Equals(70))
                        r++;
                    if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(145))
                        r++;
                    for (int i = 261; i <= 291; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(250))
                            r++;
                    if (ficha_marron.Location.X.Equals(66) && ficha_marron.Location.Y.Equals(340))
                        r++;
                    if (ficha_marron.Location.X.Equals(126) && ficha_marron.Location.Y.Equals(25))
                        r++;
                    if (ficha_marron.Location.X.Equals(141) && ficha_marron.Location.Y.Equals(40))
                        r++;
                    if (ficha_marron.Location.X.Equals(261) && ficha_marron.Location.Y.Equals(40))
                        r++;
                    if (ficha_marron.Location.X.Equals(246) && ficha_marron.Location.Y.Equals(40))
                        r++;
                    if (ficha_marron.Location.X.Equals(111) && ficha_marron.Location.Y.Equals(175))
                        r++;
                    if (ficha_marron.Location.X.Equals(366) && ficha_marron.Location.Y.Equals(280))
                        r++;
                    for (int i = 306; i <= 351; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(265))
                            r++;
                    for (int i = 36; i <= 96; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(280))
                            r++;
                    for (int i = 141; i <= 156; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(370))
                            r++;
                    for (int i = 231; i <= 246; i = i + 15)
                        if (ficha_marron.Location.X.Equals(i) && ficha_marron.Location.Y.Equals(370))
                            r++;
                    if (r == 0)
                    {
                        ficha_marron.Top -= 15;
                        movimientos.Text = Convert.ToString(Convert.ToInt16(movimientos.Text) - 1);
                    }
                    else
                        MessageBox.Show("Movimiento no válido!");
                }
                lmx.Text = Convert.ToString(ficha_marron.Location.X);
                lmy.Text = Convert.ToString(ficha_marron.Location.Y);
            }
        }
        public string actualizar()
        {
            string posiciones = ldx.Text + "," + ldy.Text + "," + lgx.Text + "," + lgy.Text + "," + llx.Text + "," + lly.Text + "," + lax.Text + "," + lay.Text + "," + lvx.Text + "," + lvy.Text + "," + lmx.Text + "," + lmy.Text;
            return posiciones;
        }
        public void mover(int ldx, int ldy, int lgx, int lgy, int llx, int lly, int lax, int lay, int lvx, int lvy, int lmx, int lmy)
        {
            ficha_dorada.Location.X.Equals(ldx);
            ficha_dorada.Location.Y.Equals(ldy);
            ficha_lila.Location.X.Equals(llx);
            ficha_lila.Location.Y.Equals(lly);
            ficha_granate.Location.X.Equals(lgx);
            ficha_granate.Location.Y.Equals(lgy);
            ficha_azul.Location.X.Equals(lax);
            ficha_azul.Location.Y.Equals(lay);
            ficha_verde.Location.X.Equals(lvx);
            ficha_verde.Location.Y.Equals(lvy);
            ficha_marron.Location.X.Equals(lmx);
            ficha_marron.Location.Y.Equals(lmy);
        }
        public void SetJugadores(string usuario,List<string>jugadores)
        {
            this.usuario = usuario;
            this.jugadores = jugadores;
        }
        public void SetPregunta(string pregunta)
        {
            this.pregunta = pregunta;
        }
        public string GetPregunta()
        {
            int i = 0;
            bool encontrado = false;
            while ((i < jugadores.Count) && (!encontrado))
            {
                if (jugadores.ElementAt(i) == usuario)
                    encontrado = true;
                else
                    i++;
            }
            return i + "/" + this.pregunta;
        }
        private void preguntar_Click(object sender, EventArgs e)
        {
            Questionario questionario = new Questionario();
            questionario.SetJugadores(usuario,jugadores);
            questionario.ShowDialog();
            SetPregunta(questionario.GetPregunta());
            SetRespuesta(true);
        }
        public void Setficha(int ficha)
        {
            if (ficha == 1)
            {
                personaje1.Image = Properties.Resources.clue___colonel_mustrad___fan_art_by_virtualbarata_d5np43m;
                vficha.Text = "1";
            }
            else if (ficha == 2)
            {
                personaje1.Image = Properties.Resources.clue___professor_plum___fan_art_by_virtualbarata_d5o2sfm;
                vficha.Text = "2";
            }
            else if (ficha == 3)
            {
                personaje1.Image = Properties.Resources.clue___mr__green___fan_art_by_virtualbarata_d5oa5i0;
                vficha.Text = "3";
            }
            else if (ficha == 4)
            {
                personaje1.Image = Properties.Resources.clue___mrs__peacock___fan_art_by_virtualbarata_d5oa5fu;
                vficha.Text = "4";
            }
            else if (ficha == 5)
            {
                personaje1.Image = Properties.Resources.clue___miss_scarlett___fan_art_by_virtualbarata_d5nh972;
                vficha.Text = "5";
            }
            else if (ficha == 6)
            {
                personaje1.Image = Properties.Resources.clue___mrs__white___fan_art_by_virtualbarata_d5nu3du;
                vficha.Text = "6";
            }
        }
        public void SetCartas(string cartas)
        {
            string[] Vcartas = cartas.Split(',');
                for (int i =0; i < (18/jugadores.Count); i++)
                {
                    if (Convert.ToInt32(Vcartas[i]) < 6)
                        ListaPersonajes.SetItemChecked(Convert.ToInt32(Vcartas[i]), true);
                    else if ((Convert.ToInt32(Vcartas[i])>5)&&(Convert.ToInt32(Vcartas[i])<12))
                        ListaArmas.SetItemChecked(Convert.ToInt32(Vcartas[i])-6, true);
                    else
                        ListaHabitaciones.SetItemChecked(Convert.ToInt32(Vcartas[i])-13, true);
                }

        }
        public void SetTurno(int turnoactual,string comprobarturno)
        {
            this.turnoactual = turnoactual;
            bool esmiturno=false;
                if (jugadores.ElementAt(turnoactual) == comprobarturno)
                    esmiturno = false; 
            if (esmiturno == false)
            {
                TirarDados.Enabled = false;
                mover_abajo.Enabled = false;
                mover_arriba.Enabled = false;
                mover_derecha.Enabled = false;
                mover_izquierda.Enabled = false;
                preguntar.Enabled = false;
                acusacionfinal.Enabled = false;
                pasarturno.Enabled = false;
            }
            else
            {
                TirarDados.Enabled = true;
                mover_abajo.Enabled = true;
                mover_arriba.Enabled = true;
                mover_derecha.Enabled = true;
                mover_izquierda.Enabled = true;
                preguntar.Enabled = true;
                acusacionfinal.Enabled = true;
                pasarturno.Enabled = true;
            }
        }
        public int GetTurno()
        {
            return turnoactual;
        }

        private void InterfazCluedo_Load(object sender, EventArgs e)
        {
            turno.Text = jugadores.ElementAt(0);
            if (jugadores.ElementAt(0) != usuario)
            {
                TirarDados.Enabled = false;
                mover_abajo.Enabled = false;
                mover_arriba.Enabled = false;
                mover_derecha.Enabled = false;
                mover_izquierda.Enabled = false;
                preguntar.Enabled = false;
                acusacionfinal.Enabled = false;
                pasarturno.Enabled = false;                
            }
        }
        public void SetFinTurno(bool finturno)
        { 
            this.finturno=finturno;
        }
        public bool GetFinTurno()
        {
            return finturno;
        }
        public void SetRespuesta(bool respuesta)
        {
            this.respuesta = respuesta;
        }
        public bool GetRespuesta()
        {
            return respuesta;
        }
        public void SetAcusacionFinal(bool acusacion)
        {
            this.acusacion = acusacion;
        }
        public bool GetAcusacionFinal()
        {
            return acusacion;
        }
        private void pasarturno_Click(object sender, EventArgs e)
        {
            SetFinTurno(true);
        }
        private void acusacionfinal_Click(object sender, EventArgs e)
        {
            Questionario questionario = new Questionario();
            questionario.SetJugadores(usuario, jugadores);
            questionario.ShowDialog();
            SetPregunta(questionario.GetPregunta());
            SetAcusacionFinal(true);
        }

    }
}
