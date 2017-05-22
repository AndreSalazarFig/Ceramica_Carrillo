using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Library.DAO
{
    public class ConexionBD
    {

        MySqlConnection conn; MySqlCommand comando;
        public ConexionBD()
        {
            conn = new MySqlConnection("Server=localhost; User ID=root; Persist Security info=true; password=Atomiclotus3.;  Database=bdcarrillo");
            comando = new MySqlCommand();
        }

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("Server=localhost; User ID=root; Persist Security info=true; password=Atomiclotus3.;  Database=bdcarrillo");
            conectar.Open();
            return conectar;
            //////////////////////////////////////////////
        }

        public void AbrirConexion() { this.conn.Open(); }
        public void CerarConexion() { this.conn.Close(); }

        public int EjecutarComando(string comandoSQL)
        {
            try
            {
                this.comando.CommandText = comandoSQL;
                this.comando.Connection = this.conn;
                this.AbrirConexion();
                this.comando.ExecuteNonQuery();
                this.CerarConexion();
                return 1;
            }
            catch (MySqlException)
            {
                return 0;
            }
            finally
            {
                this.CerarConexion();
            }
        }

        public int EjecutarSQL(string comandoSQL)
        {
            try
            {
                int valor;
                this.comando.CommandText = comandoSQL;
                this.comando.Connection = this.conn;
                this.AbrirConexion();
                valor = this.comando.ExecuteNonQuery();
                this.CerarConexion();
                return valor;
            }
            catch (MySqlException)
            {
                return -1;
            }
            finally
            {
                this.CerarConexion();
            }
        }

        public DataTable EjercutarSentecia(String comandoSQL)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSQL, this.conn);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

    }
}
