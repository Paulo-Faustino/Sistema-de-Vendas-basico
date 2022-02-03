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
    public partial class usuarios : Form
    {
        DAL dal = new DAL();
        model.mUsuario user = new model.mUsuario();
        int pegarID;
        public usuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formularios.addUsuario adduser = new formularios.addUsuario();
            adduser.ShowDialog();
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            try
            {
                dgvusuarios.DataSource = dal.MostrarTabelaUsuarios();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tens Certeza?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes && pegarID != model.Global.idUsuarioLogado) 
            {
                user.idusuario = pegarID;
                dal.EliminarUsuario(user);
                MessageBox.Show("Usuário Eliminado com Sucesso");
                usuarios_Load(null, null);
            }
            else
            {
                MessageBox.Show("Usuário activo não pode ser eliminado");
            }
        }

        private void dgvusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pegarID = (int)dgvusuarios.Rows[e.RowIndex].Cells[0].Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            alterUsuario alterar = new alterUsuario();
            alterar.Show();
        }
    }
}
