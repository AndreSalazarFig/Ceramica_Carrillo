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

namespace Productos.GUI.Productos
{
    public partial class frmXtraUCProductos : DevExpress.XtraEditors.XtraUserControl
    {
        Model.BDCarrilloEntities bdcarrillo = new Model.BDCarrilloEntities();
        //Model.Productos oProducto;

        public frmXtraUCProductos()
        {
            InitializeComponent();

            //CargarInfo();
            VistaProductos();
        }

        //#region Métodos para el CRUD de Productos

        //private void GuardarProducto()
        //{
        //    try
        //    {
        //        bdcarrillo.Productos.Add(RecuperarDatosProducto());
        //        bdcarrillo.SaveChanges();
        //        limpiarControlesProductos();
        //        VistaProductos();
        //        OnOffBotones('F');
        //    }
        //    catch (Exception a) { MessageBox.Show("Error al realizar la operación. Esto se puede ocacionar por una falta de conexión a la red. \rCompruebe que esté conectado a la red."); }
        //}

        //private void EditarProducto()
        //{
        //    try
        //    {
        //        var edicion = bdcarrillo.Productos.Find(Convert.ToInt32(txtIDProducto.Text));

        //        if (edicion != null)
        //        {
        //            var producto = RecuperarDatosProducto();
        //            edicion.Descripcion = producto.Descripcion;
        //            edicion.PrecioVenta = producto.PrecioVenta;
        //            edicion.PrecioMayoreo = producto.PrecioMayoreo;
        //            edicion.Unidades = producto.Unidades;
        //            edicion.idCategoria = producto.idCategoria;

        //            bdcarrillo.SaveChanges();
        //            limpiarControlesProductos();
        //            VistaProductos();
        //            OnOffBotones('F');
        //        }
        //    }
        //    catch (Exception a) { MessageBox.Show("Error al realizar la operación. Esto se puede ocacionar por una falta de conexión a la red. \rCompruebe que esté conectado a la red."); }
        //}

        //private void EliminarProducto()
        //{
        //    try
        //    {
        //        var eliminar = bdcarrillo.Productos.Find(Convert.ToInt32(txtIDProducto.Text));
        //        bdcarrillo.Productos.Remove(eliminar);
        //        bdcarrillo.SaveChanges();
        //        limpiarControlesProductos();
        //        VistaProductos();
        //        OnOffBotones('F');
        //    }
        //    catch (Exception a) { MessageBox.Show("Error al realizar la operación. Esto se puede ocacionar por una falta de conexión a la red. \rCompruebe que esté conectado a la red."); }
        //}

        //private Model.Productos RecuperarDatosProducto()
        //{
        //    var IDCategoria = (from tbCategoria in bdcarrillo.Categorias
        //                       join tbTipo in bdcarrillo.TipoProductos on tbCategoria.idTipoProducto equals tbTipo.idTipoProducto
        //                       let CategoriaTipo = tbCategoria.NombreCategoria + "-" + tbTipo.NombreTipo
        //                       where CategoriaTipo == cbxCategoria.SelectedItem.ToString().Trim()
        //                       select tbCategoria).ToList().FirstOrDefault();

        //    oProducto = new Model.Productos()
        //    {
        //        Descripcion = txtDescripcion.Text.Trim(),
        //        PrecioVenta = Double.Parse(txtPrecioVenta.Text.Trim()),
        //        PrecioMayoreo = Double.Parse(txtPrecioMayoreo.Text.Trim()),
        //        Unidades = Convert.ToInt32(txtUnidades.Text.Trim()),
        //        idCategoria = IDCategoria.idCategoria
        //    };

        //    if (txtIDProducto.Text != "")
        //    {
        //        oProducto.IdProductos = Convert.ToInt32(txtIDProducto.Text);
        //    }

        //    return oProducto;
        //}

        //private void limpiarControlesProductos()
        //{
        //    txtIDProducto.Text = "";
        //    txtDescripcion.Text = "";
        //    txtPrecioVenta.Text = "1";
        //    txtPrecioMayoreo.Text = "1";
        //    txtUnidades.Text = "1";
        //    cbxCategoria.SelectedIndex = 0;
        //}

        //private void dtgVistaProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    int posicion = e.RowIndex;

        //    if (posicion >= 0)
        //    {
        //        try
        //        {
        //            limpiarControlesProductos();
        //            txtIDProducto.Text = dtgVistaProductos.Rows[posicion].Cells[0].Value.ToString().Trim();
        //            txtDescripcion.Text = dtgVistaProductos.Rows[posicion].Cells[1].Value.ToString().Trim();
        //            txtPrecioVenta.Text = dtgVistaProductos.Rows[posicion].Cells[2].Value.ToString().Trim();
        //            txtPrecioMayoreo.Text = dtgVistaProductos.Rows[posicion].Cells[3].Value.ToString().Trim();
        //            txtUnidades.Text = dtgVistaProductos.Rows[posicion].Cells[4].Value.ToString().Trim();
        //            cbxCategoria.SelectedItem = dtgVistaProductos.Rows[posicion].Cells[5].Value.ToString().Trim();
        //        }
        //        catch (Exception a){ }

        //        OnOffBotones('T');
        //    }
        //}

        private void VistaProductos()
        {
            dtgVistaProductos.DataSource = (from tbProductos in bdcarrillo.Productos
                                            join tbCategorias in bdcarrillo.Categorias on tbProductos.idCategoria equals tbCategorias.idCategoria into tbLeft1
                                            from tbRight1 in tbLeft1.DefaultIfEmpty()
                                            join tbTipos in bdcarrillo.TipoProductos on tbRight1.idTipoProducto equals tbTipos.idTipoProducto into tbLeft2
                                            from tbRight2 in tbLeft2.DefaultIfEmpty()
                                            let CategoriaTipo = tbRight1.NombreCategoria + "-" + tbRight2.NombreTipo
                                            select new
                                            {
                                                tbProductos.IdProductos,
                                                tbProductos.Descripcion,
                                                tbProductos.PrecioVenta,
                                                tbProductos.PrecioMayoreo,
                                                tbProductos.Unidades,
                                                tbProductos.Status,
                                                CategoriaTipo
                                            }).ToList();
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            
        }

        //private void llenarComboCategorias()
        //{
        //    cbxCategoria.Properties.Items.Clear();

        //    cbxCategoria.Properties.Items.Add("Seleccionar");

        //    var CategoriasTipos = (from tbCategorias in bdcarrillo.Categorias
        //                           join tbTipos in bdcarrillo.TipoProductos on tbCategorias.idTipoProducto equals tbTipos.idTipoProducto
        //                           select new
        //                           {
        //                               tbCategorias.NombreCategoria, tbTipos.NombreTipo
        //                           });

        //    foreach (var CategoriaTipo in CategoriasTipos)
        //    {
        //        cbxCategoria.Properties.Items.Add(CategoriaTipo.NombreCategoria + "-" + CategoriaTipo.NombreTipo);
        //    }

        //    cbxCategoria.SelectedIndex = 0;
        //}

        //#endregion

        //#region Otros métodos y eventos

        //private void OnOffBotones(Char OnOff)
        //{
        //    switch (OnOff)
        //    {
        //        case 'T':
        //            windowsUIButtonPanelMain.Buttons[1].Properties.Enabled = false;
        //            windowsUIButtonPanelMain.Buttons[2].Properties.Enabled = true;
        //            windowsUIButtonPanelMain.Buttons[3].Properties.Enabled = true;
        //            break;
        //        case 'F':
        //            windowsUIButtonPanelMain.Buttons[1].Properties.Enabled = true;
        //            windowsUIButtonPanelMain.Buttons[2].Properties.Enabled = false;
        //            windowsUIButtonPanelMain.Buttons[3].Properties.Enabled = false;
        //            break;
        //    }
        //}

        //private void CargarInfo()
        //{
        //    dtgVistaProductos.AutoGenerateColumns = false;

        //    limpiarControlesProductos();
        //    VistaProductos();
        //    llenarComboCategorias();
        //    OnOffBotones('F');
        //}

        //private void windowsUIButtonPanelMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        //{
        //    switch (e.Button.Properties.Caption)
        //    {
        //        case "Nuevo":
        //            limpiarControlesProductos();
        //            OnOffBotones('F');
        //            break;
        //        case "Guardar":
        //            GuardarProducto();
        //            break;
        //        case "Editar":
        //            EditarProducto();
        //            break;
        //        case "Eliminar":
        //            EliminarProducto();
        //            break;
        //    }
        //}

        //#endregion
    }
}