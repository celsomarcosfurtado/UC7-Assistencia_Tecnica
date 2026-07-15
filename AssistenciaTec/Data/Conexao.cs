
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistenciaTec.Data
{
    public class Conexao
    {
        private static readonly string ConexaoString = @"Server=OSA0716396W11-1\SQLEXPRESS;Database=db_assistencia;Trusted_Connection=True;TrustServerCertificate=True;";

       public static SqlConnection GetConexao()
        {

            try
            {
                //SqlConnection conexao = new SqlConnection(ConexaoString);
                var conexao = new SqlConnection(ConexaoString);
                conexao.Open();

                /*
                 * MessageBox.Show(
                    "Conexão efetuada com sucesso", 
                    "Conectado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                */

                return conexao;
            }
            catch ( Exception ex )
            {
                MessageBox.Show(
                    "Ocorreu um erro na conexão!" + ex.Message,
                    "Falha",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return null;

            }

        }

    }
}
