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

        public void FazerAposta(IJogo tipoJogo, string numeros)
        {
            var num = numeros.Replace("[", "").Replace("]", "").Split(',').Select(Int32.Parse).ToList();
            Aposta aposta = new Aposta(tipoJogo);
            aposta.FazAposta(num);

            apostas.Add(aposta);
        }
    }
}
