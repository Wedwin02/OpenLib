using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Ventas
{
    public partial class Ventas : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.ALL_SALES();
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
                    _DATOS.Filter = "Cliente Like '%" + txbFiltrar.Text + "%' OR Vendedor Like '%" + txbFiltrar.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgDatos.AutoGenerateColumns = false;
                dtgDatos.DataSource = _DATOS;
            }
            catch
            {
            }
        }
        public Ventas()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

                NuevaVenta v = new NuevaVenta();
                v.ShowDialog();
            CargarDatos();
            
        }

        private void txbFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            FiltroLocal();
        }
    }
}
