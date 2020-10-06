using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Archivos
    {
        String _Id;
        String _Datos;
        String _Size;
        String _Extension;
        String _Nombre;
        String _MimeType;

        public string Id { get => _Id; set => _Id = value; }
        public string Size { get => _Size; set => _Size = value; }
        public string Extension { get => _Extension; set => _Extension = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string MimeType { get => _MimeType; set => _MimeType = value; }
        public string Datos { get => _Datos; set => _Datos = value; }


        public int Guardar()
        {
            DataTable Resultado = new DataTable();
            int id = 0;
            String sentencia;
            String consulta;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                sentencia = "INSERT INTO archivos(datos,size,extension,nombre,mimeType) VALUES(";
                sentencia += "'" + _Datos + "',";
                sentencia += _Size + ",";
                sentencia += "'" + _Extension + "',";
                sentencia += "'" + _Nombre+ "',";
                sentencia += "'" + _MimeType + "');";
                if (_Operacion.Insertar(sentencia) > 0) {
                    consulta = "SELECT LAST_INSERT_ID() as id_v;";
                    Resultado = _Operacion.Consultar(consulta);
                    if (Resultado.Rows.Count == 1)
                    {
                        id = Convert.ToInt32(Resultado.Rows[0]["id_v"]);
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar la imagen", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al registrar la imagen", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return id;
        }

        public int Actualizar()
        {
            int actualizar = 0;
            String sentencia;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                sentencia = "UPDATE  Archivos SET ";
                sentencia += "datos='" + _Datos + "',";
                sentencia += "size=" + _Size + ",";
                sentencia += "extension='" + _Extension + "',";
                sentencia += "nombre='" + _Nombre + "',";
                sentencia += "mimeType='" + _MimeType + "'";
                sentencia += " WHERE id = " + _Id + ";";
                if (_Operacion.Actualizar(sentencia) > 0)
                {
                    actualizar = Convert.ToInt32(_Id);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la Imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("No se pudo registrar la Imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return actualizar;
        }

    }


}
