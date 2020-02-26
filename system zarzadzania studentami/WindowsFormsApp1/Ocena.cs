using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Ocena
    {
        private string przedmiot = "";
        private string data = "";
        private double wartosc = 0;

        public string Przedmiot
        {
            get { return przedmiot; }
        }

        public string Data
        {
            get { return data; }
        }

        public double Wartosc
        {
            get { return wartosc; }
        }

        public Ocena(string przedmiot_, string data_, double wartosc_)
        {
            przedmiot = przedmiot_;
            data = data_;
            wartosc = wartosc_;
        }


    }
}
