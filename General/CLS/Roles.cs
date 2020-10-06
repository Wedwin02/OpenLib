using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.CLS
{
    class Roles
    {
        String _IDRol;
        String _Rol;
        String _Descripcion;
        //para Opciones

        Int32 _IDOpcion;
        String _Opcion;
        Int32 _IDCategoria;

        // para categeoria        
        String CategoriaOp;


        public string IDRol { get => _IDRol; set => _IDRol = value; }
        public string Rol { get => _Rol; set => _Rol = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        //opciones
        public int IDOpcion { get => _IDOpcion; set => _IDOpcion = value; }
        public string Opcion { get => _Opcion; set => _Opcion = value; }
        public int IDCategoria { get => _IDCategoria; set => _IDCategoria = value; }
        public string CategoriaOp1 { get => CategoriaOp; set => CategoriaOp = value; }

        public Boolean Guardar()
        {
            Boolean guardar = false;
            String sentencia;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                //insertar

                if (_Rol.Length>0)
                {
                    sentencia = "INSERT INTO roles(Rol,Descripcion) VALUES(";
                    sentencia += "'" + _Rol + "',";
                    sentencia += "'" + _Descripcion + "');";

                    if (_Operacion.Insertar(sentencia) > 0)
                    {
                        Opciones u = new Opciones();
                        if (_Opcion.Length>0)
                        {
                            u.IDOpcion = this.IDOpcion;
                            u.Opcion = this.Opcion;
                            u.IDCategoria = this.IDCategoria;
                        }

                        if (u.Guardar())
                        {
                            //Se inserto el empleado y el usuarios 
                            guardar = true;
                            MessageBox.Show("Registro insertado correctamente", "Confrimación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //Se inserto solo el rol
                            guardar = false;
                            MessageBox.Show("El Rol  fue insertado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }


                    }
                    else
                    {
                        //No se inserto el empelado por lo que no llego a insertar al usuario 
                        guardar = false;
                        //MessageBox.Show("El Registro no fue insertado completo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }

                else if (_Opcion.Length>0)
                {

                    Opciones u = new Opciones();                    
                        u.IDOpcion = this.IDOpcion;
                        u.Opcion = this.Opcion;
                        u.IDCategoria = this.IDCategoria;
                    

                    if (u.Guardar())
                    {
                        //Se inserto el empleado y el usuarios 
                        guardar = true;
                        MessageBox.Show("Opcion insertado correctamente", "Confrimación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //Se inserto solo el rol
                        guardar = false;
                        MessageBox.Show("Opcion  no fue insertado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }else 

                {
                    CategoriaOpciones o = new CategoriaOpciones();
                    o.IDCategoria = this.IDCategoria;
                    o.Categoria1 = this.CategoriaOp;
                    if (o.Guardar())
                    {
                        //Se inserto el empleado y el usuarios 
                        guardar = true;
                        MessageBox.Show("Registro insertado correctamente", "Confrimación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //Se inserto solo la categoria
                        MessageBox.Show("La categoria  ya existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



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
            Boolean guardar = false;
            String sentencia;
            DataManager.CLS.DBOperacion _Operacion = new DataManager.CLS.DBOperacion();

            try
            {
                //insertar

                if (_Rol.Length>0)
                {
                    sentencia = "UPDATE  roles SET ";
                    sentencia += "Rol='" + _Rol + "',";
                    sentencia += "Descripcion='" + _Descripcion + "'";
                    sentencia += "WHERE IDRol = '" + _IDRol + "';";

                    if (_Operacion.Actualizar(sentencia) > 0)
                    {
                        Opciones u = new Opciones();
                        if (_Opcion.Length>0)
                        {
                            u.IDOpcion = this.IDOpcion;
                            u.Opcion = this.Opcion;
                            u.IDCategoria = this.IDCategoria;
                        }

                        if (u.Actualizar())
                        {
                            // se inserto todo 
                            guardar = true;
                            MessageBox.Show("Registro ACTUALIZADO correctamente", "Confrimación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //Se inserto solo el rol
                            guardar = false;
                            MessageBox.Show("El Rol  fue ACTUALIZADO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }


                    }
                    else
                    {
                        //No se inserto el empelado por lo que no llego a insertar al usuario 
                        guardar = false;
                        //MessageBox.Show("El Registro no fue insertado completo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }

                else if (_Opcion.Length>0)
                {

                    Opciones u = new Opciones();
                    u.IDOpcion = this.IDOpcion;
                    u.Opcion = this.Opcion;
                    u.IDCategoria = this.IDCategoria;


                    if (u.Actualizar())
                    {
                        //Se inserto el empleado y el usuarios 
                        guardar = true;
                        //MessageBox.Show("Opcion ACTUALIZADA correctamente", "Confrimación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //Se inserto solo el rol
                        guardar = false;
                        // MessageBox.Show("Opcion fue ACTUALIZADA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }             


                

            }
            catch
            {
                guardar = false;
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return guardar;
        }




    }
}
