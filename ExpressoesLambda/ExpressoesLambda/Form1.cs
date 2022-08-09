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
            // Express�o lambda = m�todo anonimo, existe apenas no escopo que ele � declarado

            // Express�o lambda que tem uma express�o como corpo:
            // (input - parameters) => expression

            // Express�o lambda que tem um bloco como corpo:
            // (input - parameters) => { <sequence - of - statments> }


            // Uma exp. lambda pode ser converida em um delegate
            // Ex.: delegate do tipo func
            // Func<Entrada, sa�da> nome = nome_metedo
            // Os primeiros entre <> s�o os par�metros, o �ltimo � o retorno
            // Func<int, int> square = quadrado;

            Func<int, int> square = x => x * x;
            label_Resultado.Text = "O resultado �: " + square(5).ToString() + "\n";

            // Lambda -> Arvore de express�o
            // Cria a fun��o no formato de string
            Expression<Func<int, int>> ex = x => x + x;
            label_Resultado.Text += "O resultado �: " + ex.ToString() + "\n";

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