using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rzutowaniee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rzutowanie - konswersja

            //to było to jest parsowanie
            int liczba = int.Parse(Console.ReadLine());
            //wypisywanie liczbu urzytkownia
            Console.WriteLine("Liczba oryginalna (int) "+liczba);

            double liczba2 = (double)liczba + 0.5;
            //wypisywanie przekonwertowniej liczby (doble)
            Console.WriteLine("Liczba przekonwertowna do double "+liczba2);

            //powrót do inta
            int suma = (int)liczba2;
            Console.WriteLine("Liczba przekonwertowna z powrotem do int " + suma);

            Console.ReadLine();


        }
    }
}
