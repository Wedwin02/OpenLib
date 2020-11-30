using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Proveedores
{
    public partial class ProveedoresGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {

            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.Todos_Los_Proveedores();
                FiltroLocal();
            }
            catch
            {

            }
        }

        private void FiltroLocal()
        {
            try
            {
                if (txbFiltro.TextLength > 0)
                {

                    _DATOS.Filter = "NombreProveedor Like '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgProveedores.AutoGenerateColumns = false;
                dtgProveedores.DataSource = _DATOS;

                lblRegistros.Text = dtgProveedores.Rows.Count.ToString() + " Registros Encontrados";

            }
            catch
            {

            }

        }

        public ProveedoresGestion()
        {
            InitializeComponent();
            CargarDatos();
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ProveedoresEdicion f = new ProveedoresEdicion();
                f.lblAuxiliar.Text = "Insertar";
                f.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro que desea editar el empleado seleccionado", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    ProveedoresEdicion f = new ProveedoresEdicion();
                    //Sync
                    f.txbIDProveedore.Text = dtgProveedores.CurrentRow.Cells["IDProveedore"].Value.ToString();
                    f.txbNombre.Text = dtgProveedores.CurrentRow.Cells["NombreProveedor"].Value.ToString();
                    f.txbCorreo.Text = dtgProveedores.CurrentRow.Cells["CorreoElectronico"].Value.ToString();
                    f.txbTelefono.Text = dtgProveedores.CurrentRow.Cells["Telefono"].Value.ToString();
                    f.txbDireccion.Text = dtgProveedores.CurrentRow.Cells["Direccion"].Value.ToString();
                    f.lblAuxiliar.Text = "Modificar";
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
                    CLS.Proveedores oProveedores = new CLS.Proveedores();

                    oProveedores.IDProveedore = dtgProveedores.CurrentRow.Cells["IDProveedore"].Value.ToString();
                    
                    if (oProveedores.Eliminar())
                    {
                        CargarDatos();
                    }

                }

            }
            catch
            {


            }
        }

        private void txbFiltro_TextChanged_1(object sender, EventArgs e)
        {
            FiltroLocal();
        }
    }
}

