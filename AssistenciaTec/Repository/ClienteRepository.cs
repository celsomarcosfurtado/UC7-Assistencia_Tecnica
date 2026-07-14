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

    }
}
