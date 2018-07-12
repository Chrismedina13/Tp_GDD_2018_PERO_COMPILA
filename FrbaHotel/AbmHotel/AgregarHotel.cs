using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.Support;

namespace FrbaHotel.AbmHotel
{
    public partial class AgregarHotel : Form
    {
        public AgregarHotel()
        {
            InitializeComponent();
        }

        private void AgregarHotel_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lbRegimen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void limpiarCuadrosDeTexto()
        {
            textNombre.Text = "";
            textMail.Text = "";
            textTelefono.Text = "";
            comboBoxEstrellas.Text = "";
            textCiudad.Text = "";
            texPais.Text = "";
            lbRegimen.ClearSelected();            
            dateFechaCreacion.Text = "";
            textDireccion.Text = "";
            textNroCalle.Text = "";
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textTelefono.Text, @"^\d+$"))
            {
                MessageBox.Show("Sólo se permiten numeros en el Telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lbRegimen.SelectedItems.Count > 0)
            {
                MessageBox.Show("Debe seleccionar algun tipo de regimen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textTelefono.Text, @"^\d+$"))
            {
                MessageBox.Show("Sólo se permiten numeros en el Telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textNroCalle.Text, @"^\d+$"))
            {
                MessageBox.Show("Sólo se permiten numeros en el Nro de calle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textNombre.Text.Trim() == "" | textMail.Text.Trim() == "" | textTelefono.Text.Trim() == "" | comboBoxEstrellas.Text.Trim() == "" | textCiudad.Text.Trim() == "" | dateFechaCreacion.Text.Trim() == "" | textDireccion.Text.Trim() == "" | textNroCalle.Text.Trim() == "")
            {
                MessageBox.Show("Faltan completar campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String nombre = textNombre.Text;
            String mail = textMail.Text;
            String Telefono = textTelefono.Text;
            int CantidadEstrellas = Convert.ToInt32(comboBoxEstrellas.Text);
            String Ciudad = textCiudad.Text;
            String Pais = texPais.Text;
            DateTime FechaCreacion = Convert.ToDateTime(dateFechaCreacion.Text);
            String Direccion = textDireccion.Text;
            int CalleNro = Convert.ToInt32(textNroCalle.Text);
            Database.AddHotel(nombre, mail, Telefono, CantidadEstrellas, Ciudad, Pais, FechaCreacion, Direccion, CalleNro,10);
            int idHotel = Database.obtenerIDHotel(nombre, mail, Telefono, CantidadEstrellas, Ciudad, Pais, FechaCreacion, Direccion, CalleNro,10);

            var regimenes = lbRegimen.SelectedItems.Cast<String>().ToList();
            foreach(var regimen in regimenes ){

                int regimenAgregar = Convert.ToInt32(regimen);

                Database.addRegimenPorHotel(idHotel,regimenAgregar);
            
            }

            this.limpiarCuadrosDeTexto();
        }

    }
}
