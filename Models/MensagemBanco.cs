using System.Collections.Generic;
using MySqlConnector;

namespace BlackImoveisII.Models
{
    public class MensagemBanco
    {
        private const string dadosConexao = "Database=BlackImoveis; Data Source=localhost; User Id=root;";
        //------------------------------- INSERIR DADOS NA TABELA MENSAGEM-----------------------------------------
        public void Insert(Mensagem novaMensagem)
        {
            MySqlConnection conexao = new MySqlConnection (dadosConexao);
            conexao.Open();
            string query = "INSERT INTO mensagens(Nome, Sobrenome, Email, Telefone, Mensagens) VALUES (@Nome, @Sobrenome, @Email, @Telefone, @Mensagens)";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@Nome", novaMensagem.Nome); // Pega o comando, testa no banco de dados, vai por as aspas e aspas simples e testar antes de por no bando de dados.
            comando.Parameters.AddWithValue("@Sobrenome", novaMensagem.Sobrenome);
            comando.Parameters.AddWithValue("@Email", novaMensagem.Email);
            comando.Parameters.AddWithValue("@Telefone", novaMensagem.Telefone);
            comando.Parameters.AddWithValue("@Mensagens", novaMensagem.Mensagens);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        //------------------------------- LISTAR DADOS DA TABELA MENSAGEM-----------------------------------------
        public List<Mensagem> Query()
        {
            MySqlConnection conexao = new MySqlConnection (dadosConexao);

            conexao.Open();
            string query = "SELECT * FROM Mensagens";

            MySqlCommand comando = new MySqlCommand(query, conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            List<Mensagem> lista = new List<Mensagem>();
            while(reader.Read())
            {
                Mensagem m = new Mensagem();
                m.Id = reader.GetInt32("Id");
                
                if (!reader.IsDBNull(reader.GetOrdinal("Nome"))) //Verificação. Se o dado não estiver nulo. GetOrdinal garante performance mais otimizada.
                {
                    m.Nome = reader.GetString("Nome");
                }

                if (!reader.IsDBNull(reader.GetOrdinal("Sobrenome")))
                {
                    m.Sobrenome = reader.GetString("Sobrenome");
                }

                if(!reader.IsDBNull(reader.GetOrdinal("Email")))
                {
                    m.Email = reader.GetString("Email");
                }

                if(!reader.IsDBNull(reader.GetOrdinal("Mensagens")))
                {
                    m.Mensagens = reader.GetString("Mensagens");
                }

                m.Telefone = reader.GetInt32("Telefone");

                lista.Add(m);
            }

            conexao.Close();
            return lista;

        }
    }
}