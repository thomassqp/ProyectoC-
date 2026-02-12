using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TaskManagerr
{
    public static class conexion
    {
        public static string Cadena =
            @"Server=LAPTOP-CPU3CRKS\SQLEXPRESS02;Database=TaskManager;Trusted_Connection=True;";



        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(Cadena);
        }
    }
}
