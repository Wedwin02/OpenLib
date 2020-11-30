using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using General.CLS;

namespace General.GUI.Pedidos
{
    public partial class PedidosCreate : Form
    {
        private int _estadoOperacion = 0; //0: sin respuesta | 1 ok || 2 fail 
        private Pedido _pedidoData;
        private String _ProviderText;

        public int EstadoOperacion 
        {
            get { return this._estadoOperacion; }
            set { this._estadoOperacion = value; }
        }

        public Pedido PedidoData { get => _pedidoData; set => _pedidoData = value; }
        public string ProviderText { get => _ProviderText; set => _ProviderText = value; }

        public PedidosCreate()
        {
            InitializeComponent();
            CargarProveedores();
            string currentFecha = DateTime.Now.ToString("dd/MM/yyyy");
            this.lblFechaEmision.Text = currentFecha;
            this._estadoOperacion = 0;

        }

        public void CargarProveedores()
        {
            DataTable _Roles = new DataTable();
            _Roles = CacheManager.CLS.Cache.All_Providers_Combo();
            comboProviders.DataSource = _Roles;
            comboProviders.DisplayMember = "value";
            comboProviders.ValueMember = "id";
        }

        private void Procesar() 
        {
            string FechaEstimada = this.datepckFechaEstimada.Value.ToString("yyyy/MM/dd");
            string idProveedor = comboProviders.SelectedValue.ToString();
            string FechaEmision = DateTime.Now.ToString("yyyy/MM/dd"); ;
            String numProdSolicitados = "0";
            ProviderText = comboProviders.Text;

            try
            {
                _pedidoData = new General.CLS.Pedido();
                _pedidoData.FechaEmision = FechaEmision;
                _pedidoData.FechaEstimada = FechaEstimada;
                _pedidoData.Estado = "REVISION";
                _pedidoData.IdProveedor = idProveedor;
                _pedidoData.NumProductSolicitados = numProdSolicitados;

                Pedido pe = _pedidoData.Insertar();
                //Verificar si es create o pudate 


                if (pe != null)
                {
                    _pedidoData.IdPedido = pe.IdPedido;
                    this._estadoOperacion = 1;
                }
                else 
                {
                    this._estadoOperacion = 2;
                }

                Close();            }
            catch
            {

            }
        }

        private void btnConfirmCreatePedido_Click(object sender, EventArgs e)
        {
            Procesar();

        }

    }

}
