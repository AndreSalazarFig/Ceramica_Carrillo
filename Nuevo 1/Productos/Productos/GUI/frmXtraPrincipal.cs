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

namespace Productos.GUI
{
    public partial class frmXtraPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        XtraUserControl ProductosUC;
        XtraUserControl CategoriasTiposUC;

        public frmXtraPrincipal()
        {
            InitializeComponent();

            ProductosUC = CreateUserControl("Productos", new frmXtraUCProductos());
            CategoriasTiposUC = CreateUserControl("Tipos y Categorías", new frmXtraUCTiposCategorias());
            
            //accordionCtrlNavegacion.SelectedElement = btnProductos;
        }

        XtraUserControl CreateUserControl(String NombreUserControl, XtraUserControl XtraUC)
        {
            XtraUserControl result = XtraUC;
            result.Name = NombreUserControl + "UC";
            result.Text = NombreUserControl;
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
            XtraUserControl userControl = null;

            switch (e.Element.Text)
            {
                case "Productos":
                    userControl = ProductosUC;
                    break;
                case "Tipos y Categorías":
                    userControl = CategoriasTiposUC;
                    break;
                default:
                    userControl = null;
                    break;
            }

            tabbedView.AddDocument(userControl);
            tabbedView.ActivateDocument(userControl);
        }

        void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            accordionCtrlNavegacion.SelectedElement = mainAccordionGroup.Elements[barItemIndex];
        }

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
                    ProductosUC = CreateUserControl("Productos", new frmXtraUCProductos());
                    break;
                case "Tipos y Categorías":
                    CategoriasTiposUC = CreateUserControl("Tipos y Categorías", new frmXtraUCTiposCategorias());
                    break;
            }
        }

        private void frmXtraPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}