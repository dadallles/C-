using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IInfo
    {
        void WypiszInfo();
    }

    public class Osoba : IInfo
    {
        protected string imie = "";
        protected string nazwisko = "";
        protected string dataUrodzenia = "";

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public Osoba(string imie_, string nazwisko_, string dataUrodzenia_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            dataUrodzenia = dataUrodzenia_;
        }

        public void WypiszInfo()
        {
            Console.WriteLine(imie + " " + nazwisko + " " + dataUrodzenia);
        }

    }

    public class Wykladowca : Osoba,  IInfo
    {
        private string tytulNaukowy = "";
        private string stanowisko = "";

        public Wykladowca()
            : base("", "", "") { }

        public Wykladowca(string stanowisko_, string tytulNaukowy_, string imie_, string nazwisko_, string dataUrodzenia_)
            :base(imie_, nazwisko_, dataUrodzenia_)
        {
            stanowisko = stanowisko_;
            tytulNaukowy = tytulNaukowy_;
        }

        public new void WypiszInfo()
        {
            Console.WriteLine(tytulNaukowy + " " + stanowisko + "   " + imie + " " + nazwisko + " " + dataUrodzenia);
        }

    }

    public class Jednostka : IInfo
    {
        private string nazwa = "";
        private string adres = "";
        private List<Wykladowca> Wykladowcy = new List<Wykladowca>();

        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        public Jednostka(string nazwa_, string adres_)
        {
            nazwa = nazwa_;
            adres = adres_;
        }

        public void DodajWykladowce(Wykladowca w)
        {
            Wykladowcy.Add(w);
        }

        public bool UsunWykladowce(Wykladowca w)
        {
            for(int i = 0; i < Wykladowcy.Count; ++i)
            {
                if(Wykladowcy[i] == w)
                {
                    Wykladowcy.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool UsunWykladowce(string imie, string nazwisko)
        {
            for (int i = 0; i < Wykladowcy.Count; ++i)
            {
                if (Wykladowcy[i].Imie == imie && Wykladowcy[i].Nazwisko == nazwisko)
                {
                    Wykladowcy.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public void WypiszInfo()
        {
            Console.WriteLine(nazwa + " " + adres);
        }

        public void InfoWykladowcy()
        {
            for (int i = 0; i < Wykladowcy.Count; ++i)
            {
                Wykladowcy[i].WypiszInfo();
            }
        }

    }

    public class Przedmiot : IInfo
    {
        private string nazwa = "";
        private string kierunek = "";
        private string specjalnosc = "";
        private int semestr = 0;
        private int ileGodzin = 0;

        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        public Przedmiot(string nazwa_, string kierunek_, string specjalnosc_, int semestr_, int ileGodzin_)
        {
            nazwa = nazwa_;
            kierunek = kierunek_;
            specjalnosc = specjalnosc_;
            semestr = semestr_;
            ileGodzin = ileGodzin_;
        }

        public void WypiszInfo()
        {
            Console.WriteLine(nazwa + " " + kierunek + " " + specjalnosc + " " + semestr + " " + ileGodzin);
        }

    }

    public class OcenaKoncowa : IInfo
    {
        private double wartosc = 0.0;
        private string data = "";
        private Przedmiot przedmiot;

        public OcenaKoncowa(double wartosc_, string data_, Przedmiot p)
        {
            wartosc = wartosc_;
            data = data_;
            przedmiot = p;
        }

        public void WypiszInfo()
        {
            Console.WriteLine(wartosc + " " + data + " ");
            przedmiot.WypiszInfo();
        }

    }

    public class Student : Osoba
    {
        private string kierunek = "";
        private string specjalnosc = "";
        private int rok = 0;
        private int grupa = 0;
        private int nrIdeksu = 0;
        private List<OcenaKoncowa> OcenyKoncowe = new List<OcenaKoncowa>();

        public int NrIndeksu
        {
            get { return nrIdeksu; }
            set { nrIdeksu = value; }
        }

        public Student()
            :base("", "", "") { }

        public Student(string imie_, string nazwisko_, string dataUrodzenia_, string kierunek_, string specjalnosc_, int rok_, int grupa_, int nrIndeksu_)
            :base(imie_, nazwisko_, dataUrodzenia_)
        {
            kierunek = kierunek_;
            specjalnosc = specjalnosc_;
            rok = rok_;
            grupa = grupa_;
            nrIdeksu = nrIndeksu_;
        }

        public new void WypiszInfo()
        {
            Console.WriteLine(imie + " " + nazwisko + " " + dataUrodzenia + " " + kierunek + " " + specjalnosc + " " + rok + " " + grupa + " " + nrIdeksu);
        }

        public void InfoOceny()
        {
            for (int i = 0; i < OcenyKoncowe.Count; ++i)
            {
                OcenyKoncowe[i].WypiszInfo();
            }
        }

        public void DodajOcene(Przedmiot p, double ocena, string data)
        {
            OcenaKoncowa temp = new OcenaKoncowa(ocena, data, p);
            OcenyKoncowe.Add(temp);
        }

    }

    public class Wydzial
    {
        private List<Jednostka> Jednostki = new List<Jednostka>();
        private List<Przedmiot> Przedmioty = new List<Przedmiot>();
        private List<Student> Studenci = new List<Student>();

        public void DodajJednostke(string nazwa, string adres)
        {
            Jednostka temp = new Jednostka(nazwa, adres);
            Jednostki.Add(temp);
        }

        public void DodajPrzedmiot(Przedmiot p)
        {
            Przedmioty.Add(p);
        }

        public void DodajStudenta(Student s)
        {
            Studenci.Add(s);
        }

        public bool DodajWykladowce(Wykladowca w, string nazwaJednostki)
        {
            for(int i = 0; i < Jednostki.Count; ++i)
            {
                if(Jednostki[i].Nazwa == nazwaJednostki)
                {
                    Jednostki[i].DodajWykladowce(w);
                    return true;
                }
            }
            return false;
        }

        public bool InfoStudenci(bool infoOceny)
        {
            if (Studenci.Count > 0)
            {
                for(int i = 0; i < Studenci.Count; ++i)
                {
                    Studenci[i].WypiszInfo();
                    if (infoOceny)
                    {
                        Studenci[i].InfoOceny();
                    }
                }
                return true;
            }
            return false;
        }

        public bool InfoJednostki(bool infoWykladowcy)
        {
            if (Jednostki.Count > 0)
            {
                for (int i = 0; i < Jednostki.Count; ++i)
                {
                    Jednostki[i].WypiszInfo();
                    if (infoWykladowcy)
                    {
                        Jednostki[i].InfoWykladowcy();
                    }
                }
                return true;
            }
            return false;
        }

        public void InfoPrzedmioty()
        {
            for (int i = 0; i < Przedmioty.Count; ++i)
            {
                Przedmioty[i].WypiszInfo();
            }
        }

        public bool DodajOcene(int nrIndeksu, string nazwaPrzedmiotu, double ocena, string data)
        {
            if (Przedmioty.Count > 0)
            {
                for (int i = 0; i < Przedmioty.Count; ++i)
                {
                    if (Przedmioty[i].Nazwa == nazwaPrzedmiotu)
                    {
                        for(int j = 0; j < Studenci.Count; ++j)
                        {
                            if(Studenci[j].NrIndeksu == nrIndeksu)
                            {
                                Studenci[j].DodajOcene(Przedmioty[i], ocena, data);
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public bool UsunStudenta(int nrIndeksu)
        {
            for (int i = 0; i < Studenci.Count; ++i)
            {
                if (Studenci[i].NrIndeksu == nrIndeksu)
                {
                    Studenci.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool PrzeniesWykladowce(Wykladowca w, string obecnaJednostka, string nowaJednostka)
        {
            for (int i = 0; i < Jednostki.Count; ++i)
            {
                if (Jednostki[i].Nazwa == obecnaJednostka)
                {
                    if (Jednostki[i].UsunWykladowce(w))
                    {
                        for (int j = 0; j < Jednostki.Count; ++j)
                        {
                            if (Jednostki[j].Nazwa == nowaJednostka)
                            {
                                Jednostki[j].DodajWykladowce(w);
                                return true;
                            }
                        }
                    }
                    return false;
                }
            }
            return false;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Wykladowca w1 = new Wykladowca("adiunkt", "Dr inz", "Dawid", "Jonienc", "02/04/1995");
            Wykladowca w2 = new Wykladowca("adiunkt", "Dr hab inz", "Michal", "Kowal", "06/12/1985");
            Wykladowca w3 = new Wykladowca("kierownik", "Prof Dr hab inz", "Wojtek", "Zak", "12/08/1975");

            Przedmiot programowanie = new Przedmiot("programowanie", "informatyka", "IO", 4, 30);
            Przedmiot sieci = new Przedmiot("projetkowanie sieci", "informatyka", "sieci", 3, 30);
            Przedmiot analizamat = new Przedmiot("analiza matematyczna", "matematyka", "calki", 6, 60);

            Student s1 = new Student("Adam", "Adamowicz", "02/02/1999", "informatyka", "IO", 2, 3, 128010);
            Student s2 = new Student("Mateusz", "Jakis", "12/05/1998", "informatyka", "sieci", 1, 2, 128111);
            Student s3 = new Student("Damian", "Nijaki", "06/12/1985", "matematyka", "calki", 3, 5, 18987);

            Wydzial WIMII = new Wydzial();

            WIMII.DodajJednostke("IISI", "Czestochowa ul.Biblioteczna 123");
            WIMII.DodajJednostke("J. Matematyczna", "Czestochowa ul.Matematykow 10");

            WIMII.DodajPrzedmiot(programowanie);
            WIMII.DodajPrzedmiot(sieci);
            WIMII.DodajPrzedmiot(analizamat);
            WIMII.InfoPrzedmioty();

            WIMII.DodajStudenta(s1);
            WIMII.DodajStudenta(s2);
            WIMII.DodajStudenta(s3);
            WIMII.DodajOcene(128010, "programowanie", 5.0, "02/04/2019");
            WIMII.DodajOcene(128111, "projetkowanie sieci", 3.0, "12/03/2019");
            WIMII.DodajOcene(18987, "analiza matematyczna", 5.0, "22/06/2019");
            Console.WriteLine();
            WIMII.InfoStudenci(false);
            Console.WriteLine();
            WIMII.InfoStudenci(true);

            WIMII.UsunStudenta(128010);
            Console.WriteLine();
            WIMII.InfoStudenci(false);

            WIMII.DodajWykladowce(w1, "IISI");
            WIMII.DodajWykladowce(w2, "IISI");
            WIMII.DodajWykladowce(w3, "J. Matematyczna");
            WIMII.DodajWykladowce(w1, "J. Matematyczna");
            Console.WriteLine();
            WIMII.InfoJednostki(false);
            Console.WriteLine();
            WIMII.InfoJednostki(true);

            WIMII.PrzeniesWykladowce(w2, "IISI", "J. Matematyczna");
            Console.WriteLine();
            WIMII.InfoJednostki(true);

            Console.ReadKey();
        }
    }
}
