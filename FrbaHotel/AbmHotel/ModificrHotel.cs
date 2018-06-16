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
    public partial class ModificarHotel : Form
    {
        public ModificarHotel()
        {
            InitializeComponent();
            //Database.cargarGriddModificarHotel(dataGridViewModificarHotel, "", "", "","");
            dataGridViewModificarHotel.SelectionChanged += new EventHandler(dataGridViewModificarHotel_SelectionChanged);
        }

        void dataGridViewModificarHotel_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewModificarHotel.SelectedRows.Count > 0)
            {
                var row = dataGridViewModificarHotel.SelectedRows[0];
                textNombre.Text = row.Cells["hotel_nombre"].Value.ToString();
                textCantidadEstrellas.Text = row.Cells["hotel_cantEstrellas "].Value.ToString();
                textCiudad.Text = row.Cells["hotel_ciudad"].Value.ToString();
                texPais.Text = row.Cells["hotel_pais"].Value.ToString();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textCantidadEstrellas.Text, @"^\d+$") | textCantidadEstrellas.Text == "")
            {
                MessageBox.Show("Sólo se permiten numeros en el Nro en la cantidad De estrellas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cantidadDeEstrellas = Convert.ToInt32(textCantidadEstrellas.Text);

            if ( cantidadDeEstrellas > 0 || cantidadDeEstrellas < 0)
            {
                MessageBox.Show("Rango de estrellas permitido de 1 a 5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textNombre.Text.Trim() == "" | textCiudad.Text.Trim() == "" | texPais.Text.Trim() == "")
            {
                MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String nombre = textNombre.Text;
            String Pais = texPais.Text;
            String Ciudad = textCiudad.Text;


            if (false)//Database.existeHotelAModificar(nombre, Pais, cantidadDeEstrellas, Ciudad)
            {

                MessageBox.Show("Cliente no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else {


                var respuesta = MessageBox.Show("¿Estas seguro?", "Confirme Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    ModificarHotelElegido form = new ModificarHotelElegido(nombre, cantidadDeEstrellas, Pais, Ciudad);
                    this.limpiarCuadrosDeTexto();
                    form.Show();
                }
            
            
            }

        }

        private void limpiarCuadrosDeTexto()
        {

            textNombre.Text = "";
            textCantidadEstrellas.Text = "";
            textCiudad.Text = "";
            texPais.Text = "";
        }


        private void textNombre_KeyUp(object sender, KeyEventArgs e)
        {
            //Database.cargarGriddModificarHotel(dataGridViewModificarHotel,textNombre.Text,textCantidadEstrellas.Text,textCiudad.Text,texPais.Text);

        }

        private void textCantEstrellas_KeyUp(object sender, KeyEventArgs e)
        {
            //Database.cargarGriddModificarHotel(dataGridViewModificarHotel,textNombre.Text,textCantidadEstrellas.Text,textCiudad.Text,texPais.Text);

        }

        private void textCiudad_KeyUp(object sender, KeyEventArgs e)
        {
            //Database.cargarGriddModificarHotel(dataGridViewModificarHotel,textNombre.Text,textCantidadEstrellas.Text,textCiudad.Text,texPais.Text);

        }
        private void textPais_KeyUp(object sender, KeyEventArgs e)
        {
            //Database.cargarGriddModificarHotel(dataGridViewModificarHotel,textNombre.Text,textCantidadEstrellas.Text,textCiudad.Text,texPais.Text);

        }


    }
}
