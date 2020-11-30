using CacheManager.CLS;
using General.CLS;
using General.UTIL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Ventas
{
    public partial class BusquedaProducto : Form
    {
        private Contrato _contrato;
        private BindingSource _DATOS = new BindingSource();
        private List<BufferStock> _listCompras;
        private Boolean isSale = true; //Verifica si es venta 

        public Contrato contrato { get => _contrato; set => _contrato = value; }

        private void CargarDatos()
        {

            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.ALL_PRODUTOS_DISPLAY();
                FiltroLocal();
            }
            catch
            {


            }

        }
        private void FiltroLocal()
        {
            if (txbFiltroPrincipal.TextLength > 0)
            {
                _DATOS.Filter = "Codigo Like '%" + txbFiltroPrincipal.Text + "%' OR Nombre Like '%" + txbFiltroPrincipal.Text + "%'";
            }
            else
            {
                _DATOS.RemoveFilter();
            }
            dtgDatos.AutoGenerateColumns = false;
            dtgDatos.DataSource = _DATOS;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString() + " Registros Encontrados";
        }

       
        public BusquedaProducto(Boolean isVenta = true)
        {
            this.isSale = isVenta;

            InitializeComponent();
            CargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verificar si es una venta 
            if (txbCantidad.Text.Trim().Equals(""))
            {
                MessageBox.Show("La Cantidad no es valida", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (this.isSale)
            {
                DetalleVenta dt = new DetalleVenta();
                BufferStock buf = new BufferStock();

                dt.Cantidad = txbCantidad.Text;
                dt.SubTotal = txbSubTotal.Text;
                //Aqui hay que validar si esta selecionada una row 
                dt.IdProducto = dtgDatos.CurrentRow.Cells["Id"].Value.ToString();
                dt.Nombre = dtgDatos.CurrentRow.Cells["Nombre"].Value.ToString();
                dt.Precio = dtgDatos.CurrentRow.Cells["PrecioVenta"].Value.ToString();
                dt.Descuento = txbDescuento.Text;

                contrato.addDetalle(dt);

                buf.Index = dtgDatos.CurrentRow.Index.ToString();
                buf.Count = txbCantidad.Text;

                int currentStock = Convert.ToInt32(dtgDatos.CurrentRow.Cells["Stock"].Value);
                int subtrac = Convert.ToInt32(buf.Count);
                dtgDatos.CurrentRow.Cells["Stock"].Value = (currentStock - subtrac);
                contrato.addBufferStock(buf);
                verificarStock();
            }
            else //Si no es una venta es un pedido 
            {
                DetalleVenta dt = new DetalleVenta();
                dt.Cantidad = txbCantidad.Text;
                dt.IdProducto = dtgDatos.CurrentRow.Cells["Id"].Value.ToString();
                dt.Nombre = dtgDatos.CurrentRow.Cells["Nombre"].Value.ToString();

                contrato.addDetalle(dt);
            }

        }

        private void CalculosSelected()
        {
            decimal precio = 0.0m;
            int cantidad = 0;
            decimal subTotal = 0.0m;
            decimal desc = 0.0m;

            precio = Convert.ToDecimal(dtgDatos.CurrentRow.Cells["PrecioVenta"].Value);
            cantidad = txbCantidad.TextLength > 0 ? Int16.Parse(txbCantidad.Text):0;
            desc = txbDescuento.TextLength > 0 ? Decimal.Parse(txbDescuento.Text):0.0m;
            subTotal = (precio * cantidad) - desc;
            txbSubTotal.Text = subTotal.ToString();
        }

        private void txbCantidad_TextChanged(object sender, EventArgs e)
        {
            if (dtgDatos.SelectedRows.Count > 0 && verificarStock())
            {
                CalculosSelected();
            }
                    
        }
        private void CargarImagen(String Archivo) {
            int idArchivo = Convert.ToInt32(Archivo);
            String base64 = Cache.getImgBase64(idArchivo);
            if (!base64.Equals("")) {
                byte[] bites = Convert.FromBase64String(base64);
                using (MemoryStream img = new MemoryStream(bites, 0, bites.Length))
                {
                    previewImg.Image = Image.FromStream(img, true);
                }
            }
        }

        private void txbDescuento_TextChanged(object sender, EventArgs e)
        {
            CalculosSelected();
        }

        private void dtgDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgDatos.SelectedRows.Count > 0)
            {
                this.txbDescuento.Text = "0.0";
                this.txbCantidad.Text = "1";


                if(isSale)
                {
                    if (verificarStock())
                    {
                        this.txbCantidad.Text = "1";
                        this.txbSubTotal.Text = dtgDatos.CurrentRow.Cells["PrecioVenta"].Value.ToString();
                    }
                }else if(! isSale)
                {
                    this.txbCantidad.Text = "1";
                    this.txbSubTotal.Text = dtgDatos.CurrentRow.Cells["PrecioVenta"].Value.ToString();
                }




                String archivo = dtgDatos.CurrentRow.Cells["idArchivo"].Value.ToString();
                if (!archivo.Equals("")) {
                    CargarImagen(archivo);
                }
                else
                {
                    previewImg.Image = null;  
                }
            }
            else {
                this.txbDescuento.Text = "0.0";
                this.txbCantidad.Text = "0";
                this.txbSubTotal.Text = "0.0";
                this.btnAgregar.Enabled = false;
            }
            //false -> Msg: la cnatidad sol no es valida 
        }

        private bool verificarStock() {

            bool estado = true; 
            int stockSoli = txbCantidad.TextLength>0?Convert.ToInt16(txbCantidad.Text):0;
            int stockActual = Convert.ToInt16(dtgDatos.CurrentRow.Cells["Stock"].Value);
            if(stockSoli > stockActual)
            {
                estado = false;
                this.btnAgregar.Enabled = false;
                this.txbSubTotal.Text = "0.0";
            }
            else
            {
                this.btnAgregar.Enabled = true;
            }
            return estado;
        }

        private void BusquedaProducto_Load(object sender, EventArgs e)
        {
            if(isSale)
            {
                ResetExistencias();
                if (dtgDatos.SelectedRows.Count > 0)
                {
                    this.txbCantidad.Text = "1";
                    this.btnAgregar.Enabled = true;
                    verificarStock();
                }
            }else
            {
                this.txbDescuento.Visible = false;
                this.lblDisplayDesc.Visible = false;
                this.txbCantidad.Text = "1";
                this.btnAgregar.Enabled = true;
            }
        }

        private void txbFiltroPrincipal_TextChanged(object sender, EventArgs e)
        {
            FiltroLocal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setListCompras(List<BufferStock> listBuffer)
        {
            this._listCompras = listBuffer;
        }

        private void ResetExistencias()
        {
            int index = 0;
            int cantidad = 0;
            int cantToReset = 0;
            int result = 0;
            foreach (BufferStock bf in this._listCompras)
            {
                index = Convert.ToInt32(bf.Index);
                cantidad = Convert.ToInt32(bf.Count);
                cantToReset = Convert.ToInt32(dtgDatos.Rows[index].Cells["Stock"].Value);
                result = cantToReset - cantidad;
                dtgDatos.Rows[index].Cells["Stock"].Value = result;
            }
        }

    }
}
