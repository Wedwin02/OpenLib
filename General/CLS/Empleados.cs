using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Empleados
    {
        String _DUI;
        String _Nombres;
        String _Apellidos;
        String _Direccion;
        String _Telefono;
        String _Genero;
        String _FechaNacimiento;
        //Estos son de la tabla usuarios 
        String _IDUsuario;
        String _Usuario;
        String _Clave;
        String _IDRol;

        public string DUI { get => _DUI; set => _DUI = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Genero { get => _Genero; set => _Genero = value; }
        public string FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        //Estos son de la tabla usuarios 
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public string IDRol { get => _IDRol; set => _IDRol = value; }
        public string IDUsuario { get => _IDUsuario; set => _IDUsuario = value; }



        //Metodos

        public Boolean Guardar() {
            Boolean guardar = false;
            String sentencia;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                //insertar

                sentencia = "INSERT INTO empleados(DUI, Nombres, Apellidos, Direccion, Telefono, Genero, FechaNacimiento) VALUES(";
                sentencia += "'" + _DUI + "',";
                sentencia += "'" + _Nombres + "',";
                sentencia += "'" + _Apellidos + "',";              
                sentencia += "'" + _Direccion + "',";
                sentencia += "'" + _Telefono + "',";
                sentencia += "'" + _Genero + "',";
                sentencia += "'" + _FechaNacimiento + "');";

                if (_Operacion.Insertar(sentencia) > 0)
                {
                    Usuarios u = new Usuarios();
                    u.Usuario = this.Usuario;
                    u.Clave = this.Clave;
                    u.IDRol = this.IDRol;
                    u.IDEmpleado = this.DUI;
                    
                    if (u.Guardar())
                    {
                        //Se inserto el empleado y el usuarios 
                        guardar = true;
                        MessageBox.Show("Registro insertado correctamente", "Confrimación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //Se inserto el empleado pero el usuario no 
                        MessageBox.Show("El Registro no fue insertado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                else
                {
                    //No se inserto el empelado por lo que no llego a insertar al usuario 
                    guardar = false;
                    MessageBox.Show("El Registro no fue insertado completo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch 
            {
                guardar = false;
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                sentencia = "UPDATE  empleados SET ";                
                sentencia += "Nombres='" + _Nombres + "',";
                sentencia += "Apellidos='" + _Apellidos + "',";                               
                sentencia += "Direccion='" + _Direccion + "',";
                sentencia += "Telefono='" + _Telefono + "',";
                sentencia += "Genero='" + _Genero + "',";
                sentencia += "FechaNacimiento='" + _FechaNacimiento + "' ";
                sentencia += "WHERE DUI = '" + _DUI + "';";

                if (_Operacion.Actualizar(sentencia) > 0)
                {
                    Usuarios u = new Usuarios();
                    u.Usuario = this.Usuario;
                    u.Clave = this.Clave;
                    u.IDRol = this.IDRol;
                    u.IDEmpleado = this.DUI;
                    u.IDUsuario = this.IDUsuario;
                    if (u.Actualizar())
                    {
                        //Se inserto el empleado y el usuarios 
                        actualizar = true;
                        MessageBox.Show("Registro actualizado correctamente", "Confrimación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //Se inserto el empleado pero el usuario no 
                        MessageBox.Show("El Registro no fue actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                else
                {
                    //No se inserto el empelado por lo que no llego a insertar al usuario 
                    actualizar = false;
                    MessageBox.Show("El Registro no fue actualizado completo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                sentencia = "UPDATE empleados SET ";
                sentencia += "estado_campo = false ";
                sentencia += "WHERE DUI='" + _DUI + "';";

                if (_Operacion.Eliminar(sentencia) > 0)
                {
                    
                    Usuarios u = new Usuarios();
                    u.IDUsuario = IDUsuario;
                    u.Eliminar();
                    eliminar = true;
                    MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
                else
                {
                    eliminar = false;
                    MessageBox.Show("El Registro no fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
