using System;

namespace ciclo_repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrivi "Hello world" finché l'utente non digita q per uscire.
            ConsoleKeyInfo inputUtente;
            do
            {
                Console.WriteLine("Hello World!");

                Console.WriteLine("Premi un tasto per continuare. Digita 'q' per uscire dal programma.");

                inputUtente = Console.ReadKey();
                
                Console.WriteLine("");


            } while (inputUtente.KeyChar != 'q');


        }
    }
}
