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
        private List<Funcionalidad> funcionalidades;
        public Alta_Rol()
        {
            InitializeComponent();
            CargarComboFuncionalidades();
            Funcionalidad f = new Funcionalidad();
            funcionalidades = f.getListFuncionalidades();
            foreach (Funcionalidad func in funcionalidades)
                comboFuncionalidades.Items.Add(func.descripcion);
        }
        private void CargarComboFuncionalidades()
        {
            //Vaciar comboBox
            comboFuncionalidades.DataSource = null;
           Funcionalidad f = new Funcionalidad();
            //Indicar qué propiedad se verá en la lista
            this.comboFuncionalidades.DisplayMember = "funcionalidad_descripcion";
            //Indicar qué valor tendrá cada ítem
            this.comboFuncionalidades.ValueMember = "ID";
            //Asignar la propiedad DataSource
          //  this.comboBox1.DataSource = f.getListFuncionalidades();
           
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
           
            //Limiamos lo demas?
            textBox1.Text = "";
            comboFuncionalidades.SelectedItem = null;
           
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
