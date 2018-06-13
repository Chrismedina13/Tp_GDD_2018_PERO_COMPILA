using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace FrbaHotel
{
    class Database
    {
        internal static void AddCliente(string nombre, string apellido, string mail, string telefono, string nacionalidad, DateTime fechanacimiento, string Tipoidentificacion, int numeroIdentificacion ,string calle,string numeroCalle, int piso, string dto, String localidad)
        {

            SqlConnection connection = new SqlConnection(@"Data source=.\SQLSERVER2012; Initial Catalog=GD1C2018; User id=gdHotel2018; Password= gd2018");
            SqlCommand addClienteCommand = new SqlCommand("insert into [GD1C2018].[pero_compila].[Cliente] (cliente_nombre, cliente_apellido, cliente_identificacion , cliente_tipoIdentificacion, cliente_email ,cliente_telefono,cliente_direccion,cliente_calle,cliente_piso,cliente_depto,cliente_localidad,cliente_paisOrigen,cliente_nacionalidad,cliente_fecha_nacimiento,cliente_estado) values (@nombre,@apellido,@numeroIdentificacion,@Tipoidentificacion,@mail,@telefono,@calle,@numeroCalle,@piso,@dto,@localidad,NULL,@nacionalidad,@fechanacimiento,1)");
            addClienteCommand.Parameters.AddWithValue("nombre", nombre);
            addClienteCommand.Parameters.AddWithValue("apellido", apellido);
            addClienteCommand.Parameters.AddWithValue("numeroIdentificacion", numeroIdentificacion);
            addClienteCommand.Parameters.AddWithValue("Tipoidentificacion", Tipoidentificacion);
            addClienteCommand.Parameters.AddWithValue("mail", mail);
            addClienteCommand.Parameters.AddWithValue("telefono", telefono);
            addClienteCommand.Parameters.AddWithValue("calle", calle);
            addClienteCommand.Parameters.AddWithValue("numeroCalle", numeroCalle);
            addClienteCommand.Parameters.AddWithValue("piso", piso);
            addClienteCommand.Parameters.AddWithValue("dto", dto);
            addClienteCommand.Parameters.AddWithValue("localidad", localidad);
            addClienteCommand.Parameters.AddWithValue("nacionalidad", nacionalidad);
            addClienteCommand.Parameters.AddWithValue("fechanacimiento", fechanacimiento);
            addClienteCommand.Connection = connection;
            connection.Open();
            int registrosModificados = addClienteCommand.ExecuteNonQuery();
            connection.Close();
            if (registrosModificados > 0) MessageBox.Show("Cliente ingresado correctamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Error al cargar registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        internal static bool ExisteMail(string mail)
        {
            String mailCliente = null;
            SqlConnection connection = new SqlConnection(@"Data source=.\SQLSERVER2012; Initial Catalog=GD1C2018; User id=gdHotel2018; Password= gd2018");
            SqlCommand mailExistente = new SqlCommand("SELECT cliente_nombre FROM [GD1C2018].[pero_compila].[Cliente] WHERE cliente_email = @mail");
            mailExistente.Parameters.AddWithValue("mail", mail);
            mailExistente.Connection = connection;
            connection.Open();
            SqlDataReader reader = mailExistente.ExecuteReader();
            while (reader.Read())
            {
                mailCliente = reader["cliente_nombre"].ToString();
            }
            connection.Close();
            return mailCliente != null;
        }

        internal static void cargarGriddClienteAModificar(DataGridView dgv, String nombre, String apellido, String email)
        {

            SqlConnection connection = new SqlConnection(@"Data source=.\SQLSERVER2012; Initial Catalog=GD1C2018; User id=gdHotel2018; Password= gd2018"); ;
            connection.Open();
            try
            {
                String query = "SELECT [cliente_nombre],[cliente_apellido],[cliente_email],[cliente_tipoIdentificacion],[cliente_identificacion] FROM [GD1C2018].[pero_compila].[Cliente] where [cliente_nombre] like '" + nombre + "%' and [cliente_apellido] like '" + apellido + "%' and [cliente_email] like '" + email + "%' and cliente_estado = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el DataGridView: " + ex.ToString());
            }
            connection.Close();
        }

        internal static bool existeClienteAModificar(string nombre, string apellido, int identificacion ,string email)
        {
            String cliente_nombre = null;
            SqlConnection connection = new SqlConnection(@"Data source=.\SQLSERVER2012; Initial Catalog=GD1C2018; User id=gdHotel2018; Password= gd2018");
            SqlCommand existeCliente = new SqlCommand("SELECT cliente_nombre FROM [GD1C2018].[pero_compila].[Cliente] WHERE cliente_nombre = @nombre and cliente_apellido = @apellido and cliente_identificacion = @identificacion and cliente_email = @email");
            existeCliente.Parameters.AddWithValue("nombre", nombre);
            existeCliente.Parameters.AddWithValue("apellido", apellido);
            existeCliente.Parameters.AddWithValue("identificacion", identificacion);
            existeCliente.Parameters.AddWithValue("email", email);


            existeCliente.Connection = connection;
            connection.Open();
            SqlDataReader reader = existeCliente.ExecuteReader();
            while (reader.Read())
            {
                cliente_nombre = reader["cliente_nombre"].ToString();
            }
            connection.Close();
            return cliente_nombre == null;
        }


        internal static string[] getDatosCliente(string nombreViejo, string apellidoViejo, int identificacionViejo, string emailViejo)
        {
            String[] datos = new string[14];
            SqlConnection connection = new SqlConnection(@"Data source=.\SQLSERVER2012; Initial Catalog=GD1C2018; User id=gdHotel2018; Password= gd2018");
            SqlCommand getDatosClienteCommand = new SqlCommand("SELECT [cliente_nombre],[cliente_apellido],[cliente_identificacion],[cliente_tipoIdentificacion],[cliente_direccion],[cliente_email],[cliente_telefono],[cliente_direccion],[cliente_calle],[cliente_piso],[cliente_depto],[cliente_localidad],[cliente_nacionalidad],[cliente_fecha_nacimiento],[cliente_estado] FROM [GD1C2018].[pero_compila].[Cliente] WHERE cliente_nombre = @nombreViejo AND cliente_apellido = @apellidoViejo AND cliente_identificacion = @identificacionViejo and cliente_email = @emailViejo");
            getDatosClienteCommand.Parameters.AddWithValue("nombreViejo", nombreViejo);
            getDatosClienteCommand.Parameters.AddWithValue("apellidoViejo", apellidoViejo);
            getDatosClienteCommand.Parameters.AddWithValue("identificacionViejo", identificacionViejo);
            getDatosClienteCommand.Parameters.AddWithValue("emailViejo", emailViejo);

            getDatosClienteCommand.Connection = connection;
            connection.Open();
            SqlDataReader reader = getDatosClienteCommand.ExecuteReader();
            while (reader.Read())
            {

                datos[0] = reader["cliente_nombre"].ToString();
                datos[1] = reader["cliente_apellido"].ToString();
                datos[2] = reader["cliente_tipoIdentificacion"].ToString();
                datos[3] = reader["cliente_identificacion"].ToString();
                datos[4] = reader["cliente_email"].ToString();
                datos[5] = reader["cliente_telefono"].ToString();
                datos[6] = reader["cliente_nacionalidad"].ToString();
                datos[7] = reader["cliente_fecha_nacimiento"].ToString();
                datos[8] = reader["cliente_direccion"].ToString();
                datos[9] = reader["cliente_calle"].ToString();
                datos[10] = reader["cliente_piso"].ToString();
                datos[11] = reader["cliente_depto"].ToString();
                datos[12] = reader["cliente_localidad"].ToString();
                datos[13] = reader["cliente_estado"].ToString();
            }
            connection.Close();
            return datos;
        }

        internal static void modificarCliente(String nombre, String apellido, String mail, int identificacion 
       , String nombreNuevo, String apellidoNuevo, int identificacionNueva, String tipoIdentificacionNueva, String mailNuevo, String telefonoNuevo, DateTime FechaNacimientoNueva, String nacionalidadNueva,String calleNueva, String numeroDeCalleNueva,int pisoNuevo, String dtonuevo,String LocalidadNuevo,String HabilitadoNuevo )
        {
            SqlConnection connection = new SqlConnection(@"Data source=.\SQLSERVER2012; Initial Catalog=GD1C2018; User id=gdHotel2018; Password= gd2018");
            SqlCommand updateClienteCommand = new SqlCommand("UPDATE [GD1C2018].[pero_compila].[Cliente] set cliente_nombre = @nombreNuevo, cliente_apellido = @apellidoNuevo, cliente_identificacion = @identificacionNueva, cliente_tipoIdentificacion = @tipoIdentificacionNueva, cliente_email = @mailNuevo , cliente_telefono = @telefonoNuevo, cliente_direccion = @calleNueva, cliente_calle = @numeroDeCalleNueva, cliente_piso = @pisoNuevo,cliente_depto = @dtonuevo,cliente_localidad = @LocalidadNuevo,cliente_nacionalidad = @nacionalidadNueva, cliente_fecha_nacimiento = @FechaNacimientoNueva, cliente_estado = @HabilitadoNuevo  WHERE cliente_nombre = @nombre and cliente_apellido = @apellido and cliente_identificacion = @identificacion and cliente_email = @mail ");

            updateClienteCommand.Parameters.AddWithValue("nombre", nombre);
            updateClienteCommand.Parameters.AddWithValue("apellido", apellido);
            updateClienteCommand.Parameters.AddWithValue("mail", mail);
            updateClienteCommand.Parameters.AddWithValue("identificacion", identificacion);
            updateClienteCommand.Parameters.AddWithValue("nombreNuevo", nombreNuevo);
            updateClienteCommand.Parameters.AddWithValue("apellidoNuevo", apellidoNuevo);
            updateClienteCommand.Parameters.AddWithValue("identificacionNueva", identificacionNueva);
            updateClienteCommand.Parameters.AddWithValue("tipoIdentificacionNueva", tipoIdentificacionNueva);
            updateClienteCommand.Parameters.AddWithValue("mailNuevo", mailNuevo);
            updateClienteCommand.Parameters.AddWithValue("telefonoNuevo", telefonoNuevo);
            updateClienteCommand.Parameters.AddWithValue("FechaNacimientoNueva", FechaNacimientoNueva);
            updateClienteCommand.Parameters.AddWithValue("nacionalidadNueva", nacionalidadNueva);
            updateClienteCommand.Parameters.AddWithValue("calleNueva", calleNueva);
            updateClienteCommand.Parameters.AddWithValue("numeroDeCalleNueva", numeroDeCalleNueva);
            updateClienteCommand.Parameters.AddWithValue("pisoNuevo", pisoNuevo);
            updateClienteCommand.Parameters.AddWithValue("dtonuevo", dtonuevo);
            updateClienteCommand.Parameters.AddWithValue("LocalidadNuevo", LocalidadNuevo);
            updateClienteCommand.Parameters.AddWithValue("HabilitadoNuevo", HabilitadoNuevo);


            updateClienteCommand.Connection = connection;
            connection.Open();
            int FilasAfectadasClientes = updateClienteCommand.ExecuteNonQuery();

            if (FilasAfectadasClientes > 0)
            {
                MessageBox.Show("El cliente se ha modificado exitosamente.", "La base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("El registro que quiso modificar no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        internal static void cargarGriddClienteAEliminar(DataGridView dgv, String nombre, String apellido, String email)
        {

            SqlConnection connection = new SqlConnection(@"Data source=.\SQLSERVER2012; Initial Catalog=GD1C2018; User id=gdHotel2018; Password= gd2018"); ;
            connection.Open();
            try
            {
                String query = "SELECT [cliente_nombre],[cliente_apellido],[cliente_email],[cliente_tipoIdentificacion],[cliente_identificacion] FROM [GD1C2018].[pero_compila].[Cliente] where [cliente_nombre] like '" + nombre + "%' and [cliente_apellido] like '" + apellido + "%' and [cliente_email] like '" + email + "%' and cliente_estado = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el DataGridView: " + ex.ToString());
            }
            connection.Close();
        }

        internal static void deleteCliente(String nombre, String apellido, String email, int identificacion)
        {
            SqlConnection connection = new SqlConnection(@"Data source=.\SQLSERVER2012; Initial Catalog=GD1C2018; User id=gdHotel2018; Password= gd2018"); ;
            SqlCommand deleteClienteCommand = new SqlCommand("update [GD1C2018].[pero_compila].[Cliente] set [cliente_estado] = 0 where cliente_nombre = @nombre and cliente_apellido = @apellido and cliente_identificacion = @identificacion and cliente_email = @email ");
            deleteClienteCommand.Parameters.AddWithValue("nombre", nombre);
            deleteClienteCommand.Parameters.AddWithValue("apellido", apellido);
            deleteClienteCommand.Parameters.AddWithValue("email", email);
            deleteClienteCommand.Parameters.AddWithValue("identificacion", identificacion);


            deleteClienteCommand.Connection = connection;
            connection.Open();

            int FilasAfectadas = deleteClienteCommand.ExecuteNonQuery();

            if (FilasAfectadas > 0) MessageBox.Show("El cliente ha sido dado de baja exitosamente", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("El registro que quiso eliminar no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }





    }
}
