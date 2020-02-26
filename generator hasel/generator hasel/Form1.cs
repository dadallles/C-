using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace generator_hasel
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hasla.Text = "GENERATOR HASEL";
        }

        private void generuj_Click(object sender, EventArgs e)
        {
            int dlugosc = (int)(ile_znakow.Value);
            int ilosc = (int)(ile_hasel.Value);
            string[] lista_hasel = new string[ilosc];

            bool[] tab = new bool[6];
            tab[0] = male.Checked;
            tab[1] = duze.Checked;
            tab[2] = cyfry.Checked;
            tab[3] = interp.Checked;
            tab[4] = specjalne.Checked;
            tab[5] = bez_podobnych.Checked;

            if(tab[0] || tab[1] || tab[2] || tab[3] || tab[4] || tab[5])
            {
                haslo p = new haslo(dlugosc, tab);

                if (ilosc == 1)
                {
                    hasla.Text = p.get_pass();
                }
                else
                {
                    hasla.Clear();
                    for (int i=0; i<ilosc; i++)
                    {
                        hasla.AppendText(p.get_pass() + "\r\n");
                        System.Threading.Thread.Sleep(1);
                    }
                }
            }
        }
    }

}
