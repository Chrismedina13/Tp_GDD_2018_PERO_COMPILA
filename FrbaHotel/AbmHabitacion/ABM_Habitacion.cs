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


namespace FrbaHotel.AbmHabitacion
{
    public partial class ABM_Habitacion : Form
    {
        private Seleccion_de_ABMs seleccion_de_ABMs;

        public ABM_Habitacion(Seleccion_de_ABMs seleccion_de_ABMs)
        {
            InitializeComponent();
            this.seleccion_de_ABMs = seleccion_de_ABMs;
        }

        private void AgregarHabitacion_Click(object sender, EventArgs e)
        {
            AgregarHabitacion formAgregarHabitacion = new AgregarHabitacion();
            formAgregarHabitacion.Show();
        }

        private void ModificarHabitacion_Click(object sender, EventArgs e)
        {
            ModificarHabitacion formMOdificarHabitacion = new ModificarHabitacion();
            formMOdificarHabitacion.Show();
        }

        private void EliminarHabitacion_Click(object sender, EventArgs e)
        {
            EliminarHabitacion formEliminarHabitacion = new EliminarHabitacion();
            formEliminarHabitacion.Show();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
