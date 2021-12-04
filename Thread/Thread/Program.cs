using System;
using System.Threading;

namespace ThreadProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria a thread
            Thread t = new Thread(new ThreadStart(Tarefa));
            //t.IsBackground = true; // Usado para indicar que a thread é secundária e será finalizada juntamente com a thread principal
            t.Start();
            t.Join();                // Obriga que essa thread seja executada antes de iniciar a outra thread
                                     // Deixa sequencial
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Principal.");

                Thread.Sleep(500);  // Para a thread por um determinado tempo em ms
            }
            Console.ReadLine();
        }

        static void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa executada.");
                Thread.Sleep(1000);
            }
        }
    }
}
