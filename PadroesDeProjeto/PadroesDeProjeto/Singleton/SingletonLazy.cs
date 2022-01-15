using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto
{
    // Singleton preguiçoso
    internal class SingletonLazy
    {
        private static SingletonLazy instance;

        // Construtor privado garante que não será chamado externamente
        private SingletonLazy()
        {
            
        }

        // Instância é definida quando é chamada
        public static SingletonLazy Instance
        {
            get { if (instance == null) { instance = new SingletonLazy(); } return instance; }
        }
    }
}
