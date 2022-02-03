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
    public partial class addProduto : Form
    {
        DAL dal = new DAL();
        model.mProduto produto = new model.mProduto();
        DataTable dt = new DataTable();
        public addProduto()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.decNumero(sender,e);
        }

        private void addProduto_Load(object sender, EventArgs e)
        {
            cbxcategoria.DataSource = dal.MostrarTabelaCategoria();
            cbxcategoria.DisplayMember = "nome";
            cbxcategoria.ValueMember = "id";
        }

        private bool validarProduto()
        {
            if(txtnome.Text.Trim() == string.Empty || nudqtd.Value == 0 || txtpreco.Text.Trim() == string.Empty)
            {
                panelerro.BackColor = Color.Red;
                labelerro.Text = "Campos Obrigatórios";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void limparcontroles()
        {
            txtdescricao.Clear();
            txtnome.Clear();
            txtpreco.Clear();
            cbxcategoria.SelectedValue = -1;
            nudqtd.Value = 0;
        }

        private void btncad_Click(object sender, EventArgs e)
        {
            dt = dal.MostrarTabelaUsuarios();
            Int32 user = dt.Rows[0].Field<int>("id");

            try
            {
                if (validarProduto())
                {
                    produto.nome = txtnome.Text;
                    produto.descricao = txtdescricao.Text;
                    produto.preco = decimal.Parse(txtpreco.Text);
                    produto.quantidade = Int32.Parse(Math.Round(nudqtd.Value,0).ToString());
                    produto.categoria = (Int32)cbxcategoria.SelectedValue;
                    produto.usuario = user;
                    dal.CadastrarProduto(produto);
                    panelerro.BackColor = Color.Lime;
                    labelerro.Text = "Dados Cadastrados com sucesso";
                    limparcontroles();
                    addProduto_Load(null, null);
                }
            }
            catch (Exception )
            {
                panelerro.BackColor = Color.Red;
                labelerro.Text = "Produto Já existente";
            }
        }
    }
}
