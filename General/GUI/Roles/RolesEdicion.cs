using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Roles
{
    public partial class RolesEdicion : Form
    {
        private Boolean Verificados()
        {
            Boolean verificado = true;
            Notificador.Clear();

            if (txbRol.TextLength == 0)
            {
                Notificador.SetError(txbRol, "Este campo no puede quedar vacio");
                verificado = false;
            }
            if (txbDescripcion.TextLength == 0)
            {
                Notificador.SetError(txbDescripcion, "Este campo no puede quedar vacio");
                verificado = false;
            }
            if (txbOpcion.TextLength == 0)
            {
                Notificador.SetError(txbOpcion, "Este campo no puede quedar vacio");
                verificado = false;
            }
            return verificado;
        }






        private void ordenarTexBox()
        {
            //ordenando para recibir tabulacion
            txbRol.TabIndex = 0;
            txbDescripcion.TabIndex = 1;
            txbOpcion.TabIndex = 2;
            cbCategoria.TabIndex = 3;
            btnGuardar.TabIndex = 4;
            btnCancelar.TabIndex = 5;          


        }
        private void ProcesarDatosRol()
        {

            
                try
                {
                    CLS.Roles oRol = new CLS.Roles();

                    oRol.IDRol = txbIDRol.Text;
                    oRol.Rol = txbRol.Text;
                    oRol.Descripcion = txbDescripcion.Text;
                    //Opciones
                    oRol.IDOpcion = Convert.ToInt32(lblOpcion.Text);
                    oRol.Opcion = txbOpcion.Text;
                    oRol.IDCategoria = cbCategoria.SelectedIndex;
                    //Categoria Opciones
                    oRol.CategoriaOp1 = cbCategoria.Text;




                    if (txbIDRol.TextLength > 0)
                    {
                        if (oRol.Actualizar())
                        {
                            Close();
                        }

                    }
                    else
                    {
                        if (oRol.Guardar())
                        {
                            Close();
                        }

                    }


                }
                catch
                {

                }
            
        }







        public RolesEdicion()
        {
            InitializeComponent();
            cbCategoria.SelectedIndex = 0;
            ordenarTexBox();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProcesarDatosRol();
            
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ckRol_CheckedChanged(object sender, EventArgs e)
        {
            if (ckRol.Checked)
            {
                txbRol.Enabled = false;
                txbDescripcion.Enabled = false;
                txbRol.Clear();
                txbDescripcion.Clear();
                


            }
            else
            {
                txbRol.Enabled = true;
                txbDescripcion.Enabled = true;

            }
        }

        private void ckOpcion_CheckedChanged(object sender, EventArgs e)
        {
            if (ckOpcion.Checked)
            {
                txbOpcion.Enabled = false;
                txbOpcion.Clear();
                lblOpcion.Text = "0";
                


            }
            else
            {
                txbOpcion.Enabled = true;

            }
        }

        private void ckCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (ckCategoria.Checked)
            {
                cbCategoria.Enabled = false;
                cbCategoria.SelectedIndex = 0;
                

            }
            else
            {
                cbCategoria.Enabled = true;


            }

        }
    }
}
