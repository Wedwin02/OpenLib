using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Recordatorios
{
    public partial class RecordatorioEdicion : Form
    {
        private void ordenarTexBox()
        {
            //ordenando para recibir tabulacion
            txbTitulo.TabIndex = 0;
            cbbPrioridad.TabIndex = 1;
            cbbEstado.TabIndex = 2;
            txbDescripcion.TabIndex = 3;
            dtpFecha.TabIndex = 4;
            btnAceptar.TabIndex = 5;
            btnCancelar.TabIndex = 6;
        }

        private Boolean VerificarDatos()
        {
            Boolean Verificado = true;
            Notificador.Clear();
            if (txbTitulo.TextLength == 0)
            {
                Notificador.SetError(txbTitulo, "Este campo no puede quedar vacio");
                Verificado = false;
            }
            if (txbDescripcion.TextLength == 0)
            {
                Notificador.SetError(txbDescripcion, "Este campo no puede quedar vacio");
                Verificado = false;
            }
            return Verificado;
        }
        private void Procesar()
        {
            try
            {
               
                
                if (VerificarDatos())
                {
                    string fecha = DateTime.Now.ToString("yyyy/MM/dd");
                    CLS.Recordatorios ORecordatorio = new CLS.Recordatorios();
                    //SINCRONIZAR
                    ORecordatorio.IDRecordatorio = txbIDRecordatorio.Text;
                    ORecordatorio.FechaCreacion = fecha;
                    ORecordatorio.Titulo = txbTitulo.Text;
                    ORecordatorio.Prioridad = cbbPrioridad.Text;
                    ORecordatorio.EstadoActividad = cbbEstado.Text;
                    ORecordatorio.Descripcion = txbDescripcion.Text;
                    ORecordatorio.FechaPrevFin = dtpFecha.Text;

                    if (txbIDRecordatorio.TextLength > 0)
                    {
                        //Actualizar
                        if (ORecordatorio.Actualizar())
                        {
                            Close();
                        }
                    }
                    else
                    {
                        //Insercion
                        if (ORecordatorio.Guardar())
                        {
                            Close();
                        }

                    }
                }

            }
            catch
            {
            }

        }
        public RecordatorioEdicion()
        {
            InitializeComponent();
            ordenarTexBox();
            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
            this.txbFechaInicial.Text = fecha;
            cbbPrioridad.SelectedIndex = 0;
            cbbEstado.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Procesar();
        }
    }
}
