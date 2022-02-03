namespace Gestao_Vendas.formularios
{
    partial class alterUsuario
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
            this.btneditar = new System.Windows.Forms.Button();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.cbxperfil = new System.Windows.Forms.ComboBox();
            this.cbxestado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(267, 327);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(144, 38);
            this.btncancel.TabIndex = 21;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(95, 327);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(144, 38);
            this.btneditar.TabIndex = 20;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(95, 148);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(316, 24);
            this.txtusuario.TabIndex = 18;
            // 
            // txtsenha
            // 
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(95, 194);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(316, 24);
            this.txtsenha.TabIndex = 17;
            this.txtsenha.UseSystemPasswordChar = true;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(95, 103);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(316, 24);
            this.txtnome.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Editar Usuário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(95, 59);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(76, 24);
            this.txtid.TabIndex = 28;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(185, 59);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(226, 26);
            this.btnpesquisar.TabIndex = 30;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // cbxperfil
            // 
            this.cbxperfil.FormattingEnabled = true;
            this.cbxperfil.Location = new System.Drawing.Point(95, 236);
            this.cbxperfil.Name = "cbxperfil";
            this.cbxperfil.Size = new System.Drawing.Size(316, 25);
            this.cbxperfil.TabIndex = 31;
            // 
            // cbxestado
            // 
            this.cbxestado.FormattingEnabled = true;
            this.cbxestado.Location = new System.Drawing.Point(95, 276);
            this.cbxestado.Name = "cbxestado";
            this.cbxestado.Size = new System.Drawing.Size(316, 25);
            this.cbxestado.TabIndex = 32;
            // 
            // alterUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 426);
            this.Controls.Add(this.cbxestado);
            this.Controls.Add(this.cbxperfil);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "alterUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "alterUsuario";
            this.Load += new System.EventHandler(this.alterUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.ComboBox cbxperfil;
        private System.Windows.Forms.ComboBox cbxestado;
    }
}