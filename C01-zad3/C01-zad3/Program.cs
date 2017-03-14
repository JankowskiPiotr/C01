using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01_zad3
{

    class StandardowyCzlowiek
    {
        private string Imie;
        private int Wiek;
        public static int IloscKosciSzkieletowych = 206;
        private string MiejscePochodzenia;
        public static int IloscChromosomow = 46;

        public StandardowyCzlowiek(string Imie, int Wiek, string MiejscePochodzenia)
        {
            this.Imie = Imie;
            this.Wiek = Wiek;
            this.MiejscePochodzenia = MiejscePochodzenia;
        }

        public string getImie()
        {
            return this.Imie;
        }
        public int getWiek()
        {
            return this.Wiek;
        }
        public string getMiejscePochodzenia()
        {
            return this.MiejscePochodzenia;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<StandardowyCzlowiek> Ludzie = new List<StandardowyCzlowiek>();
            StandardowyCzlowiek Andrzej = new StandardowyCzlowiek("Andrzej", 44, "Radom");
            Ludzie.Add(Andrzej);
            StandardowyCzlowiek Janusz = new StandardowyCzlowiek("Janusz", 59, "Kraków");
            Ludzie.Add(Janusz);
            StandardowyCzlowiek Wladyslaw = new StandardowyCzlowiek("Władysław", 77, "Warszawa");
            Ludzie.Add(Wladyslaw);
            StandardowyCzlowiek Albert = new StandardowyCzlowiek("Albert", 33, "Kraków");
            Ludzie.Add(Albert);
            StandardowyCzlowiek Adam = new StandardowyCzlowiek("Adam", 93, "Gdynia");
            Ludzie.Add(Adam);
            StandardowyCzlowiek Jerzy = new StandardowyCzlowiek("Jerzy", 48, "Olsztyn");
            Ludzie.Add(Jerzy);



            int wybor = -1;
            while (wybor != 0)
            {
                Console.WriteLine("Wybierz:");
                Console.WriteLine("1 - Oblicz średnią wieku.");
                Console.WriteLine("2 - Wypisz imiona.");
                Console.WriteLine("3 - Podać informację o uniwersalnych danych standardowego człowieka");
                Console.WriteLine("4 - Wypisz najczesciej wystepujace miejsce pochodzenia");
                Console.WriteLine("0 - Wyjście");
                wybor = Convert.ToInt32(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        int suma = 0;
                        foreach (StandardowyCzlowiek Czlowiek in Ludzie)
                        {
                            suma += Czlowiek.getWiek();
                        }
                        Console.WriteLine("Srednia wieku wynosi: {0}", suma / Ludzie.Count);
                        break;
                    case 2:
                        foreach (StandardowyCzlowiek Czlowiek in Ludzie)
                        {
                            Console.WriteLine(Czlowiek.getImie());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Uniwersalne dane standardowego człowieka: ");
                        Console.WriteLine("Ilosc kości szkieletowych: " + StandardowyCzlowiek.IloscKosciSzkieletowych);
                        Console.WriteLine("Ilosc chromosomów: " + StandardowyCzlowiek.IloscChromosomow);
                        break;
                    case 4:
                        Dictionary<string, int> naj = new Dictionary<string, int>();
                        string miejscePochodzenia = "";
                        foreach (StandardowyCzlowiek Czlowiek in Ludzie)
                        {
                            miejscePochodzenia = Czlowiek.getMiejscePochodzenia();
                            if (naj.Keys.Contains(miejscePochodzenia))
                            {
                                naj[miejscePochodzenia]++;
                            }
                            else
                            {
                                naj.Add(miejscePochodzenia, 1);
                            }
                        }
                        Console.WriteLine(naj.Aggregate((l, r) => l.Value > r.Value ? l : r).Key);

                        break;

                    case 0:

                        break;

                }
            }
          
        }
    }
}
