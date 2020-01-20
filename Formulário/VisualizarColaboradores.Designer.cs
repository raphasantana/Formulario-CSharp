namespace Formulário
{
    partial class VisualizarColaboradores
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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Imgv = new System.Windows.Forms.PictureBox();
            this.Nomev = new MetroFramework.Controls.MetroTextBox();
            this.Telefonev = new MetroFramework.Controls.MetroTextBox();
            this.DatadeNascimentov = new MetroFramework.Controls.MetroTextBox();
            this.Enderecov = new MetroFramework.Controls.MetroTextBox();
            this.ConfimarSenhav = new MetroFramework.Controls.MetroTextBox();
            this.Editar = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.Senhav = new MetroFramework.Controls.MetroTextBox();
            this.Salvar = new MetroFramework.Controls.MetroButton();
            this.Funcaov = new MetroFramework.Controls.MetroComboBox();
            this.LabelErro = new MetroFramework.Controls.MetroLabel();
            this.Excluir = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgv)).BeginInit();
            this.SuspendLayout();
            // 
            // DG
            // 
            this.DG.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(23, 63);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(754, 153);
            this.DG.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 285);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Nome:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(31, 318);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Telefone:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(31, 353);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(131, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Data de Nascimento:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(31, 388);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Endereço:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(292, 320);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(111, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Confirmar Senha:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(349, 355);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(54, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Função:";
            // 
            // Imgv
            // 
            this.Imgv.Location = new System.Drawing.Point(625, 285);
            this.Imgv.Name = "Imgv";
            this.Imgv.Size = new System.Drawing.Size(103, 106);
            this.Imgv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imgv.TabIndex = 7;
            this.Imgv.TabStop = false;
            // 
            // Nomev
            // 
            // 
            // 
            // 
            this.Nomev.CustomButton.Image = null;
            this.Nomev.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.Nomev.CustomButton.Name = "";
            this.Nomev.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Nomev.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Nomev.CustomButton.TabIndex = 1;
            this.Nomev.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Nomev.CustomButton.UseSelectable = true;
            this.Nomev.CustomButton.Visible = false;
            this.Nomev.Lines = new string[0];
            this.Nomev.Location = new System.Drawing.Point(104, 285);
            this.Nomev.MaxLength = 32767;
            this.Nomev.Name = "Nomev";
            this.Nomev.PasswordChar = '\0';
            this.Nomev.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Nomev.SelectedText = "";
            this.Nomev.SelectionLength = 0;
            this.Nomev.SelectionStart = 0;
            this.Nomev.ShortcutsEnabled = true;
            this.Nomev.Size = new System.Drawing.Size(180, 23);
            this.Nomev.TabIndex = 8;
            this.Nomev.UseSelectable = true;
            this.Nomev.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Nomev.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Telefonev
            // 
            // 
            // 
            // 
            this.Telefonev.CustomButton.Image = null;
            this.Telefonev.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.Telefonev.CustomButton.Name = "";
            this.Telefonev.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Telefonev.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Telefonev.CustomButton.TabIndex = 1;
            this.Telefonev.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Telefonev.CustomButton.UseSelectable = true;
            this.Telefonev.CustomButton.Visible = false;
            this.Telefonev.Lines = new string[0];
            this.Telefonev.Location = new System.Drawing.Point(104, 320);
            this.Telefonev.MaxLength = 32767;
            this.Telefonev.Name = "Telefonev";
            this.Telefonev.PasswordChar = '\0';
            this.Telefonev.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Telefonev.SelectedText = "";
            this.Telefonev.SelectionLength = 0;
            this.Telefonev.SelectionStart = 0;
            this.Telefonev.ShortcutsEnabled = true;
            this.Telefonev.Size = new System.Drawing.Size(180, 23);
            this.Telefonev.TabIndex = 9;
            this.Telefonev.UseSelectable = true;
            this.Telefonev.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Telefonev.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DatadeNascimentov
            // 
            // 
            // 
            // 
            this.DatadeNascimentov.CustomButton.Image = null;
            this.DatadeNascimentov.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.DatadeNascimentov.CustomButton.Name = "";
            this.DatadeNascimentov.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DatadeNascimentov.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DatadeNascimentov.CustomButton.TabIndex = 1;
            this.DatadeNascimentov.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DatadeNascimentov.CustomButton.UseSelectable = true;
            this.DatadeNascimentov.CustomButton.Visible = false;
            this.DatadeNascimentov.Lines = new string[0];
            this.DatadeNascimentov.Location = new System.Drawing.Point(168, 355);
            this.DatadeNascimentov.MaxLength = 32767;
            this.DatadeNascimentov.Name = "DatadeNascimentov";
            this.DatadeNascimentov.PasswordChar = '\0';
            this.DatadeNascimentov.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DatadeNascimentov.SelectedText = "";
            this.DatadeNascimentov.SelectionLength = 0;
            this.DatadeNascimentov.SelectionStart = 0;
            this.DatadeNascimentov.ShortcutsEnabled = true;
            this.DatadeNascimentov.Size = new System.Drawing.Size(116, 23);
            this.DatadeNascimentov.TabIndex = 10;
            this.DatadeNascimentov.UseSelectable = true;
            this.DatadeNascimentov.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DatadeNascimentov.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Enderecov
            // 
            // 
            // 
            // 
            this.Enderecov.CustomButton.Image = null;
            this.Enderecov.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.Enderecov.CustomButton.Name = "";
            this.Enderecov.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Enderecov.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Enderecov.CustomButton.TabIndex = 1;
            this.Enderecov.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Enderecov.CustomButton.UseSelectable = true;
            this.Enderecov.CustomButton.Visible = false;
            this.Enderecov.Lines = new string[0];
            this.Enderecov.Location = new System.Drawing.Point(104, 388);
            this.Enderecov.MaxLength = 32767;
            this.Enderecov.Name = "Enderecov";
            this.Enderecov.PasswordChar = '\0';
            this.Enderecov.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Enderecov.SelectedText = "";
            this.Enderecov.SelectionLength = 0;
            this.Enderecov.SelectionStart = 0;
            this.Enderecov.ShortcutsEnabled = true;
            this.Enderecov.Size = new System.Drawing.Size(180, 23);
            this.Enderecov.TabIndex = 11;
            this.Enderecov.UseSelectable = true;
            this.Enderecov.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Enderecov.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ConfimarSenhav
            // 
            // 
            // 
            // 
            this.ConfimarSenhav.CustomButton.Image = null;
            this.ConfimarSenhav.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.ConfimarSenhav.CustomButton.Name = "";
            this.ConfimarSenhav.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ConfimarSenhav.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ConfimarSenhav.CustomButton.TabIndex = 1;
            this.ConfimarSenhav.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ConfimarSenhav.CustomButton.UseSelectable = true;
            this.ConfimarSenhav.CustomButton.Visible = false;
            this.ConfimarSenhav.Lines = new string[0];
            this.ConfimarSenhav.Location = new System.Drawing.Point(409, 320);
            this.ConfimarSenhav.MaxLength = 32767;
            this.ConfimarSenhav.Name = "ConfimarSenhav";
            this.ConfimarSenhav.PasswordChar = '●';
            this.ConfimarSenhav.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConfimarSenhav.SelectedText = "";
            this.ConfimarSenhav.SelectionLength = 0;
            this.ConfimarSenhav.SelectionStart = 0;
            this.ConfimarSenhav.ShortcutsEnabled = true;
            this.ConfimarSenhav.Size = new System.Drawing.Size(151, 23);
            this.ConfimarSenhav.TabIndex = 12;
            this.ConfimarSenhav.UseSelectable = true;
            this.ConfimarSenhav.UseSystemPasswordChar = true;
            this.ConfimarSenhav.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ConfimarSenhav.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.SteelBlue;
            this.Editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Editar.Location = new System.Drawing.Point(28, 234);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(97, 33);
            this.Editar.TabIndex = 14;
            this.Editar.Text = "Editar";
            this.Editar.UseCustomBackColor = true;
            this.Editar.UseCustomForeColor = true;
            this.Editar.UseSelectable = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(356, 289);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(47, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Senha:";
            // 
            // Senhav
            // 
            // 
            // 
            // 
            this.Senhav.CustomButton.Image = null;
            this.Senhav.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.Senhav.CustomButton.Name = "";
            this.Senhav.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Senhav.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Senhav.CustomButton.TabIndex = 1;
            this.Senhav.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Senhav.CustomButton.UseSelectable = true;
            this.Senhav.CustomButton.Visible = false;
            this.Senhav.Lines = new string[0];
            this.Senhav.Location = new System.Drawing.Point(409, 285);
            this.Senhav.MaxLength = 32767;
            this.Senhav.Name = "Senhav";
            this.Senhav.PasswordChar = '●';
            this.Senhav.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Senhav.SelectedText = "";
            this.Senhav.SelectionLength = 0;
            this.Senhav.SelectionStart = 0;
            this.Senhav.ShortcutsEnabled = true;
            this.Senhav.Size = new System.Drawing.Size(151, 23);
            this.Senhav.TabIndex = 16;
            this.Senhav.UseSelectable = true;
            this.Senhav.UseSystemPasswordChar = true;
            this.Senhav.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Senhav.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.Color.SteelBlue;
            this.Salvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Salvar.Location = new System.Drawing.Point(656, 410);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(90, 32);
            this.Salvar.TabIndex = 19;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseCustomBackColor = true;
            this.Salvar.UseCustomForeColor = true;
            this.Salvar.UseSelectable = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Funcaov
            // 
            this.Funcaov.FormattingEnabled = true;
            this.Funcaov.ItemHeight = 23;
            this.Funcaov.Items.AddRange(new object[] {
            "Dono(a)",
            "Colaborador(a)"});
            this.Funcaov.Location = new System.Drawing.Point(409, 353);
            this.Funcaov.Name = "Funcaov";
            this.Funcaov.Size = new System.Drawing.Size(118, 29);
            this.Funcaov.TabIndex = 20;
            this.Funcaov.UseSelectable = true;
            // 
            // LabelErro
            // 
            this.LabelErro.AutoSize = true;
            this.LabelErro.BackColor = System.Drawing.Color.White;
            this.LabelErro.ForeColor = System.Drawing.Color.Red;
            this.LabelErro.Location = new System.Drawing.Point(268, 423);
            this.LabelErro.Name = "LabelErro";
            this.LabelErro.Size = new System.Drawing.Size(0, 0);
            this.LabelErro.TabIndex = 21;
            this.LabelErro.UseCustomForeColor = true;
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.Color.SteelBlue;
            this.Excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Excluir.Location = new System.Drawing.Point(168, 234);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(97, 33);
            this.Excluir.TabIndex = 22;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseCustomBackColor = true;
            this.Excluir.UseCustomForeColor = true;
            this.Excluir.UseSelectable = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // VisualizarColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.LabelErro);
            this.Controls.Add(this.Funcaov);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Senhav);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.ConfimarSenhav);
            this.Controls.Add(this.Enderecov);
            this.Controls.Add(this.DatadeNascimentov);
            this.Controls.Add(this.Telefonev);
            this.Controls.Add(this.Nomev);
            this.Controls.Add(this.Imgv);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.DG);
            this.MaximizeBox = false;
            this.Name = "VisualizarColaboradores";
            this.Text = "Visualizar Colaboradores";
            this.Load += new System.EventHandler(this.VisualizarColaboradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgv)).EndInit();
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
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.PictureBox Imgv;
        private MetroFramework.Controls.MetroTextBox Nomev;
        private MetroFramework.Controls.MetroTextBox Telefonev;
        private MetroFramework.Controls.MetroTextBox DatadeNascimentov;
        private MetroFramework.Controls.MetroTextBox Enderecov;
        private MetroFramework.Controls.MetroTextBox ConfimarSenhav;
        private MetroFramework.Controls.MetroButton Editar;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox Senhav;
        private MetroFramework.Controls.MetroButton Salvar;
        private MetroFramework.Controls.MetroComboBox Funcaov;
        private MetroFramework.Controls.MetroLabel LabelErro;
        private MetroFramework.Controls.MetroButton Excluir;
    }
}