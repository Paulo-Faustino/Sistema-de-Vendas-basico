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
    public partial class vendas : Form
    {
        model.mVenda venda = new model.mVenda();
        DAL dal = new DAL();
        int pegarID;
        public vendas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addVenda venda = new addVenda();
            venda.ShowDialog();
        }

        private void vendas_Load(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            try
            {
                dgvvendas.DataSource = dal.MostrarTabelaVenda();
                model.Global.contarVenda = dgvvendas.Rows.Count;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(model.Global.nivel == "Admin")
            {
                //
            }
            else
            {
                MessageBox.Show("Acesso não Permitido");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (model.Global.nivel == "Admin")
            {
                DialogResult res = MessageBox.Show("Tem Certeza ?", "Eliminar Registo Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(res == DialogResult.Yes)
                {
                    venda.idvenda = pegarID;
                    dal.EliminarRegistoVenda(venda);
                    MessageBox.Show("Registo Eliminado com sucesso");
                    vendas_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("Acesso não Permitido");
            }
        }

        private void dgvvendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pegarID = (int)dgvvendas.Rows[e.RowIndex].Cells[0].Value;

        }
    }
}
