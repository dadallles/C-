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
        private Element poprzedniElement;

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

        public Element PoprzedniElement
        {
            get { return poprzedniElement; }
            set { poprzedniElement = value; }
        }

        public Element(Osoba wartosc_)
        {
            wartosc = wartosc_;
            nastepnyElement = null;
            poprzedniElement = null;
        }

    }

    public class Lista
    {
        private Element pierwszyElement;
        private Element ostatniElement;
        private int liczbaElementow;

        public int LiczbaElementow
        {
            get { return liczbaElementow; }
            set { liczbaElementow = value; }
        }

        public Lista()
        {
            pierwszyElement = null;
            ostatniElement = null;
            liczbaElementow = 0;
        }

        public void Dodaj(Osoba os)
        {
            Element e = new Element(os);
            if (pierwszyElement == null)
            {
                pierwszyElement = e;
                ostatniElement = pierwszyElement;
            }
            else if(pierwszyElement == ostatniElement)
            {
                pierwszyElement.NastepnyElement = e;
                pierwszyElement.NastepnyElement.PoprzedniElement = pierwszyElement;
                ostatniElement = pierwszyElement.NastepnyElement;
            }
            else
            {
                Element x = ostatniElement;
                e.PoprzedniElement = ostatniElement;
                ostatniElement.NastepnyElement = e;
                ostatniElement = ostatniElement.NastepnyElement;
            }
            ++liczbaElementow;
        }

        public void DodajzPrzodu(Osoba os)
        {
            Element e = new Element(os);
            if (pierwszyElement == null)
            {
                pierwszyElement = e;
                ostatniElement = pierwszyElement;
            }
            else
            {
                Element x = pierwszyElement;
                e.NastepnyElement = pierwszyElement;
                pierwszyElement = e;
                pierwszyElement.NastepnyElement.PoprzedniElement = pierwszyElement;
            }
            ++liczbaElementow;
        }

        public void WstawOdPrzodu(int a, Osoba os)
        {
                Element e = new Element(os);
                if (a == 0)
                {
                    Element x = pierwszyElement;
                    pierwszyElement = e;
                    pierwszyElement.NastepnyElement = x;
                    pierwszyElement.NastepnyElement.PoprzedniElement = pierwszyElement;
                }
                else if (a == liczbaElementow)
                {
                    e.PoprzedniElement = ostatniElement;
                    ostatniElement.NastepnyElement = e;
                    ostatniElement = e;
                }
                else
                {
                    Element y = pierwszyElement;
                    for (int i = 1; i < a; ++i)
                    {
                        pierwszyElement = pierwszyElement.NastepnyElement;
                    }
                    e.NastepnyElement = pierwszyElement.NastepnyElement;
                    e.PoprzedniElement = pierwszyElement.NastepnyElement.PoprzedniElement;
                    pierwszyElement.NastepnyElement = e;
                    pierwszyElement.NastepnyElement.NastepnyElement.PoprzedniElement = pierwszyElement.NastepnyElement;
                    pierwszyElement = y;
                }
        }

        //indeksowanie od tylu; [0] = ostatni element
        public void WstawOdTylu(int a, Osoba os)
        {
                Element e = new Element(os);
                if (a == 0)
                {
                    Element x = ostatniElement;
                    ostatniElement = e;
                    ostatniElement.PoprzedniElement = x;
                    ostatniElement.PoprzedniElement.NastepnyElement = ostatniElement;
                }
                else if (a == liczbaElementow)
                {
                    e.NastepnyElement = pierwszyElement;
                    pierwszyElement.PoprzedniElement = e;
                    pierwszyElement = e;
                }
                else
                {
                    Element y = ostatniElement;
                    for (int i = 1; i < a; ++i)
                    {
                        ostatniElement = ostatniElement.PoprzedniElement;
                    }
                    e.PoprzedniElement = ostatniElement.PoprzedniElement;
                    e.NastepnyElement = ostatniElement.PoprzedniElement.NastepnyElement;
                    ostatniElement.PoprzedniElement = e;
                    ostatniElement.PoprzedniElement.PoprzedniElement.NastepnyElement = ostatniElement.PoprzedniElement;
                    ostatniElement = y;
                }
        }

        public void Wstaw(int a, Osoba os)
        {
            if (a <= liczbaElementow)
            {
                if (a <= liczbaElementow / 2)
                {
                    WstawOdPrzodu(a, os);
                }
                else
                {
                    WstawOdTylu(liczbaElementow - 2 - a, os);
                }
                ++liczbaElementow;
            }
            else
            {
                Console.WriteLine("Za duzy indeks!");
            }
        }

        public Osoba PobierzOdPrzodu(int a)
        {
                Element x = pierwszyElement;
                Element y = pierwszyElement;
                if(a == 0)
                {
                    pierwszyElement = pierwszyElement.NastepnyElement;
                    pierwszyElement.PoprzedniElement = null;
                }
                else if(a == liczbaElementow - 1)
                {
                    x = ostatniElement;
                    ostatniElement.PoprzedniElement.NastepnyElement = null;
                    ostatniElement = ostatniElement.PoprzedniElement;
                }
                else
                {
                    for(int i = 0; i < a; ++i)
                    {
                        if (i < (a - 1))
                        {
                            pierwszyElement = pierwszyElement.NastepnyElement;
                        }
                        x = x.NastepnyElement;
                    }
                    Element z = pierwszyElement.NastepnyElement;
                    pierwszyElement.NastepnyElement = z.NastepnyElement;
                    pierwszyElement.NastepnyElement.PoprzedniElement = z.PoprzedniElement;
                    pierwszyElement = y;
                }
                x.Wartosc.WypiszInfo();
                Console.WriteLine("");
                return x.Wartosc;
        }

        //indeksowanie od tylu; [0] = ostatni element
        public Osoba PobierzOdTylu(int a)
        {
                Element x = ostatniElement;
                Element y = ostatniElement;
                if (a == 0)
                {
                    ostatniElement = ostatniElement.PoprzedniElement;
                    ostatniElement.NastepnyElement = null;
                }
                else if (a == liczbaElementow - 1)
                {
                    x = pierwszyElement;
                    pierwszyElement.NastepnyElement.PoprzedniElement = null;
                    pierwszyElement = pierwszyElement.NastepnyElement;
                }
                else
                {
                    for (int i = 0; i < a; ++i)
                    {
                        if (i < (a - 1))
                        {
                            ostatniElement = ostatniElement.PoprzedniElement;
                        }
                        x = x.PoprzedniElement;
                    }
                    Element z = ostatniElement.PoprzedniElement;
                    ostatniElement.PoprzedniElement = z.PoprzedniElement;
                    ostatniElement.PoprzedniElement.NastepnyElement = z.NastepnyElement;
                    ostatniElement = y;
                }
                x.Wartosc.WypiszInfo();
                Console.WriteLine("");
                return x.Wartosc; 
        }

        public Osoba Pobierz(int a)
        {
            if (a < liczbaElementow)
            {
                Osoba x;
                if(a <= liczbaElementow / 2)
                {
                    x = PobierzOdPrzodu(a);
                }
                else
                {
                    x = PobierzOdTylu(liczbaElementow - 1 - a);
                }
                --liczbaElementow;
                return x;
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

        public void WypiszOdTylu()
        {
            Element x = ostatniElement;
            for (int i = 0; i < liczbaElementow; ++i)
            {
                x.Wartosc.WypiszInfo();
                x = x.PoprzedniElement;
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
            l.WypiszOdTylu();
            
            l.Pobierz(2);
            l.Pobierz(0);
            l.Pobierz(1);

            l.Wypisz();
            l.WypiszOdTylu();

            l.Wstaw(0, o3);
            l.Wstaw(1, o4);
            l.Wstaw(2, o);

            l.Wypisz();
            l.WypiszOdTylu();

            Console.ReadKey();
        }
    }
}
