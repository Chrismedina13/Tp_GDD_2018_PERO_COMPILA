using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmCliente
{
    public partial class ABM_Cliente : Form
    {
        public ABM_Cliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarCliente formModificarCliente = new ModificarCliente();
            formModificarCliente.Show();
        }

        private void AgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente formAgregarClie = new AgregarCliente();
            formAgregarClie.Show();
        }

        private void EliminarCliente_Click(object sender, EventArgs e)
        {
            EliminarCliente formEliminarClie = new EliminarCliente();
            formEliminarClie.Show();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ABM_Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
