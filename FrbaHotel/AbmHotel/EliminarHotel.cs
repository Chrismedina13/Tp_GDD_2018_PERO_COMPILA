using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class EliminarHotel : Form
    {
        public EliminarHotel()
        {
            InitializeComponent();

            //Database.cargarGriddHotelAEliminar(dataGridViewEliminarHotel, "", "", "","");
            dataGridViewEliminarHotel.SelectionChanged += new EventHandler(dataGridViewEliminarH_SelectionChanged);
        }

        void dataGridViewEliminarH_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEliminarHotel.SelectedRows.Count > 0)
            {
                var row = dataGridViewEliminarHotel.SelectedRows[0];
                textNombre.Text = row.Cells["hotel_nombre"].Value.ToString();
                textCantidadEstrellas.Text = row.Cells["hotel_cantEstrellas "].Value.ToString();
                textCiudad.Text = row.Cells["hotel_ciudad"].Value.ToString();
                texPais.Text = row.Cells["hotel_pais"].Value.ToString();

            }
        }

        private void textNombre_KeyUp(object sender, KeyEventArgs e)
        {
            //Database.cargarGriddHotelAEliminar(dataGridViewEliminarHotel,textNombre.Text,textCantidadEstrellas.Text,textCiudad.Text,texPais.Text);

        }

        private void textCantEstrellas_KeyUp(object sender, KeyEventArgs e)
        {
            //Database.cargarGriddHotelAEliminar(dataGridViewEliminarHotel,textNombre.Text,textCantidadEstrellas.Text,textCiudad.Text,texPais.Text);

        }

        private void textCiudad_KeyUp(object sender, KeyEventArgs e)
        {
            //Database.cargarGriddHotelAEliminar(dataGridViewEliminarHotel,textNombre.Text,textCantidadEstrellas.Text,textCiudad.Text,texPais.Text);

        }
        private void textPais_KeyUp(object sender, KeyEventArgs e)
        {
            //Database.cargarGriddHotelAEliminar(dataGridViewEliminarHotel,textNombre.Text,textCantidadEstrellas.Text,textCiudad.Text,texPais.Text);

        }

        private void EliminarHotel_Load(object sender, EventArgs e)
        {

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {

            int cantidadDeEstrellas = Convert.ToInt32(textCantidadEstrellas.Text);
            String nombre = textNombre.Text;
            String Pais = texPais.Text;
            String Ciudad = textCiudad.Text;
            DateTime fechaInicio = Convert.ToDateTime(dateTimePickerFechaInicio.Text);
            DateTime fechaFin = Convert.ToDateTime(dateTimePickerFechaFin.Text);
            String Descripcion = textDescripcionCierre.Text;

            if (textNombre.Text.Trim() == "" | textCantidadEstrellas.Text.Trim() == "" | texPais.Text.Trim() == "" | dateTimePickerFechaFin.Text.Trim() == "" | dateTimePickerFechaInicio.Text.Trim() == "" | textDescripcionCierre.Text.Trim() == "" | textCiudad.Text.Trim() == "")
            {
                MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (false)//Database.existeHotel(nombre, Pais, cantidadDeEstrellas, Ciudad)
            {

                MessageBox.Show("Cliente no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                var respuesta = MessageBox.Show("¿Estas seguro?", "Confirme borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    // int idHotel = Database.obtenerIdHotel(nombre,cantidadDeEstrellas,Pais,Ciudad);
                    //   Database.eliminarHotel(nombre,cantidadDeEstrellas,Pais,Ciudad); 
                    //   Database.agregarHotelAHotelCerrado(idHotel,FechaInicio,FechaFin,Descripcion); 
                    this.limpiarCuadrosDeTexto();
                    Database.cargarGriddClienteAEliminar(dataGridViewEliminarHotel, "", "", "");
                }
                else return;
            }


        }

        private void limpiarCuadrosDeTexto()
        {

            textNombre.Text = "";
            textCantidadEstrellas.Text = "";
            textCiudad.Text = "";
            texPais.Text = "";
            dateTimePickerFechaInicio.Text = "";
            dateTimePickerFechaFin.Text = "";
            textDescripcionCierre.Text = "";

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
    
