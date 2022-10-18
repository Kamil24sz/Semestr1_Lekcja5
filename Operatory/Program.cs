using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal budżet = 40;
            decimal kosztPizzy = 40;

            bool czyWystarczy = false;

            czyWystarczy = kosztPizzy <= budżet;

            Console.WriteLine("Budżet: " + budżet);
            Console.WriteLine("Koszt Pizzy: " + kosztPizzy);
            Console.WriteLine("Czy wystraczy: " + czyWystarczy);

            Console.WriteLine();
            //tutaj wybrany rodzaj pizzy
            string rodzajPizzy = "mięsna";
            Console.WriteLine("Obecny rodzaj pizzy: " + rodzajPizzy);

            //pizza jaką powinniśmy zamówić
            string oczekiwanyRodzaj = "pieczarkowa";
            Console.WriteLine("Rodzina chce taki rodzaj pizzy: " + oczekiwanyRodzaj);


            bool czyPizzaBędzieSmakowała = rodzajPizzy != oczekiwanyRodzaj;
            Console.WriteLine("Czy pizza będzie samakowała: " + czyPizzaBędzieSmakowała);

            Console.ReadLine();
        }
    }
}
