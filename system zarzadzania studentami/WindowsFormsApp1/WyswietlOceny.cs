using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WyswietlOceny : Form
    {

        public WyswietlOceny()
        {
            InitializeComponent();
        }

        public WyswietlOceny(Student s)
        {
            InitializeComponent();
            labelStudent.Text = s.Imie + " " + s.Nazwisko + " " + s.Nr + " " + s.Kierunek;
            for(int i=0; i<s.liczbaocen(); ++i)
            {
                wys_dataGridView.Rows.Add(s.Oceny[i].Przedmiot, s.Oceny[i].Data, s.Oceny[i].Wartosc);
            }
        }

    }
}
