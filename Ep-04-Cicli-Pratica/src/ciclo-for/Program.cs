using System;

namespace ciclo_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrivi hello world tante volte quante decide l'utente.
            Console.WriteLine("Scrivi il numero di volte in cui ripetere 'hello world'");
            int numeroDiVolte = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numeroDiVolte; i++)
            {
                Console.WriteLine(i + ") Hello World");
            }
        }
    }
}
