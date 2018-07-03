﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace FrbaHotel.AbmRol
{
    public class RolDAL
    {

        public static bool CrearRol(String Nombre, int habilitado, String funcionalidad)
        {
            SqlConnection Conexion = BDComun.ObtenerConexion();
            try
            {


                SqlCommand comando = new SqlCommand("pero_compila.sp_alta_rol", Conexion);
                comando.CommandType = CommandType.StoredProcedure;
                //se limpian los parámetros
                comando.Parameters.Clear();
                //comenzamos a mandar cada uno de los parámetros, deben de enviarse en el
                //tipo de datos que coincida en sql server por ejemplo c# es string en sql server es varchar()
                comando.Parameters.AddWithValue("@nombre", Nombre);
                comando.Parameters.AddWithValue("@habilitado", habilitado);
                comando.Parameters.AddWithValue("@funcionalidad", funcionalidad);

                if (comando.ExecuteNonQuery() > 0)
                {
                    Conexion.Close();
                    return true;
                }
                else
                {
                    Conexion.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                Conexion.Close();
                return false;
            }
        }
        
       
        
        public static int insert(String Nombre)
        {
            SqlConnection Conexion = BDComun.ObtenerConexion();
            try
            {
                SqlCommand comando = new SqlCommand("pero_compila.sp_solo_alta_rol", Conexion);
                comando.CommandType = CommandType.StoredProcedure;
                //se limpian los parámetros
                comando.Parameters.Clear();
                //comenzamos a mandar cada uno de los parámetros, deben de enviarse en el
                //tipo de datos que coincida en sql server por ejemplo c# es string en sql server es varchar()
                comando.Parameters.AddWithValue("@nombre", Nombre);
                comando.Parameters.AddWithValue("@habilitado", true);
                //int id = comando.ExecuteNonQuery();
                //int id = Convert.ToInt32(comando.ExecuteScalar());
                int id = Convert.ToInt32(comando.ExecuteScalar());
                if (id > 0)
                {
                    //comando.CommandText = "Select Max(rol_Id) from [pero_compila].[Rol]";
                    //id= Convert.ToInt32(comando.ExecuteScalar());
                    //Conexion.Close();
                    return id;
                }
                else
                {
                    Conexion.Close();
                    return id;
                }

            }
            catch (Exception ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message, "ERRROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.);
                Conexion.Close();
                return 0;
            }
        }
       
        //public static bool ModificarRol(int id, String nombre, int habilitado, String Func)
        //{
        //    int Valor_Retornado = 0;
        //    try
        //    {

        //        SqlConnection Conexion = BDComun.ObtenerConexion();
        //        SqlCommand comando = new SqlCommand("pero_compila.sp_update_rol", Conexion);
        //        comando.CommandType = CommandType.StoredProcedure;
        //        //se limpian los parámetros
        //        comando.Parameters.Clear();
        //        //comenzamos a mandar cada uno de los parámetros, deben de enviarse en el
        //        //tipo de datos que coincida en sql server por ejemplo c# es string en sql server es varchar()
        //        comando.Parameters.AddWithValue("@rol_id", id);
        //        comando.Parameters.AddWithValue("@rol_nombre", nombre);
        //        comando.Parameters.AddWithValue("@rol_habilitado", habilitado);
        //        comando.Parameters.AddWithValue("@rol_funcionalidades", Func);


        //        if (comando.ExecuteNonQuery() > 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
        public static bool ModificarRol(int id, String nombre, int habilitado)
        {
            try
            {

                SqlConnection Conexion = BDComun.ObtenerConexion();
                SqlCommand comando = new SqlCommand("pero_compila.sp_update_rol", Conexion);
                comando.CommandType = CommandType.StoredProcedure;
                //se limpian los parámetros
                comando.Parameters.Clear();
                //comenzamos a mandar cada uno de los parámetros, deben de enviarse en el
                //tipo de datos que coincida en sql server por ejemplo c# es string en sql server es varchar()
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@habilitado", habilitado);
                //comando.Parameters.AddWithValue("@rol_funcionalidades", Func);
                return comando.ExecuteNonQuery() > 0 ? true : false;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static int SacarRolATodosLosUsuarios(int idRol)
        {

            int reader = 0;
            List<String> roles = new List<String>();

            using (SqlConnection Conexion = BDComun.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(String.Format("delete from pero_compila.RolXUsuario  where rolXUsuario_rol='{0}' ", idRol), Conexion);
                reader = Comando.ExecuteNonQuery();


                Conexion.Close();
            }


            return reader;
        }
        public static bool EliminarRol(int idRol)
        {
            try
            {
                SqlConnection Conexion = BDComun.ObtenerConexion();
                SqlCommand comando = new SqlCommand("pero_compila.sp_baja_rol", Conexion);
                comando.CommandType = CommandType.StoredProcedure;
                //se limpian los parámetros
                comando.Parameters.Clear();
                //comenzamos a mandar cada uno de los parámetros, deben de enviarse en el
                //tipo de datos que coincida en sql server por ejemplo c# es string en sql server es varchar()
                comando.Parameters.AddWithValue("@Id", idRol);
                return comando.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (Exception ex) { return false; }
        }
        public static List<Rol> BuscarRol()
        {
            List<Rol> roles = new List<Rol>();
            try
            {
                using (SqlConnection Conexion = BDComun.ObtenerConexion())
                {
                    SqlCommand comando = new SqlCommand("pero_compila.sp_get_roles", Conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    //se limpian los parámetros
                    //comando.Parameters.Clear();
                    //executamos la consulta SqlDataReader reader = Comando.ExecuteReader();
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        Rol rol = new Rol();
                        rol.Id = reader.GetInt32(0);
                        rol.Nombre = reader.GetString(1);
                        rol.funcionalidad = null;
                        rol.habilitado = 1;
                        rol.RolesPorUsuario = "";

                        roles.Add(rol);
                    }

                }
            }
            catch (Exception)
            {
                return null;
            }
            return roles;
        }

        public static List<Rol> BuscarRolesHabilitadosEInhabilitados()
        {
            List<Rol> roles = new List<Rol>();
            try
            {
                using (SqlConnection Conexion = BDComun.ObtenerConexion())
                {
                    SqlCommand Comando = new SqlCommand(String.Format("SELECT * from pero_compila.Rol "), Conexion);
                    SqlDataReader reader = Comando.ExecuteReader();
                    while (reader.Read())
                    {
                        Rol rol = new Rol();
                        rol.Id = reader.GetInt32(0);
                        rol.Nombre = reader.GetString(1);


                        roles.Add(rol);
                    }

                }
            }
            catch (Exception)
            {
                return null;
            }
            return roles;
        }


        public int RolId(String nombreRol)
        {
            int id = 0;
            using (SqlConnection Conexion = BDComun.ObtenerConexion())
            {

                Rol rol = new Rol();
                SqlCommand Comando = new SqlCommand(String.Format("select rol_id from pero_compila.Rol where rol_nombre = '{0}'", nombreRol), Conexion);
                SqlDataReader reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);

                }

                Conexion.Close();
            }
            return id;

        }

    }
}
