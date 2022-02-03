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
    public partial class addUsuario : Form
    {
        DAL dal = new DAL();
        model.mUsuario user = new model.mUsuario();
        public addUsuario()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool validarControles()
        {
            if(txtnome.Text.Trim()==string.Empty || txtusuario.Text.Trim() == string.Empty || txtsenha.Text == string.Empty || cbxperfil.Text == string.Empty)
            {
                panelerro.BackColor = Color.Red;
                labelerro.Text = "Campos Obrigatórios";
                return false;
            }

            return true;
        }

        private void btncad_Click(object sender, EventArgs e)
        {
            string criptgrafar = encriptar(txtsenha.Text);

            try
            {
                if (validarControles())
                {
                    user.nome = txtnome.Text;
                    user.usuario = txtusuario.Text;
                    user.senha = criptgrafar;
                    user.perfil = cbxperfil.SelectedValue.ToString();
                    user.estado = (int)cbxestado.SelectedValue;

                    dal.CadastrarUsuario(user);
                    panelerro.BackColor = Color.Lime;
                    labelerro.Text = "Dados Cadastrados com sucesso";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void addUsuario_Load(object sender, EventArgs e)
        {
            //Populano a combobox Perfil

            Dictionary<string, string> dicPerfil = new Dictionary<string, string>();
            dicPerfil.Add("Padrao", "Padrao");
            dicPerfil.Add("Admin", "Administrador");

            cbxperfil.DataSource = new BindingSource(dicPerfil, null);
            cbxperfil.DisplayMember = "value";
            cbxperfil.ValueMember = "key";

            //Populando a combobox estado
            Dictionary<int, string> dicEstado = new Dictionary<int, string>();
            dicEstado.Add(1, "Activo");
            dicEstado.Add(0, "Desativo");

            cbxestado.DataSource = new BindingSource(dicEstado, null);
            cbxestado.DisplayMember = "value";
            cbxestado.ValueMember = "key";

        }

        //Encriptar
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
