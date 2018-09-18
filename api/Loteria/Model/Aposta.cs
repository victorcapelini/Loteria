using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loteria.Modal
{
    public class Aposta
    {
        IJogo tipoAposta;
        IList<int> palpites;
        public int NumeroDeAcertos { get; private set; }
        public IList<int> Palpites { get => palpites; set => palpites = value; }

        public Aposta(IJogo tipoAposta)
        {
            this.tipoAposta = tipoAposta;
        }

        public void GeraPalpiteAleatorio()
        {
            Palpites = tipoAposta.GeraJogoAleatorio();
        }

        public void FazAposta(IList<int> numeros)
        {
            Palpites = numeros;
        }

        public void checarAcertos()
        {
            NumeroDeAcertos = 0;
            var resultado = tipoAposta.GetResultado();

            foreach (var num in resultado)
            {
                if (Palpites.Contains(num))
                {
                    NumeroDeAcertos++;
                }
            }
        }
    }
}
