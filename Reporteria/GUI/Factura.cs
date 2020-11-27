using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporteria.GUI
{
    public partial class Factura : Form
    {

        private int _Factura;

        public Factura(int factura)
        {
            this._Factura = factura;
            InitializeComponent();
        }

        private void Generar()
        {
            try
            {
                REP.FacturaVenta oFactura = new REP.FacturaVenta();
                oFactura.SetDataSource(CacheManager.CLS.Cache.DETALLES_BY_ID(this._Factura));

                //Info General Factura
                DataTable info = CacheManager.CLS.Cache.INFO_FACTURA(this._Factura);

                oFactura.SetParameterValue("pCliente", info.Rows[0]["Cliente"].ToString());
                oFactura.SetParameterValue("pVendedor", info.Rows[0]["strVendedor"].ToString());                
                oFactura.SetParameterValue("pFecha", info.Rows[0]["strFecha"].ToString());
                oFactura.SetParameterValue("pSubTotal", "$" + info.Rows[0]["SubTotal"].ToString());
                oFactura.SetParameterValue("pDescuentos", "$ "+ info.Rows[0]["TotalDescuento"].ToString());
                oFactura.SetParameterValue("pMontoPagar", "$ "+ info.Rows[0]["TotalVenta"].ToString());
                oFactura.SetParameterValue("pNIT", info.Rows[0]["NIT"].ToString());
                oFactura.SetParameterValue("pNRC", info.Rows[0]["NRC"].ToString());
                crvFactura.ReportSource = oFactura;
            }
            catch (Exception ex)
            {

            }
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            Generar();
        }
    }
}
