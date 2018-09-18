using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loteria.Modal
{
    public class Jogador
    {
        private string nome;
        public string Nome { get => nome; set => nome = value; }

        IList<Aposta> apostas;
        Aposta melhorAposta;

        public Jogador(string nome)
        {
            Nome = nome;
            apostas = new List<Aposta>();
        }

        public void FazerAposta(IJogo tipoJogo, string numeros)
        {
            var num = numeros.Replace("[", "").Replace("]", "").Split(',').Select(Int32.Parse).ToList();
            Aposta aposta = new Aposta(tipoJogo);
            aposta.FazAposta(num);
            apostas.Add(aposta);
        }

        public void ConferirApostas()
        {
            foreach(var aposta in apostas)
            {
                aposta.checarAcertos();
            }
        }

        public Aposta MelhorAposta()
        {
            Aposta melhor = apostas[0];

            foreach (var aposta in apostas)
            {
                if (aposta.NumeroDeAcertos > melhor.NumeroDeAcertos)
                {
                    melhor = aposta;
                }
            }

            return melhor;
        }
    }
}
