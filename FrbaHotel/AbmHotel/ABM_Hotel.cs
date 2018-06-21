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
         private Seleccion_de_ABMs seleccion_de_ABMs;

         public ABM_Hotel(Seleccion_de_ABMs seleccion_de_ABMs)
        {
            InitializeComponent();
            this.seleccion_de_ABMs = seleccion_de_ABMs;
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
    }
}
