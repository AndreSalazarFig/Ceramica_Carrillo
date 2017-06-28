using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos.Model;

namespace Productos.GUI.Inicio
{
    public partial class frmLogin : Form
    {

        BDCarrilloEntities bdCarrillo = new BDCarrilloEntities();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                var cantidad = (from u in bdCarrillo.Personal
                                where u.Usuario == /*txtUsuario.Text*/"administrador"
                                && u.Contrasena == /*txtContraseña.Text*/"p0nc14n0"
                                select u).Count();
                if (cantidad > 0)
                {
                    //Form1 frm = new Form1();
                    frmXtraPrincipal frm = new frmXtraPrincipal();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectos. Intente de nuevo");
                }
            }
            catch (Exception a) { MessageBox.Show("Error al realizar la operación. Esto se puede ocacionar por una falta de conexión a la red. \rCompruebe que esté conectado a la red."); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
