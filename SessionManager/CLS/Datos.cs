using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SessionManager.CLS
{
    public class Datos
    {
        DataTable Permisos = new DataTable();
       

        String _IDUsuario;
        String _Usuario;
        String _IDRol;
        String _Rol;
        String _NombreCompleto;
        public String IDUsuario
        {
            get
            {
                return _IDUsuario;
            }
            set
            {
                _IDUsuario = value;
            }
        }
        public String Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        public String IDRol
        {
            get { return _IDRol; }
            set { _IDRol = value; ObtenerPermisos(); }
        }
        public String Rol
        {
            get { return _IDRol; }
            set { _IDRol = value; }
        }

        public String NombreCompleto
        {
            get { return _NombreCompleto; }
            set { _NombreCompleto = value; }
        }


        public void ObtenerPermisos() {

            try
            {
                Permisos = CacheManager.CLS.Cache.Permisos_De_un_Rol(_IDRol);

            }
            catch 
            {

                
            }         
        }

        public Boolean VerificarPermiso(Int32 pIDOpcion) {
            Boolean Autorizado = false;
            String IDOpcionLocal; 

            try
            {
                foreach (DataRow fila in Permisos.Rows)
                {
                    IDOpcionLocal = fila["IDOpcion"].ToString();
                    if (IDOpcionLocal.Equals(pIDOpcion.ToString())) {
                        Autorizado = true;
                        break;
                    }
                }
            }
            catch 
            {
                Autorizado = false;
            }
            if (Autorizado == false) {
                              

                MessageBox.Show("No cuenta con los permisos necesarios para ejecutar esta tarea.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return Autorizado;
        
        }
    }
}
