namespace Gestao_Vendas.formularios
{
    partial class alterCliente
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
            this.btncad = new System.Windows.Forms.Button();
            this.txtmorada = new System.Windows.Forms.TextBox();
            this.masktel = new System.Windows.Forms.MaskedTextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(268, 300);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(144, 38);
            this.btncancel.TabIndex = 24;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btncad
            // 
            this.btncad.Location = new System.Drawing.Point(96, 300);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(144, 38);
            this.btncad.TabIndex = 23;
            this.btncad.Text = "Editar";
            this.btncad.UseVisualStyleBackColor = true;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // txtmorada
            // 
            this.txtmorada.Location = new System.Drawing.Point(96, 136);
            this.txtmorada.Multiline = true;
            this.txtmorada.Name = "txtmorada";
            this.txtmorada.Size = new System.Drawing.Size(340, 56);
            this.txtmorada.TabIndex = 22;
            // 
            // masktel
            // 
            this.masktel.Location = new System.Drawing.Point(96, 201);
            this.masktel.Mask = "999-000-000";
            this.masktel.Name = "masktel";
            this.masktel.Size = new System.Drawing.Size(201, 23);
            this.masktel.TabIndex = 21;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(96, 106);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(340, 23);
            this.txtnome.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Morada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Editar Clientes";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(96, 67);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(78, 23);
            this.txtid.TabIndex = 26;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "ID";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(191, 64);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(245, 28);
            this.btnpesquisar.TabIndex = 27;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // alterCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 421);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.txtmorada);
            this.Controls.Add(this.masktel);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "alterCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.TextBox txtmorada;
        private System.Windows.Forms.MaskedTextBox masktel;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnpesquisar;
    }
}