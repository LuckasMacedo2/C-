using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Game jogo = new Game();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            StartGame((int)Game.Escolha.Pedra);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            StartGame((int)Game.Escolha.Papel);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            StartGame((int)Game.Escolha.Tesoura);
        }

        private void StartGame(int opc)
        {
            lblResultado.Visible = false;

            switch (jogo.Jogar(opc))
            {
                case Game.Resultado.Ganhar:
                    pictureResultado.BackgroundImage = Properties.Resources.Ganhar;
                    break;
                case Game.Resultado.Perder:
                    pictureResultado.BackgroundImage = Properties.Resources.Perder;
                    break;
                case Game.Resultado.Empatar:
                    pictureResultado.BackgroundImage = Properties.Resources.Empatar;
                    break;
            }
            pictureBoxJogador.Image = jogo.ImgJogador;
            pictureBoxPC.Image = jogo.ImgPC;
        }
    }
}
