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
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        const string temp = "Blad";

        public class liczenie
        {
            public double a = 0;
            public double b = 0;
            public char działanie;

            public double licz()
            {
                if (działanie == '+')
                    return a + b;
                if (działanie == '-')
                    return a - b;
                if (działanie == '*')
                    return a * b;
                if (działanie == '/')
                {
                    if (b != 0)
                        return a / b;
                    else
                    {
                        MessageBox.Show(temp);
                        return 0;
                    }
                }
                else
                    return 0;
            }
        }

        liczenie licz = new liczenie();

        bool gdzieWpisać = true;
        bool czyWyczyścićPasekWyniku = false;
        bool czyscicrownasie = false;

        //cyfry
        private void button1_Click(object sender, EventArgs e)
        {
            if (czyWyczyścićPasekWyniku)
            {
                textBox1.Text = (sender as Button).Text;
                textBox2.Text += Convert.ToString(1);
            }
            else
            {
                textBox1.Text += Convert.ToString(1);
                textBox2.Text += Convert.ToString(1);
            }
            czyWyczyścićPasekWyniku = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (czyWyczyścićPasekWyniku)
            {
                textBox1.Text = (sender as Button).Text;
                textBox2.Text += Convert.ToString(2);
            }
            else
            {
                textBox1.Text += Convert.ToString(2);
                textBox2.Text += Convert.ToString(2);
            }
            czyWyczyścićPasekWyniku = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (czyWyczyścićPasekWyniku)
            {
                textBox1.Text = (sender as Button).Text;
                textBox2.Text += Convert.ToString(3);
            }
            else
            {
                textBox1.Text += Convert.ToString(3);
                textBox2.Text += Convert.ToString(3);
            }
            czyWyczyścićPasekWyniku = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (czyWyczyścićPasekWyniku)
            {
                textBox1.Text = (sender as Button).Text;
                textBox2.Text += Convert.ToString(4);
            }
            else
            {
                textBox1.Text += Convert.ToString(4);
                textBox2.Text += Convert.ToString(4);
            }
            czyWyczyścićPasekWyniku = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (czyWyczyścićPasekWyniku)
            {
                textBox1.Text = (sender as Button).Text;
                textBox2.Text += Convert.ToString(5);
            }
            else
            {
                textBox1.Text += Convert.ToString(5);
                textBox2.Text += Convert.ToString(5);
            }
            czyWyczyścićPasekWyniku = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (czyWyczyścićPasekWyniku)
            {
                textBox1.Text = (sender as Button).Text;
                textBox2.Text += Convert.ToString(6);
            }
            else
            {
                textBox1.Text += Convert.ToString(6);
                textBox2.Text += Convert.ToString(6);
            }
            czyWyczyścićPasekWyniku = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (czyWyczyścićPasekWyniku)
            {
                textBox1.Text = (sender as Button).Text;
                textBox2.Text += Convert.ToString(7);
            }
            else
            {
                textBox1.Text += Convert.ToString(7);
                textBox2.Text += Convert.ToString(7);
            }
            czyWyczyścićPasekWyniku = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (czyWyczyścićPasekWyniku)
            {
                textBox1.Text = (sender as Button).Text;
                textBox2.Text += Convert.ToString(8);
            }
            else
            {
                textBox1.Text += Convert.ToString(8);
                textBox2.Text += Convert.ToString(8);
            }
            czyWyczyścićPasekWyniku = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (czyWyczyścićPasekWyniku)
            {
                textBox1.Text = (sender as Button).Text;
                textBox2.Text += Convert.ToString(9);
            }
            else
            {
                textBox1.Text += Convert.ToString(9);
                textBox2.Text += Convert.ToString(9);
            }
            czyWyczyścićPasekWyniku = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (czyWyczyścićPasekWyniku)
            {
                textBox1.Text = (sender as Button).Text;
                textBox2.Text += Convert.ToString(0);
            }
            else
            {
                textBox1.Text += Convert.ToString(0);
                textBox2.Text += Convert.ToString(0);
            }
            czyWyczyścićPasekWyniku = false;
        }

        //przecinek
        private void button15_Click(object sender, EventArgs e)
        {
            if (czyWyczyścićPasekWyniku)
            {
                textBox1.Text = "0,";
                textBox2.Text += "0,";
            }
            else
            {
                textBox1.Text += ",";
                textBox2.Text += ",";
            }
            czyWyczyścićPasekWyniku = false;

        }

        //dzialania
        private void button10_Click(object sender, EventArgs e)
        {
            if (czyscicrownasie)
            {
                string temp = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.Text = temp + "+";
                czyscicrownasie = false;
            }
            else
                textBox2.Text += "+";

            licz.działanie = '+';
            licz.a = Convert.ToDouble(textBox1.Text);
            czyWyczyścićPasekWyniku = true;
            gdzieWpisać = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (czyscicrownasie)
            {
                string temp = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.Text = temp + "-";
                czyscicrownasie = false;
            }
            else
                textBox2.Text += "-";

            licz.działanie = '-';
            licz.a = Convert.ToDouble(textBox1.Text);
            czyWyczyścićPasekWyniku = true;
            gdzieWpisać = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (czyscicrownasie)
            {
                string temp = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.Text = temp + "*";
                czyscicrownasie = false;
            }
            else
                textBox2.Text += "*";

            licz.działanie = '*';
            licz.a = Convert.ToDouble(textBox1.Text);
            czyWyczyścićPasekWyniku = true;
            gdzieWpisać = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (czyscicrownasie)
            {
                string temp = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.Text = temp + "/";
                czyscicrownasie = false;
            }
            else
                textBox2.Text += "/";

            licz.działanie = '/';
            licz.a = Convert.ToDouble(textBox1.Text);
            czyWyczyścićPasekWyniku = true;
            gdzieWpisać = false;
        }

        //=
        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdzieWpisać)
                    licz.a = Convert.ToDouble(textBox1.Text);
                else
                {
                    if(!czyscicrownasie)
                        textBox2.Text += "=";

                    if(!czyWyczyścićPasekWyniku)
                        licz.b = Convert.ToDouble(textBox1.Text);

                    textBox1.Text = Convert.ToString(licz.licz());
                    czyscicrownasie = true;
                }
            }
            catch (FormatException err)
            {
                if (textBox1.Text != "")
                    MessageBox.Show(temp);
            }
        }

        //czyszczenie
        private void button11_Click(object sender, EventArgs e)
        {
            licz.a = licz.b = 0;
            licz.działanie = ' ';
            textBox1.Text = "";
            textBox2.Text = "";
            czyWyczyścićPasekWyniku = false;
            gdzieWpisać = true;
        }
   
    }
}
