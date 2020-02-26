using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public interface Wypisz
        {
            void WypiszInfo();
        }

        class Ptak : Zwierze, Wypisz
        {
            protected double rozpietoscSkrzydel = 0;
            protected double wytrzymalosc = 0;

            public Ptak(double rozpietoscSkrzydel_, double wytrzymalosc_, string gatunek_, string rodzajPozywienia_, string pochodzenie_)
                :base(gatunek_, rodzajPozywienia_, pochodzenie_)
            {
                rozpietoscSkrzydel = rozpietoscSkrzydel_;
                wytrzymalosc = wytrzymalosc_;
            }

            public double MaxDlugoscLotu()
            {
                return rozpietoscSkrzydel * wytrzymalosc;
            }

            public override void WypiszInfo()
            {
                Console.WriteLine(Gatunek + " " + RodzajPozywienia + " " + Pochodzenie + " " + rozpietoscSkrzydel + " " + wytrzymalosc);
            }
        }

        class Gad : Zwierze, Wypisz
        {
            protected bool jadowitosc = false;

            public Gad(bool jadowitosc_, string gatunek_, string rodzajPozywienia_, string pochodzenie_)
                :base(gatunek_, rodzajPozywienia_, pochodzenie_)
            {
                jadowitosc = jadowitosc_;
            }

            public bool ZmienJadowitosc()
            {
                if (jadowitosc)
                {
                    jadowitosc = false;
                }
                else
                {
                    jadowitosc = true;
                }
                return jadowitosc;
            }

            public override void WypiszInfo()
            {
                Console.WriteLine(Gatunek + " " + RodzajPozywienia + " " + Pochodzenie + " " + jadowitosc);
            }
        }

        class Ssak : Zwierze, Wypisz
        {
            protected string naturalneSrodowisko = "";

            public Ssak(string naturalneSrodowisko_, string gatunek_, string rodzajPozywienia_, string pochodzenie_)
                :base(gatunek_, rodzajPozywienia_, pochodzenie_)
            {
                naturalneSrodowisko = naturalneSrodowisko_;
            }

            public override void WypiszInfo()
            {
                Console.WriteLine(Gatunek + " " + RodzajPozywienia + " " + Pochodzenie + " " + naturalneSrodowisko);
            }
        }

        abstract class Zwierze : Wypisz
        {
            private string gatunek = "";
            private string rodzajPozywienia = "";
            private string pochodzenie = "";

            public string Gatunek
            {
                get { return gatunek; }
                set { gatunek = value; }
            }

            public string RodzajPozywienia
            {
                get { return rodzajPozywienia; }
                set { rodzajPozywienia = value; }
            }

            public string Pochodzenie
            {
                get { return pochodzenie; }
                set { pochodzenie = value; }
            }

            public Zwierze(string gatunek_, string rodzajPozywienia_, string pochodzenie_)
            {
                gatunek = gatunek_;
                rodzajPozywienia = rodzajPozywienia_;
                pochodzenie = pochodzenie_;
            }

            abstract public void WypiszInfo();
        }
        
        class Klatka : Wypisz
        {
            private double pojemnosc = 0;
            private bool posprzatana = true;
            private int ID = 0;
            private static int numeracja = 0;
            private List<Zwierze> zwierzeta = new List<Zwierze>();

            public double Pojemnosc
            {
                get { return pojemnosc; }
                set { pojemnosc = value; }
            }

            public int id
            {
                get { return ID; }
                set { ID = value; }
            }

            public Klatka(double pojemnosc_)
            {
                pojemnosc = pojemnosc_;
                ID = numeracja;
                numeracja++;
            }

            public Klatka(double pojemnosc_, bool posprzatana_)
            {
                pojemnosc = pojemnosc_;
                posprzatana = posprzatana_;
                ID = numeracja;
                numeracja++;
            }

            public bool CzyPosprzatana()
            {
                return posprzatana;
            }

            public bool Posprzataj()
            {
                if (posprzatana)
                {
                    return false;
                }
                else
                {
                    posprzatana = true;
                    return true;
                }
            }

            public void DodajZwierze(Zwierze ob)
            {
                zwierzeta.Add(ob);
            }

            public bool UsunZwierze(string gatunek_, string rodzajPozywienia_, string pochodzenie_)
            {
                for(int i=0; i<zwierzeta.Count; ++i)
                {
                    if(zwierzeta[i].Gatunek == gatunek_ && zwierzeta[i].Pochodzenie == pochodzenie_ && zwierzeta[i].RodzajPozywienia == rodzajPozywienia_)
                    {
                        zwierzeta.RemoveAt(i);
                        return true;
                    }
                }
                return false;
            }

            public void WypiszInfo()
            {
                Console.WriteLine(pojemnosc + " " + posprzatana + " " + ID + "\nLista zwierzat:");
                for (int i = 0; i < zwierzeta.Count; ++i)
                    zwierzeta[i].WypiszInfo();
            }
        }
        
        class Opiekun : Wypisz
        {
            private string imie = "";
            private string nazwisko = "";
            private int liczbaKlatek = 0;
            protected List<Klatka> klatki = new List<Klatka>();

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

            public Opiekun(string imie_, string nazwisko_)
            {
                imie = imie_;
                nazwisko = nazwisko_;
            }

            public void DodajKlatke(Klatka ob)
            {
                klatki.Add(ob);
                liczbaKlatek++;
            }

            public bool UsunKlatke(int ID_)
            {
                for (int i = 0; i < klatki.Count; ++i)
                {
                    if (klatki[i].id == ID_)
                    {
                        klatki.RemoveAt(i);
                        liczbaKlatek--;
                        return true;
                    }
                }
                return false;
            }

            public bool CzyWszystkieCzyste()
            {
                for (int i = 0; i < klatki.Count; ++i)
                {
                    if (!klatki[i].CzyPosprzatana())
                    {
                        return false;
                    }
                }
                return true;
            }

            public int LiczbaKlatek()
            {
                return liczbaKlatek;
            }

            public bool PosprzatajWszystkie()
            {
                bool wszystkieczyste = true;
                for(int i=0; i<klatki.Count; ++i)
                {
                    if (!klatki[i].CzyPosprzatana())
                    {
                        klatki[i].Posprzataj();
                        wszystkieczyste = false;
                    }
                }
                return wszystkieczyste;
            }

            public bool poszerz(double rozmiar, int id_)
            {
                for (int i = 0; i < klatki.Count; ++i)
                {
                    if (klatki[i].id == id_)
                    {
                        klatki[i].Pojemnosc = rozmiar;
                        return true;
                    }
                }
                return false;
            }

            public bool DodajZwierze(Zwierze ob, int id_)
            {
                for (int i = 0; i < klatki.Count; ++i)
                {
                    if (klatki[i].id == id_)
                    {
                        klatki[i].DodajZwierze(ob);
                        return true;
                    }
                }
                return false;
            }

            public void WypiszInfo()
            {
                Console.WriteLine(imie + " " + nazwisko + " " + liczbaKlatek + "\nLista klatek:");
                for (int i = 0; i < klatki.Count; ++i)
                {
                    klatki[i].WypiszInfo();
                }
            }
        }
        
        class Zoo : Wypisz
        {
            protected int liczbaOpiekunow;
            protected List<Opiekun> opiekunowie = new List<Opiekun>();

            public Zoo()
            {
                liczbaOpiekunow = 0;
            }

            public void DodajOpiekuna(Opiekun ob)
            {
                opiekunowie.Add(ob);
                ++liczbaOpiekunow;
            }

            public bool UsunOpiekuna(string imie_, string nazwisko_)
            {
                for (int i = 0; i < opiekunowie.Count; ++i)
                {
                    if (opiekunowie[i].Imie == imie_ && opiekunowie[i].Nazwisko == nazwisko_)
                    {
                        opiekunowie.RemoveAt(i);
                        --liczbaOpiekunow;
                        return true;
                    }
                }
                return false;
            }

            public virtual void WypiszInfo()
            {
                Console.WriteLine("Liczba opiekonow: " + liczbaOpiekunow + "\nLista opiekonow: ");
                for (int i = 0; i < opiekunowie.Count; ++i)
                {
                    opiekunowie[i].WypiszInfo();
                }
            }
        }

        class Dyrekcja : Zoo, Wypisz
        {
            public Dyrekcja()
                :base() { }

            public bool BudujKlatke(double pojemnosc_, bool posprzatana_, string imie_, string nazwisko_)
            {
                for (int i = 0; i < opiekunowie.Count; ++i)
                {
                    if (opiekunowie[i].Imie == imie_ && opiekunowie[i].Nazwisko == nazwisko_)
                    {
                        Klatka temp = new Klatka(pojemnosc_, posprzatana_);
                        opiekunowie[i].DodajKlatke(temp);
                        return true;
                    }
                }
                return false;
            }

            public bool PowiekszKlatke(double pojemnosc_, int id_)
            {
                for (int i = 0; i < opiekunowie.Count; ++i)
                {
                    if(opiekunowie[i].poszerz(pojemnosc_, id_))
                    {
                        return true;
                    }
                }
                return false;
            }

            public void Zatrudnij(string imie, string nazwisko)
            {
                Opiekun temp = new Opiekun(imie, nazwisko);
                DodajOpiekuna(temp);
            }

            public bool DodajZwierze(Zwierze ob, int idklatki)
            {
                for (int i = 0; i < opiekunowie.Count; ++i)
                {
                    if(opiekunowie[i].DodajZwierze(ob, idklatki))
                    {
                        return true;
                    }
                    return true;
                }
                return false;
            }

            public override void WypiszInfo()
            {
                Console.WriteLine("Liczba opiekonow: " + liczbaOpiekunow + "\nLista opiekonow: ");
                for (int i = 0; i < opiekunowie.Count; ++i)
                {
                    opiekunowie[i].WypiszInfo();
                }
            }
        }


        static void Main(string[] args)
        {
            Gad gad = new Gad(true, "gad", "muchy", "afryka");
            Ssak ssa = new Ssak("dzungla", "ssak", "weze", "ameryka poludniowa");
            Ptak pta = new Ptak(2.0, 15.12, "ptak", "ryby", "wyspy zp");

            Opiekun op1 = new Opiekun("dawid", "kopacz");
            Opiekun op2 = new Opiekun("marcel", "widczynski");

            Dyrekcja dyr = new Dyrekcja();

            dyr.Zatrudnij("dawid", "koparski");
            dyr.Zatrudnij("marcel", "widczynski");
            dyr.WypiszInfo();

            Console.WriteLine();

            dyr.BudujKlatke(14, true, "dawid", "koparski");
            dyr.PowiekszKlatke(20, 0);
            dyr.DodajZwierze(gad, 0);
            dyr.DodajZwierze(ssa, 0);
            dyr.BudujKlatke(45, false, "marcel", "widczynski");
            dyr.DodajZwierze(pta, 1);
            dyr.BudujKlatke(55, true, "dawid", "koparski");
            dyr.DodajZwierze(gad, 2);
            dyr.DodajZwierze(ssa, 2);
            dyr.WypiszInfo();

            Console.WriteLine();

            dyr.UsunOpiekuna("dawid", "koparski");
            dyr.WypiszInfo();

            Console.ReadKey();
        }
    }
}
