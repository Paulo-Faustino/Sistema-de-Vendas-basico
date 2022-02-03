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
    public partial class addClientes : Form
    {
        DAL dal = new DAL();
        model.mCliente cli = new model.mCliente();
        public addClientes()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidarCliente()
        {
            if (txtmorada.Text.Trim() == string.Empty || txtnome.Text.Trim() == string.Empty)
            {
                panelerro.BackColor = Color.Red;
                labelerro.Text = "Campos Obrigatórios";
                return false;
            }
            return true;
        }

        private void limparControles()
        {
            txtmorada.Clear();
            txtnome.Clear();
            masktel.Clear();
        }
        private void btncad_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCliente())
                {
                    cli.nome = txtnome.Text;
                    cli.telefone = masktel.Text;
                    cli.morada = txtmorada.Text;
                    dal.CadastrarCliente(cli);
                    panelerro.BackColor = Color.Lime;
                    labelerro.Text = "Dados Cadastrados com sucesso";
                    limparControles();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void addClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
