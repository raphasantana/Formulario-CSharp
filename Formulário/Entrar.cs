using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulário
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            ClasseDB entrar = new ClasseDB();

            switch (entrar.Login(Usuario.Text, Senha.Text, Funcao.Text))// Executar o Método Login da ClasseDB.
            {

                case 1:
                    {
                        if (Funcao.Text == "Dono(a)") // Conferir se é a página de dono, se for abrir o usuario de dono.
                        {
                            this.Hide();
                            new Sócio().Show();
                        }

                        if(Funcao.Text == "Colaborador(a)")// Conferir se é a página de Colaborador, se for abrir o usuario de Colaborador.
                        {
                            this.Hide();
                            new Colaborador().Show();
                        }
                        break;
                    }

                case 2: // Mostrar que não são válidos os valores colocados pelo usuário
                    {
                        MessageBox.Show("O Usuário, senha e função não são válidos");
                        break;
                    }
                case 3: // Mostrar que aconteceu um problema no banco de dados, se quiser ver o problema, só ir na Exception e colocar erro.ToString();
                    {
                        MessageBox.Show("Problema no banco de dados");
                        break;
                    }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ClasseDB usuario = new ClasseDB();

            switch(usuario.ExisteCadastro())
            {
                case 1: 
                    break;



                case 2:
                    this.Hide();
                    new CadastrodeUsuario().Show();
                    break;

                case 3:
                    MessageBox.Show("Não foi possível se conectar ao banco de dados!!!");
                    break;
            }
        }
    }
}