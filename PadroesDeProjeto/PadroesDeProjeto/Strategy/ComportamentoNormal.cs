using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Strategy
{
    internal class ComportamentoNormal : IComportamento
    {
        public void Mover()
        {
            Console.WriteLine("Robô se movendo normalmente");
        }
    }
}
