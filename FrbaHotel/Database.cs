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

        internal static void cargarGriddCliente(DataGridView dgv, String nombre, String apellido, String email)
        {

            SqlConnection connection = new SqlConnection(@"Data source=.\SQLSERVER2012; Initial Catalog=GD1C2018; User id=gdHotel2018; Password= gd2018"); ;
            connection.Open();
            try
            {
                String query = "SELECT [cliente_nombre],[cliente_apellido],[cliente_email],[cliente_tipoIdentificacion],[cliente_identificacion] FROM [GD1C2018].[pero_compila].[Cliente] where cliente_estado = 1 and [cliente_nombre] like '" + nombre + "%' and [cliente_apellido] like '" + apellido + "%' and [cliente_email] like '" + email + "%'";
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

    }
}
