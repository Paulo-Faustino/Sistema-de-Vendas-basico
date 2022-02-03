namespace Gestao_Vendas.formularios
{
    partial class addVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtval = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.nupqtd = new System.Windows.Forms.NumericUpDown();
            this.cbxcliente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_qtd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_preco = new System.Windows.Forms.Label();
            this.cbxproduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_totvenda = new System.Windows.Forms.Label();
            this.lb_pago = new System.Windows.Forms.Label();
            this.lb_desconto = new System.Windows.Forms.Label();
            this.lb_troco = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnCarrinho = new System.Windows.Forms.Button();
            this.gbCarrinho = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.panelerro = new System.Windows.Forms.Panel();
            this.labelerro = new System.Windows.Forms.Label();
            this.checkiva = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupqtd)).BeginInit();
            this.panelerro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registo de Vendas";
            // 
            // txtval
            // 
            this.txtval.Location = new System.Drawing.Point(184, 361);
            this.txtval.MaxLength = 15;
            this.txtval.Name = "txtval";
            this.txtval.Size = new System.Drawing.Size(232, 26);
            this.txtval.TabIndex = 28;
            this.txtval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtval_KeyPress);
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(184, 328);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(232, 26);
            this.txtdes.TabIndex = 27;
            this.txtdes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdes_KeyPress);
            // 
            // nupqtd
            // 
            this.nupqtd.Location = new System.Drawing.Point(184, 289);
            this.nupqtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupqtd.Name = "nupqtd";
            this.nupqtd.Size = new System.Drawing.Size(232, 26);
            this.nupqtd.TabIndex = 26;
            this.nupqtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxcliente
            // 
            this.cbxcliente.FormattingEnabled = true;
            this.cbxcliente.Location = new System.Drawing.Point(184, 402);
            this.cbxcliente.Name = "cbxcliente";
            this.cbxcliente.Size = new System.Drawing.Size(232, 28);
            this.cbxcliente.TabIndex = 25;
            this.cbxcliente.SelectedIndexChanged += new System.EventHandler(this.cbxcliente_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(113, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Quantidade ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Desconto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Valor Pago";
            // 
            // lb_qtd
            // 
            this.lb_qtd.AutoSize = true;
            this.lb_qtd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qtd.Location = new System.Drawing.Point(187, 252);
            this.lb_qtd.Name = "lb_qtd";
            this.lb_qtd.Size = new System.Drawing.Size(21, 19);
            this.lb_qtd.TabIndex = 20;
            this.lb_qtd.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Quantidade Disponível";
            // 
            // lb_preco
            // 
            this.lb_preco.AutoSize = true;
            this.lb_preco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_preco.Location = new System.Drawing.Point(187, 222);
            this.lb_preco.Name = "lb_preco";
            this.lb_preco.Size = new System.Drawing.Size(40, 19);
            this.lb_preco.TabIndex = 17;
            this.lb_preco.Text = "0,00";
            // 
            // cbxproduto
            // 
            this.cbxproduto.FormattingEnabled = true;
            this.cbxproduto.Location = new System.Drawing.Point(184, 140);
            this.cbxproduto.Name = "cbxproduto";
            this.cbxproduto.Size = new System.Drawing.Size(232, 28);
            this.cbxproduto.TabIndex = 16;
            this.cbxproduto.SelectedIndexChanged += new System.EventHandler(this.cbxproduto_SelectedIndexChanged);
            this.cbxproduto.SelectedValueChanged += new System.EventHandler(this.cbxproduto_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Selecionar Produto";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(370, 614);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(103, 38);
            this.btncancel.TabIndex = 32;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(19, 614);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 38);
            this.btnLimpar.TabIndex = 31;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btncad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Valor Pago";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(111, 536);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Desconto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(111, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Total da venda";
            // 
            // lb_totvenda
            // 
            this.lb_totvenda.AutoSize = true;
            this.lb_totvenda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totvenda.Location = new System.Drawing.Point(225, 481);
            this.lb_totvenda.Name = "lb_totvenda";
            this.lb_totvenda.Size = new System.Drawing.Size(22, 16);
            this.lb_totvenda.TabIndex = 36;
            this.lb_totvenda.Text = "00";
            // 
            // lb_pago
            // 
            this.lb_pago.AutoSize = true;
            this.lb_pago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pago.Location = new System.Drawing.Point(225, 511);
            this.lb_pago.Name = "lb_pago";
            this.lb_pago.Size = new System.Drawing.Size(22, 16);
            this.lb_pago.TabIndex = 37;
            this.lb_pago.Text = "00";
            // 
            // lb_desconto
            // 
            this.lb_desconto.AutoSize = true;
            this.lb_desconto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_desconto.Location = new System.Drawing.Point(225, 536);
            this.lb_desconto.Name = "lb_desconto";
            this.lb_desconto.Size = new System.Drawing.Size(22, 16);
            this.lb_desconto.TabIndex = 38;
            this.lb_desconto.Text = "00";
            // 
            // lb_troco
            // 
            this.lb_troco.AutoSize = true;
            this.lb_troco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_troco.Location = new System.Drawing.Point(225, 560);
            this.lb_troco.Name = "lb_troco";
            this.lb_troco.Size = new System.Drawing.Size(22, 16);
            this.lb_troco.TabIndex = 40;
            this.lb_troco.Text = "00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(111, 560);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 16);
            this.label14.TabIndex = 39;
            this.label14.Text = "Troco";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(135, 614);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(103, 38);
            this.btnVender.TabIndex = 42;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.Location = new System.Drawing.Point(251, 614);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(103, 38);
            this.btnCarrinho.TabIndex = 41;
            this.btnCarrinho.Text = "Adicionar";
            this.btnCarrinho.UseVisualStyleBackColor = true;
            this.btnCarrinho.Click += new System.EventHandler(this.btnCarrinho_Click);
            // 
            // gbCarrinho
            // 
            this.gbCarrinho.BackColor = System.Drawing.Color.Gainsboro;
            this.gbCarrinho.Location = new System.Drawing.Point(562, 140);
            this.gbCarrinho.Name = "gbCarrinho";
            this.gbCarrinho.Size = new System.Drawing.Size(385, 411);
            this.gbCarrinho.TabIndex = 43;
            this.gbCarrinho.TabStop = false;
            this.gbCarrinho.Text = "Carrinho";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(92, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "Categoria";
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(184, 180);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.ReadOnly = true;
            this.txtcategoria.Size = new System.Drawing.Size(232, 26);
            this.txtcategoria.TabIndex = 45;
            // 
            // panelerro
            // 
            this.panelerro.Controls.Add(this.labelerro);
            this.panelerro.Location = new System.Drawing.Point(2, 41);
            this.panelerro.Name = "panelerro";
            this.panelerro.Size = new System.Drawing.Size(956, 44);
            this.panelerro.TabIndex = 46;
            // 
            // labelerro
            // 
            this.labelerro.AutoSize = true;
            this.labelerro.BackColor = System.Drawing.Color.White;
            this.labelerro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelerro.ForeColor = System.Drawing.Color.White;
            this.labelerro.Location = new System.Drawing.Point(306, 9);
            this.labelerro.Name = "labelerro";
            this.labelerro.Size = new System.Drawing.Size(69, 23);
            this.labelerro.TabIndex = 16;
            this.labelerro.Text = "label1";
            // 
            // checkiva
            // 
            this.checkiva.AutoSize = true;
            this.checkiva.Location = new System.Drawing.Point(184, 444);
            this.checkiva.Name = "checkiva";
            this.checkiva.Size = new System.Drawing.Size(55, 24);
            this.checkiva.TabIndex = 48;
            this.checkiva.Text = "IVA";
            this.checkiva.UseVisualStyleBackColor = true;
            // 
            // addVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 674);
            this.Controls.Add(this.checkiva);
            this.Controls.Add(this.panelerro);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gbCarrinho);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnCarrinho);
            this.Controls.Add(this.lb_troco);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lb_desconto);
            this.Controls.Add(this.lb_pago);
            this.Controls.Add(this.lb_totvenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtval);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.nupqtd);
            this.Controls.Add(this.cbxcliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_qtd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_preco);
            this.Controls.Add(this.cbxproduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "addVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addVenda";
            this.Load += new System.EventHandler(this.addVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupqtd)).EndInit();
            this.panelerro.ResumeLayout(false);
            this.panelerro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtval;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.NumericUpDown nupqtd;
        private System.Windows.Forms.ComboBox cbxcliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_qtd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_preco;
        private System.Windows.Forms.ComboBox cbxproduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_totvenda;
        private System.Windows.Forms.Label lb_pago;
        private System.Windows.Forms.Label lb_desconto;
        private System.Windows.Forms.Label lb_troco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnCarrinho;
        private System.Windows.Forms.GroupBox gbCarrinho;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Panel panelerro;
        private System.Windows.Forms.Label labelerro;
        private System.Windows.Forms.CheckBox checkiva;
    }
}