using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Vendas.model
{
    class mVendaItem
    {
        public int idvenda { get; set; }
        public int idproduto { get; set; }
        public int quantidade { get; set; }
        public decimal total { get; set; }
        public decimal desconto { get; set; }
    }
}
