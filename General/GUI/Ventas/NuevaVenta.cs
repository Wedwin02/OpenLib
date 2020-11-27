using General.CLS;
using General.UTIL;
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
    public partial class NuevaVenta : Form, Contrato
    {
        List<DetalleVenta> detalles = new List<DetalleVenta>();
        List<BufferStock> listBuffer = new List<BufferStock>();

        SessionManager.CLS.Sesion _Seccion = SessionManager.CLS.Sesion.Instancia;

        public NuevaVenta()
        {
            InitializeComponent();
            //Asignar la fecha y el usuario de vendedor actual 
            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
            string vendedor = _Seccion.Informacion.NombreCompleto;
            this.txbVendedor.Text = vendedor;
            this.lblFecha.Text = fecha;
        }

        public void addDetalle(DetalleVenta det)
        {
                int ind = detalles.FindIndex(x => x.IdProducto == det.IdProducto);
            
            if (ind >= 0)
            {
                int cantidad = Convert.ToInt32(det.Cantidad);
                decimal subTotal = Convert.ToDecimal(det.SubTotal);
                decimal desc = Convert.ToDecimal(det.Descuento);
                //el producto ya existe solo se le suma el valor 
                DetalleVenta aux = detalles.ElementAt(ind);
                aux.Cantidad = (Convert.ToInt32(det.Cantidad) + Convert.ToInt32(aux.Cantidad)).ToString();
                aux.Descuento = (Convert.ToDecimal(det.Descuento) + Convert.ToDecimal(aux.Descuento)).ToString();
                aux.SubTotal = (Convert.ToDecimal(det.SubTotal) + Convert.ToDecimal(aux.SubTotal)).ToString();
                detalles[ind] = aux;

                foreach (DataGridViewRow row in dtgDatos.Rows)
                {
                    if (row.Cells["IdProducto"].Value.ToString().Equals(det.IdProducto))
                    {
                        row.Cells["Cantidad"].Value = aux.Cantidad;
                        row.Cells["Descuento"].Value = aux.Descuento;
                        row.Cells["SubTotal"].Value = aux.SubTotal;
                        break;
                    }
                }
            }
            else
            {
                detalles.Add(det);
                this.dtgDatos.Rows.Add(det.IdProducto,
                                        det.Cantidad,
                                        det.Nombre,
                                        det.Precio,
                                        det.Descuento,
                                        det.SubTotal);
            }

                Calcular();
        }

        public void addBufferStock(BufferStock b)
        {
            listBuffer.Add(b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
                BusquedaProducto b = new BusquedaProducto(true);
            
            b.contrato = this;
            b.setListCompras(this.listBuffer);
            b.ShowDialog();

        }

        private void Calcular()
        {
            decimal subTotalFac = 0.0m; //Sub Total de toda la factura 
            decimal desc = 0.0m;
            decimal totalPagar = 0.0m;

            foreach(DetalleVenta d in detalles)
            {
                desc += Decimal.Parse(d.Descuento);
                subTotalFac += (Decimal.Parse(d.Precio)* Decimal.Parse(d.Cantidad));
                totalPagar += Decimal.Parse(d.SubTotal);
            }
            //Componentes 
            this.lblSubTotal.Text = "$ "+subTotalFac.ToString("0.00");
            this.lblRegistros.Text = detalles.Count.ToString();
            this.lblTotal.Text = "$ "+totalPagar.ToString("0.00"); // Total pagar 
            this.lblDescuento.Text = "$ "+desc.ToString(); //Total Descuentos 
        }

        private bool ValidarCampos() {
            bool valido = true;
            Notificador.Clear();
            if (txbCliente.TextLength <=3)
            {
                Notificador.SetError(txbCliente, "Llene este campo");
                return false;
            }
            return valido;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (detalles.Count == 0) {
                MessageBox.Show("No se ha selecionado ningun producto", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ValidarCampos()) 
            {
                btnFacturar.Enabled = false;
                decimal subTotalFac = 0.0m;
                decimal desc = 0.0m;
                decimal totalPagar = 0.0m;
                int idVenta = 0;
                string fecha = DateTime.Now.ToString("yyyy/MM/dd");

                foreach (DetalleVenta d in detalles)
                {
                    desc += Decimal.Parse(d.Descuento);
                    subTotalFac += (Decimal.Parse(d.Precio) * Decimal.Parse(d.Cantidad));
                    totalPagar += Decimal.Parse(d.SubTotal);
                }


                Venta v = new Venta();
                v.FechaEmision = fecha;
                v.Cliente = this.txbCliente.Text;
                v.TotalVenta = totalPagar.ToString();
                v.TotalDescuento = desc.ToString();
                v.SubTotal = subTotalFac.ToString();
                v.IDVendedor = _Seccion.Informacion.IDUsuario;

                idVenta = v.Guardar();


                if (idVenta != 0)
                {
                    //Se crean todos los detalles 
                    foreach (DetalleVenta d in detalles)
                    {
                        d.IDVenta = idVenta.ToString();
                        if (!d.Guardar())
                        {
                            //pasar esto al panel padre 
                            MessageBox.Show("No se realizo la venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    MessageBox.Show ("Se Realizo la Venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reporteria.GUI.Factura f = new Reporteria.GUI.Factura(idVenta);
                    f.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se realizo la venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Close();
            }

        }
    }
}
