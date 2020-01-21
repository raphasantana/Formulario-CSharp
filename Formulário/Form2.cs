using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;


namespace Formulário
{
    public partial class CadastrodeUsuario : MetroFramework.Forms.MetroForm
    {
        public CadastrodeUsuario()
        {
            InitializeComponent();
        }

        private void CriarUsuario_Click(object sender, EventArgs e)
        {
            int aux = 0;

            ClasseDB UsuarioCadastro = new ClasseDB();

            if ((UsuarioCadastro.ExisteCadastro() == 1 || Funcao.Text == "Dono(a)") && Senha.Text == ConfirmarSenha.Text  && Nome.Text != "" && Telefone.Text != "" && DatadeNascimento.Text != "" && Usuario.Text != "" && Senha.Text != "" && ConfirmarSenha.Text != "" && Funcao.Text != "" && foto.ImageLocation != null) // Analisar se a senha está correta com a sua confirmação 
            {
                byte[] imagebyte;

                FileStream fstream = new FileStream(this.foto.ImageLocation, FileMode.Open, FileAccess.Read); // Filestream faz a transição de dados, busca de dados por referencia de bytes, armazenamento de dados e entre outros.
                
                BinaryReader br = new BinaryReader(fstream); // Leitor de binário, ou seja, ler em binário a imagem do diretório fstream

                imagebyte = br.ReadBytes((int)fstream.Length); // Então colocamos esse leitor de binário na nossa imagem. 

                if (UsuarioCadastro.ExisteCadastro() == 2)
                    aux = 1;

                try // Avaliar se a conexão está sendo realizada com sucesso, e previnindo a aparição de um erro desconhecido para o usuário
                {
                    ClasseDB conecta = new ClasseDB();

                    
                    MessageBox.Show(conecta.CadastrarDados(Nome.Text, Telefone.Text, DatadeNascimento.Text, Endereco.Text, Usuario.Text, Senha.Text, Funcao.Text, imagebyte));
                    // Fechar o Banco de Dados.

                    //Zerando todos os valores após o salvamento com sucesso
                    Nome.Text = "";
                    Telefone.Text = "";
                    DatadeNascimento.Text = "";
                    Endereco.Text = "";
                    Usuario.Text = "";
                    foto.ImageLocation = null;
                    Senha.Text = "";
                    ConfirmarSenha.Text = "";

                    if(aux == 1)
                    {
                        this.Hide();
                        new Login().Show();
                    }

                }
                catch(Exception erro)// Caso der um erro mostrar que não foi conectado, com a Exception é possível mostrar qual foi o erro
                {
                    MessageBox.Show(erro.Message.ToString());
                }
            }
            else if (UsuarioCadastro.ExisteCadastro() == 2 && Funcao.Text != "Dono(a)") // Mensagem de erro para confirmação da senha.
            {
                LabelErro.Text = "Como é o primeiro cadastro deve-se colocar Dono(a)";
                Funcao.Text = "Dono(a)";

            }


            else if (Senha.Text != ConfirmarSenha.Text) // Mensagem de erro para confirmação da senha.
            {
                LabelErro.Text = "A confirmação da senha está diferente!";
                Senha.Text = null;
                ConfirmarSenha.Text = null;
            }

            else if (Nome.Text == "") // Mensagem de erro para o campo Nome nulo.
                LabelErro.Text = "Preencha o Campo de Nome!";

            else if (Telefone.Text == "") // Mensagem de erro para o campo Telefone nulo.
                LabelErro.Text = "Preencha o Campo de Telefone!";

            else if (DatadeNascimento.Text == "") // Mensagem de erro para o campo Idade nulo.
                LabelErro.Text = "Preencha o Campo de Data de Nascimento!";

            else if (Endereco.Text == "") // Mensagem de erro para o campo Endereço nulo.
                LabelErro.Text = "Preencha o Campo de Endereço!";

            else if (Usuario.Text == "") // Mensagem de erro para o campo Usuario nulo.
                LabelErro.Text = "Preencha o Campo de Usuario!";

            else if (Senha.Text == "") // Mensagem de erro para o campo Senha nulo.
                LabelErro.Text = "Preencha o Campo de Senha!";

            else if (ConfirmarSenha.Text == "") // Mensagem de erro para o campo Confirmar Senha nulo.
                LabelErro.Text = "Preencha o Campo de Confirmar Senha!";

            else if (Funcao.Text == "") // Mensagem de erro para o campo Função nulo.
                LabelErro.Text = "Preencha o Campo de Função!";
            else if (foto.ImageLocation == null) // Mensagem de erro para o campo Função nulo.
                LabelErro.Text = "Insira uma foto !";

        }


        private void Selecionarfoto_Click_1(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)// Abrir a página de escolher foto do Windows
            {
                foto.ImageLocation = openFileDialog1.FileName; // Pegar a localização da foto
                foto.Load(); // Carregar a foto.
            }
        }

        private void Usuario_Validated(object sender, EventArgs e)// Executa no momento que sair do campo de usuário
        {
            ClasseDB ValidarUsuario = new ClasseDB();

            if (ValidarUsuario.ExisteUsuario(Usuario.Text) == 1) // Validação do Usuário
            {
                MessageBox.Show("Já existe um usuário cadastrado com esse nome, por valor coloque outro.");
                Usuario.Text = "";
            }
            else if (ValidarUsuario.ExisteUsuario(Usuario.Text) == 3)// Problema do banco de dados, algum dado está indo equivocado
            {
                MessageBox.Show("Falha ao se comunicar com o banco de dados.");

            }
            // Mínimo de 6 Caractere
            if(Usuario.Text.Length < 6)
            {
                MessageBox.Show("Aumente a quantidade de Caractere do usuário");
                Usuario.Text = "";
            }
        }

        private void Telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8) // Permitir o BackSpace, obs: precisa ser antes do if de bloquear as letras.
                return;

            if (!char.IsDigit(e.KeyChar)) // Bloquear tudo que nao for número.
                e.Handled = true;

                switch (Telefone.Text.Length)// Criar os parenteses do DDD e o hifen do número.
                {
                    case 0:

                        Telefone.Text += "(";
                        Telefone.SelectionStart = 1;
                        break;

                    case 3:

                        Telefone.Text += ") ";
                        Telefone.SelectionStart = 5;
                        break;

                    case 10:

                        Telefone.Text += "-";
                        Telefone.SelectionStart = 11;
                        break;

                }
        }

        private void DatadeNascimento_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8) // Permitir o BackSpace, obs: precisa ser antes do if de bloquear as letras.
                return;

            if (!char.IsDigit(e.KeyChar)) // Bloquear tudo que nao for número.
                e.Handled = true;

            switch (DatadeNascimento.Text.Length)// Criar as barras entre os números
            {
                case 2:
                    
                    DatadeNascimento.Text +=  "/";
                    DatadeNascimento.SelectionStart = 3;
                    break;

                case 5:

                    DatadeNascimento.Text += "/";
                    DatadeNascimento.SelectionStart = 6;
                    break;

            }
        }

        private void Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8) // Permitir o BackSpace, obs: precisa ser antes do if de bloquear as letras.
                return;

            if (char.IsDigit(e.KeyChar)) // Bloquear tudo que nao for número.
                e.Handled = true;
        }

        private void DatadeNascimento_Validated(object sender, EventArgs e)
        {
            if (DatadeNascimento.Text.Length < 10) {
                MessageBox.Show("Complete a Data de Nascimento");
                DatadeNascimento.Text = "";
            }
        }

        private void Telefone_Validated(object sender, EventArgs e)
        {
            if (Telefone.Text.Length < 14)
            {
                MessageBox.Show("Complete o número do Telefone");
                Telefone.Text = "";
            }
        }

        private void Senha_Validated(object sender, EventArgs e)
        {
            if(Senha.Text.Length < 6)
            {
                MessageBox.Show("Número de caracteres da senha menor que 6 !!");
                Senha.Text = "";
            }
        }
    }
}

