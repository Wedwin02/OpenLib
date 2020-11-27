using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Pedidos
{
    public partial class PedidosGestion : Form
    {
        public PedidosGestion()
        {
            InitializeComponent();
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            PedidosEdicion frmEdicionPedidos = new PedidosEdicion();
            frmEdicionPedidos.ShowDialog();
        }
    }
}
