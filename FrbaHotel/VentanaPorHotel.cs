using FrbaHotel.AbmHotel;
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
            rolUser = rolUsuario;
            InitializeComponent();
            CargarComboHotel(idUser, rolUsuario);

        }
        private void CargarComboHotel(String idUser, String rolUsuario)
        {
            //Vaciar comboBox
            comboBox1.DataSource = null;
            //---Hotel hot = new Hotel();
            //Indicar qué propiedad se verá en la lista
            this.comboBox1.DisplayMember = "UsuarioPorHotel";
            //Indicar qué valor tendrá cada ítem
            this.comboBox1.ValueMember = "UsuarioPorHotel";
            //Asignar la propiedad DataSource
           //--------- this.comboBox1.DataSource = hot.getHotelPorUsuario(this.nombreUser, rolUsuario);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            
            /*if (rolUser == "Administrativo")
            {
                VentanaPrincipal nuevaVentanta = new VentanaPrincipal(nombreUser, rolUser);
                nuevaVentanta.ShowDialog();
                this.Hide();
            }
            else if (rolUser == "Recepcionista")
            {
                VentanaRecepcionista vcob = new VentanaRecepcionista(nombreUser, rolUser);
                vcob.Show();
                this.Hide();
            }

            else
            {

                VentanaPrincipal nuevaVentanta = new VentanaPrincipal(nombreUser, rolUser);
                nuevaVentanta.ShowDialog();
                this.Hide();

            }
             */
        }
        private void VentanaPorHotel_Load(object sender, EventArgs e)
        {

        }


    }
}
