using Loteria.Modal;
using System;
using System.Linq;
using Loteria.Apoio;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogadores jogadores = new Jogadores();
            Jogador jogador = new Jogador("Victor");
            IJogo jogo = new Sena();

            jogadores.AddJogador(jogador);

            jogador.FazerAposta(jogo, "[1,2,3,4,5,6]");
            jogador.FazerAposta(jogo, "[1,5,10,15,20,25]");
            jogador.FazerAposta(jogo, "[1,5,6,7,8,9]");
            jogador.FazerAposta(jogo, "[10,13,23,44,48,56]");
            jogador.FazerAposta(jogo, "[12,24,34,36,53,56]");

            var numerosResultados = jogo.GetResultado();
            jogador.ConferirApostas();

            foreach (var numero in numerosResultados)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Jogador " + jogador.Nome);
            Console.WriteLine("Maior Numero de acertos " + jogador.MelhorAposta().NumeroDeAcertos);
            Console.WriteLine("Jogo com maior numero de acertos ");
            
            foreach (var numero in jogador.MelhorAposta().Palpites)
            {
                Console.Write(numero + " ");
            }


            Console.Read();
        }
    }
}
