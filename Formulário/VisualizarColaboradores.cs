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

namespace Formulário
{
    public partial class VisualizarColaboradores : MetroFramework.Forms.MetroForm
    {
        public VisualizarColaboradores()
        {
            InitializeComponent();
        }

        private void VisualizarColaboradores_Load(object sender, EventArgs e)
        {
            ClasseDB Lista = new ClasseDB();

            Salvar.Visible = false; // Deixar esse botao invisível para o usuario quando iniciar.

            Lista.ListarCadastro(DG); // Mostrar os valores do banco do Datagrid.
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            Salvar.Visible = true; // Como foi clicado o botão editar, tornar visível o botão salvar.

            // Pegar os valores do DataView e colocar nos campos de textos.
            Nomev.Text = DG.CurrentRow.Cells[0].Value.ToString();
            Enderecov.Text = DG.CurrentRow.Cells[1].Value.ToString();
            DatadeNascimentov.Text = DG.CurrentRow.Cells[2].Value.ToString();
            Telefonev.Text = DG.CurrentRow.Cells[3].Value.ToString();
            Senhav.Text = DG.CurrentRow.Cells[5].Value.ToString();
            ConfimarSenhav.Text = DG.CurrentRow.Cells[5].Value.ToString();
            Funcaov.Text = DG.CurrentRow.Cells[6].Value.ToString();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            string usuario = DG.CurrentRow.Cells[4].Value.ToString();

            ClasseDB Editar = new ClasseDB();

            if (Senhav.Text == ConfimarSenhav.Text && Nomev.Text != "" && Telefonev.Text != "" && DatadeNascimentov.Text != "" && Senhav.Text != "" && ConfimarSenhav.Text != "" && Funcaov.Text != "") // Analisar se os campos estão preenchidos e a  senha está correta com a sua confirmação
            {
                MessageBox.Show(Editar.EditarUsuario(Nomev.Text, Telefonev.Text, DatadeNascimentov.Text, Enderecov.Text, usuario, Senhav.Text, Funcaov.Text));

                Salvar.Visible = false; // Tornando oculto para o usuário novamente.

                Editar.ListarCadastro(DG); // Atualizando os campos de DataView

                //Zerando todos os valores após o salvamento com sucesso
                Nomev.Text = "";
                Telefonev.Text = "";
                DatadeNascimentov.Text = "";
                Enderecov.Text = "";
                Senhav.Text = "";
                ConfimarSenhav.Text = "";
                Funcaov.Text = "";
            }
            else if (Senhav.Text != ConfimarSenhav.Text) // Mensagem de erro para confirmação da senha.
            {
                LabelErro.Text = "A confirmação da senha está diferente!";
                Senhav.Text = null;
                ConfimarSenhav.Text = null;
            }

            else if (Nomev.Text == "") // Mensagem de erro para o campo Nome nulo.
                LabelErro.Text = "Preencha o Campo de Nome!";
            else if (Telefonev.Text == "") // Mensagem de erro para o campo Telefone nulo.
                LabelErro.Text = "Preencha o Campo de Telefone!";
            else if (DatadeNascimentov.Text == "") // Mensagem de erro para o campo Idade nulo.
                LabelErro.Text = "Preencha o Campo de Data de Nascimento!";
            else if (Enderecov.Text == "") // Mensagem de erro para o campo Endereço nulo.
                LabelErro.Text = "Preencha o Campo de Endereço!";
            else if (Senhav.Text == "") // Mensagem de erro para o campo Senha nulo.
                LabelErro.Text = "Preencha o Campo de Senha!";
            else if (ConfimarSenhav.Text == "") // Mensagem de erro para o campo Confirmar Senha nulo.
                LabelErro.Text = "Preencha o Campo de Confirmar Senha!";
            else if (Funcaov.Text == "") // Mensagem de erro para o campo Função nulo.
                LabelErro.Text = "Preencha o Campo de Função!";
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            ClasseDB Excluir = new ClasseDB();

            Excluir.ExcluirUsuario(DG.CurrentRow.Cells[4].Value.ToString()); // Para excluir o usuário usasse o PRIMARY KEY da tabela

            Excluir.ListarCadastro(DG); // Atualiza o DataView.
        }
    }
}
