using FrbaHotel.AbmRol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.AbmCliente;
using FrbaHotel.AbmHabitacion;
using FrbaHotel.AbmHotel;
using FrbaHotel.ListadoEstadistico;

using FrbaHotel.RegistrarConsumible;
//using FrbaHotel.Devoluciones;
//using FrbaHotel.Support;

namespace FrbaHotel
{
    public partial class VentanaPrincipal : Form
    {

        public String user { get; set; }
        public String rol { get; set; }
        public String fechaSistema { get; set; }
        
        public VentanaPrincipal()
        {
           //-- user = nombre;
            //--rol = rolUser;
            // label2.Text = nombre;

        //--            this.user = nombre;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fechaSistema == null)
            {
                MessageBox.Show("Error. Debe elegir una fecha para que inicie el sistema.");
            }
            //int idRol = Database.IdDelRol(rol);
            //if (Database.TieneAsignadaFuncionalidad(idRol, 3))
            //{

            //    MessageBox.Show("EL ROL QUE USTED TIENE NO PERMITE ESTA FUNCIONALIDAD");
            //    return;
            //}
            else
            {
                AbmCliente.ABM_Cliente form3 = new ABM_Cliente();
                form3.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPorRol vr = new VentanaPorRol();
            vr.Show();
        }
    }
}
