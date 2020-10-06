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
    public partial class RecordatorioGestiones : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void Cargar()
        {
            try
            {
                _DATOS.DataSource = CacheManager.CLS.Cache.ALL_RECORDATORIOS();
                FiltrarLocalMente();
            }
            catch
            {

            }
        }
        private void FiltrarLocalMente()
        {
            try
            {
                if (txbFiltro.TextLength > 0)
                {
                    _DATOS.Filter = "Titulo LIKE  '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgRecordatorios.AutoGenerateColumns = false;
                dtgRecordatorios.DataSource = _DATOS;
                lblEstado.Text = dtgRecordatorios.Rows.Count.ToString() + " Recordatorios Encontrados";
            }
            catch
            {

            }
        }
        public RecordatorioGestiones()
        {
            
            InitializeComponent();
                Cargar();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarLocalMente();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea finalizar el recordatorio seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Recordatorios ORecordatorio = new CLS.Recordatorios();

                    ORecordatorio.IDRecordatorio = dtgRecordatorios.CurrentRow.Cells["IDRecordatorio"].Value.ToString();

                    if (ORecordatorio.Finalizar())
                    {
                        Cargar();
                    }

                }

            }
            catch
            {
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                RecordatorioEdicion f = new RecordatorioEdicion();
                f.ShowDialog();
                Cargar();
            }
            catch
            {
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("¿Esta seguro que desea editar el recordatorio seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    RecordatorioEdicion f = new RecordatorioEdicion();
                    //Sincronisar
                    f.txbIDRecordatorio.Text = dtgRecordatorios.CurrentRow.Cells["IDRecordatorio"].Value.ToString();
                    f.txbTitulo.Text = dtgRecordatorios.CurrentRow.Cells["Titulo"].Value.ToString();
                    f.cbbPrioridad.Text = dtgRecordatorios.CurrentRow.Cells["Prioridad"].Value.ToString();
                    f.cbbEstado.Text = dtgRecordatorios.CurrentRow.Cells["EstadoActividad"].Value.ToString();
                    f.txbDescripcion.Text = dtgRecordatorios.CurrentRow.Cells["Descripcion"].Value.ToString();
                    f.dtpFecha.Text = dtgRecordatorios.CurrentRow.Cells["FechaPrevFin"].Value.ToString();
                    f.ShowDialog();
                    Cargar();
                }
            }
            catch
            {
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea eliminar el recordatorio seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Recordatorios ORecordatorio = new CLS.Recordatorios();

                    ORecordatorio.IDRecordatorio = dtgRecordatorios.CurrentRow.Cells["IDRecordatorio"].Value.ToString();
                    
                    if (ORecordatorio.Eliminar())
                    {
                        Cargar();
                    }

                }

            }
            catch
            {
            }
        }
    }
}
