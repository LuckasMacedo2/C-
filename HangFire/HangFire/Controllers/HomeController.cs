using HangFire.Utils;
using Hangfire.Storage;
using Microsoft.AspNetCore.Mvc;
using Hangfire;

namespace HangFire.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var jobs = new Jobs();
            return Ok("Sucesso");
        }

        [HttpGet("Jobs")]
        public IActionResult GetJobs()
        {
            try
            {
                string log = "";
                using (var connection = JobStorage.Current.GetConnection())
                {
                    foreach (var jobs in StorageConnectionExtensions.GetRecurringJobs(connection))
                    {
                        log += $"{DateTime.UtcNow} >> Job Id: {jobs.Id} - Criada em: {jobs.CreatedAt} -  Última execução {jobs.LastExecution} - Próxima execução {jobs.NextExecution} - Job time zone{jobs.TimeZoneId}\n";
                    }
                }
                return Ok(log);
            }
            catch (Exception ex)
            {

                throw new Exception("Deu ruim " + ex.Message);
            }
            
        }

        [HttpGet("UpdateJobs")]
        public IActionResult UpdateJob()
        {
            try
            {
                string log = "";
                using (var connection = JobStorage.Current.GetConnection())
                {


                    //log += $"{DateTime.UtcNow} >> Job Id: {job.Id} - Criada em: {job.CreatedAt} -  Última execução {job.LastExecution} - Próxima execução {job.NextExecution} - Job time zone{job.TimeZoneId}\n";

                    //job.NextExecution = DateTime.UtcNow.AddMinutes(-55);
                    //log += $"{DateTime.UtcNow} >> Job Id: {job.Id} - Criada em: {job.CreatedAt} -  Última execução {job.LastExecution} - Próxima execução {job.NextExecution} - Job time zone{job.TimeZoneId}\n";


                    //RecurringJob.AddOrUpdate("Meu job recorrente a cada minuto", () => Console.WriteLine($"Job executando {DateTime.Now}  | {DateTime.UtcNow} >> Job criada TESTE"), Cron.MinuteInterval(3));



                    //Hangfire.JobActivator.Current.

                    foreach (var job in StorageConnectionExtensions.GetRecurringJobs(connection))
                        RecurringJob.RemoveIfExists(job.Id);
                    
                    var jobs = new Jobs();
                }
                return Ok(log);
            }
            catch (Exception ex)
            {

                throw new Exception("Deu ruim " + ex.Message);
            }

        }
    }
}
