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
    public partial class ModificarHabitacionElegida : Form
    {
        int piso;
        int numero;

        public ModificarHabitacionElegida(int pisoViejo, int numeroViejo)
        {
            InitializeComponent();

            piso = pisoViejo;
            numero = numeroViejo;

            String[] datosHabitacionElegida = new String[5];
            //datosClienteElegido = Database.getDatosHAbitacion(pisoViejo,numeroViejo);
            textDescripcion.Text = datosHabitacionElegida[0];
            textNroHabitacion.Text = datosHabitacionElegida[1];
            textUbicacion.Text = datosHabitacionElegida[2];
            textPiso.Text = datosHabitacionElegida[3];
            textHabilitado.Text = datosHabitacionElegida[4];
            


        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {

            int pisoNuevo = Convert.ToInt32(textPiso.Text);
            int numeroNuevo = Convert.ToInt32(textNroHabitacion.Text);
            String DescripcionNuevo = textDescripcion.Text;
            String UbicacionNuevo = textUbicacion.Text;
            string HabilitadoNuevo = textHabilitado.Text;


            if (UbicacionNuevo == "" | HabilitadoNuevo == "")
            {
                MessageBox.Show("Verifique que los campos obligatorios hayan sido completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                if (!System.Text.RegularExpressions.Regex.IsMatch(textPiso.Text, @"^\d+$"))
                {
                    MessageBox.Show("Sólo se permiten numeros en el piso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(textNroHabitacion.Text, @"^\d+$"))
                {
                    MessageBox.Show("Sólo se permiten numeros en el numeroHabitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (false)////existeNroHabitacionEnelHotel(numeroNuevo)
                {
                    MessageBox.Show("Ya existe numero de habitacion en el hotel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!(textHabilitado.Text == "0" || textHabilitado.Text == "1"))
                {
                    MessageBox.Show("Ingrese 1 o 0 para la habilitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               // Database.modificarHabitacion(piso, numero, pisoNuevo, numeroNuevo, DescripcionNuevo, UbicacionNuevo);
                this.limpiarCuadrosDeTexto();
                this.Close();
            }
        }
        private void limpiarCuadrosDeTexto()
        {

            textPiso.Text = "";
            textUbicacion.Text = "";
            textNroHabitacion.Text = "";
            textDescripcion.Text = "";
            textHabilitado.Text = "";

        }




        }



    }

