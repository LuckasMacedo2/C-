using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForms
{
    public partial class Form1 : Form
    {
        private delegate void AtualizarControle(Control controle, string propriedade, object valor);
        Thread t;
        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true;
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Principal");
        }

        private void buttonContador_Click(object sender, EventArgs e)
        {
            if (!t.IsAlive) t.Start();
        }

        private void Tarefa()
        {
            while (true)
            {
                // Controles só podem ser atualizados na thread em que ela foi criada
                //lblPrincipal.Text = DateTime.Now.Second.ToString();
                //DefinirValorPropriedade(lblPrincipal, "Text", DateTime.Now.Second.ToString());


                // Outra forma de fazer
                lblPrincipal.Invoke(new Action(() => lblPrincipal.Text = DateTime.Now.Second.ToString()));
            }
        }

        // .Invoke -> Permite acessar o controle de outra thread, diferente da qual ele foi criado
        private void DefinirValorPropriedade(Control controle, string propriedade, object valor)
        {
            if (controle.InvokeRequired)
            {
                AtualizarControle d = new AtualizarControle(DefinirValorPropriedade);
                controle.Invoke(d, new object[] { controle, propriedade, valor });
            }
            else
            {
                Type t = controle.GetType();
                PropertyInfo[] props = t.GetProperties();

                foreach (PropertyInfo item in props)
                {
                    if (item.Name.ToUpper() == propriedade.ToUpper()) item.SetValue(controle, valor, null);
                }
            }
        }
    }
}
