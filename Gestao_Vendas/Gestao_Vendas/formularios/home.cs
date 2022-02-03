using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Vendas.formularios
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
            lb_nivel.Text = model.Global.nivel;
            lb_nome.Text = model.Global.usuario;
            lb_produto.Text = model.Global.contarProduto.ToString();
            lb_cliente.Text = model.Global.contarCliente.ToString();
            lb_vendas.Text = model.Global.contarVenda.ToString();
        }
    }
}
