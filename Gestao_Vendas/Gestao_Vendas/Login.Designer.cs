namespace Gestao_Vendas
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncsair = new System.Windows.Forms.Button();
            this.panelerro = new System.Windows.Forms.Panel();
            this.labelerro = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panelerro.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnentrar);
            this.groupBox1.Controls.Add(this.txtsenha);
            this.groupBox1.Controls.Add(this.txtuser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(85, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(372, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tela de Acesso";
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.Gray;
            this.btnentrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnentrar.FlatAppearance.BorderSize = 0;
            this.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnentrar.Location = new System.Drawing.Point(20, 159);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(316, 38);
            this.btnentrar.TabIndex = 14;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(20, 116);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(316, 24);
            this.txtsenha.TabIndex = 12;
            this.txtsenha.Text = "0000";
            this.txtsenha.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(20, 59);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(316, 24);
            this.txtuser.TabIndex = 11;
            this.txtuser.Text = "atalaia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha";
            // 
            // btncsair
            // 
            this.btncsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncsair.FlatAppearance.BorderSize = 0;
            this.btncsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncsair.Location = new System.Drawing.Point(498, 3);
            this.btncsair.Name = "btncsair";
            this.btncsair.Size = new System.Drawing.Size(53, 38);
            this.btncsair.TabIndex = 15;
            this.btncsair.Text = "X";
            this.btncsair.UseVisualStyleBackColor = true;
            this.btncsair.Click += new System.EventHandler(this.btncsair_Click);
            // 
            // panelerro
            // 
            this.panelerro.Controls.Add(this.labelerro);
            this.panelerro.Controls.Add(this.btncsair);
            this.panelerro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelerro.Location = new System.Drawing.Point(0, 0);
            this.panelerro.Name = "panelerro";
            this.panelerro.Size = new System.Drawing.Size(555, 44);
            this.panelerro.TabIndex = 16;
            // 
            // labelerro
            // 
            this.labelerro.AutoSize = true;
            this.labelerro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelerro.ForeColor = System.Drawing.Color.White;
            this.labelerro.Location = new System.Drawing.Point(204, 12);
            this.labelerro.Name = "labelerro";
            this.labelerro.Size = new System.Drawing.Size(69, 23);
            this.labelerro.TabIndex = 16;
            this.labelerro.Text = "label1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 415);
            this.Controls.Add(this.panelerro);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelerro.ResumeLayout(false);
            this.panelerro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Button btncsair;
        private System.Windows.Forms.Panel panelerro;
        private System.Windows.Forms.Label labelerro;
    }
}