namespace Formulário
{
    partial class CadastrodeUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrodeUsuario));
            this.foto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Funcao = new MetroFramework.Controls.MetroComboBox();
            this.Nome = new MetroFramework.Controls.MetroTextBox();
            this.Telefone = new MetroFramework.Controls.MetroTextBox();
            this.DatadeNascimento = new MetroFramework.Controls.MetroTextBox();
            this.Endereco = new MetroFramework.Controls.MetroTextBox();
            this.Usuario = new MetroFramework.Controls.MetroTextBox();
            this.Senha = new MetroFramework.Controls.MetroTextBox();
            this.ConfirmarSenha = new MetroFramework.Controls.MetroTextBox();
            this.CriarUsuario = new MetroFramework.Controls.MetroButton();
            this.Selecionarfoto = new MetroFramework.Controls.MetroButton();
            this.label8 = new System.Windows.Forms.Label();
            this.LabelErro = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // foto
            // 
            this.foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto.Location = new System.Drawing.Point(464, 28);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(96, 95);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 3;
            this.foto.TabStop = false;
            this.toolTip1.SetToolTip(this.foto, "Pressione o botão abaixo e coloque uma foto sua.");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Usuário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Senha: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Confirmar Senha:";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Preencha as Informações com Cuidado";
            // 
            // Funcao
            // 
            this.Funcao.FormattingEnabled = true;
            this.Funcao.ItemHeight = 23;
            this.Funcao.Items.AddRange(new object[] {
            "Dono(a)",
            "Colaborador(a)"});
            this.Funcao.Location = new System.Drawing.Point(131, 293);
            this.Funcao.Name = "Funcao";
            this.Funcao.Size = new System.Drawing.Size(121, 29);
            this.Funcao.TabIndex = 29;
            this.toolTip1.SetToolTip(this.Funcao, "Digite a Função do colaborador");
            this.Funcao.UseSelectable = true;
            // 
            // Nome
            // 
            // 
            // 
            // 
            this.Nome.CustomButton.Image = null;
            this.Nome.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.Nome.CustomButton.Name = "";
            this.Nome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Nome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Nome.CustomButton.TabIndex = 1;
            this.Nome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Nome.CustomButton.UseSelectable = true;
            this.Nome.CustomButton.Visible = false;
            this.Nome.Lines = new string[0];
            this.Nome.Location = new System.Drawing.Point(131, 63);
            this.Nome.MaxLength = 32767;
            this.Nome.Name = "Nome";
            this.Nome.PasswordChar = '\0';
            this.Nome.PromptText = "Insira seu nome completo";
            this.Nome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Nome.SelectedText = "";
            this.Nome.SelectionLength = 0;
            this.Nome.SelectionStart = 0;
            this.Nome.ShortcutsEnabled = true;
            this.Nome.Size = new System.Drawing.Size(302, 23);
            this.Nome.TabIndex = 17;
            this.Nome.UseSelectable = true;
            this.Nome.WaterMark = "Insira seu nome completo";
            this.Nome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Nome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Telefone
            // 
            // 
            // 
            // 
            this.Telefone.CustomButton.Image = null;
            this.Telefone.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.Telefone.CustomButton.Name = "";
            this.Telefone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Telefone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Telefone.CustomButton.TabIndex = 1;
            this.Telefone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Telefone.CustomButton.UseSelectable = true;
            this.Telefone.CustomButton.Visible = false;
            this.Telefone.Lines = new string[0];
            this.Telefone.Location = new System.Drawing.Point(131, 100);
            this.Telefone.MaxLength = 15;
            this.Telefone.Name = "Telefone";
            this.Telefone.PasswordChar = '\0';
            this.Telefone.PromptText = "(--) ----- ----";
            this.Telefone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Telefone.SelectedText = "";
            this.Telefone.SelectionLength = 0;
            this.Telefone.SelectionStart = 0;
            this.Telefone.ShortcutsEnabled = true;
            this.Telefone.Size = new System.Drawing.Size(105, 23);
            this.Telefone.TabIndex = 18;
            this.Telefone.UseSelectable = true;
            this.Telefone.WaterMark = "(--) ----- ----";
            this.Telefone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Telefone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Telefone_KeyPress);
            // 
            // DatadeNascimento
            // 
            // 
            // 
            // 
            this.DatadeNascimento.CustomButton.Image = null;
            this.DatadeNascimento.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.DatadeNascimento.CustomButton.Name = "";
            this.DatadeNascimento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DatadeNascimento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DatadeNascimento.CustomButton.TabIndex = 1;
            this.DatadeNascimento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DatadeNascimento.CustomButton.UseSelectable = true;
            this.DatadeNascimento.CustomButton.Visible = false;
            this.DatadeNascimento.Lines = new string[0];
            this.DatadeNascimento.Location = new System.Drawing.Point(350, 100);
            this.DatadeNascimento.MaxLength = 10;
            this.DatadeNascimento.Name = "DatadeNascimento";
            this.DatadeNascimento.PasswordChar = '\0';
            this.DatadeNascimento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DatadeNascimento.SelectedText = "";
            this.DatadeNascimento.SelectionLength = 0;
            this.DatadeNascimento.SelectionStart = 0;
            this.DatadeNascimento.ShortcutsEnabled = true;
            this.DatadeNascimento.Size = new System.Drawing.Size(83, 23);
            this.DatadeNascimento.TabIndex = 19;
            this.DatadeNascimento.UseSelectable = true;
            this.DatadeNascimento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DatadeNascimento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.DatadeNascimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DatadeNascimento_KeyPress_1);
            // 
            // Endereco
            // 
            // 
            // 
            // 
            this.Endereco.CustomButton.Image = null;
            this.Endereco.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.Endereco.CustomButton.Name = "";
            this.Endereco.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Endereco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Endereco.CustomButton.TabIndex = 1;
            this.Endereco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Endereco.CustomButton.UseSelectable = true;
            this.Endereco.CustomButton.Visible = false;
            this.Endereco.Lines = new string[0];
            this.Endereco.Location = new System.Drawing.Point(131, 135);
            this.Endereco.MaxLength = 32767;
            this.Endereco.Name = "Endereco";
            this.Endereco.PasswordChar = '\0';
            this.Endereco.PromptText = "Insira seu Endereço";
            this.Endereco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Endereco.SelectedText = "";
            this.Endereco.SelectionLength = 0;
            this.Endereco.SelectionStart = 0;
            this.Endereco.ShortcutsEnabled = true;
            this.Endereco.Size = new System.Drawing.Size(302, 23);
            this.Endereco.TabIndex = 20;
            this.Endereco.UseSelectable = true;
            this.Endereco.WaterMark = "Insira seu Endereço";
            this.Endereco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Endereco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Usuario
            // 
            // 
            // 
            // 
            this.Usuario.CustomButton.Image = null;
            this.Usuario.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.Usuario.CustomButton.Name = "";
            this.Usuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Usuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Usuario.CustomButton.TabIndex = 1;
            this.Usuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Usuario.CustomButton.UseSelectable = true;
            this.Usuario.CustomButton.Visible = false;
            this.Usuario.Lines = new string[0];
            this.Usuario.Location = new System.Drawing.Point(131, 186);
            this.Usuario.MaxLength = 32767;
            this.Usuario.Name = "Usuario";
            this.Usuario.PasswordChar = '\0';
            this.Usuario.PromptText = "Insira o Usuário desejado";
            this.Usuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Usuario.SelectedText = "";
            this.Usuario.SelectionLength = 0;
            this.Usuario.SelectionStart = 0;
            this.Usuario.ShortcutsEnabled = true;
            this.Usuario.Size = new System.Drawing.Size(232, 23);
            this.Usuario.TabIndex = 21;
            this.Usuario.UseSelectable = true;
            this.Usuario.WaterMark = "Insira o Usuário desejado";
            this.Usuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Usuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Usuario.Validated += new System.EventHandler(this.Usuario_Validated);
            // 
            // Senha
            // 
            // 
            // 
            // 
            this.Senha.CustomButton.Image = null;
            this.Senha.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.Senha.CustomButton.Name = "";
            this.Senha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Senha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Senha.CustomButton.TabIndex = 1;
            this.Senha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Senha.CustomButton.UseSelectable = true;
            this.Senha.CustomButton.Visible = false;
            this.Senha.Lines = new string[0];
            this.Senha.Location = new System.Drawing.Point(131, 220);
            this.Senha.MaxLength = 32767;
            this.Senha.Name = "Senha";
            this.Senha.PasswordChar = '●';
            this.Senha.PromptText = "Senha no mínimo de 6 caracteres";
            this.Senha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Senha.SelectedText = "";
            this.Senha.SelectionLength = 0;
            this.Senha.SelectionStart = 0;
            this.Senha.ShortcutsEnabled = true;
            this.Senha.Size = new System.Drawing.Size(185, 23);
            this.Senha.TabIndex = 22;
            this.Senha.UseSelectable = true;
            this.Senha.UseSystemPasswordChar = true;
            this.Senha.WaterMark = "Senha no mínimo de 6 caracteres";
            this.Senha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Senha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ConfirmarSenha
            // 
            // 
            // 
            // 
            this.ConfirmarSenha.CustomButton.Image = null;
            this.ConfirmarSenha.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.ConfirmarSenha.CustomButton.Name = "";
            this.ConfirmarSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ConfirmarSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ConfirmarSenha.CustomButton.TabIndex = 1;
            this.ConfirmarSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ConfirmarSenha.CustomButton.UseSelectable = true;
            this.ConfirmarSenha.CustomButton.Visible = false;
            this.ConfirmarSenha.Lines = new string[0];
            this.ConfirmarSenha.Location = new System.Drawing.Point(131, 255);
            this.ConfirmarSenha.MaxLength = 32767;
            this.ConfirmarSenha.Name = "ConfirmarSenha";
            this.ConfirmarSenha.PasswordChar = '●';
            this.ConfirmarSenha.PromptText = "Confirme a senha anterior";
            this.ConfirmarSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConfirmarSenha.SelectedText = "";
            this.ConfirmarSenha.SelectionLength = 0;
            this.ConfirmarSenha.SelectionStart = 0;
            this.ConfirmarSenha.ShortcutsEnabled = true;
            this.ConfirmarSenha.Size = new System.Drawing.Size(185, 23);
            this.ConfirmarSenha.TabIndex = 23;
            this.ConfirmarSenha.UseSelectable = true;
            this.ConfirmarSenha.UseSystemPasswordChar = true;
            this.ConfirmarSenha.WaterMark = "Confirme a senha anterior";
            this.ConfirmarSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ConfirmarSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CriarUsuario
            // 
            this.CriarUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.CriarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CriarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CriarUsuario.Location = new System.Drawing.Point(260, 362);
            this.CriarUsuario.Name = "CriarUsuario";
            this.CriarUsuario.Size = new System.Drawing.Size(103, 27);
            this.CriarUsuario.TabIndex = 24;
            this.CriarUsuario.Text = "Criar Usuário";
            this.CriarUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CriarUsuario.UseCustomBackColor = true;
            this.CriarUsuario.UseCustomForeColor = true;
            this.CriarUsuario.UseSelectable = true;
            this.CriarUsuario.Click += new System.EventHandler(this.CriarUsuario_Click);
            // 
            // Selecionarfoto
            // 
            this.Selecionarfoto.BackColor = System.Drawing.SystemColors.Highlight;
            this.Selecionarfoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Selecionarfoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Selecionarfoto.Location = new System.Drawing.Point(457, 139);
            this.Selecionarfoto.Name = "Selecionarfoto";
            this.Selecionarfoto.Size = new System.Drawing.Size(114, 27);
            this.Selecionarfoto.TabIndex = 25;
            this.Selecionarfoto.Text = "Selecionar Foto";
            this.Selecionarfoto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Selecionarfoto.UseCustomBackColor = true;
            this.Selecionarfoto.UseCustomForeColor = true;
            this.Selecionarfoto.UseSelectable = true;
            this.Selecionarfoto.UseStyleColors = true;
            this.Selecionarfoto.Click += new System.EventHandler(this.Selecionarfoto_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Endereço:";
            // 
            // LabelErro
            // 
            this.LabelErro.AutoSize = true;
            this.LabelErro.ForeColor = System.Drawing.Color.Red;
            this.LabelErro.Location = new System.Drawing.Point(238, 334);
            this.LabelErro.Name = "LabelErro";
            this.LabelErro.Size = new System.Drawing.Size(0, 13);
            this.LabelErro.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Função:";
            // 
            // CadastrodeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 396);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Funcao);
            this.Controls.Add(this.LabelErro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Selecionarfoto);
            this.Controls.Add(this.CriarUsuario);
            this.Controls.Add(this.ConfirmarSenha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.DatadeNascimento);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrodeUsuario";
            this.Text = "Cadastro de Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox Nome;
        private MetroFramework.Controls.MetroTextBox Telefone;
        private MetroFramework.Controls.MetroTextBox DatadeNascimento;
        private MetroFramework.Controls.MetroTextBox Endereco;
        private MetroFramework.Controls.MetroTextBox Usuario;
        private MetroFramework.Controls.MetroTextBox Senha;
        private MetroFramework.Controls.MetroTextBox ConfirmarSenha;
        private MetroFramework.Controls.MetroButton CriarUsuario;
        private MetroFramework.Controls.MetroButton Selecionarfoto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LabelErro;
        private MetroFramework.Controls.MetroComboBox Funcao;
        private System.Windows.Forms.Label label9;
    }
}