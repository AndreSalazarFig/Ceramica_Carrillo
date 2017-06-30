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

namespace Productos.GUI.Compras
{
    public partial class frmXtraCompras : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static Model.BDCarrilloEntities bdCarrillo = null;
        public static String strProducto;
        Model.ArchivosLocales oExtras = new Model.ArchivosLocales();
        Model.Compras oCompras;
        Boolean boolGuardar = false;

        public frmXtraCompras()
        {
            InitializeComponent();

            MostrarInfo();
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            GuardarCompra();
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmXtraCompras_FormClosing(object sender, FormClosingEventArgs e)
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

        private void GuardarCompra()
        {
            try
            {
                bdCarrillo.Compras.Add(RecuperarDatosCompra());
                bdCarrillo.SaveChanges();

                oExtras.Mensajes('B', "Éxito");

                boolGuardar = true;

                this.Close();
            }
            catch (Exception f)
            {
                oExtras.Mensajes('B', "Error");
            }
        }

        private Model.Compras RecuperarDatosCompra()
        {
            var DatosProducto = (from tbProducto in bdCarrillo.Productos
                                 where tbProducto.Descripcion == txtDescripcionProducto.Text.Trim()
                                 select tbProducto).ToList().FirstOrDefault();

            if (DatosProducto.IdProductos > 0)
            {
                oCompras = new Model.Compras()
                {
                    IdProductos = DatosProducto.IdProductos,
                    Unidades = Convert.ToInt32(txtUnidades.Text.Trim()),
                    Precio = Convert.ToDouble(txtPrecioCompra.Text.Trim()),
                    Total = Convert.ToDouble(txtTotal.Text.Trim()),
                    Fecha = DateTime.Now.Date
                };

                DatosProducto.Unidades += oCompras.Unidades;
            }
            else
            {
                throw new Exception();
            }

            return oCompras;
        }

        private void MostrarInfo()
        {
            txtDescripcionProducto.Text = strProducto;
        }
    }
}