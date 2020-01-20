using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Formulário
{
    class ClasseDB
    {
        string conectabanco = "server=localhost;port=3306;User Id = root; database=usuario;password=vertrigo;";// String para se conectar com o o BD

        MySqlConnection conexao = null; // Criar um objeto de conexão nulo.
        MySqlCommand comando; // Criar um comando objeto de de mysqlcommand.

        public string Cadastrardados(string nome, string telefone, string datanascimento, string endereco, string usuario, string senha, string funcao, byte[] imagem)
        {
            try
            {

                conexao = new MySqlConnection(conectabanco);// Criação da conexão com o banco de dados
                comando = new MySqlCommand("INSERT INTO Usuarioscadastrados(Nome, Endereco, DatadeNascimento, Telefone, Usuario, Senha, Funcao, Imagem) values(?,?,?,?,?,?,?,?)", conexao);//Realizar esse comando do mysql

                conexao.Open();// Abetura dessa conexão criada

                //Adicionar os valores presentes nesse comando.
                comando.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = nome;
                comando.Parameters.Add("@Endereco", MySqlDbType.VarChar).Value = endereco;
                comando.Parameters.Add("@DatadeNascimento", MySqlDbType.VarChar).Value = datanascimento;
                comando.Parameters.Add("@Telefone", MySqlDbType.VarChar).Value = telefone;
                comando.Parameters.Add("@Usuario", MySqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = senha;
                comando.Parameters.Add("@Funcao", MySqlDbType.VarChar).Value = funcao;
                comando.Parameters.Add("@Imagem", MySqlDbType.LongBlob).Value = imagem;
                //Executar a query, ou seja, realizar a função do mysql acima.
                comando.ExecuteNonQuery();

                conexao.Close();// Fechamento dessa conexão criada
                return "Dados salvos com Sucesso";// Mostrar uma caixa de mensagem informando que a conexão foi um sucesso


            }
            catch (Exception erro)
            {
                throw erro;
            }


        }

        public int Existeusuario(string nomeusuario)
        {
            try
            {
                // Conectando com o banco
                conexao = new MySqlConnection(conectabanco);
                comando = new MySqlCommand("select * from Usuarioscadastrados where Usuario = @Usuario", conexao);//Comando mysql
                conexao.Open();//Abrir conexão 


                comando.Parameters.AddWithValue("@Usuario", nomeusuario);//Adicionar valor de uma forma diferente

                MySqlDataReader registro = comando.ExecuteReader(); // Criar uma variável de leitura
                registro.Read(); // ler os dados;

                if (registro.HasRows)// Saber se existe alguma linha com os valores do comando, se existir quer dizer que já existe um usuário com esse nome.
                {
                    return 1;
                }
                else
                {
                    return 2;
                }

                conexao.Close();
            }
            catch (Exception erro)
            {
                return 3;
            }
        }

        public int ExisteCadastro()
        {
            try
            {
                // Conectando com o banco
                conexao = new MySqlConnection(conectabanco);
                comando = new MySqlCommand("select * from Usuarioscadastrados", conexao);//Comando mysql
                conexao.Open();//Abrir conexão 

                MySqlDataReader registro = comando.ExecuteReader(); // Criar uma variável de leitura
                registro.Read(); // ler os dados

                if (registro.HasRows)// Saber se existe alguma linha com os valores do comando, se existir quer dizer que já existe um usuário com esse nome.
                {
                    return 1;
                }
                else
                {
                    return 2;
                }

                conexao.Close();
            }
            catch (Exception erro)
            {
                return 3;
            }
        }



        public int Login(string usuario, string senha, string funcao)
        {
            try
            {
                conexao = new MySqlConnection(conectabanco);
                comando = new MySqlCommand("select * from Usuarioscadastrados where Usuario = @Usuario and  Senha = @Senha and Funcao = @Funcao", conexao);
                conexao.Open();

                // Adicionando
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Senha", senha);
                comando.Parameters.AddWithValue("@Funcao", funcao);

                MySqlDataReader registro = comando.ExecuteReader();
                registro.Read();

                if (registro.HasRows)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }

                conexao.Close();
            }
            catch
            {
                return 3;
            }


        }
        public void ListarCadastro(DataGridView dados)
        {
            conexao = new MySqlConnection(conectabanco);
            comando = new MySqlCommand("select * from Usuarioscadastrados", conexao);
            conexao.Open();

            try
            {
                MySqlDataAdapter objnovo = new MySqlDataAdapter(comando);

                DataTable dtlista = new DataTable();

                objnovo.Fill(dtlista);

                dados.DataSource = dtlista;
            }
            catch
            {
                MessageBox.Show("Deu errado a busca no banco");
            }
        }

        public int Produtos(string nome, string empresa, string quantidade, string preco, string codigo)
        {
            try
            {
                conexao = new MySqlConnection(conectabanco);// Criação da conexão com o banco de dados
                comando = new MySqlCommand("INSERT INTO ProdutosCadastrados(Nome, Empresa, Quantidade, Preco, Codigo) values(?,?,?,?,?)", conexao);//Realizar esse comando do mysql

                conexao.Open();// Abetura dessa conexão criada

                //Adicionar os valores presentes nesse comando.
                comando.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = nome;
                comando.Parameters.Add("@Empresa", MySqlDbType.VarChar).Value = empresa;
                comando.Parameters.Add("@Quantidade", MySqlDbType.VarChar).Value = quantidade;
                comando.Parameters.Add("@Preco", MySqlDbType.VarChar).Value = preco;
                comando.Parameters.Add("@Codigo", MySqlDbType.VarChar).Value = codigo;
                //Executar a query, ou seja, realizar a função do mysql acima.
                comando.ExecuteNonQuery();

                conexao.Close();// Fechamento dessa conexão criada
                MessageBox.Show("Dados salvos");
                return 1;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
                return 2;
            }


        }
        public void ListarProdutos(DataGridView dados)
        {
            conexao = new MySqlConnection(conectabanco);
            comando = new MySqlCommand("select * from Produtoscadastrados", conexao);
            conexao.Open();

            try
            {
                MySqlDataAdapter objnovo = new MySqlDataAdapter(comando);

                DataTable dtlista = new DataTable();

                objnovo.Fill(dtlista);

                dados.DataSource = dtlista;
            }
            catch
            {
                MessageBox.Show("Deu errado a busca no banco");
            }
        }
        public string EditarUsuario(string nome, string telefone, string datanascimento, string endereco, string usuario, string senha, string funcao)
        {
            try
            {

                conexao = new MySqlConnection(conectabanco);// Criação da conexão com o banco de dados
                comando = new MySqlCommand("UPDATE usuarioscadastrados SET Nome = @Nome, Endereco = @Endereco, DatadeNascimento = @DatadeNascimento, Telefone = @Telefone, Senha = @Senha, Funcao = @Funcao WHERE Usuario = @Usuario;", conexao);//Realizar esse comando do mysql

                conexao.Open();// Abetura dessa conexão criada

                //Adicionar os valores presentes nesse comando.
                comando.Parameters.AddWithValue("@Nome", nome);
                comando.Parameters.AddWithValue("@Telefone", telefone);
                comando.Parameters.AddWithValue("@Endereco", endereco);
                comando.Parameters.AddWithValue("@DatadeNascimento", datanascimento);
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Senha", senha);
                comando.Parameters.AddWithValue("@Funcao", funcao);


                //Executar a query, ou seja, realizar a função do mysql acima.
                comando.ExecuteNonQuery();

                conexao.Close();// Fechamento dessa conexão criada
                return "Dados Alterados com Sucesso";// Mostrar uma caixa de mensagem informando que a conexão foi um sucesso


            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        public void ExcluirUsuario(string usuario)
        {
            try
            {

                conexao = new MySqlConnection(conectabanco);// Criação da conexão com o banco de dados
                comando = new MySqlCommand("DELETE FROM Usuarioscadastrados WHERE Usuario = @Usuario", conexao);

                conexao.Open();

                comando.Parameters.AddWithValue("@Usuario", usuario);

                comando.ExecuteNonQuery();

                conexao.Close();// Fechamento dessa conexão criada
                MessageBox.Show( "Dados Excluídos");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }

        }
        public void EditarProduto(string nome, string empresa, string quantidade, string preco, string codigo, string id)
        {
            try
            {

                conexao = new MySqlConnection(conectabanco);// Criação da conexão com o banco de dados
                comando = new MySqlCommand("UPDATE ProdutosCadastrados SET Nome = @Nome, Empresa = @Empresa, Quantidade = @Quantidade, Preco = @Preco, Codigo = @Codigo WHERE id = @id", conexao);//Realizar esse comando do mysql

                conexao.Open();// Abetura dessa conexão criada

                //Adicionar os valores presentes nesse comando.
                comando.Parameters.AddWithValue("@Nome", nome);
                comando.Parameters.AddWithValue("@Empresa", empresa);
                comando.Parameters.AddWithValue("@Quantidade", quantidade);
                comando.Parameters.AddWithValue("@Preco", preco);
                comando.Parameters.AddWithValue("@Codigo", codigo);
                comando.Parameters.AddWithValue("@id", id);



                //Executar a query, ou seja, realizar a função do mysql acima.
                comando.ExecuteNonQuery();

                conexao.Close();// Fechamento dessa conexão criada
                MessageBox.Show("Dados Alterados com Sucesso");// Mostrar uma caixa de mensagem informando que a conexão foi um sucesso


            }
            catch (Exception erro)
            {
                MessageBox.Show( erro.ToString());
            }
        }
        public void ExcluirProduto(string id)
        {
            try
            {

                conexao = new MySqlConnection(conectabanco);// Criação da conexão com o banco de dados
                comando = new MySqlCommand("DELETE FROM ProdutosCadastrados WHERE id= @id", conexao);

                conexao.Open();

                comando.Parameters.AddWithValue("@id",id);

                comando.ExecuteNonQuery();

                conexao.Close();// Fechamento dessa conexão criada
                MessageBox.Show("Dados Excluídos");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }

        }
    }
}
