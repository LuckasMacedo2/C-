using System.Security.Cryptography;

namespace CriptografiaDeArquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Criptografia.cspp = new CspParameters();
            Criptografia.EncrPasta = @"F:\Projects\Projetos - Estudo\Estudos C#\CriptografiaDeArquivos\ArquivosCriptogrados\";
            Criptografia.DecrPasta = @"F:\Projects\Projetos - Estudo\Estudos C#\CriptografiaDeArquivos\ArquivosDecriptogrados\";
            Criptografia.SRCPasta = @"F:\Projects\Projetos - Estudo\Estudos C#\CriptografiaDeArquivos\Docs\";
        }

        private void buttonCriptografarArquivo_Click(object sender, EventArgs e)
        {
            if(Criptografia.rsa == null)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Chave não definida";
            }
            else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Criptografia.SRCPasta;
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    string fName = dialog.FileName;
                    FileInfo fInfo = new FileInfo(fName);
                    string name = fInfo.FullName;

                    label1.Text = Criptografia.EncryptFile(name);
                }
            }
        }

        private void buttonDecriptarArquivo_Click(object sender, EventArgs e)
        {
            if (Criptografia.rsa == null)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Chave não definida";
            }
            else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Criptografia.SRCPasta;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string fName = dialog.FileName;
                    FileInfo fInfo = new FileInfo(fName);
                    string name = fInfo.Name;

                    label1.Text = Criptografia.DecryptFile(name);
                }
            }
        }

        private void buttonCriarChaves_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxChave.Text))
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Insira um valor para definir a chave pública";
                textBoxChave.Focus();
                return;
            }

            Criptografia.KeyName = textBoxChave.Text;
            label1.ForeColor = Color.DarkBlue;
            label1.Text = Criptografia.CreateAsmKey();  
        }

        private void buttonExportarChave_Click(object sender, EventArgs e)
        {
            if(Criptografia.ExportPublicKey())
            {
                label1.ForeColor = Color.DarkBlue;
                label1.Text = "Chave pública exportada";
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Chave pública não exportada";
            }
        }

        private void buttonImportarChave_Click(object sender, EventArgs e)
        {
            Criptografia.KeyName = "Publica";
            label1.ForeColor = Color.DarkBlue;
            label1.Text = Criptografia.ImportPublicKey();
        }

        private void buttonObterChavePrivada_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxChave.Text))
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Insira um valor para definir a chave privada";
                textBoxChave.Focus();
                return;
            }

            Criptografia.KeyName = textBoxChave.Text;
            label1.ForeColor = Color.DarkBlue;
            label1.Text = Criptografia.GetPrivateKey();
        }

        private void textBoxChave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}