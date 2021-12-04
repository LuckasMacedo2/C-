using System;
using System.Drawing;

namespace WinFormsApp1
{
    class Game
    {
        public enum Resultado
        {
            Ganhar,
            Perder,
            Empatar
        }

        public enum Escolha
        {
            Pedra = 0,
            Tesoura = 1,
            Papel = 2
        }

        public static Image[] images =
        {
            Properties.Resources.Pedra,
            Properties.Resources.Tesoura,
            Properties.Resources.Papel
        };
        public Image ImgPC { get; private set; }
        public Image ImgJogador { get; private set; }
        public Resultado Jogar(int jogador)
        {
            int pc = jogadaPC();

            ImgJogador = images[jogador];
            ImgPC = images[pc];

            if(jogador == pc)
            {
                return Resultado.Empatar;
            }
            else if((jogador == ((int)Escolha.Pedra) && pc == ((int)Escolha.Tesoura)) ||
                    (jogador == ((int)Escolha.Tesoura) && pc == ((int)Escolha.Papel)) ||
                    (jogador == ((int)Escolha.Papel) && pc == ((int)Escolha.Pedra)))
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder;
            }
        }
        private int jogadaPC()
        {
            int milisegundos = DateTime.Now.Millisecond;

            if(milisegundos < 333)
            {
                return 0;
            }
            else if(milisegundos >= 333 & milisegundos < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
