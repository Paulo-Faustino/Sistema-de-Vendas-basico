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
    public partial class alterproduto : Form
    {
        DAL dal = new DAL();
        model.mProduto prod = new model.mProduto();
        DataTable dt = new DataTable();
        public alterproduto()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncad_Click(object sender, EventArgs e)
        {
            

            try
            {
                prod.idproduto = int.Parse(txtid.Text);
                dt = dal.EditarProduto(prod);
                if(dt.Rows.Count > 0)
                {
                    btnalterar.Enabled = true;
                    txtnome.Text = dt.Rows[0].Field<string>("nome").ToString();
                    txtdescricao.Text = dt.Rows[0].Field<string>("descricao").ToString();
                    txtpreco.Text = dt.Rows[0].Field<decimal>("preco").ToString();
                    nudqtd.Value = dt.Rows[0].Field<Int32>("quantidade");
                    cbxcategoria.SelectedValue = dt.Rows[0].Field<Int32>("categoria_id");
                }
                else
                {
                    MessageBox.Show("Vamos terminar hoje");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.decNumero(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                prod.idproduto = int.Parse(txtid.Text);
                prod.nome = txtnome.Text;
                prod.descricao = txtdescricao.Text;
                prod.preco = decimal.Parse(txtpreco.Text);
                prod.quantidade = Int32.Parse(Math.Round(nudqtd.Value, 0).ToString());
                prod.categoria = (Int32)cbxcategoria.SelectedValue;
                dal.alterProduto(prod);
                MessageBox.Show("Dados Editados com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Produto Existente");
            }
        }

        private void alterproduto_Load(object sender, EventArgs e)
        {
            cbxcategoria.DataSource = dal.MostrarTabelaCategoria();
            cbxcategoria.DisplayMember = "nome";
            cbxcategoria.ValueMember = "id";
        }
    }
}
