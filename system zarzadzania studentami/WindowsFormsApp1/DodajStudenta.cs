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
    public partial class DodajStudenta : Form
    {
        private Main mainForm = null;

        public DodajStudenta()
        {
            InitializeComponent();
        }

        public DodajStudenta(Main m)
        {
            InitializeComponent();
            mainForm = m;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imie.Text == "" || nazwisko.Text == "" || nr.Text == "" || kierunek.Text == "")
            {
                MessageBox.Show("Uzupelnij dane");
            }
            else
            {
                try
                {
                    Student s = new Student(imie.Text, nazwisko.Text, Convert.ToInt32(nr.Text), kierunek.Text);
                    mainForm.DodajStudenta(s);
                    mainForm.DodajStudentaDoDataGridView(s);
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
