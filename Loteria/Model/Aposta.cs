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

        public Aposta(IJogo tipoAposta)
        {
            this.tipoAposta = tipoAposta;
        }

        public void GeraPalpiteAleatorio()
        {
            palpites = tipoAposta.GeraJogoAleatorio();
        }

        public void FazAposta(IList<int> numeros)
        {
            palpites = numeros;
        }
    }
}
