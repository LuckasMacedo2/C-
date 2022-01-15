using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto.Strategy
{
    internal class Robo
    {
        public IComportamento Comportamento;    

        public void Mover()
        {
            Comportamento.Mover();
        }


    }
}
