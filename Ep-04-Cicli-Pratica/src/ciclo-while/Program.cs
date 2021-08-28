using System;

namespace ciclo_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrivi hello world finché il secondo dell'ora attuale non è un multiplo di 10.

            while(DateTime.Now.Second % 10 != 0)
            {
                Console.WriteLine(DateTime.Now + " Hello World");
                System.Threading.Thread.Sleep(500);
            }   
        }
    } 
}
