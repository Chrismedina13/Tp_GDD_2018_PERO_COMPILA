using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.Login;

namespace FrbaHotel.AbmRol
{
    public partial class ABM_Rol : Form
    {
        private Seleccion_de_ABMs seleccion_de_ABMs;

        public ABM_Rol(Seleccion_de_ABMs seleccion_de_ABMs)

        {
            InitializeComponent();
            this.seleccion_de_ABMs = seleccion_de_ABMs;

        }

        private void ABM_Rol_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

          Alta_Rol_Funcionalidad alta = new Alta_Rol_Funcionalidad();
         alta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modificar_rol m = new modificar_rol();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eliminar_rol el = new eliminar_rol();
            el.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Alta_Rol altaRol = new Alta_Rol();
            altaRol.Show();
        }
    }
}
