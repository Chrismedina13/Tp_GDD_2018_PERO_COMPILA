using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaHotel.Support;
using System.Windows.Forms;

namespace FrbaHotel.AbmCliente
{
    public partial class ModificarClienteElegido : Form
    {

        String nombre;
        String apellido;
        int nroIdentificacion;
        String email;
            
        public ModificarClienteElegido(string nombreViejo, string apellidoViejo, int nroIdentificacionViejo,string emailViejo)
        {
            InitializeComponent();

            nombre = nombreViejo;
            apellido = apellidoViejo;
            nroIdentificacion = nroIdentificacionViejo;
            email = emailViejo;


            String[] datosClienteElegido = new String[14];
            datosClienteElegido = Database.getDatosCliente(nombreViejo, apellidoViejo, nroIdentificacionViejo, emailViejo);
            textNombre.Text = datosClienteElegido[0];
            textApellido.Text = datosClienteElegido[1];
            textTipoIdentificacion.Text = datosClienteElegido[2];
            textNroIdentificacion.Text = datosClienteElegido[3];
            textMail.Text = datosClienteElegido[4];
            textTelefono.Text = datosClienteElegido[5];
            textNacionalidad.Text = datosClienteElegido[6];
            dateTimePickerFechaNac.Text = datosClienteElegido[7];
            textCalle.Text = datosClienteElegido[8];
            textCalleNro.Text = datosClienteElegido[9];
            textPiso.Text = datosClienteElegido[10];
            textDto.Text = datosClienteElegido[11];
            textLocalidad.Text = datosClienteElegido[12];
            textHabilitado.Text = datosClienteElegido[13];
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            

            String nombreNuevo = textNombre.Text;
            String apellidoNuevo = textApellido.Text;
            int identificacionNuevo = Convert.ToInt32(textNroIdentificacion.Text);
            String tipoIdentificacionNuevo = textTipoIdentificacion.Text;
            String mailNuevo = textMail.Text;
            String telefonoNuevo = textTelefono.Text;
            String nacionalidadNueva = textNacionalidad.Text;
            DateTime fechaNacimientoNueva = Convert.ToDateTime(dateTimePickerFechaNac.Text);
            String calleNueva = textCalle.Text;
            String nroCalleNueva = textCalleNro.Text;
            int pisoNuevo = Convert.ToInt32(textPiso.Text);
            String dtoNuevo = textDto.Text;
            String localidadNueva = textLocalidad.Text;
            string HabilitadoNuevo = textHabilitado.Text;

            if (nombreNuevo == "" | apellidoNuevo == "" | telefonoNuevo == "" | mailNuevo == "" | nacionalidadNueva == "" | mailNuevo == "" | calleNueva == "" | nroCalleNueva == "" | HabilitadoNuevo == "")
            {
                MessageBox.Show("Verifique que los campos obligatorios hayan sido completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (!System.Text.RegularExpressions.Regex.IsMatch(textNroIdentificacion.Text, @"^\d+$"))
                {
                    MessageBox.Show("Sólo se permiten numeros en el DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(textTelefono.Text, @"^\d+$"))
                {
                    MessageBox.Show("Sólo se permiten numeros en el Teléfono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!(textHabilitado.Text == "0" || textHabilitado.Text == "1"))
                {
                    MessageBox.Show("Ingrese 1 o 0 para la habilitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Database.modificarCliente(nombre, apellido, email ,nroIdentificacion, nombreNuevo, apellidoNuevo, identificacionNuevo, tipoIdentificacionNuevo, mailNuevo, telefonoNuevo, fechaNacimientoNueva,nacionalidadNueva,calleNueva,nroCalleNueva,pisoNuevo,dtoNuevo,localidadNueva,HabilitadoNuevo);
                this.limpiarCuadrosDeTexto();
                this.Close();
            }
        }


        private void limpiarCuadrosDeTexto()
        {

            textNombre.Text = "";
            textApellido.Text = "";
            textTipoIdentificacion.Text = "";
            textNroIdentificacion.Text = "";
            textMail.Text = "";
            textTelefono.Text = "";
            textNacionalidad.Text = "";
            dateTimePickerFechaNac.Text = "";
            textCalle.Text = "";
            textCalleNro.Text = "";
            textPiso.Text = "";
            textDto.Text = "";
            textLocalidad.Text = "";
            textHabilitado.Text = "";

        }



     
    }
}
