using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace conexcioBD
{
    public class BDcomun
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection Conexion = new MySqlConnection(@"server=localhost; database=seminario; Uid=root; pwd=;");
            Conexion.Open();
            return Conexion;

        }
    }
}
