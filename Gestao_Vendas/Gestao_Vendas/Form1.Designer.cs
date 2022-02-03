namespace Gestao_Vendas
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelconteudo = new System.Windows.Forms.FlowLayoutPanel();
            this.btnsair = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnusuarios = new System.Windows.Forms.Button();
            this.btnvendas = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnsair);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnusuarios);
            this.panel1.Controls.Add(this.btnvendas);
            this.panel1.Controls.Add(this.btnclientes);
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 564);
            this.panel1.TabIndex = 0;
            // 
            // panelconteudo
            // 
            this.panelconteudo.BackColor = System.Drawing.Color.White;
            this.panelconteudo.Location = new System.Drawing.Point(212, -2);
            this.panelconteudo.Name = "panelconteudo";
            this.panelconteudo.Size = new System.Drawing.Size(907, 564);
            this.panelconteudo.TabIndex = 1;
            // 
            // btnsair
            // 
            this.btnsair.FlatAppearance.BorderSize = 0;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.Color.White;
            this.btnsair.Image = global::Gestao_Vendas.Properties.Resources.sair;
            this.btnsair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsair.Location = new System.Drawing.Point(3, 506);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(186, 50);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Gestao_Vendas.Properties.Resources.icons8_basket_30px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Produtos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnusuarios
            // 
            this.btnusuarios.FlatAppearance.BorderSize = 0;
            this.btnusuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuarios.ForeColor = System.Drawing.Color.White;
            this.btnusuarios.Image = global::Gestao_Vendas.Properties.Resources.icons8_administrator_male_30px;
            this.btnusuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusuarios.Location = new System.Drawing.Point(3, 358);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Size = new System.Drawing.Size(186, 50);
            this.btnusuarios.TabIndex = 3;
            this.btnusuarios.Text = "Usuários";
            this.btnusuarios.UseVisualStyleBackColor = true;
            this.btnusuarios.Click += new System.EventHandler(this.btnusuarios_Click);
            // 
            // btnvendas
            // 
            this.btnvendas.FlatAppearance.BorderSize = 0;
            this.btnvendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvendas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvendas.ForeColor = System.Drawing.Color.White;
            this.btnvendas.Image = global::Gestao_Vendas.Properties.Resources.icons8_return_purchase_30px;
            this.btnvendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvendas.Location = new System.Drawing.Point(3, 300);
            this.btnvendas.Name = "btnvendas";
            this.btnvendas.Size = new System.Drawing.Size(186, 50);
            this.btnvendas.TabIndex = 2;
            this.btnvendas.Text = "Vendas";
            this.btnvendas.UseVisualStyleBackColor = true;
            this.btnvendas.Click += new System.EventHandler(this.btnvendas_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.Color.White;
            this.btnclientes.Image = global::Gestao_Vendas.Properties.Resources.icons8_checked_user_male_30px;
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Location = new System.Drawing.Point(2, 248);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(186, 50);
            this.btnclientes.TabIndex = 1;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btnhome
            // 
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.Image = global::Gestao_Vendas.Properties.Resources.icons8_home_30px;
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(2, 139);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(186, 50);
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 562);
            this.Controls.Add(this.panelconteudo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnusuarios;
        private System.Windows.Forms.Button btnvendas;
        private System.Windows.Forms.Button btnclientes;
        public System.Windows.Forms.FlowLayoutPanel panelconteudo;
        public System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnsair;
    }
}

