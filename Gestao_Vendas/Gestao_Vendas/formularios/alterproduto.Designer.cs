namespace Gestao_Vendas.formularios
{
    partial class alterproduto
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnprocurar = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnalterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudqtd)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(343, 345);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(144, 38);
            this.btncancel.TabIndex = 35;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnprocurar
            // 
            this.btnprocurar.Location = new System.Drawing.Point(284, 61);
            this.btnprocurar.Name = "btnprocurar";
            this.btnprocurar.Size = new System.Drawing.Size(189, 26);
            this.btnprocurar.TabIndex = 34;
            this.btnprocurar.Text = "Procurar";
            this.btnprocurar.UseVisualStyleBackColor = true;
            this.btnprocurar.Click += new System.EventHandler(this.btncad_Click);
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(171, 277);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(302, 23);
            this.txtpreco.TabIndex = 33;
            // 
            // nudqtd
            // 
            this.nudqtd.Location = new System.Drawing.Point(171, 239);
            this.nudqtd.Name = "nudqtd";
            this.nudqtd.Size = new System.Drawing.Size(302, 23);
            this.nudqtd.TabIndex = 32;
            // 
            // cbxcategoria
            // 
            this.cbxcategoria.FormattingEnabled = true;
            this.cbxcategoria.Location = new System.Drawing.Point(171, 197);
            this.cbxcategoria.Name = "cbxcategoria";
            this.cbxcategoria.Size = new System.Drawing.Size(302, 25);
            this.cbxcategoria.TabIndex = 31;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(171, 131);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(302, 59);
            this.txtdescricao.TabIndex = 30;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(171, 98);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(302, 23);
            this.txtnome.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Preço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "Editar Produtos";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(171, 64);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(95, 23);
            this.txtid.TabIndex = 37;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "ID";
            // 
            // btnalterar
            // 
            this.btnalterar.Enabled = false;
            this.btnalterar.Location = new System.Drawing.Point(171, 345);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(144, 38);
            this.btnalterar.TabIndex = 38;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.button1_Click);
            // 
            // alterproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 415);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnprocurar);
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
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "alterproduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "alterproduto";
            this.Load += new System.EventHandler(this.alterproduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudqtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnprocurar;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnalterar;
    }
}