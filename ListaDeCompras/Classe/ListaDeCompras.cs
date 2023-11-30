using ListaDeCompras.Classe.Banco;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ListaDeCompras.Classe
{


    internal class ListaDeCompras
    {
        public int Id { get; set; }
        public string Nome_item { get; set; }
        public string Prioridade { get; set; }
        public int Quantidade { get; set; }
        public bool Apagar()
        {
            string comando = "DELETE FROM listacompras WHERE id= @id";
            Banco.ConexaoBDcs conexaoBD = new Banco.ConexaoBDcs();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
        public DataTable ListarTudo()
        {
            string comando = "SELECT id, nome_item, prioridade, quantidade FROM listacompras";

            Banco.ConexaoBDcs conexaoBD = new Banco.ConexaoBDcs();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public bool Inserir()
        {

            string comando = "INSERT INTO listacompras (nome_item, quantidade, prioridade) " +
                "VALUES (@nome_item, @quantidade, @prioridade)";
            Banco.ConexaoBDcs conexaoBD = new Banco.ConexaoBDcs();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome_item", Nome_item);
            cmd.Parameters.AddWithValue("@quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@prioridade", Prioridade);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }

        }

        public bool Editar()
        {

            string comando = "UPDATE listacompras SET nome_item = @nome_item, " +
                "quantidade =  @quantidade, prioridade = @prioridade Where id = @id";
            Banco.ConexaoBDcs conexaoBD = new Banco.ConexaoBDcs();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome_item", Nome_item);
            cmd.Parameters.AddWithValue("@prioridade", Prioridade);
            cmd.Parameters.AddWithValue("@quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }


        }
    }
}


    

