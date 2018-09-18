using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loteria.Modal
{
    public class Sena : IJogo
    {
        private int numPalpites;
        private int numPossiveisPalpites;
        private IList<int> Resultado { get; }


        public Sena()
        {
            numPossiveisPalpites = 60;
            numPalpites = 6;
            Resultado = GeraSeisNumerosSena();
        }


        public IList<int> GeraJogoAleatorio()
        {
            return GeraSeisNumerosSena();
        }

        public IList<int> GetResultado()
        {
            return Resultado;
        }

        private IList<int> GeraSeisNumerosSena()
        {
            var rnd = new Random();
            var randomNumbers = Enumerable.Range(1, numPossiveisPalpites).OrderBy(x => rnd.Next()).Take(numPalpites).ToList();
            randomNumbers.Sort();

            return randomNumbers;
        }
    }
}

