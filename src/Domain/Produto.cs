using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cursoEFCore.ValueObjects;

namespace cursoEFCore.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public string CodigoBarras { get; set; }
        public string Descricao { get; set; }
        public string Valor { get; set; }
        public TipoProduto tipoProduto { get; set; }
        public bool Ativo { get; set}
    }
}