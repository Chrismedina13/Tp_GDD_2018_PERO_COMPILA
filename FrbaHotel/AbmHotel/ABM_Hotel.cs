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

namespace FrbaHotel.AbmHotel
{
    public partial class ABM_Hotel : Form
    {
        

         public ABM_Hotel()
        {
            InitializeComponent();
           
        }

        private void AgregarHotel_Click(object sender, EventArgs e)
        {
            AgregarHotel formAgregarHotel = new AgregarHotel();
            formAgregarHotel.Show();
        }

        private void ModificarHotel_Click(object sender, EventArgs e)
        {
            ModificarHotel formModificarHotel = new ModificarHotel();
            formModificarHotel.Show();
        }

        private void EliminarHotel_Click(object sender, EventArgs e)
        {
            EliminarHotel formEliminarHotel = new EliminarHotel();
            formEliminarHotel.Show();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ABM_Hotel_Load(object sender, EventArgs e)
        {

        }
    }
}
