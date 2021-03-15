using System;

namespace AnimeCRUD
{
    public class Animes : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }   
        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Animes(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.ID = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;

            this.Excluido = false;
        }

        public override string ToString(){
            // + Environment.NewLine -> Pula linha independente do S.O.

            string r = "";
            r += "Gênero: " + this.Genero + Environment.NewLine;
            r += "Título: " + this.Titulo + Environment.NewLine;
            r += "Descrição: " + this.Descricao + Environment.NewLine;
            r += "Ano: " + this.Ano + Environment.NewLine;
            r += "Excluído? " + this.Excluido;

            return r;
        } 

        public int getID(){
            return this.ID;
        }   

        public string getTitulo(){
            return this.Titulo;
        }

        public void Excluir(){
            this.Excluido = true;
        }

        public bool getExcluido(){
            return this.Excluido;
        }
    }
}