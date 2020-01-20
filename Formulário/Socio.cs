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
    public partial class Sócio : MetroFramework.Forms.MetroForm

    {
        public Sócio()
        {
            InitializeComponent();

        }

        private void CadastrarColaborador_Click(object sender, EventArgs e)
        {

            new CadastrodeUsuario().Show(); // Mostrar a tela de CadastroUsuario
            
        }

        private void VisualizarColaborador_Click(object sender, EventArgs e)
        {
            new VisualizarColaboradores().Show();// Mostrar a tela de VisualizarColaboradores
        }

        private void CadastrarProdutos_Click(object sender, EventArgs e)
        {
            new CadastrarProdutos().Show();
        }

        private void VisualizarProdutos_Click(object sender, EventArgs e)
        {
            new VisualizarProdutos().Show();
        }


        private void Sair_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconder essa tela para abrir a de login novamente, ou seja, voltar a tela inicial
            new Login().Show();
        }
    }
}
