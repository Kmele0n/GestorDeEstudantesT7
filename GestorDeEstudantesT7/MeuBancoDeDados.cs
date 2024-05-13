using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestorDeEstudantesT7
{
    internal class MeuBancoDeDados
    {
        //conexao c o banco d dados tlgd
       private MySqlConnection conexao = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=sga_estudantes_bd_t7");

        public MySqlConnection getConexao
        {
            get
            {
                return conexao;
            }
        }

        public void abrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }

        // Função para FECHAR a conexão c o banco de dados.
        public void fecharConexao()
        {
            if(conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
