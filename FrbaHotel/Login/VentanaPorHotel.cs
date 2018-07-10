using FrbaHotel.AbmHotel;
using FrbaHotel.Support;
using FrbaHotel.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class VentanaPorHotel : Form
    {
        public String nombreUser { get; set; }
        public String rolUser { get; set; }
      
        public VentanaPorHotel()
        {
            InitializeComponent();
        }
               
        public VentanaPorHotel(String idUser, String rolUsuario)
        {
            this.nombreUser = idUser;

            this.rolUser = rolUsuario;

            InitializeComponent();
            CargarComboHotel(idUser, rolUsuario);

        }
        private void CargarComboHotel(String idUser, String rolUsuario)
        {
            //Vaciar comboBox
            comboBox1.DataSource = null;
            Hotel hot = new Hotel();
            //Indicar qué propiedad se verá en la lista
            this.comboBox1.DisplayMember = "UsuarioPorHotel";
            //Indicar qué valor tendrá cada ítem
            this.comboBox1.ValueMember = "UsuarioPorHotel";
            //Asignar la propiedad DataSource
           this.comboBox1.DataSource = hot.getHotelPorUsuario(this.nombreUser, rolUsuario);
        }
       
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void VentanaPorRol_Load(object sender, EventArgs e)
        {
         
        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {

            List<FrbaHotel.Support.Rol> roles = Database.getUserRoles(nombreUser);
            
            foreach (FrbaHotel.Support.Rol rol in roles)
            {
                if (rol.estaHabilitado)
                {
                 
                   VentanaPPAL form1 = new VentanaPPAL(rol, rolUser);
                    this.Close();
                    form1.Show();

                }

                // CargarComboHotel();
                button1.Hide();
                comboBox1.Hide();
            }

        }
        private void VentanaPorHotel_Load(object sender, EventArgs e)
        {
           //va aca
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboHotel(nombreUser, rolUser);
        }



        public string userId { get; set; }

        private void VentanaPorHotel_Load_1(object sender, EventArgs e)
        {

        }
    }
}
