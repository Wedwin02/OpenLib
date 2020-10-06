using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.Empleados
{
    public partial class EmpleadosEdicion : Form
    {

        private void ordenarTexBox() {
            //ordenando para recibir tabulacion
            txbDui.TabIndex = 0;
            txbNombres.TabIndex = 1;
            txbApellidos.TabIndex = 2;
            cbGenero.TabIndex = 3;
            cbFecha.TabIndex = 4;
            txbTelefono.TabIndex = 5;
            txbDireccion.TabIndex = 6;
            txbUsuario.TabIndex = 7;
            txbPass.TabIndex = 8;
            cbRol.TabIndex = 9;
            btnGuardar.TabIndex = 10;
            btnCancelar.TabIndex = 11;



        }

        private void TamañoDeTextoDUI() {


            if (txbDui.TextLength > 10)
            {

                MessageBox.Show("El campo no puede tener mas de 10 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDui.Focus();

            }
            else if (txbDui.TextLength < 10)
            {
                MessageBox.Show("El campo no puede tener menos de 10 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDui.Focus();

            }
            
        }
        private void TamañoDeTextoTELEFONO()
        {

            if (txbTelefono.TextLength > 9)
            {

                MessageBox.Show("El campo no puede tener mas de 9 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbTelefono.Focus();

            }
            else if (txbTelefono.TextLength < 9)
            {
                MessageBox.Show("El campo no puede tener menos de 9 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbTelefono.Focus();

            }
        }





        private void cargarRoles()
        {
            DataTable _Roles = new DataTable();
            _Roles = CacheManager.CLS.Cache.Todos_Los_Roles();
            cbRol.DataSource = _Roles;
            cbRol.DisplayMember = "Rol";
            cbRol.ValueMember = "IDRol";
        }

        private Boolean Verificados() {
            Boolean verificado = true;
            Notificador.Clear();

            if (txbDui.TextLength == 0)
            {
                Notificador.SetError(txbDui, "Este campo no puede quedar vacio");
                verificado = false;
            }
            if (txbNombres.TextLength == 0)
            {
                Notificador.SetError(txbNombres, "Este campo no puede quedar vacio");
                verificado = false;
            }
            if (txbApellidos.TextLength == 0)
            {
                Notificador.SetError(txbApellidos, "Este campo no puede quedar vacio");
                verificado = false;
            }
            if (txbDireccion.TextLength == 0)
            {
                Notificador.SetError(txbDireccion, "Este campo no puede quedar vacio");
                verificado = false;
            }
            if (txbTelefono.TextLength == 0)
            {
                Notificador.SetError(txbTelefono, "Este campo no puede quedar vacio");
                verificado = false;
            }          

            return verificado;
        
        }

        private void ProcesarDatosEmpleados() {

            if (Verificados()) {

                try
                {
                    CLS.Empleados oEmpleados = new CLS.Empleados();

                    oEmpleados.DUI = txbDui.Text;
                    oEmpleados.Nombres = txbNombres.Text;
                    oEmpleados.Apellidos = txbApellidos.Text;
                    oEmpleados.Direccion = txbDireccion.Text;
                    oEmpleados.Telefono = txbTelefono.Text;
                    oEmpleados.Genero = cbGenero.Text;
                    oEmpleados.FechaNacimiento = cbFecha.Text;
                    //Son del Usuario
                    oEmpleados.IDUsuario = lblIDUsuario.Text;
                    oEmpleados.Usuario = txbUsuario.Text;
                    oEmpleados.Clave = txbPass.Text;
                    oEmpleados.IDRol = cbRol.SelectedValue.ToString();
                    


                    if (this.lblAuxiliar.Text.Equals("Insertar"))
                    {
                        oEmpleados.Guardar();
                    }
                    else if (this.lblAuxiliar.Text.Equals("Modificar"))
                    {
                        oEmpleados.Actualizar();
                    }
                    Close();                

                }
                catch 
                {

                   
                }
            
            }             
        
        
        }




        public EmpleadosEdicion()
        {
            InitializeComponent();
            cargarRoles();
            ordenarTexBox();           
            cbRol.SelectedIndex = 0;
            cbGenero.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProcesarDatosEmpleados();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        

       

        private void txbDui_Leave(object sender, EventArgs e)
        {
            TamañoDeTextoDUI();
        }

        private void txbTelefono_Leave(object sender, EventArgs e)
        {
            TamañoDeTextoTELEFONO();
        }

        private void ckDesenmascarar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDesenmascarar.Checked == true)
            {
                if (txbPass.PasswordChar == '*')
                {
                    txbPass.PasswordChar = '\0';
                }

            }
            else
            {
                txbPass.PasswordChar = '*';
            }
        }
    }
}
