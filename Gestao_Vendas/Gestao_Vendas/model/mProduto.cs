using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Vendas.model
{
    class mProduto
    {
        public int idproduto { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public Int32 quantidade { get; set; }
        public DateTime datacriacao { get; set; }
        public DateTime dataalteracao { get; set; }
        public Int32 categoria { get; set; }
        public Int32 usuario { get; set; }

    }
}
