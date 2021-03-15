using System.Collections.Generic;
using System;
using AnimeCRUD.Interfaces;

namespace AnimeCRUD
{
    public class AnimeRepositorio : IRepositorio<Animes>
    {

        private List<Animes> listaAnimes = new List<Animes>(){
            new Animes(0, (Genero) 1, "Bleach", "Anime sobre Shinigamis", 2004),
            new Animes(1, (Genero) 1, "Gintama", "Anime sobre Samurais", 2006),
            new Animes(2, (Genero) 13, "Re:Zero", "Anime sobre voltar no tempo", 2014)
        };

        public void Atualiza(int id, Animes entidade)
        {
            listaAnimes[id] = entidade;
        }

        public void Excluir(int id)
        {
            listaAnimes[id].Excluir();
        }

        public void Insere(Animes entidade)
        {
            listaAnimes.Add(entidade);
        }

        public List<Animes> Lista()
        {
            return listaAnimes;
        }

        public int ProximoId()
        {
            return listaAnimes.Count;
        }

        public Animes RetornaPorId(int id)
        {
            return listaAnimes[id];
        }
    }
}