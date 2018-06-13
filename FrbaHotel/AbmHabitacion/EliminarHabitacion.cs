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
    public partial class EliminarHabitacion : Form
    {
        public EliminarHabitacion()
        {
            InitializeComponent();
           // Database.cargarGriddHabitacionAEliminar(S, "", "", "");
            S.SelectionChanged += new EventHandler(dataGridViewEliminarH_SelectionChanged);


        }

        void dataGridViewEliminarH_SelectionChanged(object sender, EventArgs e)
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

        private void btEliminar_Click(object sender, EventArgs e)
        {
            String piso = textPiso.Text;
            String numero = textNumeroDeHabitacion.Text;

            if (!System.Text.RegularExpressions.Regex.IsMatch(textPiso.Text, @"^\d+$"))
            {
                MessageBox.Show("Sólo se permiten numeros en el piso ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textNumeroDeHabitacion.Text, @"^\d+$"))
            {
                MessageBox.Show("Sólo se permiten numeros en el numero habitacion ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textNumeroDeHabitacion.Text.Trim() == "" | textPiso.Text.Trim() == "")
            {
                MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {

                var respuesta = MessageBox.Show("¿Estas seguro?", "Confirme borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    int pisoAEliminar = Convert.ToInt32(textPiso.Text);
                    int numeroAEliminar = Convert.ToInt32(textNumeroDeHabitacion.Text);

                    //Database.deleteHabitacion(pisoAEliminar,numeroAEliminar);
                    this.limpiarCuadrosDeTexto();
                  //  Database.cargarGriddHabitaconAEliminar(S, "", "", "");
                }
                else return;

            }
        }

        private void limpiarCuadrosDeTexto()
        {
            textPiso.Text = "";
            textNumeroDeHabitacion.Text = "";
   
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

