namespace Gestao_Vendas.formularios
{
    partial class addClientes
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
            this.txtmorada = new System.Windows.Forms.TextBox();
            this.masktel = new System.Windows.Forms.MaskedTextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.panelerro = new System.Windows.Forms.Panel();
            this.labelerro = new System.Windows.Forms.Label();
            this.panelerro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registo de Clientes";
            // 
            // txtmorada
            // 
            this.txtmorada.Location = new System.Drawing.Point(140, 149);
            this.txtmorada.Multiline = true;
            this.txtmorada.Name = "txtmorada";
            this.txtmorada.Size = new System.Drawing.Size(340, 56);
            this.txtmorada.TabIndex = 11;
            // 
            // masktel
            // 
            this.masktel.Location = new System.Drawing.Point(140, 214);
            this.masktel.Mask = "999-000-000";
            this.masktel.Name = "masktel";
            this.masktel.Size = new System.Drawing.Size(201, 24);
            this.masktel.TabIndex = 10;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(140, 119);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(340, 24);
            this.txtnome.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Morada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(312, 263);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(144, 38);
            this.btncancel.TabIndex = 15;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btncad
            // 
            this.btncad.Location = new System.Drawing.Point(140, 263);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(144, 38);
            this.btncad.TabIndex = 14;
            this.btncad.Text = "Cadastrar";
            this.btncad.UseVisualStyleBackColor = true;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // panelerro
            // 
            this.panelerro.Controls.Add(this.labelerro);
            this.panelerro.Location = new System.Drawing.Point(6, 48);
            this.panelerro.Name = "panelerro";
            this.panelerro.Size = new System.Drawing.Size(637, 36);
            this.panelerro.TabIndex = 24;
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
            // addClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 360);
            this.Controls.Add(this.panelerro);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.txtmorada);
            this.Controls.Add(this.masktel);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addClientes";
            this.Load += new System.EventHandler(this.addClientes_Load);
            this.panelerro.ResumeLayout(false);
            this.panelerro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmorada;
        private System.Windows.Forms.MaskedTextBox masktel;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.Panel panelerro;
        private System.Windows.Forms.Label labelerro;
    }
}