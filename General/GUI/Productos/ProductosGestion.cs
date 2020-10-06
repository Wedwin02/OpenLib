using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Productos
{
    public partial class ProductosGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.ALL_PRODUTOS_DISPLAY();
                FiltrarLocalMente();
            }
            catch
            {

            }
        }
        private void FiltrarLocalMente()
        {
            try
            {
                if (txbFiltro.TextLength > 0)
                {
                    _DATOS.Filter = "Nombre LIKE  '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgProductos.AutoGenerateColumns = false;
                dtgProductos.DataSource = _DATOS;
                lblRegistros.Text = dtgProductos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch
            {

            }
        }
        public ProductosGestion()
        {
            InitializeComponent();
            Cargar();
        }

        private void TxbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalMente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductosEdicion p = new ProductosEdicion();
                p.ShowDialog();
                Cargar();
            }
            catch(Exception ex)
            {
                
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea EDITAR el registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProductosEdicion p = new ProductosEdicion();
                    p.txbIDProducto.Text = dtgProductos.CurrentRow.Cells["Id"].Value.ToString();
                    p.txbNombre.Text = dtgProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                    p.txbPrecioVenta.Text = dtgProductos.CurrentRow.Cells["PrecioVenta"].Value.ToString();
                    p.txbPrecioCompra.Text = dtgProductos.CurrentRow.Cells["PrecioCompra"].Value.ToString();
                    p.cbCategorias.SelectedValue = dtgProductos.CurrentRow.Cells["IDCategoria"].Value.ToString();
                    p.txbStock.Text = dtgProductos.CurrentRow.Cells["Stock"].Value.ToString();
                    p.txbCodigo.Text = dtgProductos.CurrentRow.Cells["Codigo"].Value.ToString();

                    String strIdArchivo = dtgProductos.CurrentRow.Cells["idArchivo"].Value.ToString();
                    if(strIdArchivo.Length > 0)
                    {
                        p.CargarImagen(strIdArchivo);
                        p.lblPath.Text = "is_load_file";
                        p.lblAuxImgId.Text = dtgProductos.CurrentRow.Cells["idArchivo"].Value.ToString();
                    }

                    p.ShowDialog();
                    Cargar();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Realmente desea ELIMINAR el registro seleccionado", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    CLS.Producto oProducto = new CLS.Producto();

                    oProducto.IDProducto = dtgProductos.CurrentRow.Cells["Id"].Value.ToString();

                if (oProducto.Eliminar())
                {
                        Cargar();
                }

            }

        }
            catch
            {


            }
        }
    }
}
