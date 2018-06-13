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
    public partial class EliminarCliente : Form
    {
        public EliminarCliente()
        {
            InitializeComponent();
            Database.cargarGriddClienteAEliminar(dataGridViewEliminarC, "", "", "");
            dataGridViewEliminarC.SelectionChanged += new EventHandler(dataGridViewEliminarC_SelectionChanged);

        }

        private void S_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarCuadrosDeTexto()
        {
            textNombre.Text = "";
            textApellido.Text = "";
            textNroIdentificacion.Text = "";
            textEmail.Text = "";
            textTipoIdentificacion.Text = "";

        }

        void dataGridViewEliminarC_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEliminarC.SelectedRows.Count > 0)
            {
                var row = dataGridViewEliminarC.SelectedRows[0];
                textNombre.Text = row.Cells["cliente_nombre"].Value.ToString();
                textApellido.Text = row.Cells["cliente_apellido"].Value.ToString();
                textNroIdentificacion.Text = row.Cells["cliente_identificacion"].Value.ToString();
                textTipoIdentificacion.Text = row.Cells["cliente_tipoIdentificacion"].Value.ToString();
                textEmail.Text = row.Cells["cliente_email"].Value.ToString();

            }
        }

        private void textNombre_KeyUp(object sender, KeyEventArgs e)
        {
            Database.cargarGriddClienteAEliminar(dataGridViewEliminarC, textNombre.Text, textApellido.Text, textEmail.Text);
        }

        private void textApellido_KeyUp(object sender, KeyEventArgs e)
        {
            Database.cargarGriddClienteAEliminar(dataGridViewEliminarC, textNombre.Text, textApellido.Text, textEmail.Text);
        }

        private void textNroIdentificacion_KeyUp(object sender, KeyEventArgs e)
        {
            Database.cargarGriddClienteAEliminar(dataGridViewEliminarC, textNombre.Text, textApellido.Text, textEmail.Text);
        }

        private void textTipoIdentificacion_KeyUp(object sender, KeyEventArgs e)
        {
            Database.cargarGriddClienteAEliminar(dataGridViewEliminarC, textNombre.Text, textApellido.Text, textEmail.Text);
        }

        private void textEmail_KeyUp(object sender, KeyEventArgs e)
        {
            Database.cargarGriddClienteAEliminar(dataGridViewEliminarC, textNombre.Text, textApellido.Text, textEmail.Text);
        }  

        private void btEliminar_Click(object sender, EventArgs e)
        {

            String numeroIdentidicacion = textNroIdentificacion.Text;
            String nombre = textNombre.Text;
            String apellido = textApellido.Text;
            String email = textEmail.Text;

            if (!System.Text.RegularExpressions.Regex.IsMatch(textNroIdentificacion.Text, @"^\d+$"))
            {
                MessageBox.Show("Sólo se permiten numeros en la identificacion ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textNombre.Text.Trim() == "" | textApellido.Text.Trim() == "" | textNroIdentificacion.Text.Trim() == "" | textEmail.Text.Trim() == "")
            {
                MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var respuesta = MessageBox.Show("¿Estas seguro?", "Confirme borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    int nroID = Convert.ToInt32(textNroIdentificacion.Text);
                    Database.deleteCliente(nombre, apellido, email, nroID);
                    this.limpiarCuadrosDeTexto();
                    Database.cargarGriddClienteAEliminar(dataGridViewEliminarC, "", "", "");
                }
                else return;
            }
            
        }
    }
}
