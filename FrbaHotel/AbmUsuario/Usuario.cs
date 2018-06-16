using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.AbmUsuario
{
    class Usuario
    {
        public string getHotel(string user)
        {
            string hotel = "";
            using (SqlConnection Conexion = BDComun.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(String.Format("select h.hotel_nombre from pero_compila.Usuario u join pero_compila.UsuarioXHotel uxh on(u.usuario_Id=uxh.usuarioXHotel_usuario) join pero_compila.Hotel h on(h.hotel_Id=uxh.usuarioXHotel_hotel) where  hotel_nombre not like 'null' and  u.usuario_username like'{0}'", user), Conexion);

                SqlDataReader reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    hotel = reader.GetString(0);
                }

                Conexion.Close();
            }
            return hotel;
        }
    
    }
}
