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
    public partial class frmXtraEdicionTipos : DevExpress.XtraEditors.XtraForm
    {
        public static Model.BDCarrilloEntities bdCarrillo = null;
        public static String strFormTitulo;
        public static Char chAccion;
        public static List<String> lstDatosTipo = null;
        public static Boolean boolAdministrador;
        Boolean boolGuardar = false;
        Model.TipoProductos oTiposProducto;
        Model.ArchivosLocales oExtras = new Model.ArchivosLocales();

        public frmXtraEdicionTipos()
        {
            InitializeComponent();

            MostrarInfo();
        }

        private void btnGuardarTipo_Click(object sender, EventArgs e)
        {
            switch (chAccion)
            {
                case 'N':
                    GuardarTipo();
                    break;
                case 'U':
                    EditarTipo();
                    break;
            }
        }

        private void btnCancelarTipo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmXtraEdicionTipos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (boolGuardar == false)
            {
                if (oExtras.Mensajes('C', "") == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                boolGuardar = false;
            }
        }

        private void GuardarTipo()
        {
            try
            {
                bdCarrillo.TipoProductos.Add(RecuperarDatosTipo());
                bdCarrillo.SaveChanges();

                oExtras.Mensajes('S', "Éxito");

                boolGuardar = true;

                this.Close();
            }
            catch (Exception f)
            {
                oExtras.Mensajes('S', "Error");
            }
        }

        private void EditarTipo()
        {
            try
            {
                var edicion = bdCarrillo.TipoProductos.Find(Convert.ToInt32(txtIDTipo.Text));

                if (edicion != null)
                {
                    var tipoProducto = RecuperarDatosTipo();
                    edicion.NombreTipo = tipoProducto.NombreTipo;
                    bdCarrillo.SaveChanges();

                    oExtras.Mensajes('U', "Éxito");

                    boolGuardar = true;

                    this.Close();
                }
            }
            catch (Exception f)
            {
                oExtras.Mensajes('U', "Error");
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

        private void MostrarInfo()
        {
            this.Text = strFormTitulo;

            if (lstDatosTipo != null)
            {
                txtIDTipo.Text = lstDatosTipo[0];
                txtNombreTipo.Text = lstDatosTipo[1];
            }
        }
    }
}