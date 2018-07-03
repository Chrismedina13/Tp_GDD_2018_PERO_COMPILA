using FrbaHotel.Support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRol
{
    public partial class Alta_Rol_Funcionalidad : Form
    {
        public Alta_Rol_Funcionalidad()
        {
            InitializeComponent(); CargarComboFuncionalidades();
        }
        private void CargarComboFuncionalidades()
        {
            //Vaciar comboBox
            funcionalidadesDGV.Columns.Clear();
            funcionalidadesDGV.DataSource = null;
          Funcionalidad f = new Funcionalidad();
            List<Funcionalidad> listFunc = f.getListFuncionalidades();
           //Asignar la propiedad DataSource
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            funcionalidadesDGV.Columns.Add(chkbox);
            chkbox.HeaderText = "Check Data";
            chkbox.Name = "seleccion";

            this.funcionalidadesDGV.DataSource = listFunc;
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

           try
            {
                RolDAL roldal = new RolDAL();
                Rol rol = new Rol();
                if (textBox1.Text != "")
                {

                    if (roldal.RolId(textBox1.Text) > 0)
                    {
                        MessageBox.Show("Error. Nombre del rol ya existente");
                    }
                    else
                    {
                        rol.Nombre = textBox1.Text;
                        int res = RolDAL.insert(rol.Nombre);
                        if (res > 0)
                        {
                            int resultado = agregarFuncionalidades(res);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un nombre de ROL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el alta de rol -" + ex.Message);
            }
             

        }
        private int agregarFuncionalidades(int idRol)
        {
            int i = 0;
            List<int> ChkedRow = new List<int>();
            try
            {
                for (i = 0; i <= funcionalidadesDGV.RowCount - 1; i++)
                {
                    if (Convert.ToBoolean(funcionalidadesDGV.Rows[i].Cells["seleccion"].Value) == true)
                    {
                        ChkedRow.Add(i);
                    }
                }
                if (ChkedRow.Count == 0) { return 0; }
                foreach (int k in ChkedRow)
                {
                    Funcionalidad.insert(idRol, Int32.Parse(funcionalidadesDGV.Rows[k].Cells[1].Value.ToString()));
                }
                MessageBox.Show("Rol y funcionalidades registrados Correctamente!");
                Alta_Rol_Funcionalidad af = new Alta_Rol_Funcionalidad();
                af.Close();
            }
            catch (Exception e) { return 0; }
            return 0;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Alta_Rol_Funcionalidad_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
       {

        }

        private void Alta_Rol_Funcionalidad_Load_1(object sender, EventArgs e)
        {
          
        
        }

        private void funcionalidadesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
