using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Venta
    {
        private int _IdVenta;
        private String _FechaEmision;
        private String _Cliente;
        private String _TotalVenta;
        private String _TotalDescuento;
        private String _IDVendedor;
        private String _SubTotal;

        public int IdVenta { get => _IdVenta; set => _IdVenta = value; }
        public string FechaEmision { get => _FechaEmision; set => _FechaEmision = value; }
        public string Cliente { get => _Cliente; set => _Cliente = value; }
        public string TotalVenta { get => _TotalVenta; set => _TotalVenta = value; }
        public string TotalDescuento { get => _TotalDescuento; set => _TotalDescuento = value; }
        public string IDVendedor { get => _IDVendedor; set => _IDVendedor = value; }
        public string SubTotal { get => _SubTotal; set => _SubTotal = value; }

        public int Guardar()
        {
            DataTable Resultado = new DataTable();
            String consulta;
            String sentencia;
            int id = 0;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                sentencia = "INSERT INTO ventas(FechaEmision,Cliente,TotalVenta,SubTotal,TotalDescuento,IDVendedor) values (";
                sentencia += "'"+ _FechaEmision + "',";
                sentencia += "'" + _Cliente + "',";
                sentencia += _TotalVenta + ",";
                sentencia += _SubTotal + ",";
                sentencia += _TotalDescuento + ",";
                sentencia += _IDVendedor + ");";

                if (_Operacion.Insertar(sentencia) > 0)
                {
                    consulta = "SELECT LAST_INSERT_ID() as id_v;";
                    Resultado = _Operacion.Consultar(consulta);
                    if(Resultado.Rows.Count == 1)
                    {
                        id = Convert.ToInt32(Resultado.Rows[0]["id_v"]);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id = 0;
            }
            //Guarda luego consulta 

            return id;
        }
    }
}
