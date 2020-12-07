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
using Tulpep.NotificationWindow;

namespace OpenLib.GUI
{
    public partial class Principal : Form
    {
        SessionManager.CLS.Sesion _Seccion = SessionManager.CLS.Sesion.Instancia;
        public String descripcion;
        public String monto;
        public String fechaEntrega;
        public String empresa;
        public String cadena = " ";
        public int contador = 0;
        public String date = DateTime.Today.ToString("dd/MM/yyyy");


        public void Alerta()
        {
            DataTable _Alerta = new DataTable();
            _Alerta = CacheManager.CLS.Cache.Alertas_Pedidos();        

            for (int i = 0; i< _Alerta.Rows.Count; i++)            
            {

                this.descripcion = _Alerta.Rows[i]["Descripcion"].ToString();
                this.monto = _Alerta.Rows[i]["MontoTotal"].ToString();
                this.fechaEntrega = _Alerta.Rows[i]["Fecha"].ToString();
                this.empresa = _Alerta.Rows[i]["Empresa"].ToString();

               // if(date.ToString().Trim() == fechaEntrega.ToString().Trim())
              //  {
                    this.cadena += "Descripcion de la compra hecha: " + descripcion + " Por un monto de $: " + monto + " de la empresa: " + empresa + Environment.NewLine; ;
               // }              
               
            }
            if (ValidarDiaAlerta())
            {
                //if(cadena.Length <= 0) { 
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.icons8_notification_45px;
                popup.TitleText = "RECORDATORIOS " + date;                
                popup.ContentText = this.cadena;                
                popup.TitlePadding = new Padding(3);
                popup.ContentPadding = new Padding(3);
                popup.ContentFont = new Font("Tahoma", 10F);
                popup.HeaderColor = Color.FromArgb(252, 164, 2);
                popup.BorderColor = Color.FromArgb(252, 164, 2);
                popup.ShowGrip = false;                
                popup.AnimationDuration = 1000;
                popup.AnimationInterval = 1;
                popup.HeaderHeight = 15;
                popup.Size = new Size(600,300);
                popup.Popup();
              //  }

            }


        }

       public Boolean ValidarDiaAlerta()
        {
            Boolean respuesta =true;
            

            
            String a = "Admin";

            if(_Seccion.Informacion.Rol.ToString().Equals(a))
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }


            return respuesta;

        }

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
            this.Alerta();
        }

        private void CargarProcesos()
        {
            lblActividades.Text = CacheManager.CLS.Cache.COUNT_ACTIVE_RECORDATORIOS();
            lblTodaySales.Text = "$ " + CacheManager.CLS.Cache.TODAY_SALES();
            lblTotalPedidos.Text = CacheManager.CLS.Cache.TOTAL_PEDIDOS();
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
            General.GUI.Pedidos.PedidosEdicion frmPedidos = new General.GUI.Pedidos.PedidosEdicion();
            frmPedidos.ShowDialog();
            CargarProcesos();
        }
        private void btnCerrarSession(object sender, EventArgs e)
        {
                     
            Close();
            
        }
    }
}
