using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SegundaApi.Models;

namespace SegundaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidosController : ControllerBase
    {

        private readonly ILogger<PedidosController> _logger;

        public PedidosController(ILogger<PedidosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Pedido> Get()
        {
            
            return Enumerable.Range(1, 5).Select(index => new Pedido
                {
                    Data = DateTime.Now.AddDays(-index),
                    Produto =$"Camisa tamanho : {index}", 
                    ClienteId = index,
                    Id = index
                    
                }).ToArray();
        }
        
        
        [HttpGet("{id}")]
        
        public IEnumerable<Pedido> Get(string id)
        {
            
            return   Enumerable.Range(1, 5).Select(index => new Pedido
                {
                    Data = DateTime.Now.AddDays(-index),
                    Produto =$"Camisa tamanho : {index}", 
                    ClienteId = index,
                    Id = index
                    
                })
                .ToArray().Where(x => x.ClienteId == Convert.ToInt32(id));;

            

        }
    }
}