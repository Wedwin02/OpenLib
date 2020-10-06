
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Empleados
{
    public partial class EmpleadosGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos() {

            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.Todos_Los_Empleados();
                FiltroLocal();
            }
            catch 
            {

               
            }
        }


        private void FiltroLocal() {

            try
            {
                if (txbFiltrar.TextLength > 0)
                {
                    _DATOS.Filter = "Nombres Like '%" + txbFiltrar.Text + "%' OR DUI Like '%" + txbFiltrar.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();

                }
                dtgDatos.AutoGenerateColumns = false;
                dtgDatos.DataSource = _DATOS;

                lblRegistros.Text = dtgDatos.Rows.Count.ToString() + " Registros Encontrados";

            }
            catch
            {


            }

        }                         

        public EmpleadosGestion()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltroLocal();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadosEdicion f = new EmpleadosEdicion();
                f.lblAuxiliar.Text = "Insertar";
                f.txbDui.Enabled = true;                
                f.ShowDialog();
                CargarDatos();
            }
            catch 
            {

                
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("¿Esta seguro que desea editar el empleado seleccionado","Pregunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) {

                    EmpleadosEdicion f = new EmpleadosEdicion();
                    //Sincronisar
                    f.txbDui.Text = dtgDatos.CurrentRow.Cells["DUI"].Value.ToString();
                    f.txbNombres.Text = dtgDatos.CurrentRow.Cells["Nombres"].Value.ToString();
                    f.txbApellidos.Text = dtgDatos.CurrentRow.Cells["Apellidos"].Value.ToString();
                    f.txbDireccion.Text = dtgDatos.CurrentRow.Cells["Direccion"].Value.ToString();
                    f.txbTelefono.Text = dtgDatos.CurrentRow.Cells["Telefono"].Value.ToString();
                    f.cbGenero.Text = dtgDatos.CurrentRow.Cells["Genero"].Value.ToString();
                    f.cbFecha.Text = dtgDatos.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
                    //Son de Usuario
                    f.lblIDUsuario.Text = dtgDatos.CurrentRow.Cells["IDUsuario"].Value.ToString();
                    f.txbUsuario.Text = dtgDatos.CurrentRow.Cells["Usuario"].Value.ToString();
                    f.cbRol.Text = dtgDatos.CurrentRow.Cells["Rol"].Value.ToString();
                    f.lblAuxiliar.Text = "Modificar";
                    f.txbDui.Enabled = false;
                    f.txbPass.Enabled = false;
                    f.ckDesenmascarar.Enabled = false;
                    f.ShowDialog();
                    CargarDatos();
                }

                

            }
            catch 
            {

                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Realmente desea ELIMINAR el registro seleccionado", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Empleados oEmpleado = new CLS.Empleados();

                    oEmpleado.DUI = dtgDatos.CurrentRow.Cells["DUI"].Value.ToString();
                    oEmpleado.IDUsuario = dtgDatos.CurrentRow.Cells["IDUsuario"].Value.ToString();

                    if (oEmpleado.Eliminar())
                    {
                        CargarDatos();
                    }

                }

            }
            catch
            {


            }
        }
    }
}
