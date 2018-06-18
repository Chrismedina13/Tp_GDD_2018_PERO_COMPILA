using FrbaHotel.AbmRol;
using FrbaHotel.Login;
using FrbaHotel.AbmHotel;
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

namespace FrbaHotel.AbmUsuario
{
    
    public partial class Registro : Form
    {
        private Seleccion_de_ABMs seleccion_de_ABMs;

        public Registro(Seleccion_de_ABMs seleccion_de_ABMs)
        {

            InitializeComponent();
            this.seleccion_de_ABMs = seleccion_de_ABMs;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void CargarComboRol()
        {
            ////Vaciar comboBox
            //comboBox1.DataSource = null;
            //Rol rol = new Rol();
            ////Indicar qué propiedad se verá en la lista
            //this.comboBox1.DisplayMember = "RolesPorUsuario";
            ////Indicar qué valor tendrá cada ítem
            //this.comboBox1.ValueMember = "RolesPorUsuario";
            ////Asignar la propiedad DataSource
            //this.comboBox1.DataSource = rol.getAllRoles();



            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            Rol s = new Rol();
            List<Rol> listFunc = s.getAllRol();
            //Asignar la propiedad DataSource
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            dataGridView1.Columns.Add(chkbox);
            chkbox.HeaderText = "Check Data";
            chkbox.Name = "seleccion";

            this.dataGridView1.DataSource = listFunc;

        }


        private void CargarListadoHoteles()
        {
            //Vaciar comboBox
            dataGridView2.Columns.Clear();
            dataGridView2.DataSource = null;
           // --------Hotel h = new Hotel();
            //--------------List<Hotel> listFunc = s.getListHoteles();
            //Asignar la propiedad DataSource
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            dataGridView2.Columns.Add(chkbox);
            chkbox.HeaderText = "Check Data";
            chkbox.Name = "seleccion";

            //--------this.dataGridView2.DataSource = listFunc;
            //this.dataGridView1.DataBindin();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "" || txtContrasenia.Text == "")
            {
                MessageBox.Show("Es obligatorio el Nombre de usuario o la Password");
            }
            else
            {
                if (CantCheckHot() > 0)
                {
                    if (CantCheckRol() > 0)
                    {
                        int res = UsuarioDAL.CrearCuenta(txtUsuario.Text, txtContrasenia.Text);
                        if (res > 0)
                        {
                            //verificarSucursalCobrador(res);
                            //verificarRolesCobrador(res);
                           // MessageBox.Show("Cuenta del Cobrador Creada Correctamente !");
                        }
                        else
                        {
                            MessageBox.Show("Error. No se pudo registrar el usuario");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Error. Debe elegir al menos un Rol.");
                    }
                }
                else
                {
                    MessageBox.Show("Error. Debe elegir al menos un Hotel");
                }
            }
        }


        private int CantCheckHot()
        {
            int i = 0;
            List<int> ChkedRow = new List<int>();

            for (i = 0; i <= dataGridView2.RowCount - 1; i++)
            {
                if (Convert.ToBoolean(dataGridView2.Rows[i].Cells["seleccion"].Value) == true)
                {
                    ChkedRow.Add(i);
                }
            }
            return ChkedRow.Count;

        }
        private int CantCheckRol()
        {
            int i = 0;
            List<int> ChkedRow = new List<int>();

            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["seleccion"].Value) == true)
                {
                    ChkedRow.Add(i);
                }
            }
            return ChkedRow.Count;

        }
        private bool altaAdmin(int id)
        {
            int i = 0;
            List<int> ChkedRow = new List<int>();
            try
            {
                for (i = 0; i <= dataGridView2.RowCount - 1; i++)
                {
                    if (Convert.ToBoolean(dataGridView2.Rows[i].Cells["seleccion"].Value) == true)
                    {
                        ChkedRow.Add(i);
                    }
                }
                if (ChkedRow.Count == 0) { return false; }
                foreach (int k in ChkedRow)
                {
                    //Hotel.insert(id, Int32.Parse(dataGridView2.Rows[k].Cells[1].Value.ToString()));

                } return true;
            }
            catch (Exception e) { return false; }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
