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
    public partial class clientes : Form
    {
        DAL dal = new DAL();
        model.mCliente cli = new model.mCliente();
        int pegarid;
        public clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addClientes cli = new addClientes();
            cli.Show();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            
            DAL dal = new DAL();
            try
            {
                dgvclientes.DataSource = dal.MostrarTabelaCliente();
                model.Global.contarCliente = dgvclientes.Rows.Count;
                dgvclientes.Columns[0].Width = 45;
                dgvclientes.Columns[1].Width = 160;
                dgvclientes.Columns[2].Width = 100;
                dgvclientes.Columns[3].Width = 160;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void dgvclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pegarid = (int)dgvclientes.Rows[e.RowIndex].Cells[0].Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            alterCliente alter = new alterCliente();
            alter.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem certeza ?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if(res == DialogResult.Yes)
                {
                    cli.idcliente = pegarid;
                    dal.EliminarCliente(cli);
                    MessageBox.Show("Eliminar Clientes");
                    clientes_Load(null, null);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Esse cliente já efectuou uma compra");
            }
        }
    }
}
