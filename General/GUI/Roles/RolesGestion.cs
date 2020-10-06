using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Roles
{
    public partial class RolesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();      
        Int32 indice = 0;


        private void cargarRoles()
        {
            DataTable _Roles = new DataTable();
            _Roles = CacheManager.CLS.Cache.Todos_Los_Roles();
            cbRol.DataSource = _Roles;
            cbRol.DisplayMember = "Rol";
            cbRol.ValueMember = "IDRol";
            

        }
        private void CargarDescripcion() {
            DataTable _Roles = new DataTable();
            _Roles = CacheManager.CLS.Cache.Todos_Los_Roles();
            txbDes.Text = _Roles.Rows[cbRol.SelectedIndex]["Descripcion"].ToString();
            lblIDR.Text = _Roles.Rows[cbRol.SelectedIndex]["IDRol"].ToString();

        }

        

        private void cargarAsignaciones() {


            _DATOS.DataSource = CacheManager.CLS.Cache.Asignaciones_de_Permisos_Segun_IDRol(cbRol.SelectedValue.ToString());
            dtgDatos.AutoGenerateColumns = false;
            dtgDatos.DataSource = _DATOS;
            dtgDatos.Refresh();
             

        }

     


        private void FiltroLocal()
        {

            try
            {
                if (txbFiltrar.TextLength > 0)
                {
                    _DATOS.Filter = "Opcion Like '%" + txbFiltrar.Text + "%'";
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





        public RolesGestion()
        {
            InitializeComponent();
            cargarRoles();
            FiltroLocal();
            cargarAsignaciones();            
            cbRol.SelectedIndex = 0;

        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltroLocal();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                RolesEdicion f = new RolesEdicion();
                f.ShowDialog();
                cargarAsignaciones();
            }
            catch 
            {

            }
           

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro que desea EDITAR el elemento seleccionado", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    RolesEdicion f = new RolesEdicion();
                    f.txbIDRol.Text = lblIDR.Text;
                    f.txbRol.Text = cbRol.Text;
                    f.txbDescripcion.Text = txbDes.Text;
                    f.lblOpcion.Text = dtgDatos.CurrentRow.Cells["IDOpcion"].Value.ToString();
                    f.txbOpcion.Text = dtgDatos.CurrentRow.Cells["Opcion"].Value.ToString();
                    f.cbCategoria.SelectedIndex = Convert.ToInt32(dtgDatos.CurrentRow.Cells["IDCategoria"].Value.ToString());                    
                    f.ShowDialog();                   
                    cargarAsignaciones();

                }
            }

            catch
            {


            }
        }

        private void cbRol_SelectedValueChanged(object sender, EventArgs e)
        {
            cargarAsignaciones();
            CargarDescripcion();

        }

        private void dtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex==0 && e.RowIndex>=0) {

                    Int32 valor = 0;
                    valor = Convert.ToInt32(dtgDatos.CurrentRow.Cells["IDPermiso"].Value.ToString());
                    CLS.Permisos oPermisos = new CLS.Permisos();
                    oPermisos.IDRol = cbRol.SelectedValue.ToString();
                    if (valor > 0)
                    {
                        oPermisos.IDPermiso = valor.ToString();
                        oPermisos.Revocar();
                    }
                    else {
                        oPermisos.IDOpcion = dtgDatos.CurrentRow.Cells["IDOpcion"].Value.ToString();
                        oPermisos.Conceder();
                    }
                    cargarAsignaciones();
                }
            }
            catch 
            {
                MessageBox.Show("Error");
                
            }
        }

        private void cbRol_MouseClick(object sender, MouseEventArgs e)
        {
            cargarRoles();
        }
    }
}
