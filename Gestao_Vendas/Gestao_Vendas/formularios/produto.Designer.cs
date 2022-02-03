namespace Gestao_Vendas.formularios
{
    partial class produto
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btncategoria = new System.Windows.Forms.Button();
            this.dgvproduto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produtos";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(210, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 34);
            this.button3.TabIndex = 26;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(411, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 34);
            this.button2.TabIndex = 25;
            this.button2.Text = "Apagar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncategoria
            // 
            this.btncategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategoria.Location = new System.Drawing.Point(612, 68);
            this.btncategoria.Name = "btncategoria";
            this.btncategoria.Size = new System.Drawing.Size(195, 34);
            this.btncategoria.TabIndex = 29;
            this.btncategoria.Text = "Categoria";
            this.btncategoria.UseVisualStyleBackColor = true;
            this.btncategoria.Click += new System.EventHandler(this.btncategoria_Click);
            // 
            // dgvproduto
            // 
            this.dgvproduto.AllowUserToAddRows = false;
            this.dgvproduto.AllowUserToDeleteRows = false;
            this.dgvproduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproduto.BackgroundColor = System.Drawing.Color.White;
            this.dgvproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduto.Location = new System.Drawing.Point(43, 253);
            this.dgvproduto.MultiSelect = false;
            this.dgvproduto.Name = "dgvproduto";
            this.dgvproduto.ReadOnly = true;
            this.dgvproduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproduto.Size = new System.Drawing.Size(795, 230);
            this.dgvproduto.TabIndex = 30;
            this.dgvproduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduto_CellClick);
            // 
            // produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 564);
            this.Controls.Add(this.dgvproduto);
            this.Controls.Add(this.btncategoria);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "produto";
            this.Text = "produto";
            this.Load += new System.EventHandler(this.produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btncategoria;
        private System.Windows.Forms.DataGridView dgvproduto;
    }
}