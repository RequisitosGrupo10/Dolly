using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace BDLibrary
{
    public class MySqlBD
    {
        public string origen_datos;
        public string cadenaConexion;
        public string cadenaConexionSQLNCLI;

        public MySqlBD()
        {
            MySqlConnector.MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Port = 3306;
            builder.Server = "database-pevau.cobadwnzalab.eu-central-1.rds.amazonaws.com";
            builder.UserID = "grupo10";
            builder.Password = "6A9WnAAEaNcuYQfe";
            builder.Database = "grupo10DB";
            cadenaConexion = builder.ConnectionString;


        }

        public List<string> getColumnas(string tabla)
        {
            List<string> res = new List<string>();
            string consultaSelect = "SELECT TOP 1 * FROM " + tabla + ";";
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(consultaSelect, conexion);

            conexion.Open();
            System.Data.Common.DbDataReader reader = comando.ExecuteReader();

            reader.Read();
            for (int i = 0; i < reader.FieldCount; ++i) res.Add(reader.GetName(i));

            conexion.Close();
            return res;
        }

        public List<object[]> Select(string consultaSelect)
        {

            if (consultaSelect.Length == 0) return null;
            if (consultaSelect.ToUpper().IndexOf("SELECT") == -1) return null;
            if (consultaSelect.ToUpper().IndexOf("DROP") > -1) return null;

            List<object[]> res = new List<object[]>();
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(consultaSelect, conexion);

            conexion.Open();
            System.Data.Common.DbDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int numColumnas = reader.FieldCount;
                object[] fila = new object[numColumnas];
                for (int i = 0; i < numColumnas; ++i) fila[i] = reader[i];
                res.Add(fila);
            }

            conexion.Close();


            return res;
        }

        public object SelectScalar(string consultaSelect)
        {

            if (consultaSelect.Length == 0) return null;
            if (consultaSelect.ToUpper().IndexOf("SELECT") == -1) return null;
            if (consultaSelect.ToUpper().IndexOf("DROP") > -1) return null;


            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(consultaSelect, conexion);

            conexion.Open();
            object res = comando.ExecuteScalar();

            conexion.Close();


            return res;
        }

        public void Update(string cadenaUpdate)
        {
            if (cadenaUpdate.Length == 0) return;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(cadenaUpdate, conexion);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void Delete(string cadenaDelete)
        {
            if (cadenaDelete.Length == 0) return;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(cadenaDelete, conexion);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void Insert(string cadenaInsert)
        {
            if (cadenaInsert.Length == 0) return;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            MySqlCommand comando = new MySqlCommand(cadenaInsert, conexion);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void EjecutaProcedimiento(string name, MySqlParameter[] param)
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexionSQLNCLI);
            MySqlCommand comando = new MySqlCommand(name, conexion);
            foreach (MySqlParameter p in param)
            {
                comando.Parameters.Add(p);
            }
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

    }

}