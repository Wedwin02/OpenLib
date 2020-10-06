using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Usuarios
    {

        String _IDUsuario;
        String _Usuario;
        String _Clave;
        String _IDRol;
        String _IDEmpleado;

        public string IDUsuario { get => _IDUsuario; set => _IDUsuario = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public string IDRol { get => _IDRol; set => _IDRol = value; }
        public string IDEmpleado { get => _IDEmpleado; set => _IDEmpleado = value; }

        public Boolean Guardar()
        {
            Boolean guardar = false;
            String sentencia;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                //insertar

                sentencia = "INSERT INTO usuarios( Usuario, Clave, IDRol, IDEmpleado) VALUES(";            
                sentencia += "'" + _Usuario + "',";
                sentencia += " md5(sha1('" + _Clave + "')) ,";
                sentencia += "'" + _IDRol + "',";       
                sentencia += "'" + _IDEmpleado + "');";

                if (_Operacion.Insertar(sentencia) > 0)
                {
                    guardar = true;
                }
                else
                {
                    guardar = false;

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

                if (_Clave.Length>0)
                {
                    //clave viene llena
                    sentencia = "UPDATE  usuarios SET ";
                    sentencia += "Usuario='" + _Usuario + "',";
                    sentencia += "Clave= md5(sha1('" + _Clave + "')),";
                    sentencia += "IDRol='" + _IDRol + "',";
                    sentencia += "IDEmpleado='" + _IDEmpleado + "'";
                    sentencia += "WHERE IDUsuario= '" + _IDUsuario + "';";                    

                }
                else {
                    //clave viene vacia
                    sentencia = "UPDATE  usuarios SET ";
                    sentencia += "Usuario='" + _Usuario + "',";
                    sentencia += "IDRol='" + _IDRol + "',";
                    sentencia += "IDEmpleado='" + _IDEmpleado + "'";
                    sentencia += "WHERE IDUsuario= '" + _IDUsuario + "';";
                }                    

                if (_Operacion.Insertar(sentencia) > 0)
                {
                    actualizar = true;
                    

                }
                else
                {
                    actualizar = false;
                   

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
            String sentencia;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                //eliminar
                sentencia = "UPDATE Usuarios SET ";
                sentencia += "estado_campo = false ";
                sentencia += "WHERE IDUsuario= '" + _IDUsuario + "';";

                if (_Operacion.Eliminar(sentencia) > 0)
                {
                    eliminar = true;
                    //MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    eliminar = false;
                   // MessageBox.Show("El Registro no fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch
            {
                eliminar = false;
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return eliminar;
        }


        public Boolean ActualizarPass()
        {
            Boolean actualizar = false;
            String sentencia;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                //actualizar

                    sentencia = "UPDATE  usuarios SET ";                    
                    sentencia += "Clave= md5(sha1('" + _Clave + "'))";
                    sentencia += "WHERE IDUsuario= '" + _IDUsuario + "';";

              
                if (_Operacion.Insertar(sentencia) > 0)
                {
                    actualizar = true;
                    MessageBox.Show("Contraseña ACTUALIZADA  correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    actualizar = false;
                    MessageBox.Show("Contraseña no fue ACTUALIZADA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
