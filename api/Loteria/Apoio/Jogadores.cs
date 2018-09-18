using Loteria.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return jogadores[posicao];
        }
    }
}
