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
    public partial class DodajOcene : Form
    {
        private Student student = null;

        public DodajOcene()
        {
            InitializeComponent();
        }

        public DodajOcene(Student s)
        {
            InitializeComponent();
            student = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (przedmiot.Text == "" || data.Text == "" || Convert.ToDouble(wartosc.Text) < 2 || Convert.ToDouble(wartosc.Text) > 5)
            {
                MessageBox.Show("Bledne / brak danych");
            }
            else
            {
                try
                {
                    Ocena o = new Ocena(przedmiot.Text, data.Text, Convert.ToDouble(wartosc.Text));
                    student.DodajOcene(o);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Blad: " + ex.Message);
                }
            }
        }
    }
}
