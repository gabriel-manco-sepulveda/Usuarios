using System.Data;
using System.Data.SqlClient;

namespace ProyectoCSharp.CONEXION
{
    public class clsConexion
    {
        public static string Con=(@"Data Source=LAPTOP-11V2KUD2\SQLEXPRESS;Initial Catalog=ProyectoCSharp;Integrated Security=True");
        public static SqlConnection Conectar = new SqlConnection(Con);
        public static void Abrir()
        {
            if(Conectar.State == ConnectionState.Closed)
            {
                Conectar.Open();
            }
        }
        public static void Cerrar()
        {
            if(Conectar.State == ConnectionState.Open)
            {
                Conectar.Close();
            }
        }
    }
}
