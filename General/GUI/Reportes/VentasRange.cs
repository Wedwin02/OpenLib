using Reporteria.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Reportes
{
    public partial class VentasRange : Form
    {
        public VentasRange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String initDate = dtpInit.Text;
            String endDate = dtpEnd.Text;
            ReporteVentas rp = new ReporteVentas(initDate,endDate);
            rp.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
