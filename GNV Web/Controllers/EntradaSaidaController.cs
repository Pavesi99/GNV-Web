using GNV_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GNV_Web.Controllers
{
    [Route("EntradaSaida")]
    public class EntradaSaidaController : Controller
    {
        [Route("cadastro")]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [Route("")]
        [Route("listar")]
        public IActionResult List()
        {
            return View();
        }

        [Route("cadastrar")]
        [HttpPost]
        public IActionResult Cadastrar([FromBody] Local local )
        {
            return View();
        }
    }
}
