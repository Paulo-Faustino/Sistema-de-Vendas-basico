using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Vendas.model
{
    class mVenda
    {
        public int idvenda { get; set; }
        public decimal totalvenda { get; set; }
        public decimal valorpago { get; set; }
        public decimal troco { get; set; }
        public decimal desconto { get; set; }
        public decimal iva { get; set; }
        //public DateTime datavenda { get; set; }
        public int cliente { get; set; }
        public int usuario { get; set; }
    }
}
