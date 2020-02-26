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
    public partial class Main : Form
    {
        private List<Student> studenci = new List<Student>();

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajStudenta addStudentForm = new DodajStudenta(this);
            DialogResult dr = addStudentForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Dodano studenta");
            }
        }

        public void DodajStudenta(Student s)
        {
            studenci.Add(s);
        }

        public void DodajStudentaDoDataGridView(Student s)
        {
            dataGridView1.Rows.Add(s.Imie, s.Nazwisko, s.Nr, s.Kierunek, s.liczbaocen());
        }

        public void AktualizujLiczbeOcen(int x)
        {
            dataGridView1.SelectedRows[0].Cells["liczba_ocen"].Value = x;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0; i<studenci.Count; ++i)
            {
                if (studenci[i].Nr == Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["nr"].Value))
                {
                    DodajOcene addOcenaForm = new DodajOcene(studenci[i]);
                    DialogResult dr = addOcenaForm.ShowDialog();
                    AktualizujLiczbeOcen(studenci[i].liczbaocen());
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("Dodano ocene");
                    }
                    break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < studenci.Count; ++i)
            {
                if (studenci[i].Nr == Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["nr"].Value))
                {
                    WyswietlOceny addWyswietlOceny = new WyswietlOceny(studenci[i]);
                    DialogResult dr = addWyswietlOceny.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("Dodano ocene");
                    }
                    break;
                }
            }
        }
    }
}
