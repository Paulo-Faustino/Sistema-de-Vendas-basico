using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Gestao_Vendas.formularios
{
    public partial class alterUsuario : Form
    {
        model.mUsuario user = new model.mUsuario();
        DAL dal = new DAL();
        DataTable dt = new DataTable();
        public alterUsuario()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            user.idusuario = int.Parse(txtid.Text);
            dt = dal.PesquisarUsuario(user);
            if(dt.Rows.Count > 0)
            {
                txtnome.Text = dt.Rows[0].Field<string>("nome").ToString();
                txtusuario.Text = dt.Rows[0].Field<string>("usuario").ToString();
                txtsenha.Text = dt.Rows[0].Field<string>("senha").ToString();
                cbxperfil.SelectedValue = dt.Rows[0].Field<string>("perfil").ToString();
                cbxestado.SelectedIndex = int.Parse(dt.Rows[0].Field<int>("estado").ToString());
            }
            else
            {
                MessageBox.Show("Usuário inexistente");
            }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.decNumero(sender, e);
        }

        private void alterUsuario_Load(object sender, EventArgs e)
        {
            //Populando a combbx perfil 

            Dictionary<string, string> dicperfil = new Dictionary<string, string>();
            dicperfil.Add("Padrao", "Padrao");
            dicperfil.Add("Admin", "Administrador");
            cbxperfil.DataSource = new BindingSource(dicperfil, null);
            cbxperfil.DisplayMember = "value";
            cbxperfil.ValueMember = "key";

            //Populando a combobox estado

            Dictionary<int, string> dicestado = new Dictionary<int, string>();
            dicestado.Add(0, "Desactivo");
            dicestado.Add(1, "Activo");
            cbxestado.DataSource = new BindingSource(dicestado, null);
            cbxestado.DisplayMember = "value";
            cbxestado.ValueMember = "key";
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            string senha = encriptar(txtsenha.Text);
            try
            {
                user.idusuario = int.Parse(txtid.Text);
                user.nome = txtnome.Text;
                user.senha = senha;
                user.usuario = txtusuario.Text;
                user.perfil = cbxperfil.SelectedValue.ToString();
                user.estado = (int)cbxestado.SelectedValue;
                dal.alterUsuario(user);
                MessageBox.Show("Dados alterados com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string encriptar(string senha)
        {
            //encriptar com md5 o texto recebido

            MD5 criador = MD5.Create();

            byte[] inputs = Encoding.ASCII.GetBytes(senha);
            byte[] hash = criador.ComputeHash(inputs);

            StringBuilder final = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                final.Append(hash[i].ToString("X"));
            }

            return final.ToString();
        }
    }
}
