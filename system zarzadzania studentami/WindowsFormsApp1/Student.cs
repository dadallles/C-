using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Student
    {
        private List<Ocena> oceny = new List<Ocena>();

        private string imie = "";
        private string nazwisko = "";
        private Int32 nr = 0;
        private string kierunek = "";

        public string Imie
        {
            get { return imie; }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
        }

        public Int32 Nr
        {
            get { return nr; }
        }

        public string Kierunek
        {
            get { return kierunek; }
        }

        public int liczbaocen()
        {
            return oceny.Count;
        }

        public List<Ocena> Oceny
        {
            get { return oceny; }
        }

        public Student(string imie_, string nazwisko_, Int32 nr_, string kierunek_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            nr = nr_;
            kierunek = kierunek_;
        }

        public void DodajOcene(Ocena o)
        {
            oceny.Add(o);
        }

        


    }
}
