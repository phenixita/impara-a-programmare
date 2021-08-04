using System;

namespace imparo_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero intero");
            string input = Console.ReadLine();

            int numeroInserito = Convert.ToInt32(input);

            if (numeroInserito % 2 == 0)
            {
                Console.WriteLine("Il numero inserito è pari.");
            }
            else
            {
                Console.WriteLine("Il numero inserito è dispari.");
            }
 
            Console.WriteLine("Premere INVIO per terminare.");
            Console.ReadLine();
        }
    }
}
