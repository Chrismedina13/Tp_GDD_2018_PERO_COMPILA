using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.AbmHotel
{
    class Hotel
    {

        public String UsuarioPorHotel { get; set; }
        public List<String> getHotelPorUsuario(String nombreUser, String rolUsuario)
        {
            {
                List<String> hoteles = new List<String>();

                using (SqlConnection Conexion = BDComun.ObtenerConexion())
                {
                    SqlCommand Comando = new SqlCommand(String.Format("select distinct H.hotel_nombre FROM pero_compila.Usuario u JOIN pero_compila.UsuarioXHotel uxh ON (u.usuario_ID = uxh.UsuarioXHotel_usuario) JOIN pero_compila.Hotel h ON (h.hotel_id=uxh.UsuarioXHotel_hotel) JOIN pero_compila.RolXUsuario rxu ON(rxu.rolXUsuario_usuario=u.usuario_Id) JOIN pero_compila.Rol r ON(r.rol_Id=rxu.rolXUsuario_rol) WHERE u.usuario_username LIKE '{0}' and h.hotel_estado=1 and hotel_nombre not like 'null' and r.rol_nombre LIKE '{1}'", nombreUser, rolUsuario), Conexion);
                    SqlDataReader reader = Comando.ExecuteReader();

                    while (reader.Read())
                    {
                        UsuarioPorHotel = reader.GetString(0);

                        hoteles.Add(UsuarioPorHotel);
                    }
                    Conexion.Close();
                }
                return hoteles;
            }
        }




    }
}
