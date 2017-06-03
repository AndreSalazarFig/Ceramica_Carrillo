namespace Productoss
{
    partial class frmPrincipal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.scMenu = new System.Windows.Forms.SplitContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.Gestiones = new DevExpress.XtraNavBar.NavBarGroup();
            this.Productos = new DevExpress.XtraNavBar.NavBarItem();
            this.Empleados = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).BeginInit();
            this.scMenu.Panel1.SuspendLayout();
            this.scMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(716, 459);
            // 
            // scMenu
            // 
            this.scMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMenu.IsSplitterFixed = true;
            this.scMenu.Location = new System.Drawing.Point(0, 0);
            this.scMenu.Name = "scMenu";
            // 
            // scMenu.Panel1
            // 
            this.scMenu.Panel1.Controls.Add(this.navBarControl1);
            this.scMenu.Size = new System.Drawing.Size(716, 484);
            this.scMenu.SplitterDistance = 230;
            this.scMenu.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.Gestiones;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.Gestiones});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.Productos,
            this.Empleados});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 230;
            this.navBarControl1.Size = new System.Drawing.Size(230, 484);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Office 2010 Silver");
            // 
            // Gestiones
            // 
            this.Gestiones.Caption = "Gestiones";
            this.Gestiones.Expanded = true;
            this.Gestiones.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.Productos),
            new DevExpress.XtraNavBar.NavBarItemLink(this.Empleados)});
            this.Gestiones.LargeImage = ((System.Drawing.Image)(resources.GetObject("Gestiones.LargeImage")));
            this.Gestiones.Name = "Gestiones";
            this.Gestiones.SmallImage = ((System.Drawing.Image)(resources.GetObject("Gestiones.SmallImage")));
            // 
            // Productos
            // 
            this.Productos.Caption = "Productos";
            this.Productos.LargeImage = ((System.Drawing.Image)(resources.GetObject("Productos.LargeImage")));
            this.Productos.Name = "Productos";
            this.Productos.SmallImage = ((System.Drawing.Image)(resources.GetObject("Productos.SmallImage")));
            this.Productos.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Productos_LinkClicked);
            // 
            // Empleados
            // 
            this.Empleados.Caption = "Empleados";
            this.Empleados.LargeImage = ((System.Drawing.Image)(resources.GetObject("Empleados.LargeImage")));
            this.Empleados.Name = "Empleados";
            this.Empleados.SmallImage = ((System.Drawing.Image)(resources.GetObject("Empleados.SmallImage")));
            this.Empleados.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.Empleados_LinkClicked);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 484);
            this.Controls.Add(this.scMenu);
            this.Name = "frmPrincipal";
            this.Text = "Cerámica Carrillo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.scMenu.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).EndInit();
            this.scMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.SplitContainer scMenu;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup Gestiones;
        private DevExpress.XtraNavBar.NavBarItem Productos;
        private DevExpress.XtraNavBar.NavBarItem Empleados;
    }
}