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
    public partial class ReporteVentas : Form
    {
        private String fechaInit;
        private String fechaEnd;

        public ReporteVentas(String init,String end)
        {
            this.fechaInit = init;
            this.fechaEnd = end;
            InitializeComponent();
        }

        private void Generar()
        {
            try
            {
                DataTable info = CacheManager.CLS.Cache.VENTAS_BY_RANGE(this.fechaInit,this.fechaEnd);
                if(info.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos que mostrar");
                }
                else
                {
                    REP.RepVentas rp = new REP.RepVentas();
                    rp.SetDataSource(info);
                    //parametros 
                    crvVentas.ReportSource = rp;
                }
            }
            catch
            {

            }
        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            Generar();
        }
    }
}
