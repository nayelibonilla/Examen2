
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Examen.CapaLogica
{
    public class DBconn
    {
        public SqlConnection Conectar()
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();

            return conexion;
        }
    }
}
