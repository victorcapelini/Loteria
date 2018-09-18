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
        Jogadores jogadores = new Jogadores();
       
        // GET: api/Jogador
        [HttpGet]
        public IEnumerable<string> Get()
        {
            this.jogadores.AddJogador(new Jogador("Victor"));
            this.jogadores.AddJogador(new Jogador("Jessica"));
            return new string[] { jogadores.GetJogadorPorPosicao(0).Nome };
        }

        // GET: api/Jogador/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            this.jogadores.AddJogador(new Jogador("Jose"));
            var nome = jogadores.GetJogadorPorPosicao(id).Nome;
            return nome;
        }

        // POST: api/Jogador
        [HttpPost]
        public void Post(string value)
        {
            Jogador jogador = new Jogador(value);
            this.jogadores.AddJogador(jogador);
        }

        // PUT: api/Jogador/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
