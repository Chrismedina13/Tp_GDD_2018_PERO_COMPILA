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
        public int Id { get; set; }
        public String Nombre { get; set; }
        
        public String UsuarioPorHotel { get; set; }
        public List<String> getHotelPorUsuario(String nombreUser, String rolUsuario)
        {
            {
                List<String> hoteles = new List<String>();

                using (SqlConnection Conexion = BDComun.ObtenerConexion())
                {
                    SqlCommand Comando = new SqlCommand(String.Format("select distinct H.hotel_direccion FROM pero_compila.Usuario u JOIN pero_compila.UsuarioXHotel uxh ON (u.usuario_ID = uxh.UsuarioXHotel_usuario) JOIN pero_compila.Hotel h ON (h.hotel_id=uxh.UsuarioXHotel_hotel) JOIN pero_compila.RolXUsuario rxu ON(rxu.rolXUsuario_usuario=u.usuario_Id) JOIN pero_compila.Rol r ON(r.rol_Id=rxu.rolXUsuario_rol) WHERE u.usuario_username LIKE '{0}' and h.hotel_estado=1 and hotel_id not like 'null' and r.rol_nombre LIKE '{1}'", nombreUser, rolUsuario), Conexion);
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

        public List<Hotel> getListHoteles()
        {
            List<Hotel> hots = new List<Hotel>();

            using (SqlConnection Conexion = BDComun.ObtenerConexion())
            {
                //SqlCommand Comando = new SqlCommand(String.Format(" SELECT DISTINCT hotel_id,hotel_nombre from pero_compila.Hotel where hotel_nombre not like 'null'"), Conexion);
                SqlCommand Comando = new SqlCommand(String.Format("  SELECT DISTINCT hotel_id,hotel_direccion from pero_compila.Hotel where hotel_direccion not like 'null'"), Conexion);
                
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    Hotel h = new Hotel();
                    h.Id = reader.GetInt32(0);
                    h.Nombre = reader.GetString(1);

                    hots.Add(h);
                }
                Conexion.Close();
            }
            return hots;
        }

        public static int insert(int idUsuario, int idHotel)
        {
            SqlConnection Conexion = BDComun.ObtenerConexion();
            try
            {


                SqlCommand comando = new SqlCommand("pero_compila.sp_alta_usuarioXHotel", Conexion);
                comando.CommandType = CommandType.StoredProcedure;
                //se limpian los parámetros
                comando.Parameters.Clear();
                //comenzamos a mandar cada uno de los parámetros, deben de enviarse en el
                //tipo de datos que coincida en sql server por ejemplo c# es string en sql server es varchar()
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                comando.Parameters.AddWithValue("@idHotel", idHotel);
                if (comando.ExecuteNonQuery() > 0)
                {
                    Conexion.Close();
                    return 1;
                }
                else
                {
                    Conexion.Close();
                    return 0;
                }

            }
            catch (Exception ex)
            {
                Conexion.Close();
                return 0;
            }
        }


    }
}
