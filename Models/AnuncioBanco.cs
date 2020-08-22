using System.Collections.Generic;
using MySqlConnector;

namespace BlackImoveisII.Models
{
    public class AnuncioBanco
    {
        private const string dadosConexao = "Database=BlackImoveis; Data Source=localhost; User Id=root;";

        public void Insert(Anuncio novoAnuncio)
        {
            MySqlConnection conexao = new MySqlConnection (dadosConexao);

            conexao.Open();

            string query = "INSERT INTO Imoveis(Nome, Sobrenome, Email, Telefone, Tipo, TipoServico, Financiamento, Endereco, Cidade, Sala, Quarto, Suite, Varanda, QrtoReversivel, Armarios, WCSocial, Cozinha, Copa, ArmariosCozinha, AreaServico, WCServico, Piscina, SLFesta, Garagem, AreaUtil, ValorImovel, Condominio, IPTU, Comentario, Bairro, Titulo, Descricao, Post) VALUES (@Nome, @Sobrenome, @Email, @Telefone, @Tipo, @TipoServico, @Financiamento, @Endereco, @Cidade, @Sala, @Quarto, @Suite, @Varanda, @QrtoReversivel, @Armarios, @WCSocial, @Cozinha, @Copa, @ArmariosCozinha, @AreaServico, @WCServico, @Piscina, @SLFesta, @Garagem, @AreaUtil, @ValorImovel, @Condominio, @IPTU, @Comentario, @Bairro, @Titulo, @Descricao, @Post)";

            MySqlCommand comando = new MySqlCommand(query, conexao);

            comando.Parameters.AddWithValue("@Nome", novoAnuncio.Nome); // Pega o comando, testa no banco de dados, vai por as aspas e aspas simples e testar antes de por no bando de dados.
            comando.Parameters.AddWithValue("@Sobrenome", novoAnuncio.Sobrenome);
            comando.Parameters.AddWithValue("@Email", novoAnuncio.Email);
            comando.Parameters.AddWithValue("@Telefone", novoAnuncio.Telefone);
            comando.Parameters.AddWithValue("@Tipo", novoAnuncio.Tipo);
            comando.Parameters.AddWithValue("@TipoServico", novoAnuncio.TipoServico);
            comando.Parameters.AddWithValue("@Financiamento", novoAnuncio.Financiamento);
            comando.Parameters.AddWithValue("@Endereco", novoAnuncio.Endereco);
            comando.Parameters.AddWithValue("@Cidade", novoAnuncio.Cidade);
            comando.Parameters.AddWithValue("@Sala", novoAnuncio.Sala);
            comando.Parameters.AddWithValue("@Quarto", novoAnuncio.Quarto);
            comando.Parameters.AddWithValue("@Suite", novoAnuncio.Suite);
            comando.Parameters.AddWithValue("@Varanda", novoAnuncio.Varanda);
            comando.Parameters.AddWithValue("@QrtoReversivel", novoAnuncio.QrtoReversivel);
            comando.Parameters.AddWithValue("@Armarios", novoAnuncio.Armarios);
            comando.Parameters.AddWithValue("@WCSocial", novoAnuncio.WCSocial);
            comando.Parameters.AddWithValue("@Cozinha", novoAnuncio.Cozinha);
            comando.Parameters.AddWithValue("@Copa", novoAnuncio.Copa);
            comando.Parameters.AddWithValue("@ArmariosCozinha", novoAnuncio.ArmariosCozinha);
            comando.Parameters.AddWithValue("@AreaServico", novoAnuncio.AreaServico);
            comando.Parameters.AddWithValue("@WCServico", novoAnuncio.WCServico);
            comando.Parameters.AddWithValue("@Piscina", novoAnuncio.Piscina);
            comando.Parameters.AddWithValue("@SLFesta", novoAnuncio.SLFesta);
            comando.Parameters.AddWithValue("@Garagem", novoAnuncio.Garagem);
            comando.Parameters.AddWithValue("@AreaUtil", novoAnuncio.AreaUtil);
            comando.Parameters.AddWithValue("@ValorImovel", novoAnuncio.ValorImovel);
            comando.Parameters.AddWithValue("@Condominio", novoAnuncio.Condominio);
            comando.Parameters.AddWithValue("@IPTU", novoAnuncio.IPTU);
            comando.Parameters.AddWithValue("@Comentario", novoAnuncio.Comentario);
            comando.Parameters.AddWithValue("@Bairro", novoAnuncio.Bairro);
            comando.Parameters.AddWithValue("@Titulo", novoAnuncio.Titulo);
            comando.Parameters.AddWithValue("@Descricao", novoAnuncio.Descricao);
            comando.Parameters.AddWithValue("@Post", novoAnuncio.Post);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

                public List<Anuncio> Query()
        {
            MySqlConnection conexao = new MySqlConnection (dadosConexao);

            conexao.Open();
            string query = "SELECT * FROM Imoveis";

            MySqlCommand comando = new MySqlCommand(query, conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            List<Anuncio> lista = new List<Anuncio>();
            while(reader.Read())
            {
                Anuncio anun = new Anuncio();
                anun.Id = reader.GetInt32("Id");
                anun.Telefone = reader.GetInt32("Telefone");
                anun.Sala = reader.GetInt32("Sala");
                anun.Quarto = reader.GetInt32("Quarto");
                anun.Suite = reader.GetInt32("Suite");
                if (!reader.IsDBNull(reader.GetOrdinal("Nome"))) //Verificação. Se o dado não estiver nulo. GetOrdinal garante performance mais otimizada.
                {
                    anun.Nome = reader.GetString("Nome");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Sobrenome")))
                {
                    anun.Sobrenome = reader.GetString("Sobrenome");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Email")))
                {
                    anun.Email = reader.GetString("Email");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Tipo")))
                {
                    anun.Tipo = reader.GetString("Tipo");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("TipoServico")))
                {
                    anun.TipoServico = reader.GetString("TipoServico");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Financiamento")))
                {
                    anun.Financiamento = reader.GetBoolean("Financiamento");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Endereco")))
                {
                    anun.Endereco = reader.GetString("Endereco");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Cidade")))
                {
                    anun.Cidade = reader.GetString("Cidade");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Varanda")))
                {
                    anun.Varanda = reader.GetString("Varanda");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("QrtoReversivel")))
                {
                    anun.QrtoReversivel = reader.GetString("QrtoReversivel");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Armarios")))
                {
                    anun.Armarios = reader.GetString("Armarios");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("WCSocial")))
                {
                    anun.WCSocial = reader.GetString("WCSocial");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Cozinha")))
                {
                    anun.Cozinha = reader.GetString("Cozinha");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Copa")))
                {
                    anun.Copa = reader.GetString("Copa");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("ArmariosCozinha")))
                {
                    anun.ArmariosCozinha = reader.GetString("ArmariosCozinha");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("AreaServico")))
                {
                    anun.AreaServico = reader.GetString("AreaServico");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("WCServico")))
                {
                    anun.WCServico = reader.GetString("WCServico");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Piscina")))
                {
                    anun.Piscina = reader.GetString("Piscina");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("SLFesta")))
                {
                    anun.SLFesta = reader.GetString("SLFesta");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Garagem")))
                {
                    anun.Garagem = reader.GetString("Garagem");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("AreaUtil")))
                {
                    anun.AreaUtil = reader.GetDouble("AreaUtil");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("ValorImovel")))
                {
                    anun.ValorImovel = reader.GetDouble("ValorImovel");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Condominio")))
                {
                    anun.Condominio = reader.GetDouble("Condominio");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("IPTU")))
                {
                    anun.IPTU = reader.GetDouble("IPTU");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Comentario")))
                {
                    anun.Comentario = reader.GetString("Comentario");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Bairro")))
                {
                    anun.Bairro = reader.GetString("Bairro");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Titulo")))
                {
                    anun.Titulo = reader.GetString("Titulo");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Descricao")))
                {
                    anun.Descricao = reader.GetString("Descricao");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Post")))
                {
                    anun.Post = reader.GetBoolean("Post");
                }

                lista.Add(anun);
            }

            conexao.Close();
            return lista;

        }
    }
}