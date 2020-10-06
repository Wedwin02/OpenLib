using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.ReestablecerContra
{
    public partial class ReestablecerContra : Form
    {

        private Boolean Verificados()
        {
            Boolean verificado = true;
            Notificador.Clear();
            
            if (txbNuevaPass.TextLength == 0)
            {
                Notificador.SetError(txbNuevaPass, "Este campo no puede quedar vacio");
                verificado = false;
            }
            return verificado;
        }
        private void TamañoDeTextoDUI()
        {


            if (txbDui.TextLength > 10)
            {

                MessageBox.Show("El campo no puede tener mas de 10 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDui.Focus();
                txbNuevaPass.Enabled = false;
                btnGuardar.Enabled = false;
                ckDesenmascarar.Enabled = false;
                txbIDUsuario.Clear();
                txbNuevaPass.Clear();

            }
            else if (txbDui.TextLength < 10)
            {
                MessageBox.Show("El campo no puede tener menos de 10 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDui.Focus();
                txbNuevaPass.Enabled = false;
                btnGuardar.Enabled = false;
                ckDesenmascarar.Enabled = false;
                txbIDUsuario.Clear();
                txbNuevaPass.Clear();

            }

        }

        private void EnviarDUI()
        {

            try
            {
                DataTable _pass = new DataTable();
                _pass = CacheManager.CLS.Cache.Consulta_Usuario_Segun_Dui(txbDui.Text);

                if (_pass.Rows.Count != 0)
                {

                    txbIDUsuario.Text = _pass.Rows[0]["IDUsuario"].ToString();

                    if (!txbIDUsuario.Equals(" "))
                    {
                        txbNuevaPass.Enabled = true;
                        btnGuardar.Enabled = true;
                        ckDesenmascarar.Enabled = true;
                        txbNuevaPass.Focus();
                    }

                }
                else
                {

                    MessageBox.Show("El DUI que acaba de ingresar es incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch
            {


            }

            
        }

        private void cambiarPass()
        {
            if (Verificados())
            {
                try
                {
                    CLS.Usuarios u = new CLS.Usuarios();
                    u.IDUsuario = txbIDUsuario.Text;
                    u.Clave = txbNuevaPass.Text;
                    u.ActualizarPass();
                    Close();

                }
                catch
                {


                }
            }
        }




        public ReestablecerContra()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            EnviarDUI();
            TamañoDeTextoDUI();
        }

        private void ReestablecerContra_Load(object sender, EventArgs e)
        {
            txbNuevaPass.Enabled = false;
            btnGuardar.Enabled = false;
            ckDesenmascarar.Enabled = false;
        }

        private void ckDesenmascarar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDesenmascarar.Checked == true)
            {
                if (txbNuevaPass.PasswordChar == '*')
                {
                    txbNuevaPass.PasswordChar = '\0';
                }

            }
            else
            {
                txbNuevaPass.PasswordChar = '*';
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cambiarPass();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
