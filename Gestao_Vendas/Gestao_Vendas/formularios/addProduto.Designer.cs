namespace Gestao_Vendas.formularios
{
    partial class addProduto
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
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.nudqtd = new System.Windows.Forms.NumericUpDown();
            this.cbxcategoria = new System.Windows.Forms.ComboBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.panelerro = new System.Windows.Forms.Panel();
            this.labelerro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudqtd)).BeginInit();
            this.panelerro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registo de Produtos";
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(128, 297);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(302, 24);
            this.txtpreco.TabIndex = 20;
            this.txtpreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreco_KeyPress);
            // 
            // nudqtd
            // 
            this.nudqtd.Location = new System.Drawing.Point(128, 259);
            this.nudqtd.Name = "nudqtd";
            this.nudqtd.Size = new System.Drawing.Size(302, 24);
            this.nudqtd.TabIndex = 19;
            // 
            // cbxcategoria
            // 
            this.cbxcategoria.FormattingEnabled = true;
            this.cbxcategoria.Location = new System.Drawing.Point(128, 217);
            this.cbxcategoria.Name = "cbxcategoria";
            this.cbxcategoria.Size = new System.Drawing.Size(302, 26);
            this.cbxcategoria.TabIndex = 18;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(128, 142);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(302, 59);
            this.txtdescricao.TabIndex = 17;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(128, 102);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(302, 24);
            this.txtnome.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Preço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descrição";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(300, 344);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(144, 38);
            this.btncancel.TabIndex = 22;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btncad
            // 
            this.btncad.Location = new System.Drawing.Point(128, 344);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(144, 38);
            this.btncad.TabIndex = 21;
            this.btncad.Text = "Cadastrar";
            this.btncad.UseVisualStyleBackColor = true;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // panelerro
            // 
            this.panelerro.Controls.Add(this.labelerro);
            this.panelerro.Location = new System.Drawing.Point(3, 47);
            this.panelerro.Name = "panelerro";
            this.panelerro.Size = new System.Drawing.Size(668, 36);
            this.panelerro.TabIndex = 23;
            // 
            // labelerro
            // 
            this.labelerro.AutoSize = true;
            this.labelerro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelerro.ForeColor = System.Drawing.Color.White;
            this.labelerro.Location = new System.Drawing.Point(268, 5);
            this.labelerro.Name = "labelerro";
            this.labelerro.Size = new System.Drawing.Size(0, 25);
            this.labelerro.TabIndex = 0;
            // 
            // addProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 456);
            this.Controls.Add(this.panelerro);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.nudqtd);
            this.Controls.Add(this.cbxcategoria);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addProduto";
            this.Load += new System.EventHandler(this.addProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudqtd)).EndInit();
            this.panelerro.ResumeLayout(false);
            this.panelerro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.NumericUpDown nudqtd;
        private System.Windows.Forms.ComboBox cbxcategoria;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.Panel panelerro;
        private System.Windows.Forms.Label labelerro;
    }
}