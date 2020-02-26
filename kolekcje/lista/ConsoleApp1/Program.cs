using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Osoba
    {
        private string imie;
        private string nazwisko;

        public Osoba(string imie_, string nazwisko_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
        }

        public void WypiszInfo()
        {
            Console.WriteLine(nazwisko + "  " + imie);
        }
    }

    public class Element
    {
        private Osoba wartosc;
        private Element nastepnyElement;

        public Osoba Wartosc
        {
            get { return wartosc; }
            set { wartosc = value; }
        }

        public Element NastepnyElement
        {
            get { return nastepnyElement; }
            set { nastepnyElement = value; }
        }

        public Element(Osoba wartosc_)
        {
            wartosc = wartosc_;
            nastepnyElement = null;
        }

    }

    public class Lista
    {
        private Element pierwszyElement;
        private int liczbaElementow;

        public Lista()
        {
            pierwszyElement = null;
            liczbaElementow = 0;
        }

        public void Dodaj(Osoba os)
        {
            Element e = new Element(os);
            if (pierwszyElement == null)
            {
                pierwszyElement = e;
            }
            else
            {
                Element x = pierwszyElement;
                while (x.NastepnyElement != null)
                {
                    x = x.NastepnyElement;
                }
                x.NastepnyElement = e;
            }
            ++liczbaElementow;
        }

        public void Wstaw(int a, Osoba os)
        {
            if (a <= liczbaElementow)
            {
                Element e = new Element(os);
                Element x = pierwszyElement;
                if (a == 0)
                {
                    pierwszyElement = e;
                    pierwszyElement.NastepnyElement = x;
                }
                else if (a == liczbaElementow)
                {
                    while (x.NastepnyElement != null)
                    {
                        x = x.NastepnyElement;
                    }
                    x.NastepnyElement = e;
                }
                else
                {
                    Element y = pierwszyElement;
                    for (int i = 1; i < a; ++i)
                    {
                        pierwszyElement = pierwszyElement.NastepnyElement;
                    }
                    x = pierwszyElement.NastepnyElement;
                    pierwszyElement.NastepnyElement = e;
                    pierwszyElement.NastepnyElement.NastepnyElement = x;
                    pierwszyElement = y;
                }
                ++liczbaElementow;
            }
            else
            {
                Console.WriteLine("Za duzy indeks!");
            }
        }

        public Osoba Pobierz(int a)
        {
            if (a < liczbaElementow)
            {
                Element x = pierwszyElement;
                Element y = pierwszyElement;
                for (int i = 0; i < a; ++i)
                {
                    if(a > 0 && i < (a - 1))
                    {
                        pierwszyElement = pierwszyElement.NastepnyElement;
                    }
                    x = x.NastepnyElement;
                }
                if (a > 0)
                {
                    Element z = pierwszyElement.NastepnyElement;
                    pierwszyElement.NastepnyElement = z.NastepnyElement;
                    pierwszyElement = y;
                }
                else
                {
                    pierwszyElement = pierwszyElement.NastepnyElement;
                }
                --liczbaElementow;
                x.Wartosc.WypiszInfo();
                return x.Wartosc;
            }
            else
            {
                Console.WriteLine("Za duzy indeks!");
                return null;
            }
        }

        public void Wypisz()
        {
            Element x = pierwszyElement;
            for (int i=0; i<liczbaElementow; ++i)
            {
                x.Wartosc.WypiszInfo();
                x = x.NastepnyElement;
            }
            Console.WriteLine("");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Osoba o = new Osoba("Alicja", "Nowak");
            Osoba o2 = new Osoba("Karolina", "Kowalska");
            Osoba o3 = new Osoba("Michal", "Jablonski");
            Osoba o4 = new Osoba("Karol", "Wisniewski");

            Lista l = new Lista();

            l.Dodaj(o);
            l.Dodaj(o2);
            l.Dodaj(o3);
            l.Dodaj(o4);

            l.Wypisz();

            l.Pobierz(2);
            l.Pobierz(0);
            l.Pobierz(1);

            l.Wypisz();

            l.Wstaw(0, o3);
            l.Wstaw(1, o4);
            l.Wstaw(2, o);

            l.Wypisz();

            Console.ReadKey();
        }
    }
}
