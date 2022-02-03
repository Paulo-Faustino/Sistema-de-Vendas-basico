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
    public partial class addVenda : Form
    {
        DAL dal = new DAL();
        model.mVenda venda = new model.mVenda();
        model.mProduto produto = new model.mProduto();
        DataTable dt = new DataTable();
        string nomePrdotuo = " ";
        double totVenda;
        double preco;
        int quantidade;
        double iva = 0;
        int qtdDisponivel;

        public addVenda()
        {
            InitializeComponent();
        }

        private void txtval_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.decNumero(sender, e);
        }

        private void txtdes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.decNumero(sender, e);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addVenda_Load(object sender, EventArgs e)
        {
            //Populando a cbbx cliente

            cbxcliente.DataSource = dal.MostrarClien().Tables[0];
            cbxcliente.DisplayMember = "nome";
            cbxcliente.ValueMember = "id";

            //Populando a cbbx produto

            cbxproduto.DataSource = dal.MostrarProduto().Tables[0];
            cbxproduto.DisplayMember = "nome";
            cbxproduto.ValueMember = "id";       
            
        }

        private void limparErros()
        {
            panelerro.BackColor = Color.White;
            labelerro.BackColor = Color.White;
        }
        private void novoErro()
        {
            limparErros();
            panelerro.BackColor = Color.Red;
            labelerro.BackColor = Color.Red;
            labelerro.ForeColor = Color.White;
        }

        private void semErros()
        {
            panelerro.BackColor = Color.Lime;
            labelerro.BackColor = Color.Lime;
        }


        private void limparControles()
        {
            cbxproduto.SelectedValue = -1;
            cbxcliente.SelectedValue = -1;
            nupqtd.Value = 1;
            checkiva.Checked = false;
            txtdes.Clear();
            txtcategoria.Clear();
            txtval.Clear();
            lb_desconto.Text = "00";
            lb_pago.Text = "00";
            lb_preco.Text = "00";
            lb_qtd.Text = "00";
            lb_totvenda.Text = "00";
            lb_troco.Text = "00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double desconto;
            double valorPago;
            double troco = 0;

            quantidade = int.Parse((nupqtd.Value).ToString());

            if(txtdes.Text == string.Empty)
            {
                desconto = 0;
            }
            else
            {
                desconto = double.Parse(txtdes.Text);
            }

            //Validar a Quantidade

            if (quantidade > qtdDisponivel)
            {
                novoErro();
                labelerro.Text = "Quantidade Indisponível ";
                return;
            }
            model.Global.qtdRestanteDoProduto = qtdDisponivel - quantidade;

            //Validar o valor

            if (txtval.Text == string.Empty)
            {
                novoErro();
                labelerro.Text = "Não se pode efecutar uma venda sem pagamentos";
                return;
            }
            else
            {
                valorPago = double.Parse(txtval.Text);
                limparErros();
            }
       

            //IVA

            if (checkiva.Checked)
            {
                iva = 0.14;
                totVenda = ((preco * quantidade) + (preco * quantidade) * iva) - desconto;
            }
            else
            {            
                totVenda = (preco * quantidade) - desconto;
            }

            //Desconto

            if(desconto > totVenda * 0.10)
            {
                novoErro();
                labelerro.Text = "O desconto não pode ser maior que 10%";
                return;
            }



             if (totVenda > valorPago)
             {
                    novoErro();
                    labelerro.Text = "O seu valor não lhe permite efectuar essa compra";
                    troco = 0;
                    lb_troco.Text = troco.ToString();
                    return;
             }
             else
             {
                troco = valorPago - totVenda;
                lb_troco.Text = troco.ToString();
             }

                lb_desconto.Text = desconto.ToString();
                lb_pago.Text = valorPago.ToString();
                lb_totvenda.Text = totVenda.ToString();

            try
            {

                venda.totalvenda = (decimal)totVenda;
                venda.valorpago = (decimal)valorPago;
                venda.troco = (decimal)troco;
                venda.desconto = (decimal)desconto;
                venda.iva = (decimal)iva;
                venda.cliente = (int)cbxcliente.SelectedValue;
                venda.usuario = model.Global.idUsuarioLogado;
                // actualizar a quantidade do produto vendido;
                produto.quantidade = model.Global.qtdRestanteDoProduto;

                dal.Vender(venda);
                dal.actualizarQtdProduto(produto);
                limparErros();
                limparControles();
                semErros();
                labelerro.Text = "Venda Efectuada com sucesso";

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void cbxcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
                 
        }

        private void cbxproduto_SelectedIndexChanged(object sender, EventArgs e)
        {         

        }

        private void cbxproduto_SelectedValueChanged(object sender, EventArgs e)
        {
            nomePrdotuo = cbxproduto.Text;
            try
            {
                dt = dal.RetornarProdutoSelecionado(nomePrdotuo);
                txtcategoria.Text = dt.Rows[0].Field<int>("categoria_id").ToString();
                preco = Double.Parse(Math.Round(dt.Rows[0].Field<decimal>("preco"),0).ToString());
                lb_preco.Text = preco.ToString();
                qtdDisponivel = dt.Rows[0].Field<int>("quantidade");
                lb_qtd.Text = qtdDisponivel.ToString();
                model.Global.pegarIdProdutoSelecionado = dt.Rows[0].Field<int>("id");
               
            }
            catch (Exception)
            {

            }
        }

        private void btncad_Click(object sender, EventArgs e)
        {
            limparControles();
        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            
        }
    }
}
