using System;

namespace AnimeCRUD
{
    class Program
    {
        static AnimeRepositorio repositorio = new AnimeRepositorio();
        static void Main(string[] args)
        {
            string opc = Menu();

            while(opc.ToUpper() != "X"){
                switch (opc){
                    case "1":
                        ListarAnimes();
                        break;
                    case "2":
                        InserirAnime();
                        break;
                    case "3":
                        AtualizarAnime();
                        break;
                    case "4":
                        ExcluirAnime();
                        break;
                    case "5":
                        VisualizarAnime();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                       Console.WriteLine("Opção Inválida! Informe novamente");
                       break;
                }
                opc = Menu();
            }
            Console.WriteLine("Obrigado por usar o serviço");
            Console.ReadLine(); 
        }

        private static void VisualizarAnime()
        {
            Console.WriteLine("--- Visualizar Anime ---");

            Console.Write("Informe o ID do Anime: ");
            int id = int.Parse(Console.ReadLine());

            if (id > repositorio.ProximoId() - 1)
                Console.WriteLine("Anime não cadastrado!");
            else{
                var anime = repositorio.RetornaPorId(id);

                Console.WriteLine(anime);
            }
        }

        private static void ExcluirAnime()
        {
             Console.WriteLine("--- Excluir Anime ---");

            Console.Write("Informe o ID do Anime: ");
            int id = int.Parse(Console.ReadLine());

            if (id > repositorio.ProximoId() - 1)
                Console.WriteLine("Anime não cadastrado!");
            else
                repositorio.Excluir(id);
        }

        private static void AtualizarAnime()
        {
            Console.WriteLine("--- Atualizar Anime ---");

            Console.Write("Informe o ID do Anime: ");
            int id = int.Parse(Console.ReadLine());

            if (id > repositorio.ProximoId() - 1)
                Console.WriteLine("Anime não cadastrado!");
            else{
                Animes anime = criarObjeto(id);
                repositorio.Atualiza(id, anime);
            }
        }

        private static void InserirAnime()
        {
            Console.WriteLine("--- Inserir Anime ---");

            Animes anime = criarObjeto();

            repositorio.Insere(anime);

        }

        private static void ListarAnimes()
        {
            Console.WriteLine("-- Lista de Animes cadastrados ---");

            var lista = repositorio.Lista();

            if (lista.Count == 0) {
                Console.WriteLine("Nenhum anime cadastrado!");
                return;
            }else{
                foreach(var anime in lista){
                    bool excluido = anime.getExcluido();
                    Console.WriteLine("#{0}: {1} - {2}", anime.ID, anime.getTitulo(), excluido ? "Excluido": "");
                }
            }

        }

        private static string Menu(){
            Console.WriteLine("\nBanco");
            Console.WriteLine("Informe a opção");
            Console.WriteLine("1 - Listar animes");
            Console.WriteLine("2 - Inserir novo anime");
            Console.WriteLine("3 - Atualizar anime");
            Console.WriteLine("4 - Excluir anime");
            Console.WriteLine("5 - Visualizar anime");
            Console.WriteLine("C - Limpar a Tela");
            Console.WriteLine("X - Sair");

            string opc = Console.ReadLine().ToUpper();
            return opc;     
        }

        private static Animes criarObjeto(int id = -1){
            foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Informe o genêro a partir das opções acima: ");
            int genero = int.Parse(Console.ReadLine());

            Console.Write("Informe o título do anime: ");
            string titulo = Console.ReadLine();

            Console.Write("Informe o ano do anime: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Informe a descrição do anime: ");
            string descricao = Console.ReadLine();

            Animes anime = new Animes(id == -1 ? repositorio.ProximoId(): id, (Genero)genero, titulo, descricao, ano);

            return anime;
        }
    }
}
