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
    public partial class Alta_Rol : Form
    {
        public Alta_Rol()
        {
            InitializeComponent();
            CargarComboFuncionalidades();
        }
        private void CargarComboFuncionalidades()
        {
            //Vaciar comboBox
            comboBox1.DataSource = null;
          ////////  Funcionalidad f = new Funcionalidad();
            //Indicar qué propiedad se verá en la lista
            this.comboBox1.DisplayMember = "funcionalidad_descripcion";
            //Indicar qué valor tendrá cada ítem
            this.comboBox1.ValueMember = "ID";
            //Asignar la propiedad DataSource
           //////// this.comboBox1.DataSource = f.getAllFuncionalidades();


        }

        private void Alta_Rol_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                Rol rol = new Rol();

                rol.Nombre = textBox1.Text;

                Funcionalidad func = new Funcionalidad();

                //rol.funcionalidad.Add(comboBox1.GetItemText(0).ToString);
                Boolean TR = RolDAL.CrearRol(rol.Nombre, 1, rol.funcionalidad.descripcion);

                if (TR)
                {
                    MessageBox.Show("Rol registrado Correctamente!");
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el Rol :(");
                }
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
