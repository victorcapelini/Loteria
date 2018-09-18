using Loteria.Modal;
using System;
using Xunit;

namespace TestaJogo
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IJogo jogo = new Sena();

            var resultado = jogo.GeraResultado();

            foreach(var res in resultado)
            {
                Console.WriteLine(res);
            }

            Console.ReadKey();
        }
    }
}
