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
    public partial class VisualizarProdutos : MetroFramework.Forms.MetroForm
    {
        public VisualizarProdutos()
        {
            InitializeComponent();
        }

        private void VisualizarProdutos_Load(object sender, EventArgs e)
        {
            ClasseDB Produto = new ClasseDB();

            Produto.ListarProdutos(DG);// Mostrar os valores do banco do Datagrid.

            Salvar.Visible = false;// Deixar esse botao invisível para o usuario quando iniciar.

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            Salvar.Visible = true;// Como foi clicado o botão editar, tornar visível o botão salvar.
            // Pegar os valores do DataView e colocar nos campos de textos.
            Nome.Text = DG.CurrentRow.Cells[1].Value.ToString();
            Empresa.Text = DG.CurrentRow.Cells[2].Value.ToString();
            Quantidade.Text = DG.CurrentRow.Cells[3].Value.ToString();
            Preco.Text = DG.CurrentRow.Cells[4].Value.ToString();
            Codigo.Text = DG.CurrentRow.Cells[5].Value.ToString();

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            ClasseDB Produto = new ClasseDB();
            if (Nome.Text != "" && Empresa.Text != "" && Quantidade.Text != "" && Preco.Text != "" && Codigo.Text != "")// Analisar se os campos estão preenchidos
            {

                Produto.EditarProduto(Nome.Text, Empresa.Text, Quantidade.Text, Preco.Text, Codigo.Text, (DG.CurrentRow.Cells[0].Value.ToString()));
                Produto.ListarProdutos(DG);// Atualizando os campos de DataView
                //Zerando os valores.
                Nome.Text = "";
                Empresa.Text = "";
                Quantidade.Text = "";
                Preco.Text = "";
                Codigo.Text = "";

                Salvar.Visible = false;// Tornando oculto para o usuário novamente.
            }
            else if (Nome.Text == "")
                Labelerro.Text = "Insira o Nome do Produto";
            else if (Empresa.Text == "")
                Labelerro.Text = "Insira a Empresa do Produto";
            else if (Quantidade.Text == "")
                Labelerro.Text = "Insira Quantidade de Produto";
            else if (Preco.Text == "")
                Labelerro.Text = "Insira o Preço do Produto";
            else if (Codigo.Text == "")
                Labelerro.Text = "Insira o Código de Barras do Produto";
            
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            ClasseDB Produto = new ClasseDB();

            Produto.ExcluirProduto((DG.CurrentRow.Cells[0].Value.ToString()));
            Produto.ListarProdutos(DG);
        }
    }
}
