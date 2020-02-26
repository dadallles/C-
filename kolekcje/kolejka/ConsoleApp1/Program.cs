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
        private Element nastepnyElement;
        public object Wartosc
        {
            get { return wartosc; }
            set { wartosc = value; }
        }

        public Element NastepnyElement
        {
            get { return nastepnyElement; }
            set { nastepnyElement = value; }
        }

        public Element(object wartosc_)
        {
            wartosc = wartosc_;
            nastepnyElement = null;
        }
    }

    public class Kolejka
    {
        private Element pierwszyElement;
        private Element ostatniElement;
        private int liczbaElementow;

        public int LiczbaElementow
        {
            get { return liczbaElementow; }
            set { liczbaElementow = value; }
        }

        public Kolejka()
        {
            pierwszyElement = null;
            ostatniElement = null;
            liczbaElementow = 0;
        }

        public void Dodaj(object elem)
        {
            Element e = new Element(elem);
            if(pierwszyElement == null)
            {
                pierwszyElement = e;
                ostatniElement = e;
            }
            else
            {
                ostatniElement.NastepnyElement = e;
                ostatniElement = e;
            }
            ++liczbaElementow;
        }

        public object Pobierz()
        {
            if (pierwszyElement == null)
            {
                Console.WriteLine("Pusto");
                return null;
            }
            else
            {
                Element e = pierwszyElement;
                pierwszyElement = pierwszyElement.NastepnyElement;
                --liczbaElementow;
                return e.Wartosc;
            }

        }

        public void Wypisz()
        {
            Element e = pierwszyElement;
            while(e != null)
            {
                Console.WriteLine(e.Wartosc.ToString());
                e = e.NastepnyElement;
            }
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Kolejka k = new Kolejka();
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
