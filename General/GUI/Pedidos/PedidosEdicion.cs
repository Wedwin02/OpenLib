using General.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using General.GUI.Ventas;
using General.UTIL;

namespace General.GUI.Pedidos
{
    public partial class PedidosEdicion : Form,ContratoUserForm,Contrato
    {
        private DataTable _DATOS = new DataTable();
        private int idPedidoSelected;
        private bool changeSaved;
        private ItemPedido currentControlItemSelected;

        public PedidosEdicion()
        {
            InitializeComponent();
            dtgCurrentDetails.AutoGenerateColumns = false;
            idPedidoSelected = 0;
            changeSaved = true;
            currentControlItemSelected = null;
        }


        private void Cargar()
        {
            try
            {
                _DATOS = CacheManager.CLS.Cache.ALL_PEDIDOS_DISPLAY();

                for (int i = 0; i < _DATOS.Rows.Count; i++) {
                    ItemPedido e3 = new ItemPedido();

                    e3.Estado = _DATOS.Rows[i]["Estado"].ToString();
                    e3.FechaEmision = "Fecha de Emision | " + _DATOS.Rows[i]["FechaEmision"].ToString();
                    e3.idPedido = Convert.ToInt32(_DATOS.Rows[i]["IDPedido"].ToString());
                    e3.Width = flowLayoutPanel1.Width - 10;
                    e3.Proveedor = "Proveedor | "+_DATOS.Rows[i]["NombreProveedor"].ToString();
                    e3.TotalProductos = _DATOS.Rows[i]["NumProductos"].ToString() + " Productos Solicitados";
                    e3.EmailSend = _DATOS.Rows[i]["CorreoElectronico"].ToString();
                    e3.Contrato = this;

                    if (e3.Estado.Equals("ENVIADO")) //Se pone verde 
                    {
                        e3.BkColor = System.Drawing.ColorTranslator.FromHtml("#27ae61");
                    }
                    else  //Se pone amarillo 
                    {
                        e3.BkColor = System.Drawing.ColorTranslator.FromHtml("#f39c11");
                    }
                    

                    this.flowLayoutPanel1.Controls.Add(e3);
                }
            }
            catch
            {

            }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void PedidosEdicion_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnCreatePedido_Click(object sender, EventArgs e)
        {
            PedidosCreate formCreate = new PedidosCreate();
            formCreate.ShowDialog();

            if (formCreate.EstadoOperacion == 1) {
                ItemPedido it = new ItemPedido();
                it.idPedido = Convert.ToInt32(formCreate.PedidoData.IdPedido);
                it.Estado = formCreate.PedidoData.Estado;
                it.FechaEmision = "Emision / " + formCreate.PedidoData.FechaEmision;
                it.idPedido = Convert.ToInt32(formCreate.PedidoData.IdPedido);
                it.Width = flowLayoutPanel1.Width - 10;
                it.Proveedor = "Proveedor | " + formCreate.ProviderText;
                it.TotalProductos = formCreate.PedidoData.NumProductSolicitados + " Productos Solicitados";
                it.Contrato = this;
                it.BkColor = System.Drawing.ColorTranslator.FromHtml("#f39c11");
                this.flowLayoutPanel1.Controls.Add(it);
            }
        }

        public void RefrestDataGridView(int idFilter) 
        {
            DataTable details = new DataTable();
            details = CacheManager.CLS.Cache.DETAILS_PEDIDO_FOR_DISPLAY(idFilter);
            dtgCurrentDetails.Rows.Clear();
            dtgCurrentDetails.Refresh();

            int contador = 0;
            for (int i = 0; i < details.Rows.Count; i++)
            {
                String idDetalle = details.Rows[i]["idDetalle"].ToString();
                String cantidad = details.Rows[i]["Cantidad"].ToString();
                String idProducto = details.Rows[i]["IDProducto"].ToString();
                String producto = details.Rows[i]["Nombre"].ToString();

                dtgCurrentDetails.Rows.Add(idDetalle, cantidad, idProducto, producto);
                contador++;
            }

            this.lblTotalNumDetalles.Text = Convert.ToString(contador);

        }

        public void RefreshItems(int IdPedido,ItemPedido itemSelected)
        {
            this.idPedidoSelected = IdPedido;
            this.currentControlItemSelected = itemSelected;

            if (itemSelected.Estado.Equals("ENVIADO"))
            {
                button6.Enabled = false;
                btnDelDetallePedido.Enabled = false;
                button4.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                button6.Enabled = true;
                btnDelDetallePedido.Enabled = true;
                button4.Enabled = true;
                button1.Enabled = true;
            }

            //Refrescar 
            RefrestDataGridView(this.idPedidoSelected);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (currentControlItemSelected == null)
            {
                MessageBox.Show("Selecione un pedido primero", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Ventas.BusquedaProducto frmBusqueda = new Ventas.BusquedaProducto(false);
            frmBusqueda.contrato = this;
            frmBusqueda.ShowDialog();

        }

        public void addDetalle(DetalleVenta d)
        {
            //Realizar la busqueda 
            bool encontrado = false;
            int a = Convert.ToInt32(d.IdProducto);
            int b = 0;
            int i = 0;

            for (i = 0; i < dtgCurrentDetails.Rows.Count; i++)
            {
                b = Convert.ToInt32(dtgCurrentDetails.Rows[i].Cells["IDProducto"].Value.ToString());
                if(b == a)
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                int CantAnt = Convert.ToInt32(dtgCurrentDetails.Rows[i].Cells["Cantidad"].Value.ToString());
                int CantNew = Convert.ToInt32(d.Cantidad);
                dtgCurrentDetails.Rows[i].Cells["Cantidad"].Value = (CantAnt + CantNew).ToString();
            }
            else
            {
                dtgCurrentDetails.Rows.Add(0, d.Cantidad, d.IdProducto, d.Nombre);
            }

            
            this.changeSaved = false;
            this.btnSaveChange.Enabled = true;

        }

        public void addBufferStock(BufferStock b)
        {
            throw new NotImplementedException();
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String HTMLContentBodyTable = "";
            String HTMLContent = "";

            //Enviar Email 
            //NOTA: Validar si esta con Estado de Pendiente de enviar 
            if (! changeSaved)
            {
                SaveChanges();  
            }

            DataTable details = new DataTable();
            details = CacheManager.CLS.Cache.DETAILS_PEDIDO_FOR_DISPLAY(this.idPedidoSelected);

            for (int i = 0; i < details.Rows.Count; i++)
            {
                HTMLContentBodyTable += "<tr>";
                HTMLContentBodyTable += "<td style='border-bottom: 1px solid #B5B5B5;padding: 10px;'>"+(i+1)+"</td>";
                HTMLContentBodyTable += "<td style='border-bottom: 1px solid #B5B5B5;padding: 10px;'>"+ details.Rows[i]["Nombre"].ToString() + "</td>";
                HTMLContentBodyTable += "<td style='border-bottom: 1px solid #B5B5B5;padding: 10px;'>"+ details.Rows[i]["Cantidad"].ToString() + "</td>";
                HTMLContentBodyTable += "</tr>";
            }

            //Logica de preparacion 
            //Preparacion HTML content

            HTMLContent += "<div style='width: 100%; max-width: 700px; margin: auto;'>";
            HTMLContent += "<h1 style='text-align: center;'>Detalles de Pedido</h1>";
            HTMLContent += "<small style='display: block; text-align: center; '>Lorem ipsum dolor sit amet, consectetur adipiscing elit</small>";
            HTMLContent += "<small style='display: block; text-align: center;margin-bottom: 20px;'> sed eiusmod tempor incidunt ut labore et dolore magna aliqua.</small>";
            HTMLContent += "<table border='0px' style='width: 100%;   border: 1px solid #B5B5B5; border-radius: 13px;  border-spacing: 0; text-align: center; overflow: hidden;'>";
            HTMLContent += "<thead style='background-color: #242444;'><tr>";
            HTMLContent += "<th style='color: white;'>#</th><th style='color: white;'>DESCRIPCION PRODUCTO</th><th style='color: white;'>SOLICITADO</th>";
            HTMLContent += "</tr></thead>";
            HTMLContent += "<tbody style='background-color: #EDEDED;'>";
            HTMLContent += HTMLContentBodyTable; 
            HTMLContent += "</tbody>";
            HTMLContent += "</table>";
            HTMLContent += "</div>";

            string destino = currentControlItemSelected.EmailSend;
            //Preparacion mensaje 
            System.Net.Mail.MailMessage mensaje = new System.Net.Mail.MailMessage();
            mensaje.To.Add(destino); //para quien va dirigido
            mensaje.Subject = "Notificacion de Nuevo Pedido";
            mensaje.SubjectEncoding = System.Text.Encoding.UTF8;

            mensaje.Body = HTMLContent;
            mensaje.BodyEncoding = System.Text.Encoding.UTF8;
            mensaje.IsBodyHtml = true;
            mensaje.From = new System.Net.Mail.MailAddress("openlib.inc@gmail.com");


            //Cliente Correo 
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.EnableSsl = true;
            cliente.UseDefaultCredentials = false;
            cliente.Credentials = new System.Net.NetworkCredential("openlib.inc@gmail.com", "q7WGrTaeu3LHuz7");
            cliente.Port = 587;
            cliente.Host = "smtp.gmail.com";
            cliente.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;


            //Logica de Ejecucion 
            try
            {
                cliente.Send(mensaje);
                
                Boolean enviadoEstado = CacheManager.CLS.Cache.ChangeStatusPedido(idPedidoSelected, "ENVIADO");
                if (! enviadoEstado) 
                {
                    MessageBox.Show("Pedido Enviado, pero ocurrio un error al actualizar en local", "Estado de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.currentControlItemSelected.Estado = "ENVIADO";
                this.currentControlItemSelected.BkColor = System.Drawing.ColorTranslator.FromHtml("#27ae61");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al enviar el pedido", "Estado de Envio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void SendEmail()
        {
            //Aqui se asume que todo esta guardado 
            //Obtener los datos de la base de datos 


        }

        private void SaveChanges()
        {
            if (changeSaved)
            {
                MessageBox.Show("No hay cambios que guardar", "Estado de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int contador = 0;
            for (int i = 0; i < dtgCurrentDetails.Rows.Count; i++)
            {
                int idTemporal = Convert.ToInt32(dtgCurrentDetails.Rows[i].Cells["idDetalle"].Value);
                bool estadoOperacion = false;
                DetallePedido dp = new DetallePedido();
                dp.Cantidad = dtgCurrentDetails.Rows[i].Cells["Cantidad"].Value.ToString();
                dp.IdPedido = this.idPedidoSelected.ToString();
                dp.IdProducto = dtgCurrentDetails.Rows[i].Cells["IDProducto"].Value.ToString();

                if (idTemporal == 0) // Insersion 
                {
                    estadoOperacion = dp.Guardar();
                }
                else //Actualizacion 
                {
                    dp.IdDetalle = idTemporal.ToString();
                    estadoOperacion = dp.Actualizar();
                }

                if (!estadoOperacion)
                {
                    MessageBox.Show("Error al persistir informacion", "Estado de operacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else
                {
                    //Limpiar y refrescar desde el server
                    contador++;
                }

            }

            RefrestDataGridView(this.idPedidoSelected);
            //Agui Guardar la cantidad de los productos 
            CacheManager.CLS.Cache.UPDATE_TOTAL_NUM_PEDIDOS(idPedidoSelected,contador);

            this.currentControlItemSelected.TotalProductos = contador + " Productos Solicitados";
            this.changeSaved = true;
            this.btnSaveChange.Enabled = false;
        }

        private void btnDelDetallePedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estoy entrando", "Informe Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Console.WriteLine("Me estan dando click");

            if (currentControlItemSelected == null) {
                Console.WriteLine("Esta nulo");
                return;
            }
            Console.WriteLine("No esta nulo");
            currentControlItemSelected.Estado = "Actualizado";
        }
    }
}
