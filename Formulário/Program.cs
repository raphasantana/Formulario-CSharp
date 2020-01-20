using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Formulário
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ClasseDB telas = new ClasseDB();
            if(telas.ExisteCadastro() == 2)
                Application.Run(new CadastrodeUsuario());
            else
                Application.Run(new Login());
        }
            
    }
}

