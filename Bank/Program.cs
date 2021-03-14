using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opc = Menu();

            while(opc.ToUpper() != "X"){
                switch (opc){
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opc = Menu();
            }
            Console.WriteLine("Obrigado por usar o banco");
            Console.ReadLine(); 
        }

        private static void Transferir()
        {
            Console.WriteLine("--- Transferência ---");

            Console.Write("Informe o indice da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Informe o indice da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            if(listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino])){
                Console.WriteLine("Transferência realizada com sucesso!");
            } else{
                Console.WriteLine("Impossível realizar a transferência. Saldo insuficiente na conta de origem!");
            }
            Console.Write("Conta de origem: ");
            Console.WriteLine(listContas[indiceContaOrigem]);
            Console.Write("Conta de destino: ");
            Console.WriteLine(listContas[indiceContaDestino]);
        }

        private static void Depositar()
        {
            Console.WriteLine("--- Deposito ---");

            Console.Write("Informe o indice da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);

            Console.WriteLine("Deposito realizado com sucesso!");
            Console.WriteLine(listContas[indiceConta]);
        }

        private static void Sacar()
        {
            Console.WriteLine("--- Saque ---");

            Console.Write("Informe o indice da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            if(listContas[indiceConta].Sacar(valorSaque)){
                Console.WriteLine("Saque realiado com sucesso.");
            } else{
                Console.WriteLine("Saldo Insuficiente! Impossível realizar o saque");
            }
            Console.WriteLine(listContas[indiceConta]);
        }

        private static void ListarContas()
        {
            Console.WriteLine("--- Listar Contas ---");
            if(listContas.Count == 0){
                Console.WriteLine("Nenhuma conta cadastrada");
                return;
            }else{
                for(int i = 0; i < listContas.Count; i++){
                    Conta conta = listContas[i];
                    Console.Write("#{0} - ", i);
                    Console.WriteLine(conta);
                }
            }
        }

        private static void InserirConta()
        {
            Console.WriteLine("--- Inserir nova Conta ---");

            Console.Write("Informe o tipo da conta 1 - conta Fisica ou 2 - conta juridica: ");
            int tipoConta = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome: ");
            string nome = Console.ReadLine();
             
            Console.Write("Informe o saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine());

            Console.Write("Informe o Crédito: ");
            double credito = double.Parse(Console.ReadLine());

            Conta conta = new Conta(nome, saldo, credito, (TipoConta) tipoConta);

            listContas.Add(conta);

        }

        private static string Menu(){
            Console.WriteLine("\nBanco");
            Console.WriteLine("Informe a opção");
            Console.WriteLine("1 - Listar Contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar a Tela");
            Console.WriteLine("X - Sair");

            string opc = Console.ReadLine().ToUpper();
            return opc;     
        }
    }
}
