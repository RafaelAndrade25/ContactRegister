using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ContactRegister.Controllers
{
    [Route("[controller]")]
    public class ContatoController : Controller
    {
        
        private readonly ILogger<ContatoController> _logger;

        public ContatoController(ILogger<ContatoController> logger)
        {
            _logger = logger;
        }
        
        //Aqui você vai ter q indicar o mapeamento da rota pra chegar na sua action, quando elas tiverem parâmetros iguais
        //Observe que você criou dois IActionResult, Index e Error, com os mesmos parâmetros, e isso tava dando conflito no roteamento
        //Aqui eu usei o HttpGet pra mapear a rota do Index para "/Contato", e o mesmo HttpGet para mapear o Error para "/Contato/Error"
        //Isso é o mapeamento dos verbos HTTP para diferentes rotas, então vc pode usar HttpPost, HttpPut, HttpDelete para mapear as rotas
        //Nesse caso, que eu me lembre, vai tratar o /Contato se você tentar acessar com método POST, mas não tem problema acrescentar mais
        //anotações para os outros métodos, tipo assim [HttpPost("/Contato")]
        [HttpGet("/Contato")]
        public IActionResult Index()
        {
            return View();
        }

        //Vê depois na videoaula que você tá acompanhando sobre como vão ser tratadas as exceções, porque no Program.cs tem um mapeamento de uma
        //rota padrão de gerenciamento de exceções, então talvez vc vá ter que forçar algo para essa rota /Contato/Error que eu defini aqui
        //Mas de resto acho que tá OK, pelo menos forçando a rota a gente definiu o que tinha que ficar mesmo
        [HttpGet("/Contato/Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [HttpGet("/Criar")]
        public IActionResult Criar()
        {
            return View();
        }
        
        [HttpGet("/Editar")]
        public IActionResult Editar()
        {
            return View();
        }

        [HttpGet("/ApagarConfirmacao")]
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
    }
}