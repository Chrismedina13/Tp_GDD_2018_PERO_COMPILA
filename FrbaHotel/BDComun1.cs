using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrbaHotel
{
      public class BDComun
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conexion = new SqlConnection(@"Data source=.\SQLSERVER2012; Initial Catalog=GD1C2018; User id=gdHotel2018; Password= gd2018");
            Conexion.Open();
            return Conexion;
        }

    }
}


