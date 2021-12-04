using System;
using System.Threading.Tasks;
using System.Threading;

namespace Tarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Task simples"
            //Task tarefa = new Task(Tarefa);
            //tarefa.Start();                     // Inicia a task

            //Task tarefa2 = Task.Run(Tarefa);    // Inicia a task

            //Task.Factory.StartNew(Tarefa);      // Cria a task, útil para métodos com retorno

            // Task.Run(() => {  })             // Passando uma tarefa de forma anonima
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Tarefa principal");
            //}
            #endregion

            #region Array de tasks
            // Exibe conforme a finalização da task
            //Task[] tasks = 
            //{ 
            //    Task.Factory.StartNew(() => { Console.WriteLine("Task #1"); }),
            //    Task.Factory.StartNew(() => { Console.WriteLine("Task #2"); }),
            //    Task.Factory.StartNew(() => { Console.WriteLine("Task #3"); })
            //};

            // Espera executar as tasks passadas por argumento, para dar continuidade no
            // programa principal
            //Task.WaitAll(tasks);

            //Console.WriteLine("Principal");
            #endregion

            // Task com retorno
            //Task<int> tarefa1 = Task.Factory.StartNew(() => Dobro(10));

            //Console.WriteLine(tarefa1.Result);

            // Uma tarefa espera outra finalizar
            Task<int> tarefa2 = Task.Factory.StartNew(() => { return new Random().Next(10); });
            // ContinueWith -> faz com que a task seja finalizada para executar a próxima
            Task<int> tarefa3 = tarefa2.ContinueWith((num) => { return num.Result * 2; });
            Task<string> tarefa4 = tarefa3.ContinueWith((num) => { return $"Resultado {num.Result}"; });
            Console.WriteLine(tarefa4.Result);

            Console.ReadKey();
        }

        static int Dobro(int num)
        {
            return num * 2;
        }

        static private void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa");
            }
        }
    }
}
