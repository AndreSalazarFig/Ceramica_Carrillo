﻿namespace Productos.GUI.Inicio
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
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanelNavegacion = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.accordionCtrlNavegacion = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mainAccordionGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnVentas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnPuntoVenta = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnBodega = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnProductos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnCategorias_Tipos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.ribCtrlMenuPrincipal = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.dockPanelNavegacion.SuspendLayout();
            this.dockPanel_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionCtrlNavegacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribCtrlMenuPrincipal)).BeginInit();
            this.SuspendLayout();
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
            this.dockPanelNavegacion.Location = new System.Drawing.Point(0, 53);
            this.dockPanelNavegacion.Name = "dockPanelNavegacion";
            this.dockPanelNavegacion.Options.ShowAutoHideButton = false;
            this.dockPanelNavegacion.Options.ShowCloseButton = false;
            this.dockPanelNavegacion.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanelNavegacion.Size = new System.Drawing.Size(200, 536);
            this.dockPanelNavegacion.Text = "Navegación";
            // 
            // dockPanel_Container
            // 
            this.dockPanel_Container.Controls.Add(this.accordionCtrlNavegacion);
            this.dockPanel_Container.Location = new System.Drawing.Point(3, 24);
            this.dockPanel_Container.Name = "dockPanel_Container";
            this.dockPanel_Container.Size = new System.Drawing.Size(193, 509);
            this.dockPanel_Container.TabIndex = 0;
            // 
            // accordionCtrlNavegacion
            // 
            this.accordionCtrlNavegacion.AllowItemSelection = true;
            this.accordionCtrlNavegacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.accordionCtrlNavegacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionCtrlNavegacion.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mainAccordionGroup,
            this.btnVentas,
            this.btnBodega});
            this.accordionCtrlNavegacion.Location = new System.Drawing.Point(0, 0);
            this.accordionCtrlNavegacion.Name = "accordionCtrlNavegacion";
            this.accordionCtrlNavegacion.Size = new System.Drawing.Size(193, 509);
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
            // btnVentas
            // 
            this.btnVentas.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnPuntoVenta});
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Text = "Ventas";
            // 
            // btnPuntoVenta
            // 
            this.btnPuntoVenta.Name = "btnPuntoVenta";
            this.btnPuntoVenta.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnPuntoVenta.Text = "Punto de Venta";
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
            // ribCtrlMenuPrincipal
            // 
            this.ribCtrlMenuPrincipal.ExpandCollapseItem.Id = 0;
            this.ribCtrlMenuPrincipal.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribCtrlMenuPrincipal.ExpandCollapseItem});
            this.ribCtrlMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ribCtrlMenuPrincipal.MaxItemId = 2;
            this.ribCtrlMenuPrincipal.Name = "ribCtrlMenuPrincipal";
            this.ribCtrlMenuPrincipal.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribCtrlMenuPrincipal.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribCtrlMenuPrincipal.Size = new System.Drawing.Size(778, 53);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "VS2010";
            // 
            // frmXtraPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 589);
            this.Controls.Add(this.dockPanelNavegacion);
            this.Controls.Add(this.ribCtrlMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmXtraPrincipal";
            this.Ribbon = this.ribCtrlMenuPrincipal;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerámica Carrillo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmXtraPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.dockPanelNavegacion.ResumeLayout(false);
            this.dockPanel_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionCtrlNavegacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribCtrlMenuPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private DevExpress.XtraBars.Ribbon.RibbonControl ribCtrlMenuPrincipal;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnVentas;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnPuntoVenta;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}