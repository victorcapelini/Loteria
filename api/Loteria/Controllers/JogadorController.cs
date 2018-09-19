using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loteria.Apoio;
using Loteria.Modal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Loteria.Controllers
{

    [Produces("application/json")]
    [Route("api/Jogador")]
    public class JogadorController : Controller
    {
        static Jogadores jogadores = new Jogadores();

        // GET: api/Jogador
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { jogadores.GetTodosJogadores() };
        }

        // GET: api/Jogador/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            try
            {
                var nome = jogadores.GetJogadorPorPosicao(id).Nome;
                return nome;
            }
            catch (ArgumentOutOfRangeException e)
            {
                return "A posicao nao possui jogador";
            }
        }

        // POST: api/Jogador
        [HttpPost]
        public void Post(string value)
        {
            Jogador jogador = new Jogador(value);
            jogadores.AddJogador(jogador);
        }

    }
}
