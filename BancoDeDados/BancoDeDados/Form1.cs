using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlServerCe;
using System.IO;

// Baixar o SQL Server compact edition > Adicionar a referência da dll
//      Para os demais bancos de dados é bem parecido

namespace BancoDeDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\dbSQLServer.sdf";
            string strConnection = $@"DataSource = {baseDados}; Password = '1234'";
            SqlCeEngine db = new SqlCeEngine(strConnection);

            if (!File.Exists(baseDados))
            {
                db.CreateDatabase();
            }

            db.Dispose();

            // Cria a conexão
            SqlCeConnection conexao = new SqlCeConnection(strConnection);
            try
            { 
                conexao.Open();

                lblResultado.Text = "Conectado";
                
            }
            catch (Exception ex)
            {
                lblResultado.Text = $"Falha ao conectar {ex.ToString()}";
            }
            finally
            {
                conexao.Close();
            }


            
        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            // SQL Server CE
            string baseDados = Application.StartupPath + @"\db\dbSQLServer.sdf";
            string strConnection = $@"DataSource = {baseDados}; Password = '1234'";

            // Abrir a conexão
            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE TABLE Pessoas (id INT NOT NULL PRIMARY KEY, Nome NVARCHAR(50), Email NVARCHAR(50))";

                comando.ExecuteNonQuery();

                lblResultado.Text = "Tabela criada no SQL Server CE";

            }
            catch(Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // SQL Server CE
            string baseDados = Application.StartupPath + @"\db\dbSQLServer.sdf";
            string strConnection = $@"DataSource = {baseDados}; Password = '1234'";

            // Abrir a conexão
            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                comando.CommandText = $"INSERT INTO Pessoas VALUES ({id}, '{nome}', '{email}')";

                comando.ExecuteNonQuery();

                lblResultado.Text = "Registro inserido no SQL Server CE";

            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            dataGridView1.Rows.Clear();

            // SQL Server CE
            string baseDados = Application.StartupPath + @"\db\dbSQLServer.sdf";
            string strConnection = $@"DataSource = {baseDados}; Password = '1234'";

            // Abrir a conexão
            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            try
            {
                string query = "SELECT * FROM Pessoas";

                if (txtNome.Text != "")
                    query = "SELECT * FROM Pessoas WHERE nome LIKE '" + txtNome.Text + "'";

                DataTable dados = new DataTable();

                SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, strConnection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    dataGridView1.Rows.Add(linha.ItemArray);
                }

                

            }
            catch (Exception ex)
            {
                dataGridView1.Rows.Clear();
                lblResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // SQL Server CE
            string baseDados = Application.StartupPath + @"\db\dbSQLServer.sdf";
            string strConnection = $@"DataSource = {baseDados}; Password = '1234'";

            // Abrir a conexão
            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                comando.CommandText = $"DELETE FROM Pessoas WHERE id = {id}";

                comando.ExecuteNonQuery();

                lblResultado.Text = "Registro excluído no SQL Server CE";

            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // SQL Server CE
            string baseDados = Application.StartupPath + @"\db\dbSQLServer.sdf";
            string strConnection = $@"DataSource = {baseDados}; Password = '1234'";

            // Abrir a conexão
            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                string query = $"UPDATE FROM Pessoas SET Nome = '{txtNome.Text}', email = '{txtEmail.Text}' WHERE id = {id}";

                comando.CommandText = query;

                comando.ExecuteNonQuery();

                lblResultado.Text = "Registro alterado no SQL Server CE";

            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
