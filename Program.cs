using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartCw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            //string imie;
            //string nazwisko;

            //Console.WriteLine("Podaj imię: ");
            //imie = Console.ReadLine();

            //string tekst = "Podaj swoje nazwisko: ";
            //Console.WriteLine(tekst);
            //nazwisko = Console.ReadLine();


            //Console.WriteLine("Imię: {0}; Nazwisko: {1}", imie, nazwisko); // Wypisanie wprowadzonych danych przez użytkownika
            //                                                               // (W nawiasach wąsiastych są numery argumentów -
            //                                                               // czyli po cudzysłowie i przecinku podajemy w odpowiedniej kolejności argumenty funkcji -> imie, -> nazwisko)

            //Console.WriteLine("Imię: " + imie + " Nazwisko: " + nazwisko); // Drugi sposób wyświetlania wartości w konsoli poprzez połączenie stringów znakiem +




            //Console.ReadKey(); // Zapobiega wyłączeniu konsoli po wykonaniu programu

            //Zad 2.

            //int liczba1;
            //int liczba2;

            //Console.WriteLine("Podaj pierwszą liczbę: ");

            ////liczba1 = Convert.ToInt32(Console.ReadLine());
            //Convert.ToInt32-> jest to metoda zmieniajaca stringa na liczbe calkowita

            //liczba1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Podaj drugą liczbę: ");
            //liczba2 = int.Parse(Console.ReadLine());
            // int.Parse -> jest to metoda zmienajaca stringa na liczbe calkowita

            //Console.WriteLine("Wynik: " + (liczba1 + liczba2));

            //Console.WriteLine ("{0} + {1} = {2}", one two, (one + two));
            //Console.WriteLine (one + " + " + two + " = " + (one + two));

            //Console.ReadKey();


            //Zadanie 3


            //double liczba1, liczba2;


            //Console.WriteLine("Podaj pierwszą liczbę: ");
            //liczba1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Podaj drugą liczbę: ");
            //liczba2 = Convert.ToDouble(Console.ReadLine());

            //Metoda 2
            //double liczba2 = double.Parse(Console.ReadLine());

            ////Math.Max(a, b)->jest to funkcja która zwraca nam większą liczbę z dwóch podanych
            //Console.WriteLine("Liczba większa: " + Math.Max(liczba1, liczba2));


            //if (liczba1 > liczba2)
            //{
            //    Console.WriteLine("Większa liczba to: " + liczba1);

            //}
            //else if (liczba1 == liczba2)
            //{
            //    Console.WriteLine("obie sa rowne!");
            //}
            //else
            //{
            //    Console.WriteLine("Większa liczba to: " + liczba2);
            //}


            //Console.WriteLine("Liczba większa to: " + (liczba1 > liczba2 ? liczba1 : liczba2));
            // double wieksza = liczba1 > liczba2 ? liczba1 : liczba2;
            //Console.WriteLine(wieksza);

            //string komunikat = liczba1>liczba2 ? "Liczba wieksza to: "+liczba1
            //  : liczba1 == liczba2 ? "Obie sa rowne": "Liczba wieksza to: "+ liczba2;
            //Console.WriteLine(komunikat);

            //Console.ReadKey();


            //Zad 4.

            //int liczba;
            //int warunek = 9;

            //Console.WriteLine("Podaj liczbe calkowita: ");
            //liczba = int.Parse(Console.ReadLine());

            //if (liczba > warunek)
            //{
            //    if (liczba % 2 == 0)
            //        Console.WriteLine("Liczba parzysta");
            //    else
            //        Console.WriteLine("Liczba jest nieparzysta");

            //}
            //else
            //{
            //    if (liczba >= warunek)
            //    {
            //        if (liczba % 2 == 0)
            //            Console.WriteLine("Cyfra jest parzysta");
            //        else
            //            Console.WriteLine("Cyfra jest nieparzysta");
            //    }
            //    else
            //        Console.WriteLine("Ujemna");
            //    //
            //    //if (liczba >= 0 && liczba % 2 == 0)
            //    //    Console.WriteLine("Cyfra parzysta");
            //    //else if (liczba >= 0 && liczba % 2 != 0)
            //    //    Console.WriteLine("Cyfra nieparzysta");
            //    //else
            //    //    Console.WriteLine("Ujemna");

            //}


            //string komunikat = liczba > 9 ? (liczba % 2) == 0 ? "Liczba parzysta" : "Liczba nieparzysta"
            // :liczba >= 0 ? (liczba % 2) == 0 ? "Cyfra parzysta" : "Cyfra nieparzysta"
            // : "Liczba ujemna";


          
           //Zad 5

            int[] tablica = new int[10]; //tworzymy nowy objekt klasy random
            //tablica[0] = 15; Przypisanie indeksu do tablicy

            Random rand = new Random();

            for (int i=0; i<10; i++)
            {
                tablica[i] = rand.Next(0,101);
            }

            //Console.WriteLine("Pierwsza: " + tablica[0] + "Siódmy: " + tablica[6] + "Ostatnia: " + tablica[9]);
            //tablica.Length zwraca długość tablicy
            for(int i=0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }

            Console.WriteLine("Pierwsza: " + tablica[0] + ", Siódma: " + tablica[6] + ", Ostatnia: " + tablica[9]);

            //Console.WriteLine("Pierwszy: {0} , Siódmy: {1} , Ostatnia: {2}", tab[0], tab[6], tab[9]);
            Console.WriteLine("==============================================================");
            //Pętla foreach służy do iteracji po każdym elemencie w kolekcji danych (Mniejszy poziom kontroli nad indeksami)
            foreach(int value in tablica)
            {
                Console.WriteLine(value);
            }



            Console.ReadKey();

        }
    }
}
