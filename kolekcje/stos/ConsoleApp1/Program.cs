using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Element
    {
        private object wartosc;
        private Element poprzedniElement;

        public object Wartosc
        {
            get { return wartosc; }
            set { wartosc = value; }
        }

        public Element PoprzedniElement
        {
            get { return poprzedniElement; }
            set { poprzedniElement = value; }
        }

        public Element(object wartosc_)
        {
            wartosc = wartosc_;
            poprzedniElement = null;
        }
    }

    public class Stos
    {
        private Element ostatniElement;
        private int liczbaElementow;

        public int LiczbaElementow
        {
            get { return liczbaElementow; }
            set { liczbaElementow = value; }
        }

        public Stos()
        {
            ostatniElement = null;
            liczbaElementow = 0;
        }

        public void Dodaj(object ob)
        {
            Element e = new Element(ob);
            if(liczbaElementow == 0)
            {
                ostatniElement = e;
            }
            else
            {
                e.PoprzedniElement = ostatniElement;
                ostatniElement = e;
            }
            ++liczbaElementow;
        }

        public object Pobierz()
        {
            if(ostatniElement == null)
            {
                Console.WriteLine("Pusto");
                return null;
            }
            else
            {
                Element e = ostatniElement;
                ostatniElement = e.PoprzedniElement;
                --liczbaElementow;
                return e.Wartosc;
            }
        }

        public void Wypisz()
        {
            Element e = ostatniElement;
            while (e != null)
            {
                Console.WriteLine(e.Wartosc.ToString());
                e = e.PoprzedniElement;
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Stos k = new Stos();
            k.Dodaj(1);
            k.Dodaj(5);
            k.Dodaj(3);
            k.Dodaj(8);
            k.Wypisz();
            Console.WriteLine("Liczba elementow {0}", k.LiczbaElementow);
            int element = (int) k.Pobierz();
            Console.WriteLine("Pobrany element: {0}", element);
            k.Wypisz();
            Console.WriteLine("Liczba elementow {0}", k.LiczbaElementow);
            k.Dodaj(7);
            k.Dodaj(4);
            k.Wypisz();
            Console.WriteLine("Liczba elementow {0}", k.LiczbaElementow);
            element = (int)k.Pobierz();
            Console.WriteLine("Pobrany element: {0}", element);
            k.Wypisz();
            Console.WriteLine("Liczba elementow {0}", k.LiczbaElementow);

            Console.ReadKey();
        }
    }
}
