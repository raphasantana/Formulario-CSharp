namespace Formulário
{
    partial class Colaborador
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
            this.Sair = new System.Windows.Forms.Button();
            this.VisualizarProdutos = new System.Windows.Forms.Button();
            this.CadastrarProdutos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.Sair);
            this.panel1.Controls.Add(this.VisualizarProdutos);
            this.panel1.Controls.Add(this.CadastrarProdutos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 98);
            this.panel1.TabIndex = 7;
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.SteelBlue;
            this.Sair.FlatAppearance.BorderSize = 0;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sair.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Sair.Location = new System.Drawing.Point(255, 19);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(108, 66);
            this.Sair.TabIndex = 7;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // VisualizarProdutos
            // 
            this.VisualizarProdutos.BackColor = System.Drawing.Color.SteelBlue;
            this.VisualizarProdutos.FlatAppearance.BorderSize = 0;
            this.VisualizarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisualizarProdutos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualizarProdutos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VisualizarProdutos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VisualizarProdutos.Location = new System.Drawing.Point(129, 19);
            this.VisualizarProdutos.Name = "VisualizarProdutos";
            this.VisualizarProdutos.Size = new System.Drawing.Size(120, 66);
            this.VisualizarProdutos.TabIndex = 4;
            this.VisualizarProdutos.Text = "Visualizar Produtos";
            this.VisualizarProdutos.UseVisualStyleBackColor = false;
            this.VisualizarProdutos.Click += new System.EventHandler(this.VisualizarProdutos_Click);
            // 
            // CadastrarProdutos
            // 
            this.CadastrarProdutos.BackColor = System.Drawing.Color.SteelBlue;
            this.CadastrarProdutos.FlatAppearance.BorderSize = 0;
            this.CadastrarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastrarProdutos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarProdutos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CadastrarProdutos.Location = new System.Drawing.Point(3, 19);
            this.CadastrarProdutos.Name = "CadastrarProdutos";
            this.CadastrarProdutos.Size = new System.Drawing.Size(120, 66);
            this.CadastrarProdutos.TabIndex = 3;
            this.CadastrarProdutos.Text = "Cadastro de Produtos";
            this.CadastrarProdutos.UseVisualStyleBackColor = false;
            this.CadastrarProdutos.Click += new System.EventHandler(this.CadastrarProdutos_Click);
            // 
            // Colaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 246);
            this.Controls.Add(this.panel1);
            this.Name = "Colaborador";
            this.Text = "Colaborador(a)";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button VisualizarProdutos;
        private System.Windows.Forms.Button CadastrarProdutos;
    }
}