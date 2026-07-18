using AssistenciaTec.Data;
using AssistenciaTec.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistenciaTec.Repository
{
    public class ClienteRepository
    {

        public int Salvar(Cliente cliente)
        {

            // Criar a instrução SQL de INSERT
            string sql = "INSERT INTO tbl_clientes (nome, email, telefone, endereco) " +
                "OUTPUT INSERTED.cliente_id " +
                "VALUES (@Nome, @Email, @Telefone, @Endereco)";

            // Criar/abrir a conexão com o banco de dados
            using var conexao = Conexao.GetConexao();

            // Criar o comando que será enviado ao banco de dados
            using var comando = new SqlCommand(sql, conexao);

            // Preecher os campos da instrução sql com os valores
            comando.Parameters.AddWithValue("@Nome", cliente.Nome);
            comando.Parameters.AddWithValue("@Email", cliente.Email);
            comando.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            comando.Parameters.AddWithValue("@Endereco", cliente.Endereco);

            // Executar o comando
            var novoId = (int)comando.ExecuteScalar(); // casting

            return novoId;

            //Da forma antiga, não esquecer de fechar a conexão depois de usar
            //conexao.Close();

        }

        public List<Cliente> ListarTodos()
        {

            // Criar a instrução SQL para listar todos
            var sql = "select * from tbl_clientes order by nome ASC";

            // Abrir a conexão com o banco
            using var conexao = Conexao.GetConexao();

            // Criar o comando
            using var comando = new SqlCommand(sql, conexao);

            // Criar o objeto que guarda o resultado do comando SELECT
            using var resultado = comando.ExecuteReader();

            // Criar uma lista de clientes vazia
            List<Cliente> clientes = new List<Cliente>();

            while (resultado.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = resultado.GetInt32(resultado.GetOrdinal("cliente_id"));
                cliente.Nome = resultado.GetString(resultado.GetOrdinal("nome"));
                cliente.Email = resultado.GetString(resultado.GetOrdinal("email"));
                cliente.Telefone = resultado.GetString(resultado.GetOrdinal("telefone"));
                cliente.Endereco = resultado.GetString(resultado.GetOrdinal("endereco"));
                clientes.Add(cliente);
            }

            return clientes;
        }

        public int excluir(int id)
        {
            // Instrução SQL de exclusão
            var sql = "DELETE FROM tbl_clientes WHERE cliente_id = @Id";

            // Abrir a conexão com o banco
            using var conexao = Conexao.GetConexao();

            // Criar o comando
            using var comando = new SqlCommand(sql, conexao);

            // Substituir o parâmetro @Id do SQL pelo valor do id do cliente
            comando.Parameters.AddWithValue("@Id", id);

            // Executar o comando
            var resultado = comando.ExecuteNonQuery();

            return resultado;

        }

        public int atualizar(Cliente cliente)
        {
            // Instrução SQL para atualização do cliente
            var sql = "UPDATE tbl_clientes SET nome = @Nome, " +
                "email = @Email, " +
                "telefone = @Telefone, " +
                "endereco = @Endereco " +
                "WHERE cliente_id = @Id";

            // Abrir a conexão com o banco de dados
            using var conexao = Conexao.GetConexao();

            // Criar o comando que será enviado ao banco de dados
            using var comando = new SqlCommand(sql, conexao);

            // Preecher os campos da instrução sql com os valores
            comando.Parameters.AddWithValue("@Nome", cliente.Nome);
            comando.Parameters.AddWithValue("@Email", cliente.Email);
            comando.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            comando.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            comando.Parameters.AddWithValue("@Id", cliente.Id);

            var resultado = comando.ExecuteNonQuery();

            return resultado;

        }

        public List<Cliente> ListarPorNome(string nome)
        {

            // Criar a instrução SQL para listar todos
            var sql = "SELECT * FROM tbl_clientes " +
                "WHERE nome LIKE @Nome " +
                "ORDER BY nome ASC";

            // Abrir a conexão com o banco
            using var conexao = Conexao.GetConexao();

            // Criar o comando
            using var comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Nome", "%" + nome + "%");

            // Criar o objeto que guarda o resultado do comando SELECT
            using var resultado = comando.ExecuteReader();

            // Criar uma lista de clientes vazia
            List<Cliente> clientes = new List<Cliente>();

            while (resultado.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = resultado.GetInt32(resultado.GetOrdinal("cliente_id"));
                cliente.Nome = resultado.GetString(resultado.GetOrdinal("nome"));
                cliente.Email = resultado.GetString(resultado.GetOrdinal("email"));
                cliente.Telefone = resultado.GetString(resultado.GetOrdinal("telefone"));
                cliente.Endereco = resultado.GetString(resultado.GetOrdinal("endereco"));
                clientes.Add(cliente);
            }

            return clientes;

        }

    }
}
