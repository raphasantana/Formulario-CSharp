namespace Formulário
{
    partial class VisualizarProdutos
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
            this.DG = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Nome = new MetroFramework.Controls.MetroTextBox();
            this.Empresa = new MetroFramework.Controls.MetroTextBox();
            this.Quantidade = new MetroFramework.Controls.MetroTextBox();
            this.Preco = new MetroFramework.Controls.MetroTextBox();
            this.Codigo = new MetroFramework.Controls.MetroTextBox();
            this.Salvar = new MetroFramework.Controls.MetroButton();
            this.Editar = new MetroFramework.Controls.MetroButton();
            this.Excluir = new MetroFramework.Controls.MetroButton();
            this.Labelerro = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // DG
            // 
            this.DG.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(23, 63);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(580, 130);
            this.DG.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(81, 249);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Nome:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(67, 288);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Empresa:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(343, 249);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Preço (R$):";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(49, 337);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Quantidade:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(300, 292);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(116, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Código de Barras:";
            // 
            // Nome
            // 
            // 
            // 
            // 
            this.Nome.CustomButton.Image = null;
            this.Nome.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.Nome.CustomButton.Name = "";
            this.Nome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Nome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Nome.CustomButton.TabIndex = 1;
            this.Nome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Nome.CustomButton.UseSelectable = true;
            this.Nome.CustomButton.Visible = false;
            this.Nome.Lines = new string[0];
            this.Nome.Location = new System.Drawing.Point(136, 249);
            this.Nome.MaxLength = 32767;
            this.Nome.Name = "Nome";
            this.Nome.PasswordChar = '\0';
            this.Nome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Nome.SelectedText = "";
            this.Nome.SelectionLength = 0;
            this.Nome.SelectionStart = 0;
            this.Nome.ShortcutsEnabled = true;
            this.Nome.Size = new System.Drawing.Size(133, 23);
            this.Nome.TabIndex = 5;
            this.Nome.UseSelectable = true;
            this.Nome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Nome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Empresa
            // 
            // 
            // 
            // 
            this.Empresa.CustomButton.Image = null;
            this.Empresa.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.Empresa.CustomButton.Name = "";
            this.Empresa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Empresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Empresa.CustomButton.TabIndex = 1;
            this.Empresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Empresa.CustomButton.UseSelectable = true;
            this.Empresa.CustomButton.Visible = false;
            this.Empresa.Lines = new string[0];
            this.Empresa.Location = new System.Drawing.Point(136, 292);
            this.Empresa.MaxLength = 32767;
            this.Empresa.Name = "Empresa";
            this.Empresa.PasswordChar = '\0';
            this.Empresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Empresa.SelectedText = "";
            this.Empresa.SelectionLength = 0;
            this.Empresa.SelectionStart = 0;
            this.Empresa.ShortcutsEnabled = true;
            this.Empresa.Size = new System.Drawing.Size(133, 23);
            this.Empresa.TabIndex = 6;
            this.Empresa.UseSelectable = true;
            this.Empresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Empresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Quantidade
            // 
            // 
            // 
            // 
            this.Quantidade.CustomButton.Image = null;
            this.Quantidade.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.Quantidade.CustomButton.Name = "";
            this.Quantidade.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Quantidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Quantidade.CustomButton.TabIndex = 1;
            this.Quantidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Quantidade.CustomButton.UseSelectable = true;
            this.Quantidade.CustomButton.Visible = false;
            this.Quantidade.Lines = new string[0];
            this.Quantidade.Location = new System.Drawing.Point(136, 337);
            this.Quantidade.MaxLength = 32767;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.PasswordChar = '\0';
            this.Quantidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Quantidade.SelectedText = "";
            this.Quantidade.SelectionLength = 0;
            this.Quantidade.SelectionStart = 0;
            this.Quantidade.ShortcutsEnabled = true;
            this.Quantidade.Size = new System.Drawing.Size(133, 23);
            this.Quantidade.TabIndex = 7;
            this.Quantidade.UseSelectable = true;
            this.Quantidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Quantidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Preco
            // 
            // 
            // 
            // 
            this.Preco.CustomButton.Image = null;
            this.Preco.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.Preco.CustomButton.Name = "";
            this.Preco.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Preco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Preco.CustomButton.TabIndex = 1;
            this.Preco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Preco.CustomButton.UseSelectable = true;
            this.Preco.CustomButton.Visible = false;
            this.Preco.Lines = new string[0];
            this.Preco.Location = new System.Drawing.Point(422, 249);
            this.Preco.MaxLength = 32767;
            this.Preco.Name = "Preco";
            this.Preco.PasswordChar = '\0';
            this.Preco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Preco.SelectedText = "";
            this.Preco.SelectionLength = 0;
            this.Preco.SelectionStart = 0;
            this.Preco.ShortcutsEnabled = true;
            this.Preco.Size = new System.Drawing.Size(133, 23);
            this.Preco.TabIndex = 8;
            this.Preco.UseSelectable = true;
            this.Preco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Preco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Codigo
            // 
            // 
            // 
            // 
            this.Codigo.CustomButton.Image = null;
            this.Codigo.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.Codigo.CustomButton.Name = "";
            this.Codigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Codigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Codigo.CustomButton.TabIndex = 1;
            this.Codigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Codigo.CustomButton.UseSelectable = true;
            this.Codigo.CustomButton.Visible = false;
            this.Codigo.Lines = new string[0];
            this.Codigo.Location = new System.Drawing.Point(422, 292);
            this.Codigo.MaxLength = 32767;
            this.Codigo.Name = "Codigo";
            this.Codigo.PasswordChar = '\0';
            this.Codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Codigo.SelectedText = "";
            this.Codigo.SelectionLength = 0;
            this.Codigo.SelectionStart = 0;
            this.Codigo.ShortcutsEnabled = true;
            this.Codigo.Size = new System.Drawing.Size(133, 23);
            this.Codigo.TabIndex = 9;
            this.Codigo.UseSelectable = true;
            this.Codigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Codigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.Color.SteelBlue;
            this.Salvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Salvar.Location = new System.Drawing.Point(466, 337);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(89, 34);
            this.Salvar.TabIndex = 10;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseCustomBackColor = true;
            this.Salvar.UseCustomForeColor = true;
            this.Salvar.UseSelectable = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.SteelBlue;
            this.Editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Editar.Location = new System.Drawing.Point(23, 199);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(89, 34);
            this.Editar.TabIndex = 11;
            this.Editar.Text = "Editar";
            this.Editar.UseCustomBackColor = true;
            this.Editar.UseCustomForeColor = true;
            this.Editar.UseSelectable = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.Color.SteelBlue;
            this.Excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Excluir.Location = new System.Drawing.Point(136, 199);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(89, 34);
            this.Excluir.TabIndex = 12;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseCustomBackColor = true;
            this.Excluir.UseCustomForeColor = true;
            this.Excluir.UseSelectable = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Labelerro
            // 
            this.Labelerro.AutoSize = true;
            this.Labelerro.ForeColor = System.Drawing.Color.Red;
            this.Labelerro.Location = new System.Drawing.Point(228, 363);
            this.Labelerro.Name = "Labelerro";
            this.Labelerro.Size = new System.Drawing.Size(0, 0);
            this.Labelerro.TabIndex = 13;
            this.Labelerro.UseCustomForeColor = true;
            // 
            // VisualizarProdutos
            // 
            this.ClientSize = new System.Drawing.Size(626, 383);
            this.Controls.Add(this.Labelerro);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.Preco);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.Empresa);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.DG);
            this.MaximizeBox = false;
            this.Name = "VisualizarProdutos";
            this.Text = "Visualizar Produtos";
            this.Load += new System.EventHandler(this.VisualizarProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox Nome;
        private MetroFramework.Controls.MetroTextBox Empresa;
        private MetroFramework.Controls.MetroTextBox Quantidade;
        private MetroFramework.Controls.MetroTextBox Preco;
        private MetroFramework.Controls.MetroTextBox Codigo;
        private MetroFramework.Controls.MetroButton Salvar;
        private MetroFramework.Controls.MetroButton Editar;
        private MetroFramework.Controls.MetroButton Excluir;
        private MetroFramework.Controls.MetroLabel Labelerro;
    }
}