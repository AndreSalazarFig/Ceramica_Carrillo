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

namespace Productos.GUI.TiposCategorias
{
    public partial class frmXtraUCTiposCategorias : DevExpress.XtraEditors.XtraUserControl
    {
        Model.BDCarrilloEntities bdcarrillo = new Model.BDCarrilloEntities();
        //Model.TipoProductos oTiposProducto;
        //Model.Categorias oCategorias;

        public frmXtraUCTiposCategorias()
        {
            InitializeComponent();

            VistaDatos();
            //CargarInfo();
        }
        
        private void btnAgregarTipos_Click(object sender, EventArgs e)
        {
            AbrirAltaTipo("Agregar Tipos de Productos", 'N');
        }

        private void AbrirAltaTipo(String Titulo, Char Accion)
        {
            frmXtraEdicionTipos.frmTitulo = Titulo;
            frmXtraEdicionTipos.Accion = Accion;

            frmXtraEdicionTipos frm = new frmXtraEdicionTipos();

            frm.ShowDialog();

            VistaDatos();
        }

        private void VistaDatos()
        {
            dtgVistaTipos.DataSource = bdcarrillo.TipoProductos.ToList();
        }

        private void ItemButtonAccionesTipos_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception f)
            {

            }
        }

        //#region Métodos para el CRUD de Tipos de Productos

        //private void GuardarTipo()
        //{
        //    try
        //    {
        //        bdcarrillo.TipoProductos.Add(RecuperarDatosTipo());
        //        bdcarrillo.SaveChanges();
        //        limpiarControlesTipos();
        //        VistaTipos();
        //        OnOffBotones('F');
        //    }
        //    catch (Exception a) { MessageBox.Show("Error al realizar la operación. Esto se puede ocacionar por una falta de conexión a la red. \rCompruebe que esté conectado a la red."); }
        //}

        //private void EditarTipo()
        //{
        //    try
        //    {
        //        var edicion = bdcarrillo.TipoProductos.Find(Convert.ToInt32(txtIDTipo.Text));

        //        if (edicion != null)
        //        {
        //            var tipoProducto = RecuperarDatosTipo();
        //            edicion.NombreTipo = tipoProducto.NombreTipo;

        //            bdcarrillo.SaveChanges();
        //            limpiarControlesTipos();
        //            VistaTipos();
        //            OnOffBotones('F');
        //        }
        //    }
        //    catch (Exception a) { MessageBox.Show("Error al realizar la operación. Esto se puede ocacionar por una falta de conexión a la red. \rCompruebe que esté conectado a la red."); }
        //}

        //private void EliminarTipo()
        //{
        //    try
        //    {
        //        var eliminar = bdcarrillo.TipoProductos.Find(Convert.ToInt32(txtIDTipo.Text));
        //        bdcarrillo.TipoProductos.Remove(eliminar);
        //        bdcarrillo.SaveChanges();
        //        limpiarControlesTipos();
        //        VistaTipos();
        //        OnOffBotones('F');
        //    }
        //    catch (Exception a) { MessageBox.Show("Error al realizar la operación. Esto se puede ocacionar por una falta de conexión a la red. \rCompruebe que esté conectado a la red."); }
        //}

        //private Model.TipoProductos RecuperarDatosTipo()
        //{
        //    oTiposProducto = new Model.TipoProductos()
        //    {
        //        NombreTipo = txtNombreTipo.Text.Trim()
        //    };

        //    if (txtIDTipo.Text != "")
        //    {
        //        oTiposProducto.idTipoProducto = Convert.ToInt32(txtIDTipo.Text);
        //    }

        //    return oTiposProducto;
        //}

        //private void limpiarControlesTipos()
        //{
        //    txtIDTipo.Text = "";
        //    txtNombreTipo.Text = "";
        //}

        //private void dtgVistaTipos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    int posicion = e.RowIndex;

        //    if (posicion >= 0)
        //    {
        //        txtIDTipo.Text = dtgVistaTipos.Rows[posicion].Cells[0].Value.ToString().Trim();
        //        txtNombreTipo.Text = dtgVistaTipos.Rows[posicion].Cells[1].Value.ToString().Trim();

        //        OnOffBotones('T');
        //    }
        //}

        //private void VistaTipos()
        //{
        //    dtgVistaTipos.DataSource = bdcarrillo.TipoProductos.ToList();
        //}

        //#endregion

        //#region Métodos para el CRUD de Categorias

        //private void GuardarCategoria()
        //{
        //    try
        //    {
        //        bdcarrillo.Categorias.Add(RecuperarDatosCategoria());
        //        bdcarrillo.SaveChanges();
        //        limpiarControlesCategoria();
        //        VistaCategorias();
        //        OnOffBotones('F');
        //    }
        //    catch (Exception a) { MessageBox.Show("Error al realizar la operación. Esto se puede ocacionar por una falta de conexión a la red. \rCompruebe que esté conectado a la red."); }
        //}

        //private void EditarCategoria()
        //{
        //    try
        //    {
        //        var edicion = bdcarrillo.Categorias.Find(Convert.ToInt32(txtIDCategoria.Text));

        //        if (edicion != null)
        //        {
        //            var categoria = RecuperarDatosCategoria();
        //            edicion.NombreCategoria = categoria.NombreCategoria;
        //            edicion.idTipoProducto = categoria.idTipoProducto;

        //            bdcarrillo.SaveChanges();
        //            limpiarControlesCategoria();
        //            VistaCategorias();
        //            OnOffBotones('F');
        //        }
        //    }
        //    catch (Exception a) { MessageBox.Show("Error al realizar la operación. Esto se puede ocacionar por una falta de conexión a la red. \rCompruebe que esté conectado a la red."); }
        //}

        //private void EliminarCategoria()
        //{
        //    try
        //    {
        //        var eliminar = bdcarrillo.Categorias.Find(Convert.ToInt32(txtIDCategoria.Text));
        //        bdcarrillo.Categorias.Remove(eliminar);
        //        bdcarrillo.SaveChanges();
        //        limpiarControlesCategoria();
        //        VistaCategorias();
        //        OnOffBotones('F');
        //    }
        //    catch (Exception a) { MessageBox.Show("Error al realizar la operación. Esto se puede ocacionar por una falta de conexión a la red. \rCompruebe que esté conectado a la red."); }
        //}

        //private Model.Categorias RecuperarDatosCategoria()
        //{
        //    try
        //    {
        //        var IDTipo = (from tbTipos in bdcarrillo.TipoProductos
        //                      where tbTipos.NombreTipo == cbxTiposProducto.SelectedItem.ToString().Trim()
        //                      select tbTipos).ToList().FirstOrDefault();

        //        oCategorias = new Model.Categorias()
        //        {
        //            NombreCategoria = txtNombreCategoria.Text.Trim(),
        //            idTipoProducto = IDTipo.idTipoProducto
        //        };

        //        if (txtIDCategoria.Text != "")
        //        {
        //            oCategorias.idCategoria = Convert.ToInt32(txtIDCategoria.Text);
        //        }
        //    }
        //    catch(Exception e) { }

        //    return oCategorias;
        //}

        //private void limpiarControlesCategoria()
        //{
        //    txtIDCategoria.Text = "";
        //    txtNombreCategoria.Text = "";
        //    cbxTiposProducto.SelectedIndex = 0;
        //}

        //private void dtgVistaCategorias_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    int posicion = e.RowIndex;

        //    if (posicion >= 0)
        //    {
        //        txtIDCategoria.Text = dtgVistaCategorias.Rows[posicion].Cells[0].Value.ToString().Trim();
        //        txtNombreCategoria.Text = dtgVistaCategorias.Rows[posicion].Cells[1].Value.ToString().Trim();
        //        cbxTiposProducto.SelectedItem = dtgVistaCategorias.Rows[posicion].Cells[2].Value.ToString().Trim();

        //        OnOffBotones('T');
        //    }
        //}

        //private void VistaCategorias()
        //{
        //    try
        //    {
        //        dtgVistaCategorias.DataSource = (from tbCategoria in bdcarrillo.Categorias
        //                                         join tbTipos in bdcarrillo.TipoProductos on tbCategoria.idTipoProducto equals tbTipos.idTipoProducto
        //                                         select new
        //                                         {
        //                                             tbCategoria.idCategoria,
        //                                             tbCategoria.NombreCategoria,
        //                                             tbTipos.NombreTipo
        //                                         }).ToList();
        //    }
        //    catch(Exception e) { }
        //}

        //private void llenarComboTipos()
        //{
        //    cbxTiposProducto.Properties.Items.Clear();

        //    cbxTiposProducto.Properties.Items.Add("Seleccionar");

        //    foreach (var Tipo in bdcarrillo.TipoProductos)
        //    {
        //        cbxTiposProducto.Properties.Items.Add(Tipo.NombreTipo);
        //    }
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
        //    dtgVistaTipos.AutoGenerateColumns = false;
        //    dtgVistaCategorias.AutoGenerateColumns = false;

        //    limpiarControlesTipos();
        //    limpiarControlesCategoria();
        //    VistaTipos();
        //    VistaCategorias();
        //    llenarComboTipos();
        //    OnOffBotones('F');
        //}

        //private void windowsUIButtonPanelMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        //{
        //    if (xtraTabCtrlCategorias_Tipos.SelectedTabPage == xtraTabPageTipos)
        //    {
        //        switch (e.Button.Properties.Caption)
        //        {
        //            case "Nuevo":
        //                limpiarControlesTipos();
        //                OnOffBotones('F');
        //                break;
        //            case "Guardar":
        //                GuardarTipo();
        //                break;
        //            case "Editar":
        //                EditarTipo();
        //                break;
        //            case "Eliminar":
        //                EliminarTipo();
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        switch (e.Button.Properties.Caption)
        //        {
        //            case "Nuevo":
        //                limpiarControlesCategoria();
        //                OnOffBotones('F');
        //                break;
        //            case "Guardar":
        //                GuardarCategoria();
        //                break;
        //            case "Editar":
        //                EditarCategoria();
        //                break;
        //            case "Eliminar":
        //                EliminarCategoria();
        //                break;
        //        }
        //    }

        //}

        //private void xtraTabCtrlCategorias_Tipos_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        //{
        //    CargarInfo();
        //}

        //#endregion
    }
}