using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class DetalleVenta
    {
        String _IdProducto;
        String _SubTotal;
        String _Precio;
        String _Cantidad;
        String _Nombre;
        String _IDVenta;
        String _Descuento;
        
        //
        public string IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public string SubTotal { get => _SubTotal; set => _SubTotal = value; }
        public string Precio { get => _Precio; set => _Precio = value; }
        public string Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string IDVenta { get => _IDVenta; set => _IDVenta = value; }
        public string Descuento { get => _Descuento; set => _Descuento = value; }

        public Boolean Guardar() {
            bool correcto = false;
            String sentencia;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();
            try
            {
                sentencia = "INSERT INTO detallesventas(IDProducto,Precio,Cantidad,Descuento,IDVenta) values(";
                sentencia += _IdProducto + ",";
                sentencia += _Precio + ",";
                sentencia += _Cantidad + ",";
                sentencia += _Descuento + ",";
                sentencia += _IDVenta + ");";
                if (_Operacion.Insertar(sentencia) > 0)
                {
                    sentencia = String.Format("UPDATE productos SET Stock = (Stock -{0}) WHERE IDProducto = {1}; ", _Cantidad, _IdProducto);
                    if (_Operacion.Actualizar(sentencia) > 0) {
                        correcto = true;
                    }
                    
                }
            }
            catch
            {
                correcto = false;
            }
            return correcto;
        }
    }
}
