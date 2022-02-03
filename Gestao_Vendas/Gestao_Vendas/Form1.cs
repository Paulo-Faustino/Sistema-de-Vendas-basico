using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Login logar = new Login(this);
            logar.ShowDialog();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            formularios.home casa = new formularios.home();
            panelconteudo.Controls.Clear();
            casa.TopLevel = false;
            panelconteudo.Controls.Add(casa);
            casa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(model.Global.nivel == "Admin")
            {
                formularios.produto produt = new formularios.produto();
                panelconteudo.Controls.Clear();
                produt.TopLevel = false;
                panelconteudo.Controls.Add(produt);
                produt.Show();
            }
            else
            {
                MessageBox.Show("Acesso Não Permitido");
            }
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            if(model.Global.nivel == "Admin")
            {
                formularios.clientes cli = new formularios.clientes();
                panelconteudo.Controls.Clear();
                cli.TopLevel = false;
                panelconteudo.Controls.Add(cli);
                cli.Show();
            }
            else
            {
                MessageBox.Show("Acesso Não Permitido");
            }
        }

        private void btnvendas_Click(object sender, EventArgs e)
        {
            formularios.vendas venda = new formularios.vendas();
            panelconteudo.Controls.Clear();
            venda.TopLevel = false;
            panelconteudo.Controls.Add(venda);
            venda.Show();
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
           if(model.Global.nivel == "Admin")
            {
                formularios.usuarios user = new formularios.usuarios();
                panelconteudo.Controls.Clear();
                user.TopLevel = false;
                panelconteudo.Controls.Add(user);
                user.Show();
            }
            else
            {
                MessageBox.Show("Acesso Não Permitido");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Login log = new Login(this);
            this.Hide();
            log.Show();
        }
    }
}
