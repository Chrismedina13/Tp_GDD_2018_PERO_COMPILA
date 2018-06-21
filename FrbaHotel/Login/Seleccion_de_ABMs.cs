using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.AbmRol;
using FrbaHotel.AbmUsuario;
using FrbaHotel.AbmCliente;
using FrbaHotel.AbmHotel;
using FrbaHotel.AbmHabitacion;
using FrbaHotel.AbmRegimen;
using FrbaHotel.Support;


namespace FrbaHotel.Login
{
    public partial class Seleccion_de_ABMs : Form
    {
        private VentanaPrincipal lastForm;
        private string userId;
        private Support.Rol rol;
        
        public Seleccion_de_ABMs()
        {
            InitializeComponent();
        }


        public Seleccion_de_ABMs(VentanaPrincipal lastForm)
        {
            InitializeComponent();
            this.lastForm = lastForm;
        }

        public Seleccion_de_ABMs(VentanaPrincipal acciones, Support.Rol rol, string userId)
        {
            InitializeComponent();
            this.lastForm = acciones;
            this.rol = rol;
            this.userId = userId;
        }

        private void Seleccion_de_ABMs_Load(object sender, EventArgs e)
        {
            List<Funcionalidadd> funcionalidades = Database.getFuncionalidadesPara(rol.id);
            foreach (Funcionalidadd funcionalidad in funcionalidades)
            {
                if (funcionalidad.activado)
                {
                    switch (funcionalidad.nombre)
                    {
                        case "ABM_ROL": btnRoles.Show(); break;
                        case "ABM_USUARIO": btnUsuario.Show(); break;
                        case "ABM_CLIENTE": btnCliente.Show(); break;
                        case "ABM_HOTEL": btnHotel.Show(); break;
                        case "ABM_HABITACION": btnHabitacion.Show(); break;
                        case "ABM_ESTADIA": btnEstadia.Show(); break;
                    }
                }
            }
        }

        private void abrirForm(Form form)
        {
            this.Hide();
            form.Show();
         }

        private void button3_Click(object sender, EventArgs e)
        {
            ABM_Rol ABM_Rol = new ABM_Rol(this);
            abrirForm(ABM_Rol);
 
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Registro Reg = new Registro(this);
            abrirForm(Reg);

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ABM_Cliente abmclie = new ABM_Cliente(this);

            abrirForm(abmclie);
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            ABM_Hotel abmhot = new ABM_Hotel(this);
            abrirForm(abmhot);
        }

        private void btnHabitacion_Click(object sender, EventArgs e)
        {
            ABM_Habitacion abmHab = new ABM_Habitacion(this);
            abrirForm(abmHab);
        }

        private void btnEstadia_Click(object sender, EventArgs e)
        {
        
            /*
            // ESTO VA EN EL ABM REGIMEN
             
             * private Seleccion_de_ABMs seleccion_de_ABMs;
             * public ABM_Regimen(Seleccion_de_ABMs seleccion_de_ABMs)
                 {
                      InitializeComponent();
                      this.seleccion_de_ABMs = seleccion_de_ABMs;
                 }
                  
             * // ESTO LO DEJO ACA 
             * ABM_Regimen abmREG = new ABM_Regimen(this);
             * abrirForm(abmREG);
             */
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lastForm.Show();
            this.Close();
        }
    }
}
