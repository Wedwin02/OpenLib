using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Proveedores
    {
        String _IDProveedore;
        String _NombreProveedor;
        String _CorreoElectronico;
        String _Telefono;
        String _Direccion;

        public string IDProveedore { get => _IDProveedore; set => _IDProveedore = value; }
        public string NombreProveedor { get => _NombreProveedor; set => _NombreProveedor = value; }
        public string CorreoElectronico { get => _CorreoElectronico; set => _CorreoElectronico = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }

    

    //Metodos

    public Boolean Guardar()
    {
        Boolean Guardado = false;
        String Sentencia;
        DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();

        try
        {
            Sentencia = "INSERT INTO proveedores(NombreProveedor, CorreoElectronico, Telefono, Direccion) VALUES(";
            Sentencia += "'" + _NombreProveedor + "',";
            Sentencia += "'" + _CorreoElectronico + "',";
            Sentencia += "'" +  _Telefono + "',";
            Sentencia += "'" + _Direccion + "');";


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
            Boolean actualizar = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                Sentencia = "UPDATE proveedores SET ";
                Sentencia += "NombreProveedor='" + _NombreProveedor + "',";
                Sentencia += "CorreoElectronico='" + _CorreoElectronico + "',";
                Sentencia += "Telefono='" + _Telefono + "',";
                Sentencia += "Direccion='" + _Direccion + "'";
                Sentencia += "WHERE IDProveedore = " + _IDProveedore + ";";
                if (Operacion.Actualizar(Sentencia) > 0)
                {
                    actualizar = true;
                    MessageBox.Show("Registro actualizado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {   
                    actualizar = false;
                    MessageBox.Show("Registro no actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                actualizar = false;
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return actualizar;
        }

        public Boolean Eliminar()
        {
            Boolean eliminar = false;
            String Sentencia;
            DataManager.CLS.DBOperacion Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                Sentencia = "UPDATE proveedores SET ";
                Sentencia += "estado_campo=false ";
                Sentencia += "WHERE IDProveedore =" + _IDProveedore + ";";
                if (Operacion.Actualizar(Sentencia) > 0)
                {
                    eliminar = true;
                    MessageBox.Show("Registro eliminado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    eliminar = false;
                    MessageBox.Show("Registro no eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
