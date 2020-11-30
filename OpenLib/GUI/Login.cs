using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SessionManager.CLS;

namespace OpenLib.GUI
{
    public partial class Login : Form
    {

        Boolean _Autorizado = false;
        Sesion _SESION = Sesion.Instancia;

        private void Validar()
        {
            try
            {
                String query = @"SELECT u.IDUsuario,u.Usuario,u.Clave, u.IDRol, r.Rol,
                                concat(e.Nombres,' ',e.Apellidos) as 'Empleado',
                                u.IDEmpleado from usuarios u, roles r, empleados e where
                                u.estado_campo = true and
                                u.Usuario = '"+txbUsuario.Text+@"' and
                                u.Clave = md5(sha1('"+txbClave.Text+@"')) and
                                u.IDRol = r.IDRol and 
                                u.IDEmpleado = e.DUI;";
                DataTable Datos = new DataTable();
                DataManager.CLS.DBOperacion Consultor = new DataManager.CLS.DBOperacion();
                Datos = Consultor.Consultar(query);

                if (Datos.Rows.Count == 1)
                {
                    _SESION.Informacion.IDUsuario = Datos.Rows[0]["IDUsuario"].ToString();
                    _SESION.Informacion.Usuario = Datos.Rows[0]["Usuario"].ToString();
                    _SESION.Informacion.IDRol = Datos.Rows[0]["IDRol"].ToString();
                    _SESION.Informacion.Rol = Datos.Rows[0]["Rol"].ToString();
                    _SESION.Informacion.NombreCompleto = Datos.Rows[0]["Empleado"].ToString();

                    _Autorizado = true;
                    this.Close();
                }
                else
                {
                    lblMensaje.Text = "Usuario o contraseña erronea";
                }
            }
            catch
            {
                lblMensaje.Text = "Usuario o contraseña erronea";
            }
        }
        public Login()
        {
            InitializeComponent();
        }
        public Boolean Autorizado
        {
            get { return _Autorizado; }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Validar();
        }


        private void txbUsuario_Enter_1(object sender, EventArgs e)
        {
            if (this.txbUsuario.Text == "USUARIO")
            {
                this.txbUsuario.Text = "";
            }
        }

        private void txbUsuario_Leave_1(object sender, EventArgs e)
        {
            if (this.txbUsuario.Text == "")
            {
                this.txbUsuario.Text = "USUARIO";
            }
        }

        private void txbClave_Enter(object sender, EventArgs e)
        {
            if (this.txbClave.Text == "CLAVE")
            {
                this.txbClave.Text = "";
            }
        }

        private void txbClave_Leave(object sender, EventArgs e)
        {
            if (this.txbClave.Text == "")
            {
                this.txbClave.Text = "CLAVE";
            }
        }

        private void ckDesenmascarar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDesenmascarar.Checked == true)
            {
                if (txbClave.PasswordChar == '*')
                {
                    txbClave.PasswordChar = '\0';
                }

            }
            else
            {
                txbClave.PasswordChar = '*';
            }

        }

        private void ReestablecerContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                General.GUI.ReestablecerContra.ReestablecerContra f = new General.GUI.ReestablecerContra.ReestablecerContra();
                f.ShowDialog();
            }
            catch 
            {

               
            }
        }
    }
}
