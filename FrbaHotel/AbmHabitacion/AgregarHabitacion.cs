using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHabitacion
{
    public partial class AgregarHabitacion : Form
    {
        public AgregarHabitacion()
        {
            InitializeComponent();
        }

        private void textNroHabitacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgregarHabitacion_Load(object sender, EventArgs e)
        {

        }

        private void limpiarCuadrosDeTexto()
        {
            textNroHabitacion.Text = "";
            textPiso.Text = "";
            textUbicacion.Text = "";
            cbTipoHabitacion.Text = "";
            textDescripcion.Text = "";
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (textNroHabitacion.Text.Trim() == "" | textPiso.Text.Trim() == "" | textUbicacion.Text.Trim() == "" | cbTipoHabitacion.Text.Trim() == "")
            {
                MessageBox.Show("Faltan completar campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textNroHabitacion.Text, @"^\d+$"))
            {
                MessageBox.Show("Sólo se permiten numeros en el Nro de Habitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textPiso.Text, @"^\d+$"))
            {
                MessageBox.Show("Sólo se permiten numeros en el Nro de Piso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int nroHabitacion = Convert.ToInt32(textNroHabitacion.Text);
            if (false)//existeNroHabitacionEnelHotel(nroHabitacion)
            {

                MessageBox.Show("Existe N° habitacion en el hotel ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                int piso = Convert.ToInt32(textPiso.Text);
                String Descripcion = textDescripcion.Text;
                String TipoHabitacion = cbTipoHabitacion.Text;
                String Ubicacion = textUbicacion.Text;

                //Database.AddHabitacion(nroHabitacion,piso,Descripcion,TipoHabitacion,Ubicacion);
                this.limpiarCuadrosDeTexto();
            }
        }





    }
}
