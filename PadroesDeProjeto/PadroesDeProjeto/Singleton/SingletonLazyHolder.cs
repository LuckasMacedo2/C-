using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto
{
    internal class SingletonLazyHolder
    {   
        // Encpasula a instância do singleton
        private static class InstanceHolder
        {
            public static SingletonLazyHolder instance = new SingletonLazyHolder();
        }
        

        // Construtor privado garante que não será chamado externamente
        private SingletonLazyHolder()
        {

        }

        public static SingletonLazyHolder Instance
        {
            get { return InstanceHolder.instance; }
        }
    }
}
