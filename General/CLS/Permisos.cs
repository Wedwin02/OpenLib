using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Permisos
    {

        String _IDPermiso;
        String _IDRol;
        String _IDOpcion;

        public string IDPermiso { get => _IDPermiso; set => _IDPermiso = value; }
        public string IDRol { get => _IDRol; set => _IDRol = value; }
        public string IDOpcion { get => _IDOpcion; set => _IDOpcion = value; }


        public Boolean Conceder()
        {
            Boolean guardar = false;
            String sentencia;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                //insertar

                sentencia = "INSERT INTO permisos (IDOpcion,IDRol) VALUES(";
                sentencia += "'" + _IDOpcion + "',";
                sentencia += "'" + _IDRol + "');";

                if (_Operacion.Insertar(sentencia) > 0)
                {
                    guardar = true;
                    MessageBox.Show("Registro insertado correctamente", "Confrimación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    guardar = false;
                    MessageBox.Show("El Registro no fue insertado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch
            {
                guardar = false;
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return guardar;
        }

        public Boolean Revocar()
        {
            Boolean eliminar = false;
            String sentencia;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                //eliminar
                sentencia = "DELETE FROM  permisos ";
                sentencia += "WHERE IDPermiso='" + _IDPermiso + "';";

                if (_Operacion.Eliminar(sentencia) > 0)
                {
                    eliminar = true;
                    MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    eliminar = false;
                    MessageBox.Show("El Registro no fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch
            {
                eliminar = false;
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return eliminar;
        }





    }
}
