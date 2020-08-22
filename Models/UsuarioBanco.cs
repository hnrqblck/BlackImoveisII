using MySqlConnector;
using System.Collections.Generic;

namespace BlackImoveisII.Models
{
    public class UsuarioBanco
    {
        private const string dadosConexao = "Database=BlackImoveis; Data Source=localhost; User Id=root;";
        //------------------------------- INSERIR DADOS NA TABLE USUÁRIO-----------------------------------------
        public void Insert(Usuario novoUsuario)
        {
            MySqlConnection conexao = new MySqlConnection (dadosConexao);

            conexao.Open();

            string query = "INSERT INTO Usuario(Nome, Email, Login, Senha) VALUES (@Nome, @Email, @Login, @Senha)";

            MySqlCommand comando = new MySqlCommand(query, conexao);

            comando.Parameters.AddWithValue("@Nome", novoUsuario.Nome); // Pega o comando, testa no banco de dados, vai por as aspas e aspas simples e testar antes de por no bando de dados.
            comando.Parameters.AddWithValue("@Email", novoUsuario.Email);
            comando.Parameters.AddWithValue("@Login", novoUsuario.Login);
            comando.Parameters.AddWithValue("@Senha", novoUsuario.Senha);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        //------------------------------- LISTAR DADOS DA TABELA USUARIOS-----------------------------------------
        public List<Usuario> Query()
        {
            MySqlConnection conexao = new MySqlConnection (dadosConexao);

            conexao.Open();
            string query = "SELECT * FROM Usuario";

            MySqlCommand comando = new MySqlCommand(query, conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            List<Usuario> lista = new List<Usuario>();
            while(reader.Read())
            {
                Usuario user = new Usuario();
                user.Id = reader.GetInt32("Id");
                
                if (!reader.IsDBNull(reader.GetOrdinal("Nome"))) //Verificação. Se o dado não estiver nulo. GetOrdinal garante performance mais otimizada.
                {
                    user.Nome = reader.GetString("Nome");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Email")))
                {
                    user.Email = reader.GetString("Email");
                }
                if(!reader.IsDBNull(reader.GetOrdinal("Login")))
                {
                    user.Login = reader.GetString("Login");
                }
                if(!reader.IsDBNull(reader.GetOrdinal("Senha")))
                {
                    user.Senha = reader.GetString("Senha");
                }
                lista.Add(user);
            }

            conexao.Close();
            return lista;

        }
        //------------------------------- CONFERIR DADOS DA TABELA USUARIOS P/ LOGIN-----------------------------------------

        public Usuario QueryLogin(Usuario usuario)
        {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string sql = "SELECT * FROM usuario WHERE login = @Login AND senha = @Senha";

            MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
            comandoQuery.Parameters.AddWithValue("@Login", usuario.Login);
            comandoQuery.Parameters.AddWithValue("@Senha", usuario.Senha);
            MySqlDataReader reader = comandoQuery.ExecuteReader();

            Usuario novoUsuario = null;
            if (reader.Read())
            {
                novoUsuario = new Usuario();
                novoUsuario.Id = reader.GetInt32("Id");

                if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                {
                    novoUsuario.Nome = reader.GetString("Nome");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Email")))
                {
                    novoUsuario.Email = reader.GetString("Email");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Login")))
                {
                    novoUsuario.Login = reader.GetString("Login");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Senha")))
                {
                    novoUsuario.Senha = reader.GetString("Senha");
                }
            }
            conexao.Close();
            return novoUsuario;
        }

    }
}