using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Strategy
{
    internal class ComportamentoDefensivo : IComportamento
    {
        public void Mover()
        {
            Console.WriteLine("Robô se movendo defensivamente");
        }
    }
}
