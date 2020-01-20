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
    public partial class Colaborador : MetroFramework.Forms.MetroForm
    {
        public Colaborador()
        {
            InitializeComponent();
        }

        private void VisualizarColaborador_Click(object sender, EventArgs e)
        {
            new VisualizarProdutos().Show(); // Abrir a página de visualizar produtos.
        }

        private void CadastrarProdutos_Click(object sender, EventArgs e)
        {
            new CadastrarProdutos().Show(); // Abrir a página de cadastrar produtos.
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();// Voltar para a página de Login.
        }

        private void VisualizarProdutos_Click(object sender, EventArgs e)
        {
            new VisualizarColaboradores().Show();
        }
    }
}
