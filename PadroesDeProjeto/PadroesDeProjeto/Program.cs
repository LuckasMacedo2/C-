using PadroesDeProjeto.Facade;
using PadroesDeProjeto.Strategy;

namespace PadroesDeProjeto
{
    public class Program
    {

        // Validação dos singletons
        public static void Main(string[] args)
        {
            // TesteSingleton();
            // TesteStrategy();
            TesteFacade();
            Console.ReadLine();
        }

        private static void TesteStrategy()
        {
            IComportamento normal = new ComportamentoNormal();
            IComportamento defensivo = new ComportamentoDefensivo();
            IComportamento agressivo = new ComportamentoAgressivo();

            Robo robo = new Robo();
            robo.Comportamento = normal;
            robo.Mover();
            robo.Mover();
            robo.Comportamento = defensivo;
            robo.Mover();
            robo.Comportamento = agressivo;
            robo.Mover();
            robo.Mover();
            robo.Mover();
            robo.Mover();

        }

        private static void TesteSingleton()
        {
            // Singleton lazy
            SingletonLazy lazy = SingletonLazy.Instance;
            Console.WriteLine(lazy);
            lazy = SingletonLazy.Instance;
            Console.WriteLine(lazy);



            Console.ReadLine();
        }

        private static void TesteFacade()
        {
            FacadeClass facade = new FacadeClass();
            facade.MigrarCliente("Lucas", "74971301");

        }
    }
}