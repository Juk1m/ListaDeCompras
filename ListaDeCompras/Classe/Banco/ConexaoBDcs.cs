using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace ListaDeCompras.Classe.Banco
{
    internal class ConexaoBDcs
    {
         private const string SERVER = "localhost",

                             PORT = "3306",

                             DATABASE = "listacompras",

                             UID = "root",

                             PWD = "";

        
        public MySqlConnection ObterConexao()

        {

            MySqlConnection con = null;
            try
            {

                con = new MySqlConnection("SERVER=" + SERVER + ";PORT=" + PORT + ";DATABASE=" + DATABASE + ";UID=" + UID + ";PWD=" + PWD + ";");
                con.Open();

            }

            catch (MySqlException e)

            {

                Console.WriteLine(e.ToString());

                Console.WriteLine("Não foi possível realizar a conexão.");

            }

            return con;

        }

        

        public bool ConexaoAberta(MySqlConnection con)

        {

            return (con.State == ConnectionState.Open);

        }

        

        public void Desconectar(MySqlConnection con)

        {

            try

            {
                con.Close();

            }

            catch (MySqlException e)

            {

                Console.WriteLine(e.ToString());

                Console.WriteLine("Não foi possível encerrar a conexão.");

            }

        }

    }
}

