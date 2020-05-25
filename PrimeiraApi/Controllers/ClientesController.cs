using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrimeiraApi.Models;

namespace PrimeiraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly ILogger<ClientesController> _logger;
        public ClientesController(ILogger<ClientesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Cliente()
                {
                    Id =  index,
                    Nome = $"Cliente - {index}"
                }).ToArray();
        }
    }
}