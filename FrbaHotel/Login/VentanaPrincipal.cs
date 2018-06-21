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
using FrbaHotel.Support;
//using FrbaHotel.ListadoEstadistico;
using FrbaHotel.RegistrarConsumible;


namespace FrbaHotel
{
    public partial class VentanaPrincipal : Form
    {

        public String user { get; set; }
        public String rol { get; set; }
        public String fechaSistema { get; set; }
        FrbaHotel.Support.Rol roll;
        private string userID;

             
        public VentanaPrincipal(FrbaHotel.Support.Rol roll, string userID)
        {
        InitializeComponent();
        this.roll = roll;
        this.userID = userID;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fechaSistema == null)
            {
                //MessageBox.Show("Error. Debe elegir una fecha para que inicie el sistema.");
            //}
           
           // else
           // {
                //AbmCliente.ABM_Cliente form3 = new ABM_Cliente();
                FrbaHotel.Login.Seleccion_de_ABMs form = new FrbaHotel.Login.Seleccion_de_ABMs(this, roll, userID);
                form.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            VentanaPorRol vr = new VentanaPorRol();
            vr.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //estadistica form = new estadistica (this);
            //form.Show();
            //this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //RegistroConsumible form = new RegistroConsumible (userID, this);
            // form.Show();
            // this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //GenerarModificacionReserva form = new GenerarModificacionReserva (userID, this);
            // form.Show();
            // this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //CancelarReserva form = new CancelarReserva (userID, this);
            // form.Show();
            // this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login1 form = new Login1();
            form.Show();
            this.Close();
        }
        
        private void acciones_Load(object sender, EventArgs e)
        {
            List<Funcionalidadd> funcionalidades = Database.getFuncionalidadesPara(roll.id);
            foreach (Funcionalidadd funcionalidad in funcionalidades)
            {
                if (funcionalidad.activado)
                {
                    switch (funcionalidad.nombre)
                    {
                        case "ABM_ROL":
                        case "ABM_USUARIO": 
                        case "ABM_CLIENTE": 
                        case "ABM_HOTEL": 
                        case "ABM_HABITACION":
                        case "ABM_ESTADIA": btnABMs.Show(); break;
                        case "LISTADO_ESTADISTICO": btnEstadisticas.Show(); break;
                        case "REGISTRAR_CONSUMIBLE": btnRegistrarConsumible.Show(); break;
                        case "GENERAR_O_MODIFICAR_RESERVA": btnGenerarOmodificarReserva.Show(); break;
                        case "CANCELAR_RESERVA": btnCancelarReserva.Show(); break;
                        
                    }
                }
            }
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
