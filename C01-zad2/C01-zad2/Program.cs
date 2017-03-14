using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01_zad2
{

    class KontoBankowe
    {
        public string Imie;
        public string Nazwisko;
        public string NrKonta;
        public double Fundusze;
        private int id;
        public string status;

        static int nr = 1;

        public KontoBankowe(string Imie, string Nazwisko, string NrKonta, double Fundusze)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.NrKonta = NrKonta;
            this.Fundusze = Fundusze;
            this.id = nr;
            this.status = "Aktywny";
            nr++;
        }

        public void WplacPieniadze(double kwota)
        {
            ZmienFunduszeKonta(this.Fundusze + kwota);
        }

        private void ZmienFunduszeKonta(double fundusze)
        {
            this.Fundusze = fundusze;
        }

        public void UsunKonto()
        {

        }
        public void WyplacPieniadze(double kwota)
        {
            ZmienFunduszeKonta(this.Fundusze - kwota);
        }
        public void setStatus(string status)
        {
            this.status = status;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

           

            List<KontoBankowe> ListaKont = new List<KontoBankowe>();
            KontoBankowe Adam = new KontoBankowe("Adam", "Smith", "0000000000000", 2001.21);
            ListaKont.Add(Adam);
            KontoBankowe Miroslaw = new KontoBankowe("Mirosław", "Aleksandrowicz", "1111111111111111", 345000);
            ListaKont.Add(Miroslaw);
            KontoBankowe Krzysztof = new KontoBankowe("Krzysztof", "Malczewski", "2222222222222", 1.01);
            ListaKont.Add(Krzysztof);
            KontoBankowe Maciej = new KontoBankowe("Maciej", "Opalach", "3333333333333", 12035);
            ListaKont.Add(Maciej);
            KontoBankowe Wlodzimierz = new KontoBankowe("Włodzimierz", "Dąbrowski", "4444444444444", 1000000.01);
            ListaKont.Add(Wlodzimierz);
            Console.WriteLine("Dostepne konta bankowe: ");
            foreach (KontoBankowe konto in ListaKont)
            {
                Console.WriteLine(konto.Imie + " " + konto.Nazwisko + ". Saldo: " + konto.Fundusze + ". Status: " + konto.status);
            }
            Console.WriteLine("");
            Console.WriteLine("Wybierz nr konta");
            int wyborKonta = Convert.ToInt32(Console.ReadLine());
            try
            {
                KontoBankowe wybraneKonto = ListaKont[wyborKonta - 1];
                int wybor = -1;
                while (wybor != 0)
                {


                    Console.WriteLine("Wybrano konto: " + wybraneKonto.Imie + " " + wybraneKonto.Nazwisko + ". Stan konta: " + wybraneKonto.Fundusze);
                    Console.WriteLine("");
                    Console.WriteLine("Wybierz opcje:");
                    Console.WriteLine("1 - Wplac pieniadze");
                    Console.WriteLine("2 - Dodaj odsetki");
                    Console.WriteLine("3 - Ustaw konto do usuniecia");
                    Console.WriteLine("4 - Aby wyswietlic konta");
                    Console.WriteLine("0 - Aby zakonczyc");
                    Console.WriteLine("");
                    wybor = Convert.ToInt32(Console.ReadLine());

                    switch (wybor) {

                        case 1:
                            Console.WriteLine("Podaj kwote ktora chcesz wplacic.");
                            double kwota = Convert.ToDouble(Console.ReadLine());
                            wybraneKonto.WplacPieniadze(kwota);
                            break;
                        case 2:
                            Console.WriteLine("Podaj procent odsetek o jaki chcesz zwiekszyc stan konta");
                            double procent = Convert.ToDouble(Console.ReadLine());
                            if (procent < 0)
                            {
                                Console.WriteLine("Niepoprawna wartosc");
                            }
                            else
                            {
                                wybraneKonto.WplacPieniadze((wybraneKonto.Fundusze * (procent / 100 + 1)) - wybraneKonto.Fundusze);
                            }
                            break;
                        case 3:
                            Console.WriteLine("Czy chcesz ustawić status konta na 'Do usuniecia'? Wpisz 'TAK' aby potwierdzić.");
                            string usunWybor = "";
                            usunWybor = Console.ReadLine();
                            if (usunWybor == "TAK")
                            {
                                wybraneKonto.setStatus("Do usuniecia");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Dostepne konta bankowe: ");
                            foreach (KontoBankowe konto in ListaKont)
                            {
                                Console.WriteLine(konto.Imie + " " + konto.Nazwisko + ". Saldo: " + konto.Fundusze + ". Status: " + konto.status);
                            }
                            break;
                    }

                }

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Zly numer konta.", e);
            }
        }
    }
}
