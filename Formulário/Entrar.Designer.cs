namespace Formulário
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Usuario = new MetroFramework.Controls.MetroTextBox();
            this.Senha = new MetroFramework.Controls.MetroTextBox();
            this.Funcao = new MetroFramework.Controls.MetroComboBox();
            this.Entrar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.Name = "metroLabel1";
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.Name = "metroLabel2";
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.Name = "metroLabel3";
            // 
            // Usuario
            // 
            // 
            // 
            // 
            this.Usuario.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.Usuario.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.Usuario.CustomButton.Name = "";
            this.Usuario.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.Usuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Usuario.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.Usuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Usuario.CustomButton.UseSelectable = true;
            this.Usuario.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.Usuario.Lines = new string[0];
            resources.ApplyResources(this.Usuario, "Usuario");
            this.Usuario.MaxLength = 32767;
            this.Usuario.Name = "Usuario";
            this.Usuario.PasswordChar = '\0';
            this.Usuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Usuario.SelectedText = "";
            this.Usuario.SelectionLength = 0;
            this.Usuario.SelectionStart = 0;
            this.Usuario.ShortcutsEnabled = true;
            this.Usuario.UseSelectable = true;
            this.Usuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Usuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Senha
            // 
            // 
            // 
            // 
            this.Senha.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.Senha.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.Senha.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.Senha.CustomButton.Name = "";
            this.Senha.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.Senha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Senha.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.Senha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Senha.CustomButton.UseSelectable = true;
            this.Senha.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.Senha.Lines = new string[0];
            resources.ApplyResources(this.Senha, "Senha");
            this.Senha.MaxLength = 32767;
            this.Senha.Name = "Senha";
            this.Senha.PasswordChar = '●';
            this.Senha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Senha.SelectedText = "";
            this.Senha.SelectionLength = 0;
            this.Senha.SelectionStart = 0;
            this.Senha.ShortcutsEnabled = true;
            this.Senha.UseSelectable = true;
            this.Senha.UseSystemPasswordChar = true;
            this.Senha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Senha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Funcao
            // 
            this.Funcao.FormattingEnabled = true;
            resources.ApplyResources(this.Funcao, "Funcao");
            this.Funcao.Items.AddRange(new object[] {
            resources.GetString("Funcao.Items"),
            resources.GetString("Funcao.Items1")});
            this.Funcao.Name = "Funcao";
            this.Funcao.UseSelectable = true;
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Entrar, "Entrar");
            this.Entrar.Name = "Entrar";
            this.Entrar.UseCustomBackColor = true;
            this.Entrar.UseSelectable = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.Funcao);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox Usuario;
        private MetroFramework.Controls.MetroTextBox Senha;
        private MetroFramework.Controls.MetroComboBox Funcao;
        private MetroFramework.Controls.MetroButton Entrar;
    }
}