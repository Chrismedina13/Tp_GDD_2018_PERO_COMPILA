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
    public partial class ModificarCliente : Form
    {
        public ModificarCliente()
        {
            InitializeComponent();
            Database.cargarGriddClienteAModificar(dataGridView1, "", "", "");
            dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);
        }

        void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                textNombre.Text = row.Cells["cliente_nombre"].Value.ToString();
                textApellido.Text = row.Cells["cliente_apellido"].Value.ToString();
                textNroIdentificacion.Text = row.Cells["cliente_identificacion"].Value.ToString();
                textTipoIdentificacion.Text = row.Cells["cliente_tipoIdentificacion"].Value.ToString();
                textEmail.Text = row.Cells["cliente_email"].Value.ToString();
               
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {

            if (!System.Text.RegularExpressions.Regex.IsMatch(textNroIdentificacion.Text, @"^\d+$"))
            {
                MessageBox.Show("Sólo se permiten numeros en el Nro de Identificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String nombre = textNombre.Text;
            String apellido = textApellido.Text;
            String tipoIdentificacion = textTipoIdentificacion.Text;
            String email = textEmail.Text;
            int identificacion = Convert.ToInt32(textNroIdentificacion.Text);

            if (textNombre.Text.Trim() == "" | textApellido.Text.Trim() == "" | textNroIdentificacion.Text.Trim() == "" | textEmail.Text.Trim() == "" )
            {
                MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Database.existeClienteAModificar(nombre, apellido, identificacion,email))
            {

                MessageBox.Show("Cliente no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                var respuesta = MessageBox.Show("¿Estas seguro?", "Confirme Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    ModificarClienteElegido form = new ModificarClienteElegido(nombre, apellido, identificacion,email);
                    this.limpiarCuadrosDeTexto();
                    form.Show();
                }
            }
        }


          private void limpiarCuadrosDeTexto()
        {

            textNombre.Text = "";
            textApellido.Text = "";
            textNroIdentificacion.Text = "";
            textEmail.Text = "";
            textTipoIdentificacion.Text ="";
        }

          private void textNombre_KeyUp(object sender, KeyEventArgs e)
          {
              Database.cargarGriddClienteAModificar(dataGridView1, textNombre.Text, textApellido.Text, textEmail.Text);
          }

          private void textApellido_KeyUp(object sender, KeyEventArgs e)
          {
              Database.cargarGriddClienteAModificar(dataGridView1, textNombre.Text, textApellido.Text, textEmail.Text);
          }

          private void textNroIdentificacion_KeyUp(object sender, KeyEventArgs e)
          {
              Database.cargarGriddClienteAModificar(dataGridView1, textNombre.Text, textApellido.Text, textEmail.Text);
          }

          private void textTipoIdentificacion_KeyUp(object sender, KeyEventArgs e)
          {
              Database.cargarGriddClienteAModificar(dataGridView1, textNombre.Text, textApellido.Text, textEmail.Text);
          }

          private void textEmail_KeyUp(object sender, KeyEventArgs e)
          {
              Database.cargarGriddClienteAModificar(dataGridView1, textNombre.Text, textApellido.Text, textEmail.Text);
          }  
  

        
    }
}
