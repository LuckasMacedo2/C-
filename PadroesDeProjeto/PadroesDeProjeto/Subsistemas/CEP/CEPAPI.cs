using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Subsistemas.CEP
{

    internal class CEPAPI
    {
        // Atribui a instância quando a classe é definida
        // Já atribuída quando a classe é chamada
        private static CEPAPI instance = new CEPAPI();

        // Construtor privado garante que não será chamado externamente
        private CEPAPI()
        {

        }

        public static CEPAPI Instance
        {
            get { return instance; }
        }

        public string RecuperarCidade(string CEP)
        {
            return "Pindamanaguaba";
        }

        public string RecuperarEstado(string CEP)
        {
            return "Goiás";
        }
    }
}
