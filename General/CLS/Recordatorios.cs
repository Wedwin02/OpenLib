using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Recordatorios
    {
        String _IDRecordatorio;
        String _FechaCreacion;
        String _FechaPrevFin;
        String _Titulo;
        String _Descripcion;
        String _Prioridad;
        String _EstadoActividad;

        public string IDRecordatorio { get => _IDRecordatorio; set => _IDRecordatorio = value; }
        public string FechaCreacion { get => _FechaCreacion; set => _FechaCreacion = value; }
        public string FechaPrevFin { get => _FechaPrevFin; set => _FechaPrevFin = value; }
        public string Titulo { get => _Titulo; set => _Titulo = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Prioridad { get => _Prioridad; set => _Prioridad = value; }
        public string EstadoActividad { get => _EstadoActividad; set => _EstadoActividad = value; }

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                Sentencia = "INSERT INTO recordatorio(FechaCreacion, FechaPrevFin, Titulo, Descripcion, Prioridad, EstadoActividad) VALUES(";
                Sentencia += "'" + _FechaCreacion + "',";
                Sentencia += "'" + _FechaPrevFin + "',";
                Sentencia += "'" + _Titulo + "',";
                Sentencia += "'" + _Descripcion + "',";
                Sentencia += "'" + _Prioridad + "',";
                Sentencia += "'" + _EstadoActividad + "');";
                if (Operacion.Insertar(Sentencia)> 0)
                {
                    Guardado = true;
                    MessageBox.Show("Registro insertado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Guardado = false;
                    MessageBox.Show("Registro no insertado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                Guardado = false;
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Guardado;
        }

        public Boolean Actualizar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                Sentencia = "UPDATE recordatorio SET ";
                Sentencia += "FechaCreacion='" + _FechaCreacion + "',";
                Sentencia += "FechaPrevFin='" + _FechaPrevFin + "',";
                Sentencia += "Titulo='" + _Titulo + "',";
                Sentencia += "Descripcion='" + _Descripcion + "',";
                Sentencia += "Prioridad='" + _Prioridad + "',";
                Sentencia += "EstadoActividad='" + _EstadoActividad + "' ";
                Sentencia += "WHERE IDRecordatorio=" + IDRecordatorio + ";";
                if (Operacion.Actualizar(Sentencia) > 0)
                {
                    Guardado = true;
                    MessageBox.Show("Registro actualizado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Guardado = false;
                    MessageBox.Show("Registro no actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                Guardado = false;
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Guardado;
        }

        public Boolean Eliminar()
        {
            Boolean Eliminar = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                
                Sentencia = "DELETE FROM recordatorio  ";
                Sentencia += "WHERE IDRecordatorio='" + IDRecordatorio + "';";
                if (Operacion.Eliminar(Sentencia) > 0)
                {

                    Eliminar = true;
                    MessageBox.Show("Registro eliminado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Eliminar = false;
                    MessageBox.Show("Registro no eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                Eliminar = false;
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Eliminar;
        }

        public Boolean Finalizar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                Sentencia = "update recordatorio set ";
                Sentencia += "EstadoActividad = 'Finalizada'";
                Sentencia += "WHERE IDRecordatorio='" + _IDRecordatorio + "';";
                if (Operacion.Actualizar(Sentencia) > 0)
                {
                    Guardado = true;
                    MessageBox.Show("Registro Finalizado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Guardado = false;
                    MessageBox.Show(" error no  pudo finalizar el recordatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                Guardado = false;
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Guardado;
        }
    }
}


