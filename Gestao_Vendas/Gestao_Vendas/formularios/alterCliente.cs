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
    public partial class alterCliente : Form
    {
        model.mCliente cli = new model.mCliente();
        DAL dal = new DAL();
        DataTable dt = new DataTable();
        public alterCliente()
        {
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            cli.idcliente = int.Parse(txtid.Text);
            dt = dal.EditarCliente(cli);
            if(dt.Rows.Count > 0)
            {
                txtnome.Text = dt.Rows[0].Field<string>("nome").ToString();
                txtmorada.Text = dt.Rows[0].Field<string>("morada").ToString();
                masktel.Text = dt.Rows[0].Field<string>("telefone").ToString();
            }
            else
            {
                MessageBox.Show("Não Existe");
            }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.decNumero(sender, e);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncad_Click(object sender, EventArgs e)
        {
            try
            {
                cli.idcliente = int.Parse(txtid.Text);
                cli.nome = txtnome.Text;
                cli.morada = txtmorada.Text;
                cli.telefone = masktel.Text;
                dal.alterCliente(cli);
                MessageBox.Show("Dados alterados com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
