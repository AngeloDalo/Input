using System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero");
            string inputUtente = Console.ReadLine();
            Console.WriteLine("Inserisci un altro numero");
            string inputUtente2 = Console.ReadLine();
            int num1 = int.Parse(inputUtente);
            int num2 = int.Parse(inputUtente2);
            int risultato = num1 + num2;
            Console.WriteLine("risultato: " + risultato);
        }
    }
}
