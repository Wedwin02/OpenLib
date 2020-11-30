using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Proveedores
{
    public partial class ProveedoresEdicion : Form
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
            if (txbCorreo.TextLength == 0)
            {
                Notificador.SetError(txbCorreo, "Este campo no puede quedar vacio");
                Verificado = false;
            }
            if (txbTelefono.TextLength == 0)
            {
                Notificador.SetError(txbTelefono, "Este campo no puede quedar vacio");
                Verificado = false;
            }
            if (txbDireccion.TextLength == 0)
            {
                Notificador.SetError(txbDireccion, "Este campo no puede quedar vacio");
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
                    CLS.Proveedores oProveedores = new CLS.Proveedores();
                    oProveedores.IDProveedore = txbIDProveedore.Text;
                    oProveedores.NombreProveedor = txbNombre.Text;
                    oProveedores.Direccion = txbDireccion.Text;
                    oProveedores.Telefono = txbTelefono.Text;
                    oProveedores.CorreoElectronico = txbCorreo.Text;
                    if (this.txbIDProveedore.TextLength > 0)
                    {
                        if (oProveedores.Actualizar())
                        {
                            Close();
                        }
                       
                    }
                    else 
                    {
                        if (oProveedores.Guardar())
                        {
                            Close();
                        }

                    }
                    Close();
                }
                catch
                {
                }
            }
        }
        public ProveedoresEdicion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
