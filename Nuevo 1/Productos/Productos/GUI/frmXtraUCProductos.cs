using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Productos.GUI
{
    public partial class frmXtraUCProductos : DevExpress.XtraEditors.XtraUserControl
    {
        Model.BDCarrilloEntities bdcarrillo = new Model.BDCarrilloEntities();
        Model.Productos oProducto;

        public frmXtraUCProductos()
        {
            InitializeComponent();

            CargarInfo();
        }

        #region Métodos para el CRUD de Categorias

        private void GuardarProducto()
        {
            try
            {
                bdcarrillo.Productos.Add(RecuperarDatosProducto());
                bdcarrillo.SaveChanges();
                limpiarControlesProductos();
                VistaProductos();
                OnOffBotones('F');
            }
            catch (Exception a) { MessageBox.Show("Error al realizar la operación. Esto se puede ocacionar por una falta de conexión a la red. \rCompruebe que esté conectado a la red."); }
        }

        private void EditarProducto()
        {
            try
            {
                var edicion = bdcarrillo.Productos.Find(Convert.ToInt32(txtIDProducto.Text));

                if (edicion != null)
                {
                    var producto = RecuperarDatosProducto();
                    edicion.Descripcion = producto.Descripcion;
                    edicion.PrecioVenta = producto.PrecioVenta;
                    edicion.PrecioMayoreo = producto.PrecioMayoreo;
                    edicion.idCategoria = producto.idCategoria;

                    bdcarrillo.SaveChanges();
                    limpiarControlesProductos();
                    VistaProductos();
                    OnOffBotones('F');
                }
            }
            catch (Exception a) { MessageBox.Show("Error al realizar la operación. Esto se puede ocacionar por una falta de conexión a la red. \rCompruebe que esté conectado a la red."); }
        }

        private void EliminarProducto()
        {
            try
            {
                var eliminar = bdcarrillo.Productos.Find(Convert.ToInt32(txtIDProducto.Text));
                bdcarrillo.Productos.Remove(eliminar);
                bdcarrillo.SaveChanges();
                limpiarControlesProductos();
                VistaProductos();
                OnOffBotones('F');
            }
            catch (Exception a) { MessageBox.Show("Error al realizar la operación. Esto se puede ocacionar por una falta de conexión a la red. \rCompruebe que esté conectado a la red."); }
        }

        private Model.Productos RecuperarDatosProducto()
        {
            var IDCategoria = (from tbCategoria in bdcarrillo.Categorias
                          where tbCategoria.NombreCategoria == cbxCategoria.SelectedItem.ToString().Trim()
                          select tbCategoria).ToList().FirstOrDefault();

            oProducto = new Model.Productos()
            {
                Descripcion = txtDescripcion.Text.Trim(),
                PrecioVenta = Double.Parse(txtPrecioVenta.Text.Trim()),
                PrecioMayoreo = Double.Parse(txtPrecioMayoreo.Text.Trim()),
                idCategoria = IDCategoria.idCategoria
            };

            if (txtIDProducto.Text != "")
            {
                oProducto.idCategoria = Convert.ToInt32(txtIDProducto.Text);
            }

            return oProducto;
        }

        private void limpiarControlesProductos()
        {
            txtIDProducto.Text = "";
            txtDescripcion.Text = "";
            txtPrecioVenta.Text = "";
            txtPrecioMayoreo.Text = "";
            cbxCategoria.SelectedIndex = 0;
        }

        private void dtgVistaProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posicion = e.RowIndex;

            if (posicion >= 0)
            {
                txtIDProducto.Text = dtgVistaProductos.Rows[posicion].Cells[0].Value.ToString().Trim();
                txtDescripcion.Text = dtgVistaProductos.Rows[posicion].Cells[1].Value.ToString().Trim();
                txtPrecioVenta.Text = dtgVistaProductos.Rows[posicion].Cells[2].Value.ToString().Trim();
                txtPrecioMayoreo.Text = dtgVistaProductos.Rows[posicion].Cells[3].Value.ToString().Trim(); ;
                cbxCategoria.SelectedItem = dtgVistaProductos.Rows[posicion].Cells[5].Value.ToString().Trim();

                OnOffBotones('T');
            }
        }

        private void VistaProductos()
        {
            dtgVistaProductos.DataSource = (from tbtbProductos in bdcarrillo.Productos
                                             join tbCategorias in bdcarrillo.Categorias on tbtbProductos.idCategoria equals tbCategorias.idCategoria
                                             select new
                                             {
                                                 tbtbProductos.IdProductos,
                                                 tbtbProductos.Descripcion,
                                                 tbtbProductos.PrecioVenta,
                                                 tbtbProductos.PrecioMayoreo,
                                                 tbtbProductos.Unidades,
                                                 tbCategorias.NombreCategoria
                                             }).ToList();
        }

        private void llenarComboCategorias()
        {
            cbxCategoria.Properties.Items.Clear();

            cbxCategoria.Properties.Items.Add("Seleccionar");

            foreach (var Tipo in bdcarrillo.Categorias)
            {
                cbxCategoria.Properties.Items.Add(Tipo.NombreCategoria);
            }
        }

        #endregion
        
        #region Otros métodos y eventos

        private void OnOffBotones(Char OnOff)
        {
            switch (OnOff)
            {
                case 'T':
                    windowsUIButtonPanelMain.Buttons[1].Properties.Enabled = false;
                    windowsUIButtonPanelMain.Buttons[2].Properties.Enabled = true;
                    windowsUIButtonPanelMain.Buttons[3].Properties.Enabled = true;
                    break;
                case 'F':
                    windowsUIButtonPanelMain.Buttons[1].Properties.Enabled = true;
                    windowsUIButtonPanelMain.Buttons[2].Properties.Enabled = false;
                    windowsUIButtonPanelMain.Buttons[3].Properties.Enabled = false;
                    break;
            }
        }

        private void CargarInfo()
        {
            dtgVistaProductos.AutoGenerateColumns = false;

            limpiarControlesProductos();
            VistaProductos();
            llenarComboCategorias();
            OnOffBotones('F');
        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption)
            {
                case "Nuevo":
                    limpiarControlesProductos();
                    OnOffBotones('F');
                    break;
                case "Guardar":
                    GuardarProducto();
                    break;
                case "Editar":
                    EditarProducto();
                    break;
                case "Eliminar":
                    EliminarProducto();
                    break;
            }
            }
        #endregion
        }
}