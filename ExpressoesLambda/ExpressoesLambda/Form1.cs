using System.Linq.Expressions;

namespace ExpressoesLambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Resultado_Click(object sender, EventArgs e)
        {
            // Expressão lambda = método anonimo, existe apenas no escopo que ele é declarado

            // Expressão lambda que tem uma expressão como corpo:
            // (input - parameters) => expression

            // Expressão lambda que tem um bloco como corpo:
            // (input - parameters) => { <sequence - of - statments> }


            // Uma exp. lambda pode ser converida em um delegate
            // Ex.: delegate do tipo func
            // Func<Entrada, saída> nome = nome_metedo
            // Os primeiros entre <> são os parâmetros, o último é o retorno
            // Func<int, int> square = quadrado;

            Func<int, int> square = x => x * x;
            label_Resultado.Text = "O resultado é: " + square(5).ToString() + "\n";

            // Lambda -> Arvore de expressão
            // Cria a função no formato de string
            Expression<Func<int, int>> ex = x => x + x;
            label_Resultado.Text += "O resultado é: " + ex.ToString() + "\n";

            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            var squaredNumbers = numbers.Select(x => x * x);
            label_Resultado.Text += string.Join(" ", squaredNumbers) + "\n";

            Action<string> greet = name =>
            {
                string greeting = $"Hello {name}";
                label_Resultado.Text += greeting + "\n";
            };

            greet("Lucas");

            Action line = () => Console.WriteLine();
            Console.WriteLine("Lucas ");
            line();
            Console.WriteLine("Macedo");

            Func<int, int, bool> testForEquality = (x, y) => x == y;
            label_Resultado.Text += testForEquality(10, 1).ToString();


        }

        int quadrado(int x)
        {
            return x * x;
        }
    }
}