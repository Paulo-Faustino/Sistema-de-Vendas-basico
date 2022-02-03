namespace Gestao_Vendas.formularios
{
    partial class categoria
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
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adicionar Categoria";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(102, 152);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(302, 59);
            this.txtdescricao.TabIndex = 21;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(102, 120);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(302, 23);
            this.txtnome.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Descrição";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(367, 268);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(144, 38);
            this.btncancel.TabIndex = 24;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btncad
            // 
            this.btncad.Location = new System.Drawing.Point(35, 268);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(144, 38);
            this.btncad.TabIndex = 23;
            this.btncad.Text = "Cadastrar";
            this.btncad.UseVisualStyleBackColor = true;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(189, 66);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(215, 27);
            this.btnpesquisar.TabIndex = 25;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(102, 68);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(83, 23);
            this.txtid.TabIndex = 27;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nome";
            // 
            // btndelete
            // 
            this.btndelete.Enabled = false;
            this.btndelete.Location = new System.Drawing.Point(35, 313);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(476, 38);
            this.btndelete.TabIndex = 28;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Enabled = false;
            this.btnalterar.Location = new System.Drawing.Point(190, 268);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(162, 38);
            this.btnalterar.TabIndex = 29;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 371);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnalterar;
    }
}