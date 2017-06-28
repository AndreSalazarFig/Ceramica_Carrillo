using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Productos.GUI.TiposCategorias
{
    public partial class frmXtraEdicionTipos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Model.BDCarrilloEntities bdcarrillo = new Model.BDCarrilloEntities();
        Model.TipoProductos oTiposProducto;
        Model.ArchivosLocales oExtras = new Model.ArchivosLocales();
        public static String frmTitulo;
        public static Char Accion;

        public frmXtraEdicionTipos()
        {
            InitializeComponent();

            this.Text = frmTitulo;
        }

        private void btnGuardarTipo_Click(object sender, EventArgs e)
        {
            switch (Accion)
            {
                case 'N':
                    GuardarTipo();
                    break;
                case 'U':

                    break;
            }

            this.Close();
        }

        private void btnCancelarTipo_Click(object sender, EventArgs e)
        {
            if (oExtras.Mensajes('C', "") == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void GuardarTipo()
        {
            try
            {
                bdcarrillo.TipoProductos.Add(RecuperarDatosTipo());
                bdcarrillo.SaveChanges();

                oExtras.Mensajes('S', "Éxito");

                limpiarControlesTipos();
            }
            catch (Exception f)
            {
                oExtras.Mensajes('S', "Error");
            }
        }

        private Model.TipoProductos RecuperarDatosTipo()
        {
            oTiposProducto = new Model.TipoProductos()
            {
                NombreTipo = txtNombreTipo.Text.Trim()
            };

            if (txtIDTipo.Text != "")
            {
                oTiposProducto.idTipoProducto = Convert.ToInt32(txtIDTipo.Text);
            }

            return oTiposProducto;
        }

        private void limpiarControlesTipos()
        {
            txtIDTipo.Text = "";
            txtNombreTipo.Text = "";
        }
    }
}