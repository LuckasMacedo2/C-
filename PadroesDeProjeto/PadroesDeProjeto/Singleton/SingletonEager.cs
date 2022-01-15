using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesDeProjeto
{
    // Singletor apressado
    internal class SingletonEager
    {
        // Atribui a instância quando a classe é definida
        // Já atribuída quando a classe é chamada
        private static SingletonEager instance = new SingletonEager();

        // Construtor privado garante que não será chamado externamente
        private SingletonEager()
        {

        }

        public static SingletonEager Instance
        {
            get { return instance; }
        }
    }
}
