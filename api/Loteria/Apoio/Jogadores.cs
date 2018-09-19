using Loteria.Modal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Loteria.Apoio
{
    public class Jogadores
    {
        public IList<Jogador> jogadores;

        public Jogadores()
        {
            jogadores = new List<Jogador>();
        }

        public void AddJogador(Jogador jogador)
        {
            jogadores.Add(jogador);
        }

        public Jogador GetJogadorPorNome(string nome)
        {
            foreach(var jogador in jogadores)
            {
                if (jogador.Nome.Equals(nome)){
                    return jogador;
                }
            }
            return null;
        }

        public Jogador GetJogadorPorPosicao(int posicao)
        {
            try
            {
                return jogadores[posicao];
            }catch(ArgumentOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException("A posicao nao contem jogador!");
            }
        }

        public string GetTodosJogadores()
        {
            var json = JsonConvert.SerializeObject(jogadores);
            json.Replace(@"\", "");
            return json;
        }

    }
}
