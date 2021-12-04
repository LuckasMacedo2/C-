using System;
using System.Collections.Generic;

namespace EstruturasDeDados
{
    class Program
    {
        // Comparação
        //      SortedList x SortedDictionary: SortedList usa menos memória que o SortedDictionary.
        //                                     SortedDictionary tem operações de inserção e remoção mais rápidas
        static void Main(string[] args)
        {
            // HashSetEstudo();
            // DictionaryEstudo();
            // SortedListEstudo();
            // SortedDictionaryEstudo();
            // SortedSetEstudo();
            // QueueEstudo();
            StackEstudo();
        }

        private static void StackEstudo()
        {
            // Primeiro elemento a entrar é o último a sair
            Stack<string> pilha = new Stack<string>();

            // Adiciona itens na pilha
            pilha.Push("José");
            pilha.Push("Abacaxi");
            pilha.Push("ABCDEFGHIJKL");

            // Stack
            //      .Peek() -> Retorna o elemento no topo da pilha
            //      .Pop()  -> Remove e retorna o elemento do topo da pilha

            foreach (string item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        private static void QueueEstudo()
        {
            Queue<string> fila = new Queue<string>();

            // Adiciona o elemento na fila
            fila.Enqueue("José");
            fila.Enqueue("João");
            fila.Enqueue("Lucas");

            // Queue
            //      .Peek() -> Retorna o primeiro elemento da fila sem retirá-lo
            //      .Dequeue() -> Remove e retorna o primeiro elemento da fila
            //      .First()   -> Retorna o primeiro elemento da fila. Semelhante ao Peek()
            //      .Last()    -> Retorna o último elemento da fila

            Console.WriteLine("Primeiro elemento: " + fila.Peek());

            foreach (string item in fila)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

        private static void SortedSetEstudo()
        {
            // Conjunto ordenado
            // Não aceita itens repetidos
            //
            SortedSet<string> sortedSet = new SortedSet<string>()
            {
                { "Azul" },
                { "Vermelho" },
                { "Verde" }
            };

            //          

            sortedSet.Add("Abacaxi");

            foreach (string item in sortedSet)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortedDictionaryEstudo()
        {
            // Dicionário ordenado
            // Ordenado pela chave
            SortedDictionary<int, string> dicionarioOrdenado = new SortedDictionary<int, string>()
            {
                { 48, "Azul" },
                { 46, "Vermelho" },
                { 47, "Verde" }
            };

            //  SortedDictionary
            //          .Reverse()      -> Ordena de forma inversa
            //          .Remove(chave)  -> Remove o item determinado pela chave
            //          .Count, .Clear()
            //          .ContainsKey(chave), .ContainsValue(valor)
            //          

            dicionarioOrdenado.Add(58, "Abacaxi");

            foreach (KeyValuePair<int, string> item in dicionarioOrdenado)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        private static void SortedListEstudo()
        {
            // Estutura de dados do tipo chave, valor
            // Os itens são ordenadas pela chave do item
            SortedList<int, string> listaOrdenada = new SortedList<int, string>()
            {
                { 27, "Lucas" },
                { 28, "José" }
            };

            // SortedList
            //      .Reverse()  -> Ordena os itens na ordem reversa
            //      .Remove(chave) -> Remove o item determinado pela chave
            //      .RemoveAt(indice) -> Remove o item determinado no indice definido
            //      .ContainsKey() e .ContainsValue() -> Determina se existe determinada chave e valor na lista, respectivamente

            listaOrdenada.Add(14, "Abacaxi");

            foreach (KeyValuePair<int, string> item in listaOrdenada)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.ReadLine();
        }

        private static void DictionaryEstudo()
        {
            // Usa chave e valor. A chave é única para cada valor
            //      Dictionary<chave, valor>
            Dictionary<int, string> dicionarioAlunos = new Dictionary<int, string>()
            {
                { 150, "Jose" },
                { 125, "João" }
            };

            // Dictionary
            //      .Add(chave, valor)
            //      .Count                  -> Conta os elementos
            //      .Remove(chave)          -> Remove o elemento referenciado pela chave
            //      .Clear()                -> Limpar toda a coleção
            //      .First() e .Last()      -> Pega o primeiro e o último elemento respectivamente
            //      .ContainsKey(chave) e .ContainsValue(valor) -> Determina se no dicionário existe uma chave ou um valor, respectivamente


            dicionarioAlunos.Add(100, "Lucas");

            // KeyValuePair -> receber chaves de valores em par
            // Usada para receber valores de dicionário

            foreach (KeyValuePair<int, string> item in dicionarioAlunos)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();



        }

        static void HashSetEstudo()
        {
            // HashSet não permite itens repetidos
            HashSet<string> veiculos = new HashSet<string>()
            {
                "Carro", "Moto"
            };

            // Adicionado itens
            // Verifica também se o item já está na lista
            veiculos.Add("Gol");

            // Outros métodos:
            // HashSet
            //  .Contains(item) -> se o item está no hashset
            //  .Remove(item)   -> remove o item e retorna true se conseguir excluir
            //  .Count()        -> Conta os itens presentes no HashSet
            //  .Clear()        -> Limpa o hashSet
            //  .ElementAt(indice) -> Acessar o elemento de um hashSet
            //  .First()           -> Retorna o primeiro elemento da coleção
            //  .Last()            -> Retorna o último elemento da coleção


            foreach (string veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }

            Console.ReadLine();
        }
    }
}
