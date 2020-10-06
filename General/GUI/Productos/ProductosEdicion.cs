using CacheManager.CLS;
using General.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Productos
{
    public partial class ProductosEdicion : Form
    {

        private Boolean VerificarDatos()
        {
            Boolean Verificado = true;
            Notificador.Clear();
            if (txbNombre.TextLength == 0)
            {
                Notificador.SetError(txbNombre, "Este campo no puede quedar vacio");
                Verificado = false;
            }
            if (txbPrecioVenta.TextLength == 0)
            {
                Notificador.SetError(txbPrecioVenta, "Este campo no puede quedar vacio");
                Verificado = false;
            }
            if (txbPrecioCompra.TextLength == 0)
            {
                Notificador.SetError(txbPrecioCompra, "Este campo no puede quedar vacio");
                Verificado = false;
            }
            if (txbStock.TextLength == 0)
            {
                Notificador.SetError(txbStock, "Este campo no puede quedar vacio");
                Verificado = false;
            }
            if (txbCodigo.TextLength == 0)
            {
                Notificador.SetError(txbCodigo, "Este campo no puede quedar vacio");
                Verificado = false;
            }
            if (txbCodigo.TextLength == 0)
            {
                Notificador.SetError(txbCodigo, "Este campo no puede quedar vacio");
                Verificado = false;
            }
            if (lblPath.Text == "default")
            {
                Notificador.SetError(previewImg, "Se debe cargar una Imagen");
                Verificado = false;
            }
            return Verificado;
        }
        private void Procesar()
        {
            if (VerificarDatos())
            {
                try
                {
                    Archivos pArchivo = new Archivos();


                    int idArchivo = 0;
                    if (txbIDProducto.TextLength > 0 && (lblPath.Text.Equals("is_load_file")) && !(lblAuxImgId.Text.Equals("id_file")))
                    {
                        //Esta actualizando pero dejo la misma imagen 
                        idArchivo = Convert.ToInt32( lblAuxImgId.Text);
                    }
                    else if (txbIDProducto.TextLength > 0 && !(lblPath.Text .Equals("is_load_file") )&& !(lblAuxImgId.Text.Equals("id_file")))
                    {

                        using (MemoryStream reader = new MemoryStream())
                        {
                            previewImg.Image.Save(reader, previewImg.Image.RawFormat);
                            pArchivo.Datos = Convert.ToBase64String(reader.ToArray());
                        }
                        //Esta actualizando y cambio la imagen o si esta insertando 
                        pArchivo.Id = lblAuxImgId.Text;

                        var info1 = new FileInfo(lblPath.Text);
                        pArchivo.Nombre = info1.Name;
                        pArchivo.Extension = info1.Extension;
                        pArchivo.Size = info1.Length.ToString();
                        pArchivo.MimeType = "NAN";


                        idArchivo = pArchivo.Actualizar(); //Si se actualizo trae el mismo id sino trae 0 
                    }
                    else
                    {
                        using (MemoryStream reader = new MemoryStream())
                        {
                            previewImg.Image.Save(reader, previewImg.Image.RawFormat);
                            pArchivo.Datos = Convert.ToBase64String(reader.ToArray());
                        }
                        var info2 = new FileInfo(lblPath.Text);
                        pArchivo.Nombre = info2.Name;
                        pArchivo.Extension = info2.Extension;
                        pArchivo.Size = info2.Length.ToString();
                        pArchivo.MimeType = "NAN";

                        idArchivo = pArchivo.Guardar();
                    }


                    if (idArchivo != 0)
                    {
                        Producto pProducto = new Producto();
                        pProducto.IDProducto = txbIDProducto.Text;
                        pProducto.Nombre = txbNombre.Text;
                        pProducto.PrecioVenta = txbPrecioVenta.Text;
                        pProducto.PrecioCompra = txbPrecioCompra.Text;
                        pProducto.IDCategoria = cbCategorias.SelectedValue.ToString();
                        pProducto.Stock = txbStock.Text;
                        pProducto.Codigo = txbCodigo.Text;
                        pProducto.IdArchivo = idArchivo.ToString(); 

                        if (txbIDProducto.TextLength > 0)
                        {
                            pProducto.Actualizar();
                        }
                        else
                        {
                            pProducto.Guardar();
                        }
                        this.Close();
                    }
                    else
                    {

                    }
                }
                catch(Exception ex)
                {

                }

            }
        }
        public ProductosEdicion()
        {
            InitializeComponent();
            CargarCategorias();
            if(cbCategorias.Items.Count > 0)
            {
                cbCategorias.SelectedIndex = 0;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           Procesar();
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {

            var file = new OpenFileDialog();
            file.Title = "Selecione una imagen";
            file.Filter = "Imagefiles (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                lblPath.Text = file.FileName;
                previewImg.Image = Image.FromFile(lblPath.Text);
            }

        }

        private void CargarCategorias()
        {
            DataTable _Categorias = new DataTable();
            _Categorias = CacheManager.CLS.Cache.Todos_Las_Categorias();
            cbCategorias.DataSource = _Categorias;
            cbCategorias.DisplayMember = "Categoria";
            cbCategorias.ValueMember = "IDCategoria";
            
        }


        public void CargarImagen(String idenArchivo)
        {
            int idArchivo = Convert.ToInt32(idenArchivo);
            String base64 = Cache.getImgBase64(idArchivo);
            if (!base64.Equals(""))
            {
                byte[] bites = Convert.FromBase64String(base64);
                using (MemoryStream img = new MemoryStream(bites, 0, bites.Length))
                {
                    previewImg.Image = Image.FromStream(img, true);
                }
            }
        }

    }
}
