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
    public partial class CadastrarProdutos : MetroFramework.Forms.MetroForm
    {
        public CadastrarProdutos()
        {
            InitializeComponent();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            ClasseDB Produto = new ClasseDB();
            // Conferir se existe algum campo sem ser preenchido.
            if (Nome.Text != "" && Empresa.Text != "" && Quantidade.Text != "" && Preco.Text != "" && Codigo.Text != "")
            {
                if (Produto.CadastrarProdutos(Nome.Text, Empresa.Text, Quantidade.Text, Preco.Text, Codigo.Text) == 1) // O método retorna um inteiro, por isso está dentro de um if, analisar o método em ClassDB, mas se igual a 1, o salvamento foi realizado com sucesso.
                {
                    // Limpar todos os campos após o salvamento com sucesso.
                    Nome.Text = "";
                    Empresa.Text = "";
                    Quantidade.Text = "";
                    Preco.Text = "";
                    Codigo.Text = "";
                }
            }
            //Mostrar qual campo não está preenchido.
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

        private void Preco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ',') // Permitir o BackSpace, obs: precisa ser antes do if de bloquear as letras.
                return;

            if (!char.IsDigit(e.KeyChar)) // Bloquear tudo que nao for número.
                e.Handled = true;

            if (Preco.Text.Length == 0)// Criar as barras entre os números
            {
                    Preco.Text += "R$";
                    Preco.SelectionStart = 2;
            }
        }

        private void Quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8) // Permitir o BackSpace, obs: precisa ser antes do if de bloquear as letras.
                return;

            if (!char.IsDigit(e.KeyChar)) // Bloquear tudo que nao for número.
                e.Handled = true;
        }

        private void Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8) // Permitir o BackSpace, obs: precisa ser antes do if de bloquear as letras.
                return;

            if (!char.IsDigit(e.KeyChar)) // Bloquear tudo que nao for número.
                e.Handled = true;
        }
    }
}
