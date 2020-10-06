using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Categoria
{
    public partial class CategoriaEdicion : Form
    {
        private Boolean Verificados()
        {
            Boolean verificado = true;
            Notificador.Clear();

            if (txbCategoria.TextLength == 0)
            {
                Notificador.SetError(txbCategoria, "Este campo no puede quedar vacio");
                verificado = false;
            }
            return verificado;
        }
            private void ProcesarDatosCategoria() {

            if (Verificados())
            {

                try
                {
                    CLS.Categorias u = new CLS.Categorias();
                    u.IDCategoria = txbIDCategoria.Text;
                    u.Categoria = txbCategoria.Text;


                    if (txbIDCategoria.TextLength> 0)
                    {
                        if (u.Actualizar())
                        {
                            Close();
                        }

                    }
                    else
                    {
                        if (u.Guardar())
                        {
                            Close();
                        }

                    }

                }
                catch(Exception ex)
                {


                }

            }

        }

        public CategoriaEdicion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProcesarDatosCategoria();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
