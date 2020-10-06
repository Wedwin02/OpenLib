using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Categoria
{
    public partial class CategoriaGestion : Form
    {

        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {

            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.Todos_Las_Categorias();                
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
                if (txbFiltrar.TextLength > 0)
                {
                    _DATOS.Filter = "Categoria Like '%" + txbFiltrar.Text + "%'";
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





        public CategoriaGestion()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriaEdicion f = new CategoriaEdicion();
            f.ShowDialog();
            CargarDatos();
        }

       

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltroLocal();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {

                if (MessageBox.Show("¿Esta seguro que desea editar el empleado seleccionado", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    CategoriaEdicion f = new CategoriaEdicion();
                    //Sincronisar
                    f.txbIDCategoria.Text = dtgDatos.CurrentRow.Cells["IDCategoria"].Value.ToString();
                    f.txbCategoria.Text = dtgDatos.CurrentRow.Cells["Categoria"].Value.ToString();
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
                    CLS.Categorias o = new CLS.Categorias();

                    o.IDCategoria = dtgDatos.CurrentRow.Cells["IDCategoria"].Value.ToString();
                    if (o.Eliminar())
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
