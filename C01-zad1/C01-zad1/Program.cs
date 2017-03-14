using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01_zad1
{

    class Samochod
    {
        private string Marka;
        private int LiczbaKol;
        public int Predkosc;
        private string Kolor;
        private int Rocznik;

        public Samochod(string Marka, int LiczbaKol, int Predkosc, string Kolor = "Czarny", int Rocznik = 2016)
        {
            this.Marka = Marka;
            this.LiczbaKol = LiczbaKol;
            this.Predkosc = Predkosc;
            this.Kolor = Kolor;
            this.Rocznik = Rocznik;
        }

        public void Jedz(int predkosc)
        {
            Console.WriteLine(this.Kolor + " samochód marki " + this.Marka + " jedzie z predkoscia " + predkosc);
            Console.WriteLine("Domyślna ilość kół używanych jednoczesnie w samochodzie to " + this.LiczbaKol);
        }

        public void Hamuj()
        {
            Console.WriteLine("Hamuje samochod marki: " + this.Marka);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Samochod> Samochody = new List<Samochod>();
            Samochod Mercedes = new Samochod("Mercedes", 4, 172, "biały");
            Samochody.Add(Mercedes);
            Samochod Toyota = new Samochod("Toyota", 4, 113, "srebrny");
            Samochody.Add(Toyota);
            Samochod Lexus = new Samochod("Lexus", 4, 159, "czarny", 2002);
            Samochody.Add(Lexus);
            Samochod Rover = new Samochod("Rover", 4, 95, "czerwony", 1995);
            Samochody.Add(Rover);
            Samochod Mitsubishi = new Samochod("Mitsubishi", 4, 123, "zielony", 1999);
            Samochody.Add(Mitsubishi);

            foreach (Samochod samochod in Samochody)
            {
                samochod.Jedz(samochod.Predkosc);
            }

            foreach (Samochod samochod in Samochody)
            {
                samochod.Hamuj();
            }
        }
    }
}
