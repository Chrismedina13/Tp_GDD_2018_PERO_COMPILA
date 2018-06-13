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
    public partial class ModificarHabitacion : Form
    {
        public ModificarHabitacion()
        {
            InitializeComponent();
            //Database.cargarGriddHabitacionAModificar(S, "", "");
            S.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);
        }

        void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (S.SelectedRows.Count > 0)
            {
                var row = S.SelectedRows[0];
                textPiso.Text = row.Cells["habitacion_piso"].Value.ToString();
                textNumeroDeHabitacion.Text = row.Cells["habitacion_nuemeo"].Value.ToString();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (textPiso.Text.Trim() == "" | textNumeroDeHabitacion.Text.Trim() == "")
            {
                MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textNumeroDeHabitacion.Text, @"^\d+$"))
            {
                MessageBox.Show("Sólo se permiten numeros en el Nro de Habitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textPiso.Text, @"^\d+$"))
            {
                MessageBox.Show("Sólo se permiten numeros en el Piso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int numero = Convert.ToInt32(textNumeroDeHabitacion.Text);
            int piso = Convert.ToInt32(textPiso.Text);

            if (false) //Database.existeHabitacionAModificar(piso,numero)
            {

                MessageBox.Show("Habitacion ingresada no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {


                var respuesta = MessageBox.Show("¿Estas seguro?", "Confirme Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    ModificarHabitacionElegida form = new ModificarHabitacionElegida(piso, numero);
                    this.limpiarCuadrosDeTexto();
                    form.Show();
                }


            }
        }



        private void limpiarCuadrosDeTexto()
        {

            textNumeroDeHabitacion.Text = "";
            textPiso.Text = "";
        }

        private void textNumeroHabitacion_KeyUp(object sender, KeyEventArgs e)
        {
            // Database.cargarGriddHabitacionAModificar(S, textPiso.Text, textNumeroDeHabitacion.Text);
        }

        private void textPiso_KeyUp(object sender, KeyEventArgs e)
        {
            // Database.cargarGriddHabitacionAModificar(S, textPiso.Text, textNumeroDeHabitacion.Text);         

        }


    }

}