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
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;

namespace Productos.GUI.Inicio
{
    public partial class frmXtraPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static Model.BDCarrilloEntities bdCarrillo = null;
        public static String strNombreUsuario;
        public static Boolean boolAdministrador;
        XtraUserControl frmProductosUC;
        XtraUserControl frmCategoriasTiposUC;
        XtraUserControl frmPuntoVentaUC;

        public frmXtraPrincipal()
        {
            InitializeComponent();

            CargarFormularios();
        }

        XtraUserControl CreateUserControl(String strNombreUserControl, XtraUserControl frmXtraUC)
        {
            XtraUserControl result = frmXtraUC;
            result.Name = strNombreUserControl + "UC";
            result.Text = strNombreUserControl;
            return result;
        }

        void accordionControl_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
        {
            if (e.Element == null) return;
            //XtraUserControl userControl = e.Element.Text == "Productos" ? employeesUserControl : customersUserControl;
            XtraUserControl frmUserControl = null;

            switch (e.Element.Text)
            {
                case "Productos":
                    frmUserControl = frmProductosUC;
                    break;
                case "Tipos y Departamentos":
                    frmUserControl = frmCategoriasTiposUC;
                    break;
                case "Punto de Venta":
                    frmUserControl = frmPuntoVentaUC;
                    break;
                default:
                    frmUserControl = null;
                    break;
            }

            tabbedView.AddDocument(frmUserControl);
            tabbedView.ActivateDocument(frmUserControl);
        }

        //void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
        //    accordionCtrlNavegacion.SelectedElement = mainAccordionGroup.Elements[barItemIndex];
        //}

        void tabbedView_DocumentClosed(object sender, DocumentEventArgs e)
        {
            RecreateUserControls(e);
            SetAccordionSelectedElement(e);
        }

        void SetAccordionSelectedElement(DocumentEventArgs e)
        {
            //    if (tabbedView.Documents.Count != 0)
            //    {
            //        if (e.Document.Caption == "Employees") accordionCtrlNavegacion.SelectedElement = btnProductos;
            //        else accordionCtrlNavegacion.SelectedElement = employeesAccordionControlElement;
            //switch (e.Document.Caption)
            //{
            //    case "Productos":
            //        accordionCtrlNavegacion.SelectedElement = btnProductos;
            //        break;
            //    case "Tipos y Categorías":
            //        accordionCtrlNavegacion.SelectedElement = btnCategorias_Tipos;
            //        break;
            //}
            //    }
            //    else
            //    {
                    accordionCtrlNavegacion.SelectedElement = null;
            //    }
            if (tabbedView.Documents.Count == 0)
            {
                accordionCtrlNavegacion.SelectedElement = null;
            }
        }

        void RecreateUserControls(DocumentEventArgs e)
        {
            //if (e.Document.Caption == "Productos") employeesUserControl = CreateUserControl("Productos");
            //else customersUserControl = CreateUserControl("Customers");
            switch (e.Document.Caption)
            {
                case "Productos":
                    frmProductosUC = CreateUserControl("Productos", new Productos.frmXtraUCProductos());
                    break;
                case "Tipos y Departamentos":
                    frmCategoriasTiposUC = CreateUserControl("Tipos y Departamentos", new TiposCategorias.frmXtraUCTiposCategorias());
                    break;
                case "Punto de Venta":
                    frmPuntoVentaUC = CreateUserControl("Punto de Venta", new Ventas.frmXtraUCPuntoVenta());
                    break;
            }
        }

        private void CargarFormularios()
        {
            Productos.frmXtraUCProductos.bdCarrillo = bdCarrillo;
            Productos.frmXtraUCProductos.strNombreUsuario = strNombreUsuario;
            Productos.frmXtraUCProductos.boolAdministrador = boolAdministrador;

            TiposCategorias.frmXtraUCTiposCategorias.boolAdministrador = boolAdministrador;
            TiposCategorias.frmXtraUCTiposCategorias.bdCarrillo = bdCarrillo;

            Ventas.frmXtraUCPuntoVenta.datos = bdCarrillo;

            frmProductosUC = CreateUserControl("Productos", new Productos.frmXtraUCProductos());
            frmCategoriasTiposUC = CreateUserControl("Tipos y Departamentos", new TiposCategorias.frmXtraUCTiposCategorias());
            frmPuntoVentaUC = CreateUserControl("Punto de Venta", new Ventas.frmXtraUCPuntoVenta());
        }

        private void frmXtraPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}