using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cursoEFCore.Domain
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int Cliente Cliente { get; set; }
        public int DateTime IniciadoEm { get; set; }
        public int DateTime FinalizadoEm { get; set; }
        public int TipoFrete TipoFrete { get; set; }
        public int StatusPedido Status { get; set; }
        public string Observacao { get; set; }
        public ICollection<PedidoItem> Itens { get; set; }

    }
}