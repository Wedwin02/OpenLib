using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Pedidos
{
    public partial class ItemPedido : UserControl
    {
        //atributos  
        private string _lblEstado;
        private string _lblEmision;
        private string _lblProvider;
        private int TotalProds;
        private Image _Icon;
        private int _idPedido;
        private ContratoUserForm _contrato;
        private Color _bkColor;
        private string _emailSend;
        private Color _colorGround;
        private bool _isSelected;


        public ItemPedido()
        {
            InitializeComponent();
            this._idPedido = 0;
            this.IsSelected = false;
        }


        //propiedades 
        [Category("Custon Props")]
        public string Estado
        {
            get { return this._lblEstado; }
            set { this._lblEstado = value; this.lblEstado.Text = value; }
        }

        [Category("Custon Props")]
        public string FechaEmision
        {
            get { return this._lblEmision; }
            set { this._lblEmision = value; this.lblFechaEmision.Text = value; }
        }

        [Category("Custon Props")]
        public string Proveedor
        {
            get { return this._lblProvider; }
            set { this._lblProvider = value; this.lblProveedor.Text = value; }
        }

        [Category("Custon Props")]
        public int TotalProductos
        {
            get { return this.TotalProds; }
            set { this.TotalProds = value; this.lblTotalProductos.Text = value + " Productos Solicitados"; }
        }

        [Category("Custon Props")]
        public Image Icon
        {
            get { return this._Icon; }
            set { this._Icon = value; this.imgEstado.Image = value; }
        }

        public int idPedido
        {
            get { return this._idPedido; }
            set { this._idPedido = value; }
        }

        public ContratoUserForm Contrato { get => _contrato; set => _contrato = value; }
        
        [Category("Custon Props")]
        public Color BkColor 
        {
            get { return this._bkColor; }
            set { this._bkColor = value; this.imgEstado.BackColor = value;}
        }

        public string EmailSend { get => _emailSend; set => _emailSend = value; }

        [Category("Custon Props")]
        public Color ColorGround 
        {
            get { return this._colorGround; }
            set { 
                this._colorGround = value;
                this.tableLayoutPanel1.BackColor = value;
                this.lblEstado.BackColor = value;
                //this.lblFechaEmision.BackColor = value;
                //this.lblProveedor.BackColor = value;
                //this.lblTotalProductos.BackColor = value;
            }
        }

        public bool IsSelected { get => _isSelected; set => _isSelected = value; }

        private void tableLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.BackColor = Color.Silver;
            this.lblEstado.BackColor = Color.Silver;
        }

        private void tableLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            if(! IsSelected)
            {
                this.tableLayoutPanel1.BackColor = Color.Gainsboro;
                this.lblEstado.BackColor = Color.Gainsboro;
            }
            
        }

        private void onClickShowDetails(object sender, EventArgs e)
        {
            int PEDIDO = this.idPedido;

            Contrato.RefreshItems(this.idPedido,this);
        }
    }
}
