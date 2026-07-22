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
    public class UsuarioRepository
    {

        public Usuario Login(string email, string senha)
        {

            // Instrução SQL para autenticar o usuário
            string sql = "SELECT * FROM tbl_usuarios " +
                "WHERE email = @Email AND senha = @Senha";

            // Abrir a conexao com banco
            using var conexao = Conexao.GetConexao();

            // Criar o comando
            using var comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Senha", senha);

            // Executo o comando
            SqlDataReader resultado = comando.ExecuteReader();

            // Cria um objeto Usuario com os dados do banco
            Usuario usuarioLogado = null;

            if (resultado.Read()) { 
                usuarioLogado = new Usuario();

                usuarioLogado.Id = resultado.GetInt32(resultado.GetOrdinal("usuario_id"));
                usuarioLogado.Nome = resultado.GetString(resultado.GetOrdinal("nome"));
                usuarioLogado.Email = resultado.GetString(resultado.GetOrdinal("email"));
                usuarioLogado.Senha = resultado.GetString(resultado.GetOrdinal("senha"));
            }

            return usuarioLogado;
        }

    }
}
