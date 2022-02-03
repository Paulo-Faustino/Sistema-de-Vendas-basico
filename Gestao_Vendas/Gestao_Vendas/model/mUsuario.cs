using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_Vendas.model
{
    class mUsuario
    {
        public int idusuario { get; set; }
        public string nome { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string perfil { get; set; }
        public int estado { get; set; } 
        public DateTime datacriacao { get; set; }
        public  DateTime ultimologin { get; set; }
    }
}
