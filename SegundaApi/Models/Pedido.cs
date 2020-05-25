using System;

namespace SegundaApi.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public DateTime Data { get; set; }
        public int ClienteId { get; set; }
       
    }
}