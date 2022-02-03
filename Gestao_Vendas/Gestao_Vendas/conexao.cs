using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestao_Vendas
{
    class conexao
    {
        public static string stringcon
        {
            get
            {
                return "server=localhost;port=3306;username=root;password=;database = db_gestaovenda";
            }
        }
    }
}
