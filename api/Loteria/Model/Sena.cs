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

        public int NumPalpites
        {
            get { return numPalpites; }
            set { numPalpites = 6; }
        }

        public int NumPossiveisPalpites
        {
            get { return numPossiveisPalpites; }
            set { numPossiveisPalpites = 60; }
        }

        public Sena()
        {
            Resultado = GeraResultado();
        }


        public IList<int> GeraJogoAleatorio()
        {
            return GeraSeisNumerosSena();
        }

        public IList<int> GeraResultado()
        {
            return GeraSeisNumerosSena();
        }

        private IList<int> GeraSeisNumerosSena()
        {
            var rnd = new Random();
            var randomNumbers = Enumerable.Range(1, NumPossiveisPalpites).OrderBy(x => rnd.Next()).Take(NumPalpites).ToList();
            randomNumbers.Sort();

            return randomNumbers;
        }
    }
}

