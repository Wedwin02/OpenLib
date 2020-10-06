using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Categorias
    {

        String _IDCategoria;
        String _Categoria;

        public string IDCategoria { get => _IDCategoria; set => _IDCategoria = value; }
        public string Categoria { get => _Categoria; set => _Categoria = value; }


        public Boolean Guardar()
        {

            Boolean Guardar = false;
            String sentencia;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                sentencia = "INSERT INTO Categorias(Categoria) VALUES(";              
                sentencia += "'" + _Categoria + "');";

                if (_Operacion.Insertar(sentencia) > 0)
                {
                    Guardar = true;
                    MessageBox.Show("Registro insertado correctamente", "Confrimación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Guardar = false;
                    MessageBox.Show("El Registro no fue insertado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
            catch
            {
                Guardar = false;
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Guardar;
        }
        public Boolean Actualizar()
        {

            Boolean Actualizar = false;
            String sentencia;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                sentencia = "UPDATE  Categorias SET ";
                sentencia += "categoria='" + _Categoria + "'";              
                sentencia += "WHERE IDCategoria = '" + _IDCategoria + "';";

                if (_Operacion.Actualizar(sentencia) > 0)
                {
                    Actualizar = true;
                    MessageBox.Show("Registro actualizado correctamente", "Confrimación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Actualizar = false;
                    MessageBox.Show("El Registro no fue Acualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
            catch
            {
                Actualizar = false;
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Actualizar;
        }
        public Boolean Eliminar()
        {

            Boolean Eliminar = false;
            String sentencia;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                sentencia = "UPDATE Categorias SET ";
                sentencia += "estado_campo = false ";
                sentencia += "WHERE IDCategoria= '" + _IDCategoria + "';";

                if (_Operacion.Eliminar(sentencia) > 0)
                {
                    Eliminar = true;
                    MessageBox.Show("Registro eliminado correctamente", "Confrimación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Eliminar = false;
                    MessageBox.Show("El Registro no fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
            catch
            {
                Eliminar = false;
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Eliminar;
        }






    }
}
