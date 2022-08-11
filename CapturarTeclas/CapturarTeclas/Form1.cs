namespace CapturarTeclas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_X_Click(object sender, EventArgs e)
        {
            label_Tecla.Text = "X pressionado";
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            label_Tecla.Text = "Enter pressionado";
        }

        private void form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)97) // Enter pressionada
            {
                button_Enter.PerformClick();
                label_Tecla.Text += " - Tecla A";
            }
        }
    }
}