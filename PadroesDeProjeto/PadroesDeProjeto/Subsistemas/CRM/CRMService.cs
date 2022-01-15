namespace PadroesDeProjeto.Subsistemas.CRM
{
    internal class CRMService
    {
        private CRMService()
        {

        }
        public static void GravarCliente(string nome, string cep, string cidade, string estado)
        {
            Console.WriteLine($"Cliente {nome} {cep} {cidade} {estado} criado no sistema de CRM");
        }
    }
}
