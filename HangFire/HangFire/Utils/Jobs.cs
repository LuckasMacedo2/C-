using Hangfire;

namespace HangFire.Utils
{
    public class Jobs
    {
        public Jobs()
        {
            // Jobs fire-and-forget
            // Jobs executadas uma única vez e depois são esquecidas. 
            // Elas são acessíveis no dashboard
            var jobId = BackgroundJob.Enqueue(() => JobEsquecida());

            // Jobs delayed
            // Jobs executadas dentro de um tempo especifico
            BackgroundJob.Schedule(() => JobDelayed(), TimeSpan.FromMinutes(2));

            // Recurring jobs
            // Tarefa que será executada muitas vezes por meio de um agendamento CRON definido
            RecurringJob.AddOrUpdate("Meu job recorrente", () => JobRecorrente(), Cron.MinuteInterval(1));

            RecurringJob.AddOrUpdate("Meu job recorrente", () => JobRecorrente(), Cron.MinuteInterval(1));

            RecurringJob.AddOrUpdate("Meu job recorrente 5 minutos", () => JobRecorrente(), Cron.MinuteInterval(5));

            RecurringJob.AddOrUpdate("Meu job recorrente bloqueado", () => JobRecorrenteBloqueado(), Cron.MinuteInterval(1));

            RecurringJob.AddOrUpdate("Meu job recorrente a cada hora", () => JobRecorrente(), Cron.Hourly());

            // Jobs com continuations
            // Permite que um job seja executada depois da finalização de uma job pai
            jobId = BackgroundJob.Enqueue(() => JobPai());
            BackgroundJob.ContinueJobWith(jobId, () => JobFilho(jobId));
        }

        public static void JobRecorrenteBloqueado()
        {
            Console.WriteLine($"Job executando {DateTime.Now}  | {DateTime.UtcNow} >> Job recorrente bloqueado iniciando ...");
            while (true)
            {
                int i = 0;
            }
            Console.WriteLine($"Job executando {DateTime.Now}  | {DateTime.UtcNow} >> Job recorrente bloqueado finalizado");
        }

        public static void JobFilho(string jobId)
        {
            Console.WriteLine($"Job executando {DateTime.Now}  | {DateTime.UtcNow} >> Job continuation! (Job pai: {jobId})");
        }

        public static void JobPai()
        {
            Console.WriteLine($"Job executando {DateTime.Now}  | {DateTime.UtcNow} >> Job fire-and-forget pai!");
        }

        public static void JobRecorrente()
        {
            Console.WriteLine($"Job executando {DateTime.Now}  | {DateTime.UtcNow} >> Job recorrente a cada hora gerou um número: {new Random(2012).Next(1, 200)} ");
        }

        public static void JobEsquecida()
        {
            Console.WriteLine($"Job executando {DateTime.Now}  | {DateTime.UtcNow} >> Job Fire-and-forget! (Executada uma vez e depois esquecidas)");
        }

        public static void JobDelayed()
        {
            Console.WriteLine($"Job executando {DateTime.Now}  | {DateTime.UtcNow} >> Job Delayed: 2 minutos após o início da aplicação");
        }
    }
}
