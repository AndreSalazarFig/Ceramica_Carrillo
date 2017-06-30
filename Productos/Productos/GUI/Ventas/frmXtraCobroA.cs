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
using Productos.Model;

namespace Productos.GUI.Ventas
{
    public partial class frmXtraCobroA : DevExpress.XtraEditors.XtraForm
    {
        public static BDCarrilloEntities datos = null;
        List<Model.Productos> Compra;
        List<int> Cantidad;
        double total = 0;

        public frmXtraCobroA()
        {
            InitializeComponent();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            double cambio = total - Convert.ToInt32(txtMonto.Text);
            if (cambio < 0)
            {
                txtCambio.ForeColor = Color.Black;
                txtCambio.Text = (cambio * -1).ToString();
            }
            else
            {
                txtCambio.ForeColor = Color.Red;
                txtCambio.Text = (cambio * -1).ToString();
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            validarCobro();
        }

        private void validarCobro()
        {
            if (Convert.ToDouble(txtCambio.Text) >= 0)
            {
                if (XtraMessageBox.Show("Con este abono se completará el pago de los productos adquiridos.", "Abonando", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    realizarCompra();
                }
            }
            else
            {
                if (XtraMessageBox.Show("El abono ha sido realizado.", "Abonando", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    realizarCompra();
                }
            }
        }

        private void realizarCompra()
        {
            try
            {
                double totalVenta = 0;
                Folio folio = new Folio();
                folio.FechaVenta = DateTime.Now;
                folio.IdPersonal = 1; // Cambiar
                datos.Folio.Add(folio);
                datos.SaveChanges();
                int idFolio = Convert.ToInt32((from f in datos.Folio orderby f.IdFolio descending select f.IdFolio).ToList()[0]);
                DetalleFolio detalle;
                for (int i = 0; i < Compra.Count; i++)
                {
                    detalle = new DetalleFolio();
                    detalle.IdFolio = idFolio;
                    Model.Productos producto = datos.Productos.Find(Compra[i].IdProductos);
                    producto.Unidades -= Cantidad[i];
                    detalle.IdProductos = producto.IdProductos;
                    detalle.Precio = producto.PrecioVenta;
                    detalle.Unidades = Cantidad[i];
                    detalle.Total = Cantidad[i] * detalle.Precio;
                    totalVenta += detalle.Total;
                    datos.DetalleFolio.Add(detalle);
                    datos.SaveChanges();
                }
                folio = datos.Folio.Find(idFolio);
                folio.TotalVenta = totalVenta;
                datos.SaveChanges();
                Hide();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Error: " + e.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}