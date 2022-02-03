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

namespace Gestao_Vendas
{
    public partial class Login : Form
    {
        DataTable dt = new DataTable();
        Form1 form;
        public Login(Form1 este)
        {
            InitializeComponent();
            form = este;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

      

        private bool validacao()
        {
            if(txtuser.Text.Trim() == String.Empty)
            {
                panelerro.BackColor = Color.Red;
                labelerro.Text = "Digite o nome";
                return false;
            }
            else if(txtsenha.Text.Trim() == String.Empty)
            {
                panelerro.BackColor = Color.Red;
                labelerro.Text = "Digite a senha";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string senha = encriptar(txtsenha.Text);
            try
            {
                model.mUsuario user = new model.mUsuario();
                DAL dal = new DAL();
                if (validacao())
                {
                    user.usuario = txtuser.Text;
                    user.senha = senha;
                    //dal.Login(user);
                    dt = dal.Login(user);
                    if(dt.Rows.Count == 1)
                    {
                        user.usuario = dt.Rows[0].Field<string>("usuario").ToString();
                        user.perfil = dt.Rows[0].Field<string>("perfil").ToString();
                        user.estado = dt.Rows[0].Field<int>("estado");    
                        model.Global.nivel = dt.Rows[0].Field<string>("perfil").ToString();
                        model.Global.idUsuarioLogado = dt.Rows[0].Field<int>("id");
                        model.Global.usuario = dt.Rows[0].Field<string>("usuario");
                        dal.UltimoLogin(model.Global.idUsuarioLogado);
                        this.Close();
                        
                    }
                    else
                    {
                        panelerro.BackColor = Color.Red;
                        labelerro.Text = "Usuário Desconhecido";
                    }
                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btncsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
