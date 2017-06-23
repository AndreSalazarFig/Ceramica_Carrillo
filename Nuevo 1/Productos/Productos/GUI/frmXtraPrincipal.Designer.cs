namespace Productos.GUI
{
    partial class frmXtraPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXtraPrincipal));
            this.ribStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribCtrlMenu = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barSubItemNavigation = new DevExpress.XtraBars.BarSubItem();
            this.employeesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.customersBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestaurar = new DevExpress.XtraBars.BarButtonItem();
            this.btnImportar = new DevExpress.XtraBars.BarButtonItem();
            this.txtIDBuscar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtDescripcionBuscar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnBorrar = new DevExpress.XtraBars.BarButtonItem();
            this.ribPageInicio = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribGroupAcciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribGroupImportar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribGroupBusquedas = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanelNavegacion = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.accordionCtrlNavegacion = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mainAccordionGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnBodega = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnProductos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnCategorias_Tipos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribCtrlMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.dockPanelNavegacion.SuspendLayout();
            this.dockPanel_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionCtrlNavegacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribStatusBar
            // 
            this.ribStatusBar.Location = new System.Drawing.Point(0, 568);
            this.ribStatusBar.Name = "ribStatusBar";
            this.ribStatusBar.Ribbon = this.ribCtrlMenu;
            this.ribStatusBar.Size = new System.Drawing.Size(790, 31);
            // 
            // ribCtrlMenu
            // 
            this.ribCtrlMenu.AllowMinimizeRibbon = false;
            this.ribCtrlMenu.Enabled = false;
            this.ribCtrlMenu.ExpandCollapseItem.Id = 0;
            this.ribCtrlMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribCtrlMenu.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem,
            this.barSubItemNavigation,
            this.employeesBarButtonItem,
            this.customersBarButtonItem,
            this.btnNuevo,
            this.btnGuardar,
            this.btnEditar,
            this.btnEliminar,
            this.btnRestaurar,
            this.btnImportar,
            this.txtIDBuscar,
            this.txtDescripcionBuscar,
            this.btnBorrar});
            this.ribCtrlMenu.Location = new System.Drawing.Point(0, 0);
            this.ribCtrlMenu.MaxItemId = 58;
            this.ribCtrlMenu.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribCtrlMenu.Name = "ribCtrlMenu";
            this.ribCtrlMenu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribPageInicio});
            this.ribCtrlMenu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.ribCtrlMenu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribCtrlMenu.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribCtrlMenu.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribCtrlMenu.Size = new System.Drawing.Size(790, 143);
            this.ribCtrlMenu.StatusBar = this.ribStatusBar;
            this.ribCtrlMenu.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Id = 14;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // barSubItemNavigation
            // 
            this.barSubItemNavigation.Caption = "Navigation";
            this.barSubItemNavigation.Id = 15;
            this.barSubItemNavigation.ImageOptions.ImageUri.Uri = "NavigationBar";
            this.barSubItemNavigation.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.employeesBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.customersBarButtonItem)});
            this.barSubItemNavigation.Name = "barSubItemNavigation";
            // 
            // employeesBarButtonItem
            // 
            this.employeesBarButtonItem.Caption = "Employees";
            this.employeesBarButtonItem.Id = 46;
            this.employeesBarButtonItem.Name = "employeesBarButtonItem";
            this.employeesBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNavigation_ItemClick);
            // 
            // customersBarButtonItem
            // 
            this.customersBarButtonItem.Caption = "Cutomers";
            this.customersBarButtonItem.Id = 47;
            this.customersBarButtonItem.Name = "customersBarButtonItem";
            this.customersBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNavigation_ItemClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 48;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.LargeImage")));
            this.btnNuevo.Name = "btnNuevo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar";
            this.btnGuardar.Id = 57;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.LargeImage")));
            this.btnGuardar.Name = "btnGuardar";
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar";
            this.btnEditar.Id = 50;
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.LargeImage")));
            this.btnEditar.Name = "btnEditar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 51;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.LargeImage")));
            this.btnEliminar.Name = "btnEliminar";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Caption = "Restaurar";
            this.btnRestaurar.Id = 52;
            this.btnRestaurar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.ImageOptions.Image")));
            this.btnRestaurar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.ImageOptions.LargeImage")));
            this.btnRestaurar.Name = "btnRestaurar";
            // 
            // btnImportar
            // 
            this.btnImportar.Caption = "Importar";
            this.btnImportar.Enabled = false;
            this.btnImportar.Id = 53;
            this.btnImportar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImportar.ImageOptions.Image")));
            this.btnImportar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnImportar.ImageOptions.LargeImage")));
            this.btnImportar.Name = "btnImportar";
            // 
            // txtIDBuscar
            // 
            this.txtIDBuscar.Caption = "Clave";
            this.txtIDBuscar.Edit = this.repositoryItemTextEdit1;
            this.txtIDBuscar.Id = 54;
            this.txtIDBuscar.Name = "txtIDBuscar";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // txtDescripcionBuscar
            // 
            this.txtDescripcionBuscar.Caption = "Descripción";
            this.txtDescripcionBuscar.Edit = this.repositoryItemTextEdit2;
            this.txtDescripcionBuscar.Id = 55;
            this.txtDescripcionBuscar.Name = "txtDescripcionBuscar";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Caption = "Borrar";
            this.btnBorrar.Id = 56;
            this.btnBorrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.ImageOptions.Image")));
            this.btnBorrar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.ImageOptions.LargeImage")));
            this.btnBorrar.Name = "btnBorrar";
            // 
            // ribPageInicio
            // 
            this.ribPageInicio.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribGroupAcciones,
            this.ribGroupImportar,
            this.ribGroupBusquedas});
            this.ribPageInicio.Name = "ribPageInicio";
            this.ribPageInicio.Text = "Inicio";
            // 
            // ribGroupAcciones
            // 
            this.ribGroupAcciones.AllowTextClipping = false;
            this.ribGroupAcciones.ItemLinks.Add(this.btnNuevo);
            this.ribGroupAcciones.ItemLinks.Add(this.btnGuardar);
            this.ribGroupAcciones.ItemLinks.Add(this.btnEditar);
            this.ribGroupAcciones.ItemLinks.Add(this.btnEliminar);
            this.ribGroupAcciones.ItemLinks.Add(this.btnRestaurar);
            this.ribGroupAcciones.Name = "ribGroupAcciones";
            this.ribGroupAcciones.Text = "Acciones";
            // 
            // ribGroupImportar
            // 
            this.ribGroupImportar.AllowTextClipping = false;
            this.ribGroupImportar.ItemLinks.Add(this.btnImportar);
            this.ribGroupImportar.Name = "ribGroupImportar";
            this.ribGroupImportar.Text = "Imprimir y Exportar";
            // 
            // ribGroupBusquedas
            // 
            this.ribGroupBusquedas.AllowTextClipping = false;
            this.ribGroupBusquedas.ItemLinks.Add(this.txtIDBuscar);
            this.ribGroupBusquedas.ItemLinks.Add(this.txtDescripcionBuscar);
            this.ribGroupBusquedas.ItemLinks.Add(this.btnBorrar);
            this.ribGroupBusquedas.Name = "ribGroupBusquedas";
            this.ribGroupBusquedas.Text = "Busquedas";
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelNavegacion});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanelNavegacion
            // 
            this.dockPanelNavegacion.Controls.Add(this.dockPanel_Container);
            this.dockPanelNavegacion.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanelNavegacion.ID = new System.Guid("a045df26-1503-4d9a-99c1-a531310af22b");
            this.dockPanelNavegacion.Location = new System.Drawing.Point(0, 143);
            this.dockPanelNavegacion.Name = "dockPanelNavegacion";
            this.dockPanelNavegacion.Options.ShowAutoHideButton = false;
            this.dockPanelNavegacion.Options.ShowCloseButton = false;
            this.dockPanelNavegacion.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanelNavegacion.Size = new System.Drawing.Size(200, 425);
            this.dockPanelNavegacion.Text = "Navegación";
            // 
            // dockPanel_Container
            // 
            this.dockPanel_Container.Controls.Add(this.accordionCtrlNavegacion);
            this.dockPanel_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel_Container.Name = "dockPanel_Container";
            this.dockPanel_Container.Size = new System.Drawing.Size(191, 398);
            this.dockPanel_Container.TabIndex = 0;
            // 
            // accordionCtrlNavegacion
            // 
            this.accordionCtrlNavegacion.AllowItemSelection = true;
            this.accordionCtrlNavegacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.accordionCtrlNavegacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionCtrlNavegacion.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mainAccordionGroup,
            this.btnBodega});
            this.accordionCtrlNavegacion.Location = new System.Drawing.Point(0, 0);
            this.accordionCtrlNavegacion.Name = "accordionCtrlNavegacion";
            this.accordionCtrlNavegacion.Size = new System.Drawing.Size(191, 398);
            this.accordionCtrlNavegacion.TabIndex = 0;
            this.accordionCtrlNavegacion.Text = "accordionControl";
            this.accordionCtrlNavegacion.SelectedElementChanged += new DevExpress.XtraBars.Navigation.SelectedElementChangedEventHandler(this.accordionControl_SelectedElementChanged);
            // 
            // mainAccordionGroup
            // 
            this.mainAccordionGroup.Expanded = true;
            this.mainAccordionGroup.HeaderVisible = false;
            this.mainAccordionGroup.Name = "mainAccordionGroup";
            this.mainAccordionGroup.Text = "mainGroup";
            // 
            // btnBodega
            // 
            this.btnBodega.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnProductos,
            this.btnCategorias_Tipos});
            this.btnBodega.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Text = "Bodega";
            // 
            // btnProductos
            // 
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnProductos.Text = "Productos";
            // 
            // btnCategorias_Tipos
            // 
            this.btnCategorias_Tipos.Name = "btnCategorias_Tipos";
            this.btnCategorias_Tipos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnCategorias_Tipos.Text = "Tipos y Categorías";
            // 
            // tabbedView
            // 
            this.tabbedView.RootContainer.Element = null;
            this.tabbedView.DocumentClosed += new DevExpress.XtraBars.Docking2010.Views.DocumentEventHandler(this.tabbedView_DocumentClosed);
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // frmXtraPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 599);
            this.Controls.Add(this.dockPanelNavegacion);
            this.Controls.Add(this.ribStatusBar);
            this.Controls.Add(this.ribCtrlMenu);
            this.Name = "frmXtraPrincipal";
            this.Ribbon = this.ribCtrlMenu;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribStatusBar;
            this.Text = "Cerámica Carrillo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmXtraPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribCtrlMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.dockPanelNavegacion.ResumeLayout(false);
            this.dockPanel_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionCtrlNavegacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribStatusBar;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelNavegacion;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel_Container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionCtrlNavegacion;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mainAccordionGroup;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnBodega;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnProductos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCategorias_Tipos;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribCtrlMenu;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.BarSubItem barSubItemNavigation;
        private DevExpress.XtraBars.BarButtonItem employeesBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem customersBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnGuardar;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraBars.BarButtonItem btnRestaurar;
        private DevExpress.XtraBars.BarButtonItem btnImportar;
        private DevExpress.XtraBars.BarEditItem txtIDBuscar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarEditItem txtDescripcionBuscar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarButtonItem btnBorrar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribPageInicio;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGroupAcciones;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGroupImportar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGroupBusquedas;
    }
}