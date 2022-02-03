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
    public partial class categoria : Form
    {
        model.mCategoria cat = new model.mCategoria();
        DAL dal = new DAL();
        DataTable dt = new DataTable();
        public categoria()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool validarcat()
        {
            if(txtnome.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Escolha uma categoria");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btncad_Click(object sender, EventArgs e)
        {
            try
            {
                DAL dal = new DAL();
                model.mCategoria cat = new model.mCategoria();
                if (validarcat())
                {
                    cat.nome = txtnome.Text;
                    cat.descricao = txtdescricao.Text;
                    dal.CadastrarCategoria(cat);
                    MessageBox.Show("Categoria inserida com sucesso");
                    limparControles();
                }
            }catch(Exception )
            {
                MessageBox.Show("Categoria já existe");
            }
        }

        private void limparControles()
        {
            txtid.Clear();
            txtnome.Clear();
            txtdescricao.Clear();
        }
        private void desabilitarBotoes()
        {
            btndelete.Enabled = false;
            btnalterar.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.decNumero(sender, e);
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                cat.idcategoria = int.Parse(txtid.Text);
                dt = dal.PesquisarCategoria(cat);
                txtnome.Text = dt.Rows[0].Field<string>("nome").ToString();
                txtdescricao.Text = dt.Rows[0].Field<string>("descricao").ToString();
                btnalterar.Enabled = true;
                btndelete.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Categoria não encontrada");
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo eliminar ? ", "Eliminar Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {

                if (res == DialogResult.Yes)
                {
                    cat.idcategoria = int.Parse(txtid.Text);
                    dal.EliminarCategoria(cat);
                    MessageBox.Show("Dados eliminados com sucesso");
                    limparControles();
                }
            }catch (Exception)
            {
                MessageBox.Show("Categoria Inexistente");
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            try
            {
                cat.idcategoria = int.Parse(txtid.Text);
                cat.nome = txtnome.Text;
                cat.descricao = txtdescricao.Text;
                dal.alterarCategoria(cat);
                MessageBox.Show("Dados alterardos com sucesso");
                limparControles();
                desabilitarBotoes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
