using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    public class Pedido
    {
        String _IdPedido;
        String _IdProveedor;
        String _FechaEmision;
        String _FechaEstimada;
        String _Estado;
        String _NumProductSolicitados;

        public string IdPedido { get => _IdPedido; set => _IdPedido = value; }
        public string IdProveedor { get => _IdProveedor; set => _IdProveedor = value; }
        public string FechaEmision { get => _FechaEmision; set => _FechaEmision = value; }
        public string FechaEstimada { get => _FechaEstimada; set => _FechaEstimada = value; }
        public string NumProductSolicitados { get => _NumProductSolicitados; set => _NumProductSolicitados = value; }
        public string Estado { get => _Estado; set => _Estado = value; }

        public Boolean Guardar()
        {
            Boolean estado = false;
            String sentencia = "";
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                //insertar 
                sentencia += "insert into pedidos(FechaEmision,FechaEntrega,Estado,IDProveedor,NumProductos) values(";
                sentencia += "'" + _FechaEmision + "',";
                sentencia += "'" + _FechaEstimada + "',";
                sentencia += "'" + _Estado + "',";
                sentencia +=  _IdProveedor + ",";
                sentencia += _NumProductSolicitados;
                sentencia += ");";

                if (_Operacion.Insertar(sentencia) > 0)
                {
                    estado = true;
                    MessageBox.Show("Registro insertado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Registro no insertado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Registro no insertado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return estado;
        }

        public Pedido Insertar() {
            Pedido p = null;
            DataTable Resultado = new DataTable();

            String sentencia = "";
            String consulta = "";
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();

            try
            { 
                sentencia += "insert into pedidos(FechaEmision,FechaEntrega,Estado,IDProveedor,NumProductos) values(";
                sentencia += "'" + _FechaEmision + "',";
                sentencia += "'" + _FechaEstimada + "',";
                sentencia += "'" + _Estado + "',";
                sentencia += _IdProveedor + ",";
                sentencia += _NumProductSolicitados;
                sentencia += ");";

                if (_Operacion.Insertar(sentencia) > 0)
                {
                    consulta = "SELECT LAST_INSERT_ID() as id_v;";
                    Resultado = _Operacion.Consultar(consulta);
                    if (Resultado.Rows.Count == 1)
                    {
                        p = new Pedido();
                        p.IdPedido = Resultado.Rows[0]["id_v"].ToString();
                        p.FechaEmision = _FechaEmision;
                        p.FechaEstimada = _FechaEstimada;
                        p.Estado = _Estado;
                        p.IdProveedor = _IdProveedor;
                        p.NumProductSolicitados = _NumProductSolicitados;
                    }
                }

            }
            catch
            {
                p = null;
            }

            return p;
        }

        public Boolean Actualizar()
        {
            Boolean estado = false;

            return estado;
        }

        public Boolean Eliminar()
        {
            Boolean estado = false;

            return estado;
        }


    }
}
