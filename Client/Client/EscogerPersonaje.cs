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
    public partial class EscogerPersonaje : Form
    {
        int personaje;
        public EscogerPersonaje()
        {
            InitializeComponent();
        }

        private void blanco_Click(object sender, EventArgs e)
        {
            SetPersonaje(6);
            Close();
        }

        private void rubio_Click(object sender, EventArgs e)
        {
            SetPersonaje(1);
            Close();
        }

        private void escarlata_Click(object sender, EventArgs e)
        {
            SetPersonaje(5);
            Close();
        }

        private void prado_Click(object sender, EventArgs e)
        {
            SetPersonaje(3);
            Close();
        }

        private void celeste_Click(object sender, EventArgs e)
        {
            SetPersonaje(4);
            Close();
        }

        private void mora_Click(object sender, EventArgs e)
        {
            SetPersonaje(2);
            Close();
        }

        public void SetPersonaje(int personaje)
        {
            this.personaje = personaje;
        }
        public int GetPersonaje()
        {
            return this.personaje;
        }
        public void Bloqueos(int b1,int b2,int b3,int b4,int b5)
        {
            if (b1 != 0)
            {
                if (b1 == 1)
                {
                    rubio.Enabled = false;
                    coronelrubio.BackColor = Color.Red;
                }
                else if(b1==2)
                {
                    mora.Enabled = false;
                    profesormora.BackColor = Color.Red;
                }
                else if (b1 == 3)
                {
                    prado.Enabled = false;
                    padreprado.BackColor = Color.Red;
                }
                else if (b1 == 4)
                {
                    celeste.Enabled = false;
                    sraceleste.BackColor = Color.Red;
                }
                else if (b1 == 5)
                {
                    escarlata.Enabled = false;
                    sraescarlata.BackColor = Color.Red;
                }
                else if (b1 == 6)
                {
                    blanco.Enabled = false;
                    srablanco.BackColor = Color.Red;
                }
            }
            if (b2 != 0)
            {
                if (b2 == 1)
                {
                    rubio.Enabled = false;
                    coronelrubio.BackColor = Color.Red;
                }
                else if (b2 == 2)
                {
                    mora.Enabled = false;
                    profesormora.BackColor = Color.Red;
                }
                else if (b2 == 3)
                {
                    prado.Enabled = false;
                    padreprado.BackColor = Color.Red;
                }
                else if (b2 == 4)
                {
                    celeste.Enabled = false;
                    sraceleste.BackColor = Color.Red;
                }
                else if (b2 == 5)
                {
                    escarlata.Enabled = false;
                    sraescarlata.BackColor = Color.Red;
                }
                else if (b2 == 6)
                {
                    blanco.Enabled = false;
                    srablanco.BackColor = Color.Red;
                }
            }
            if (b3 != 0)
            {
                if (b3 == 1)
                {
                    rubio.Enabled = false;
                    coronelrubio.BackColor = Color.Red;
                }
                else if (b3 == 2)
                {
                    mora.Enabled = false;
                    profesormora.BackColor = Color.Red;
                }
                else if (b3 == 3)
                {
                    prado.Enabled = false;
                    padreprado.BackColor = Color.Red;
                }
                else if (b3 == 4)
                {
                    celeste.Enabled = false;
                    sraceleste.BackColor = Color.Red;
                }
                else if (b3 == 5)
                {
                    escarlata.Enabled = false;
                    sraescarlata.BackColor = Color.Red;
                }
                else if (b3 == 6)
                {
                    blanco.Enabled = false;
                    srablanco.BackColor = Color.Red;
                }
            }
            if (b4 != 0)
            {
                if (b4 == 1)
                {
                    rubio.Enabled = false;
                    coronelrubio.BackColor = Color.Red;
                }
                else if (b4 == 2)
                {
                    mora.Enabled = false;
                    profesormora.BackColor = Color.Red;
                }
                else if (b4 == 3)
                {
                    prado.Enabled = false;
                    padreprado.BackColor = Color.Red;
                }
                else if (b4 == 4)
                {
                    celeste.Enabled = false;
                    sraceleste.BackColor = Color.Red;
                }
                else if (b4 == 5)
                {
                    escarlata.Enabled = false;
                    sraescarlata.BackColor = Color.Red;
                }
                else if (b4 == 6)
                {
                    blanco.Enabled = false;
                    srablanco.BackColor = Color.Red;
                }
            }
            if (b5 != 0)
            {
                if (b5 == 1)
                {
                    rubio.Enabled = false;
                    coronelrubio.BackColor = Color.Red;
                }
                else if (b5 == 2)
                {
                    mora.Enabled = false;
                    profesormora.BackColor = Color.Red;
                }
                else if (b5 == 3)
                {
                    prado.Enabled = false;
                    padreprado.BackColor = Color.Red;
                }
                else if (b5 == 4)
                {
                    celeste.Enabled = false;
                    sraceleste.BackColor = Color.Red;
                }
                else if (b5 == 5)
                {
                    escarlata.Enabled = false;
                    sraescarlata.BackColor = Color.Red;
                }
                else if (b5 == 6)
                {
                    blanco.Enabled = false;
                    srablanco.BackColor = Color.Red;
                }
            }
        }




    }
}
