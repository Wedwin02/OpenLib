using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    //Atributos
    class Producto
    {
        String _IDProducto;
        String _Nombre;
        String _PrecioVenta;
        String _PrecioCompra;
        String _IDCategoria;
        String _Stock;
        String _Codigo;
        String _IdArchivo;

        //Propiedades
        public string IDProducto { get => _IDProducto; set => _IDProducto = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string PrecioVenta { get => _PrecioVenta; set => _PrecioVenta = value; }
        public string PrecioCompra { get => _PrecioCompra; set => _PrecioCompra = value; }
        public string IDCategoria { get => _IDCategoria; set => _IDCategoria = value; }
        public string Stock { get => _Stock; set => _Stock = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string IdArchivo { get => _IdArchivo; set => _IdArchivo = value; }



        //Metodos

        public Boolean Guardar()
        {
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                Sentencia = "INSERT INTO productos(Nombre, PrecioVenta, PrecioCompra, IDCategoria, Stock,Codigo,idArchivo) VALUES(";
                Sentencia += "'" + _Nombre + "',";
                Sentencia += _PrecioVenta + ",";
                Sentencia += _PrecioCompra + ",";
                Sentencia += _IDCategoria + ",";
                Sentencia +=  _Stock + ",";
                Sentencia += "'" + _Codigo + "',";
                Sentencia +=  _IdArchivo + ");";


                if (Operacion.Insertar(Sentencia) > 0)
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
                Sentencia = "UPDATE productos SET ";
                Sentencia += "Nombre='" + _Nombre + "',";
                Sentencia += "PrecioVenta=" + _PrecioVenta + ",";
                Sentencia += "PrecioCompra=" + _PrecioCompra + ",";
                Sentencia += "IDCategoria=" + _IDCategoria + ", ";
                Sentencia += "Stock=" + _Stock + ",";
                Sentencia += "Codigo='" + _Codigo + "' ";
                Sentencia += "WHERE IDProducto=" + IDProducto + ";";
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
            Boolean Guardado = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                Sentencia = "UPDATE productos SET estado_campo = FALSE ";
                Sentencia += "WHERE IDProducto = " + IDProducto + ";";
                if (Operacion.Actualizar(Sentencia) > 0)
                {
                    Guardado = true;
                    MessageBox.Show("Registro eliminado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Guardado = false;
                    MessageBox.Show("Registro no eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
