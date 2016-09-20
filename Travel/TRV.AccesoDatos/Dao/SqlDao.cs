using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRV.AccesoDatos.Dao
{
    public class SqlDao
    {
        private static string CONNECTION_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["TRV_DB"].ConnectionString.ToString();
        //private static string CONNECTION_STRING = @"Data Source=SQL5028.Smarterasp.net;Initial Catalog=DB_A06942_GreenCodeTechn;User ID=DB_A06942_GreenCodeTechn_admin;Password=12345678c";
        //private static string CONNECTION_STRING = "server = localhost;Database=TRV_DB;Trusted_Connection=true";
        //private static string CONNECTION_STRING = @"Data Source=DESKTOP-TR2EV5L\MSSQLSERVER2014;Initial Catalog=TRV_DB;Integrated Security=True";
        //private static string CONNECTION_STRING = @"Data Source=DESKTOP-9IDBMOP\;Initial Catalog=TRV_DB;Integrated Security=True";

        public static void ExecuteProcedure(SqlOperation sqlOperation)
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            using (var command = new SqlCommand(sqlOperation.ProcedureName, conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                foreach (var param in sqlOperation.Parameters)
                {
                    command.Parameters.Add(param);
                }

                conn.Open();
                command.ExecuteNonQuery();
            }
        }

        public static List<Dictionary<string, object>> ExecuteQueryProcedure(SqlOperation sqlOperation)
        {

            var lstResult = new List<Dictionary<string, object>>();

            using (var conn = new SqlConnection(CONNECTION_STRING))
            using (var command = new SqlCommand(sqlOperation.ProcedureName, conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                foreach (var param in sqlOperation.Parameters)
                {
                    command.Parameters.Add(param);
                }

                conn.Open();
                var reader = command.ExecuteReader();//Ejecuta una lectura.
                if (reader.HasRows)//si hay filas
                {
                    while (reader.Read())
                    {
                        //Dictionary es como un hashmap en java <key,value>
                        var dict = new Dictionary<string, object>();

                        for (var lp = 0; lp < reader.FieldCount; lp++)
                        {
                            dict.Add(reader.GetName(lp), reader.GetValue(lp));
                        }
                        lstResult.Add(dict);
                    }
                }
            }

            return lstResult;


        }

        public static bool ExecuteQueryProcedureBoolean(SqlOperation sqlOperation)
        {
            bool itWorked = false;

            using (var conn = new SqlConnection(CONNECTION_STRING))
            using (var command = new SqlCommand(sqlOperation.ProcedureName, conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                foreach (var param in sqlOperation.Parameters)
                {
                    command.Parameters.Add(param);
                }

                conn.Open();
                var reader = command.ExecuteNonQuery();
                if (reader > 0)
                {
                    itWorked = true;
                }
            }

            return itWorked;
        }

        public static bool CanExecuteQueryProcedure(SqlOperation sqlOperation)
        {
            bool resul = false;
            var lstResult = new List<Dictionary<string, object>>();

            using (var conn = new SqlConnection(CONNECTION_STRING))
            using (var command = new SqlCommand(sqlOperation.ProcedureName, conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                // Entra solo si el procedimiento tiene parametros
                foreach (var param in sqlOperation.Parameters)
                {
                    command.Parameters.Add(param);
                }

                conn.Open();
                var upt = command.ExecuteNonQuery();

                if (upt > 0)
                {
                    resul = true;
                }
            }

            return resul;
        }

    }
}
