using FrbaHotel.AbmUsuario;
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
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == txtContrasenia.Text)
            {
                if (UsuarioDAL.Autenticacion(txtUsuario.Text, txtContrasenia.Text) == 0 || UsuarioDAL.Autenticacion(txtUsuario.Text, txtContrasenia.Text) == -3)
                {
                    VentanaPorRol vpr = new VentanaPorRol(txtUsuario.Text);
                    this.Hide();
                    vpr.ShowDialog();
                }
                else
                {
                    if (UsuarioDAL.Autenticacion(txtUsuario.Text, txtContrasenia.Text) == -1)
                    {
                        MessageBox.Show("Error al iniciar sesion");
                    }
                    else
                    {
                        MessageBox.Show("Usuario Inhabilitado.");
                        UsuarioDAL.PasarAInhabilitado(txtUsuario.Text);
                    }

                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
