using PadroesDeProjeto.Subsistemas.CEP;
using PadroesDeProjeto.Subsistemas.CRM;

namespace PadroesDeProjeto.Facade
{
    internal class FacadeClass
    {
        public void MigrarCliente(string nome, string CEP)
        {
            string cidade = CEPAPI.Instance.RecuperarCidade(CEP);
            string estado = CEPAPI.Instance.RecuperarEstado(CEP);

            CRMService.GravarCliente(nome, CEP, cidade, estado);
        }
    }
}
