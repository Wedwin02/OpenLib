using General.GUI.Reportes;
using General.GUI.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLib.GUI
{
    public partial class Principal : Form
    {
        SessionManager.CLS.Sesion _Seccion = SessionManager.CLS.Sesion.Instancia;


        


        public Principal()
        {
            InitializeComponent();
        }       

        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {
            if (_Seccion.Informacion.VerificarPermiso(5))
            {
                General.GUI.Empleados.EmpleadosGestion f = new General.GUI.Empleados.EmpleadosGestion();
                f.Show();
            }
            

        }

        private void btnGestionRoles_Click(object sender, EventArgs e)
        {
            if (_Seccion.Informacion.VerificarPermiso(7))
            {
                General.GUI.Roles.RolesGestion f = new General.GUI.Roles.RolesGestion();
                f.ShowDialog();
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = _Seccion.Informacion.Usuario;
            lblRol.Text = _Seccion.Informacion.Rol;

            CargarProcesos();
        }

        private void CargarProcesos()
        {
            lblActividades.Text = CacheManager.CLS.Cache.COUNT_ACTIVE_RECORDATORIOS();
            lblTodaySales.Text = "$ " + CacheManager.CLS.Cache.TODAY_SALES();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (_Seccion.Informacion.VerificarPermiso(1))
            {
                General.GUI.Productos.ProductosGestion f = new General.GUI.Productos.ProductosGestion();
                f.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_Seccion.Informacion.VerificarPermiso(4))
            {
                Ventas v = new Ventas();
                v.ShowDialog();                          
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            NuevaVenta n = new NuevaVenta();
            n.ShowDialog();
            CargarProcesos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_Seccion.Informacion.VerificarPermiso(6))
            {
                VentasRange g = new VentasRange();
                g.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (_Seccion.Informacion.VerificarPermiso(2))
            {
                General.GUI.Categoria.CategoriaGestion f = new General.GUI.Categoria.CategoriaGestion();
                f.ShowDialog();
            }
           
        }
		
        private void button4_Click(object sender, EventArgs e)
        {
            if (_Seccion.Informacion.VerificarPermiso(3))
            {			
            General.GUI.Recordatorios.RecordatorioGestiones F = new General.GUI.Recordatorios.RecordatorioGestiones();
            F.ShowDialog();
                CargarProcesos();
			}
		}

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            if (_Seccion.Informacion.VerificarPermiso(3))
            {
                General.GUI.Proveedores.ProveedoresGestion F = new General.GUI.Proveedores.ProveedoresGestion();
                F.ShowDialog();
                
            }
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {

        }
    }
}
