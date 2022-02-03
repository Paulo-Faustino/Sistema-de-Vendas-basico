namespace Gestao_Vendas.formularios
{
    partial class vendas
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
            this.btncategoria = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvvendas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendas";
            // 
            // btncategoria
            // 
            this.btncategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategoria.Location = new System.Drawing.Point(642, 70);
            this.btncategoria.Name = "btncategoria";
            this.btncategoria.Size = new System.Drawing.Size(195, 34);
            this.btncategoria.TabIndex = 33;
            this.btncategoria.Text = "Item Venda";
            this.btncategoria.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(240, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 34);
            this.button3.TabIndex = 32;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(441, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 34);
            this.button2.TabIndex = 31;
            this.button2.Text = "Apagar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 34);
            this.button1.TabIndex = 30;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvvendas
            // 
            this.dgvvendas.AllowUserToAddRows = false;
            this.dgvvendas.AllowUserToDeleteRows = false;
            this.dgvvendas.BackgroundColor = System.Drawing.Color.White;
            this.dgvvendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvendas.Location = new System.Drawing.Point(14, 205);
            this.dgvvendas.MultiSelect = false;
            this.dgvvendas.Name = "dgvvendas";
            this.dgvvendas.ReadOnly = true;
            this.dgvvendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvvendas.Size = new System.Drawing.Size(855, 230);
            this.dgvvendas.TabIndex = 34;
            this.dgvvendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvendas_CellClick);
            // 
            // vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 564);
            this.Controls.Add(this.dgvvendas);
            this.Controls.Add(this.btncategoria);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "vendas";
            this.Text = "vendas";
            this.Load += new System.EventHandler(this.vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncategoria;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvvendas;
    }
}