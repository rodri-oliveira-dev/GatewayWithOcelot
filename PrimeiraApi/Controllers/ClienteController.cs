using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrimeiraApi.Models;

namespace PrimeiraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        public ClienteController(ILogger<ClienteController> logger)
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