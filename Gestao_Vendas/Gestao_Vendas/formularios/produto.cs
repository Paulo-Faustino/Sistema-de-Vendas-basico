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
    public partial class produto : Form
    {
        model.mProduto pro = new model.mProduto();
        DAL dal = new DAL();
        int pegarIdProduto;
        DataTable dt = new DataTable();
        public produto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProduto produto = new addProduto();
            produto.ShowDialog();
        }

        private void produto_Load(object sender, EventArgs e)
        {
            try
            {
                DAL dal = new DAL();
                dgvproduto.DataSource = dal.MostrarTabelaProduto();
                model.Global.contarProduto = dgvproduto.Rows.Count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btncategoria_Click(object sender, EventArgs e)
        {
            categoria cat = new categoria();
            cat.Show();
        }

        private void dgvproduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pegarIdProduto = (int)dgvproduto.Rows[e.RowIndex].Cells[0].Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tens Certeza? ", "Eliminar Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res == DialogResult.Yes)
            {
                pro.idproduto = pegarIdProduto;
                dal.EliminarProduto(pro);
                MessageBox.Show("Dados elimados com sucesso");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            alterproduto alterproduto = new alterproduto();
            alterproduto.Show();
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
