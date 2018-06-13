using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmCliente
{
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }



        private void limpiarCuadrosDeTexto()
        {
            textNombre.Text = "";
            textApellido.Text = "";
            textMail.Text = "";
            textTelefono.Text = "";
            textNacionalidad.Text = "";
            dateTimePickerFechaNac.Text = "";
            textTipoIdentificacion.Text = "";
            textNroIdentificacion.Text = "";
            textCalle.Text = "";
            textCalleNro.Text = "";
            textPiso.Text = "";
            textDto.Text = "";
            textLocalidad.Text = "";
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textNroIdentificacion.Text, @"^\d+$"))
            {
                MessageBox.Show("Sólo se permiten numeros en el Nro de Identificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Database.ExisteMail(textMail.Text))
            {

                MessageBox.Show("Duplicacion de mails", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textTelefono.Text, @"^\d+$"))
            {
                MessageBox.Show("Sólo se permiten numeros en el Teléfono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textCalleNro.Text.Trim() == "" |textTipoIdentificacion.Text.Trim() == "" |textNroIdentificacion.Text.Trim() == "" |textCalle.Text.Trim() == "" |textNombre.Text.Trim() == "" | textApellido.Text.Trim() == "" | textMail.Text.Trim() == "" | textTelefono.Text.Trim() == "" | textNacionalidad.Text.Trim() == "" | dateTimePickerFechaNac.Text.Trim() == "")
            {
                MessageBox.Show("Faltan completar campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                String nombre = textNombre.Text;
                String apellido = textApellido.Text;
                String mail = textMail.Text;
                String telefono = textTelefono.Text;
                String nacionalidad = textNacionalidad.Text;
                String fechanacimiento = dateTimePickerFechaNac.Text;
                String TipoDeIdentificacion = textTipoIdentificacion.Text;
                int numeroIden = Convert.ToInt32(textNroIdentificacion.Text);
                String calle = textCalle.Text;
                String calleNro = textCalleNro.Text;
                int piso =  Convert.ToInt32(textPiso.Text);
                String dto = textDto.Text;
                String localidad = textLocalidad.Text;
                DateTime fecha = Convert.ToDateTime(fechanacimiento);
                Database.AddCliente(nombre,apellido,mail,telefono,nacionalidad,fecha,TipoDeIdentificacion,numeroIden,calle,calleNro,piso,dto,localidad);
                this.limpiarCuadrosDeTexto();
            }
        }


    }
}
