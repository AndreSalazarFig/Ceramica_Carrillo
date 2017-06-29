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

        public frmXtraPrincipal()
        {
            InitializeComponent();

            CargarFormularios();
            //accordionCtrlNavegacion.SelectedElement = btnProductos;
        }

        XtraUserControl CreateUserControl(String strNombreUserControl, XtraUserControl frmXtraUC)
        {
            XtraUserControl result = frmXtraUC;
            result.Name = strNombreUserControl + "UC";
            result.Text = strNombreUserControl;
            //LabelControl label = new LabelControl();
            //label.Parent = result;
            //label.Appearance.Font = new Font("Tahoma", 25.25F);
            //label.Appearance.ForeColor = Color.Gray;
            //label.Dock = System.Windows.Forms.DockStyle.Fill;
            //label.AutoSizeMode = LabelAutoSizeMode.None;
            //label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            //label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            //label.Text = NombreUserControl;
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
                case "Tipos y Categorías":
                    frmUserControl = frmCategoriasTiposUC;
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
                case "Tipos y Categorías":
                    frmCategoriasTiposUC = CreateUserControl("Tipos y Categorías", new TiposCategorias.frmXtraUCTiposCategorias());
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

            frmProductosUC = CreateUserControl("Productos", new Productos.frmXtraUCProductos());
            frmCategoriasTiposUC = CreateUserControl("Tipos y Categorías", new TiposCategorias.frmXtraUCTiposCategorias());
        }

        private void frmXtraPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}