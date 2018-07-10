using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRol
{
    public partial class eliminar_rol : Form
    {
        public eliminar_rol()
        {
            InitializeComponent(); 
            CargarComboRoles();
        }
        private void CargarComboRoles()
        {
            //Vaciar comboBox
            comboBox1.DataSource = null;
            try
            {
                //Indicar qué propiedad se verá en la lista
                this.comboBox1.DisplayMember = "Nombre";
                //Indicar qué valor tendrá cada ítem
                this.comboBox1.ValueMember = "Id";
                //Asignar la propiedad DataSource
                List<Rol> listita = new List<Rol>();

                listita = RolDAL.BuscarRol();
                //this.comboBox1.Items.Insert(0, "Seleccione un rol");
                listita.Add(new Rol(0, "Seleccione un rol"));
                this.comboBox1.DataSource = listita;
                //this.comboBox1.Items.Add(new KeyValuePair<string, string>("0", "Mujer"));
            }
            catch (Exception e)
            { MessageBox.Show("Error al intentar cargar los roles -" + e.Message); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdProducto = Convert.ToInt32(comboBox1.SelectedValue);
            string Descripcion = Convert.ToString(comboBox1.Text);
            if (IdProducto > 0)
            {
                label2.Text = Descripcion;
            }
        }

        

        private void eliminar_rol_Load(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("fdsf " + comboBox1.SelectedIndex);
           // int IdProducto = Convert.ToInt32(comboBox1.SelectedIndex);

          
          
            MessageBox.Show("fdsf    " + comboBox1.Text);
            string Descripcion = Convert.ToString(comboBox1.Text);


            int IdProducto = RolDAL.RolId(Descripcion);
            MessageBox.Show("fdsf   " + IdProducto);
          
            if (RolDAL.ModificarRol(IdProducto, label2.Text, 0))
            {
                if (RolDAL.SacarRolATodosLosUsuarios(IdProducto) > 0)
                {

                    MessageBox.Show("Se eliminó el rol " + Descripcion);
                }
                else
                {
                    MessageBox.Show("Fue eliminado, pero no se encontraron usuarios asociados al Rol  " + Descripcion);
                    //MessageBox.Show("Error al intentar eliminar el rol seleccionado " + IdProducto);
                }
            }
            else
            {
                MessageBox.Show("Error al intentar eliminar el rol seleccionado " + IdProducto);
            }
            CargarComboRoles();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int IdProducto = Convert.ToInt32(comboBox1.SelectedValue);
            string Descripcion = Convert.ToString(comboBox1.Text);
            if (IdProducto > 0)
            {
                label2.Text = Descripcion;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
        }
    }
}
