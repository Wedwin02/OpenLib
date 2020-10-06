using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Opciones
    {
        Int32 _IDOpcion;
        String _Opcion;
        Int32 _IDCategoria;

        public int IDOpcion { get => _IDOpcion; set => _IDOpcion = value; }
        public string Opcion { get => _Opcion; set => _Opcion = value; }
        public int IDCategoria { get => _IDCategoria; set => _IDCategoria = value; }

        public Boolean Guardar()
        {
            Boolean guardar = false;
            String sentencia;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();



            try
            {
                //insertar

                sentencia = "INSERT INTO opciones(Opcion,IDCategoria) VALUES(";
                sentencia += "'" + _Opcion + "',";
                sentencia += "'" + _IDCategoria + "');";

                if (_Operacion.Insertar(sentencia) > 0)
                {
                    guardar = true;
                    MessageBox.Show("La opcion fue insertado correctamente", "Confrimación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    guardar = false;
                    MessageBox.Show("La opcion no  fue insertado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch
            {
                guardar = false;
            }
            return guardar;
        }

        public Boolean Actualizar()
        {
            Boolean actualizar = false;
            String sentencia;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                //actualizar

                sentencia = "UPDATE  Opciones SET ";
                sentencia += "Opcion='" + _Opcion + "'";
                sentencia += "WHERE IDOpcion = '" + _IDOpcion + "';";

                if (_Operacion.Actualizar(sentencia) > 0)
                {
                    actualizar = true;
                    MessageBox.Show("La Opcion  fue  ACTUALIZADA correctamente", "Confrimación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    actualizar = false;
                    MessageBox.Show("La Opcion  no fue ACTUALIZADA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch
            {
                actualizar = false;
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return actualizar;
        }






    }
}
