using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace C_TEst
{
    
    class Osoba
    {
        public string Imie { get;  } 
        public string Nazwisko { get; }
        
        public Osoba(string imie,string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

    }
    class Konto
    {
        public Osoba Wlasciciel { get; }
        private decimal saldo = 0;
        private int pin = 0;

        public void UstawSaldo(decimal sld)
        {
            saldo = sld;
        }
        public void UstawPIN(int p)
        {
            pin = p;
        }
       
        public Konto(string imieWlasciciela,string nazwiskoWlasciciela)
        {
            Wlasciciel = new Osoba(imieWlasciciela, nazwiskoWlasciciela);
        }

        public void ZmienPIN()
        {
            Console.WriteLine("Podaj aktualny PIN");
            string pinText = Console.ReadLine();
            int pin = int.Parse(pinText);

            if (pin == this.pin)
            {
                Console.WriteLine("Podaj nowy PIN");
                int pinNowy = int.Parse(Console.ReadLine());
                this.pin = pinNowy;
            }
            else
                Console.WriteLine("Błędny PIN");
        }
        public void StanKonta()
        {
            Console.WriteLine("Aby wyświetlić informacje o koncie podaj PIN");
            string podanypinText = Console.ReadLine();
            int pin1 = int.Parse(podanypinText);

            if (pin1 == this.pin)
            {
                Console.WriteLine("Właściciel konta:{0}{1} Twój stan konta: {2}", Wlasciciel.Imie, Wlasciciel.Nazwisko, saldo);
            }
            else
                Console.WriteLine("Błędny PIN");
        }
    }


    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Witamy w banku XYZ");
            
            
            Konto k = new Konto("Ewa","Nowak");
            k.UstawSaldo(500);
            k.UstawPIN(1234);
            k.StanKonta();
            

            Konto l = new Konto("Bożena", "Kowalska");
            l.UstawSaldo(4500);
            l.UstawPIN(4321);
            l.StanKonta();

        }


    }
}
