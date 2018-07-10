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
using FrbaHotel.Support;


namespace FrbaHotel
{
    public partial class VentanaPorRol : Form
    {
       
        public String rolSeleccionado;

        public VentanaPorRol()
        {
            InitializeComponent();
        }

        public String nombreUser { get; set; }

        public VentanaPorRol(String idUser)
        {
            this.nombreUser = idUser;
            InitializeComponent();
            CargarComboRol();

        }
        private void CargarComboRol()
        {
            //Vaciar comboBox
            comboBox1.DataSource = null;
            FrbaHotel.AbmRol.Rol rol = new FrbaHotel.AbmRol.Rol();
            //Indicar qué propiedad se verá en la lista
            this.comboBox1.DisplayMember = "RolesPorUsuario";
            //Indicar qué valor tendrá cada ítem
            this.comboBox1.ValueMember = "RolesPorUsuario";
            //Asignar la propiedad DataSource
            this.comboBox1.DataSource = rol.getRolPorUsuario(this.nombreUser);


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            rolSeleccionado = this.comboBox1.Text.ToString();
            VentanaPorHotel vhot = new VentanaPorHotel(nombreUser, rolSeleccionado);
         vhot.ShowDialog();
         this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
           Login1 log = new Login1();
          log.Show();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void VentanaPorRol_Load(object sender, EventArgs e)
        {

        }
    }
}
