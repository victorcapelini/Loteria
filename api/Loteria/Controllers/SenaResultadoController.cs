using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loteria.Modal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Loteria.Controllers
{
    [Produces("application/json")]
    [Route("api/Jogos/Sena/Resultado")]
    public class SenaResultadoController : Controller
    {
        IJogo jogo = new Sena();
        // GET: api/Jogos/Sena
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { String.Join(",", jogo.GetResultado())};
        }

    }
}
