using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class DetallePedido
    {
        String _idDetalle;
        String _cantidad;
        String _idPedido;
        String _idProducto;

        public string IdDetalle { get => _idDetalle; set => _idDetalle = value; }
        public string Cantidad { get => _cantidad; set => _cantidad = value; }
        public string IdPedido { get => _idPedido; set => _idPedido = value; }
        public string IdProducto { get => _idProducto; set => _idProducto = value; }

        public Boolean Guardar()
        {
            Boolean estado = false;
            String Sentencia = "";
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                Sentencia += "insert into detallespedidos(Cantidad,IDPedido,IDProducto) values(";
                Sentencia += _cantidad + ",";
                Sentencia += _idPedido + ",";
                Sentencia += _idProducto;
                Sentencia += ");";

                if(Operacion.Insertar(Sentencia) > 0 )
                {
                    estado = true;
                }
            }
            catch
            {
                estado = false;
            }
            return estado;
        }

        public Boolean Actualizar()
        {
            Boolean estado = false;
            String Sentencia = "";
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                Sentencia += "UPDATE detallespedidos SET ";
                Sentencia += "Cantidad=" + _cantidad;
                Sentencia += " WHERE idDetalle=" + _idDetalle + ";";

                if(Operacion.Actualizar(Sentencia) > 0)
                {
                    estado = true;
                }
            }
            catch
            {
                estado = false;
            }
            return estado;
        }

        public Boolean Eliminar()
        {
            Boolean estado = false;
            String Sentencia = "";
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                Sentencia = "delete from detallespedidos ";
                Sentencia += "where idDetalle = " + _idDetalle;
                if (Operacion.Eliminar(Sentencia) > 0)
                {
                    estado = true;
                }
            }
            catch
            {
                estado = false;
            }
            return estado;
        }
    }
}
