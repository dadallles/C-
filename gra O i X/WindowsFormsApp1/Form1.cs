using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string [,] tablica = new string[3,3] { {"", "", ""}, {"", "", ""}, {"", "", ""} };
        private bool spr = false;
        private int x = 0;
        private int y = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void Koniec(bool winner)
        {
            if (winner) wynik.Text = "Wygrales";
            else wynik.Text = "Przegrales";

            B00.Enabled = false;
            B01.Enabled = false;
            B02.Enabled = false;
            B10.Enabled = false;
            B11.Enabled = false;
            B12.Enabled = false;
            B20.Enabled = false;
            B21.Enabled = false;
            B22.Enabled = false;

            spr = true;
        }

        public void Sprawdzenie()
        {
            if (B00.Text == "X" && B01.Text == "X" && B02.Text == "X") Koniec(true);
            else if (B00.Text == "O" && B01.Text == "O" && B02.Text == "O") Koniec(false);

            else if (B10.Text == "X" && B11.Text == "X" && B12.Text == "X") Koniec(true);
            else if (B10.Text == "O" && B11.Text == "O" && B12.Text == "O") Koniec(false);

            else if (B20.Text == "X" && B21.Text == "X" && B22.Text == "X") Koniec(true);
            else if (B20.Text == "O" && B21.Text == "O" && B22.Text == "O") Koniec(false);

            else if (B00.Text == "X" && B10.Text == "X" && B20.Text == "X") Koniec(true);
            else if (B00.Text == "O" && B10.Text == "O" && B20.Text == "O") Koniec(false);

            else if (B01.Text == "X" && B11.Text == "X" && B21.Text == "X") Koniec(true);
            else if (B01.Text == "O" && B11.Text == "O" && B21.Text == "O") Koniec(false);

            else if (B02.Text == "X" && B12.Text == "X" && B22.Text == "X") Koniec(true);
            else if (B02.Text == "O" && B12.Text == "O" && B22.Text == "O") Koniec(false);

            else if (B02.Text == "X" && B11.Text == "X" && B20.Text == "X") Koniec(true);
            else if (B02.Text == "O" && B11.Text == "O" && B20.Text == "O") Koniec(false);

            else if (B00.Text == "X" && B11.Text == "X" && B22.Text == "X") Koniec(true);
            else if (B00.Text == "O" && B11.Text == "O" && B22.Text == "O") Koniec(false);
        }

        public void Gra()
        {
            Sprawdzenie();

            if (!spr)
            {
                if (B00.Text != "" && B01.Text != "" && B02.Text != "" &&
                B10.Text != "" && B11.Text != "" && B12.Text != "" &&
                B20.Text != "" && B21.Text != "" && B22.Text != "")
                {
                    wynik.Text = "Remis";
                    B00.Enabled = false;
                    B01.Enabled = false;
                    B02.Enabled = false;
                    B10.Enabled = false;
                    B11.Enabled = false;
                    B12.Enabled = false;
                    B20.Enabled = false;
                    B21.Enabled = false;
                    B22.Enabled = false;

                    spr = true;
                }
                else
                {
                    Random rand = new Random();
                    x = rand.Next() % 3;
                    y = rand.Next() % 3;
                    while (tablica[x, y] == "X" || tablica[x, y] == "O")
                    {
                        x = rand.Next() % 3;
                        y = rand.Next() % 3;
                    }

                    if (x == 0 && y == 0)
                    {
                        B00.Text = "O";
                        tablica[0, 0] = "O";
                    }
                    else if (x == 0 && y == 1)
                    {
                        B01.Text = "O";
                        tablica[0, 1] = "O";
                    }
                    else if (x == 0 && y == 2)
                    {
                        B02.Text = "O";
                        tablica[0, 2] = "O";
                    }
                    else if (x == 1 && y == 0)
                    {
                        B10.Text = "O";
                        tablica[1, 0] = "O";
                    }
                    else if (x == 1 && y == 1)
                    {
                        B11.Text = "O";
                        tablica[1, 1] = "O";
                    }
                    else if (x == 1 && y == 2)
                    {
                        B12.Text = "O";
                        tablica[1, 2] = "O";
                    }
                    else if (x == 2 && y == 0)
                    {
                        B20.Text = "O";
                        tablica[2, 0] = "O";
                    }
                    else if (x == 2 && y == 1)
                    {
                        B21.Text = "O";
                        tablica[2, 1] = "O";
                    }
                    else if (x == 2 && y == 2)
                    {
                        B22.Text = "O";
                        tablica[2, 2] = "O";
                    }

                    Sprawdzenie();
                }
            }

        }

        private void B00_Click(object sender, EventArgs e)
        {
            if (B00.Text == "")
            {
                B00.Text = "X";
                tablica[0, 0] = "X";
                Gra();
            }
        }

        private void B01_Click(object sender, EventArgs e)
        {
            if (B01.Text == "")
            {
                B01.Text = "X";
                tablica[0, 1] = "X";
                Gra();
            }
        }

        private void B02_Click(object sender, EventArgs e)
        {
            if (B02.Text == "")
            {
                B02.Text = "X";
                tablica[0, 2] = "X";
                Gra();
            }
        }

        private void B10_Click(object sender, EventArgs e)
        {
            if (B10.Text == "")
            {
                B10.Text = "X";
                tablica[1, 0] = "X";
                Gra();
            }
        }

        private void B11_Click(object sender, EventArgs e)
        {
            if (B11.Text == "")
            {
                B11.Text = "X";
                tablica[1, 1] = "X";
                Gra();
            }
        }

        private void B12_Click(object sender, EventArgs e)
        {
            if (B12.Text == "")
            {
                B12.Text = "X";
                tablica[1, 2] = "X";
                Gra();
            }
        }

        private void B20_Click(object sender, EventArgs e)
        {
            if (B20.Text == "")
            {
                B20.Text = "X";
                tablica[2, 0] = "X";
                Gra();
            }
        }

        private void B21_Click(object sender, EventArgs e)
        {
            if (B21.Text == "")
            {
                B21.Text = "X";
                tablica[2, 1] = "X";
                Gra();
            }
        }

        private void B22_Click(object sender, EventArgs e)
        {
            if (B22.Text == "")
            {
                B22.Text = "X";
                tablica[2, 2] = "X";
                Gra();
            }
        }

        private void nowa_gra_Click(object sender, EventArgs e)
        {
            B00.Enabled = true;
            B01.Enabled = true;
            B02.Enabled = true;
            B10.Enabled = true;
            B11.Enabled = true;
            B12.Enabled = true;
            B20.Enabled = true;
            B21.Enabled = true;
            B22.Enabled = true;

            B00.Text = "";
            B01.Text = "";
            B02.Text = "";
            B10.Text = "";
            B11.Text = "";
            B12.Text = "";
            B20.Text = "";
            B21.Text = "";
            B22.Text = "";

            tablica[0, 0] = "";
            tablica[0, 1] = "";
            tablica[0, 2] = "";
            tablica[1, 0] = "";
            tablica[1, 1] = "";
            tablica[1, 2] = "";
            tablica[2, 0] = "";
            tablica[2, 1] = "";
            tablica[2, 2] = "";

            spr = false;

            wynik.Text = "Nowa Gra";
        }
    }
}
