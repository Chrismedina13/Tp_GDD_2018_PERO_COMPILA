using FrbaHotel.AbmRol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrbaHotel.Login
{
    public partial class VentanaPPAL : Form
    {
        public String rolUser { get; set; }
       
        List<Funcionalidad> funcsDelRolDelUser;
       
        public VentanaPPAL(FrbaHotel.Support.Rol roll, string rolUsuario)
        {
        InitializeComponent();
        this.rolUser = rolUsuario;
        funcsDelRolDelUser = Funcionalidad.getFuncionalidadesXRol(rolUsuario);
            foreach (Funcionalidad unFuncs in funcsDelRolDelUser){
            comboFuncionalidades.Items.Add(unFuncs);
           comboFuncionalidades.ValueMember = "Descripcion";
            comboFuncionalidades.SelectedIndex = 0;
        }
        }
       

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            Funcionalidad funcionalidadElegida = (Funcionalidad)comboFuncionalidades.SelectedItem;
           if (funcionalidadElegida != null)
                  seleccionABM(funcionalidadElegida.descripcion);
            else MessageBox.Show("Seleccione una funcionalidad", "Error no selecciono funcionalidad");
        }

        private void seleccionABM(string func)
        {
            switch (func)
            {

                case "ABM de Rol":
                    new AbmRol.ABM_Rol().Show();
                    break;

                case "ABM de Usuarios":
                    new AbmUsuario.Registro().Show();
                    break;

                case "ABM de Clientes":
                    new AbmCliente.ABM_Cliente().Show();
                    break;

                case "ABM de Hotel":
                    new AbmHotel.ABM_Hotel().Show();
                    break;

                case "ABM de Habitacion":
                     new AbmHabitacion.ABM_Habitacion().Show();
                     break;

                case "ABM Regimen de estadia":
                //  new RegistrarEstadia.RegimenBajaMod().Show();
                  //  break;

                case "Generar o Modificar Reserva":
                  //  new Generar_Modificar_Reserva.MainReservas().Show();
                  //  break;
                case "Cancelar Reserva":
                  //  new Cancelar_Reserva.CancelarReserva().Show();
                  //  break;

                case "Registrar Estadia":
                  //  new Registrar_Estadia.EstadiasMain().Show();
                   // break;

                case "Registrar Consumible":
                  //  new Registrar_Consumible.RegistrarConsumibles().Show();
                  //  break;

                case "Listado estadistico":
                   // new ABM_de_Facturas.FacturasAlta().Show();
                    //break;

                default: break;
                 
            }
          //  Globals.deshabilitarAnterior(this);
        }
        private void VentanaPPAL_Load(object sender, EventArgs e)
        {

        }

        private void comboFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         
    }
   }
    