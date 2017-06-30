namespace Productos.GUI.Anomalias
{
    partial class frmXtraAnomalias
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXtraAnomalias));
            this.ribCtrlMenuCompras = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lyCtrlDatosAnomalia = new DevExpress.XtraLayout.LayoutControl();
            this.lyCtrlDatos = new DevExpress.XtraLayout.LayoutControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcionProducto = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcionAnomalia = new DevExpress.XtraEditors.MemoEdit();
            this.lyCtrlGroupDatos = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyGroupBoxDatosAnomalia = new DevExpress.XtraLayout.LayoutControlGroup();
            this.CtrlItemDescripcionAnomalia = new DevExpress.XtraLayout.LayoutControlItem();
            this.CtrlItemProducto = new DevExpress.XtraLayout.LayoutControlItem();
            this.Space2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.CtrlItemUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.Space1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lyCtrlGroupDatosAnomalia = new DevExpress.XtraLayout.LayoutControlGroup();
            this.CtrlItemDatos = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnCancelarAnomalia = new DevExpress.XtraEditors.SimpleButton();
            this.btnReportarAnomalia = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribCtrlMenuCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlDatosAnomalia)).BeginInit();
            this.lyCtrlDatosAnomalia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlDatos)).BeginInit();
            this.lyCtrlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionAnomalia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlGroupDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGroupBoxDatosAnomalia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemDescripcionAnomalia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Space2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Space1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlGroupDatosAnomalia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // ribCtrlMenuCompras
            // 
            this.ribCtrlMenuCompras.ExpandCollapseItem.Id = 0;
            this.ribCtrlMenuCompras.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribCtrlMenuCompras.ExpandCollapseItem});
            this.ribCtrlMenuCompras.Location = new System.Drawing.Point(0, 0);
            this.ribCtrlMenuCompras.MaxItemId = 1;
            this.ribCtrlMenuCompras.Name = "ribCtrlMenuCompras";
            this.ribCtrlMenuCompras.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribCtrlMenuCompras.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribCtrlMenuCompras.Size = new System.Drawing.Size(444, 49);
            // 
            // lyCtrlDatosAnomalia
            // 
            this.lyCtrlDatosAnomalia.Controls.Add(this.lyCtrlDatos);
            this.lyCtrlDatosAnomalia.Location = new System.Drawing.Point(12, 55);
            this.lyCtrlDatosAnomalia.Name = "lyCtrlDatosAnomalia";
            this.lyCtrlDatosAnomalia.Root = this.lyCtrlGroupDatosAnomalia;
            this.lyCtrlDatosAnomalia.Size = new System.Drawing.Size(414, 250);
            this.lyCtrlDatosAnomalia.TabIndex = 2;
            this.lyCtrlDatosAnomalia.Text = "layoutControl1";
            // 
            // lyCtrlDatos
            // 
            this.lyCtrlDatos.Controls.Add(this.txtUsuario);
            this.lyCtrlDatos.Controls.Add(this.txtDescripcionProducto);
            this.lyCtrlDatos.Controls.Add(this.txtDescripcionAnomalia);
            this.lyCtrlDatos.Location = new System.Drawing.Point(12, 12);
            this.lyCtrlDatos.Name = "lyCtrlDatos";
            this.lyCtrlDatos.Root = this.lyCtrlGroupDatos;
            this.lyCtrlDatos.Size = new System.Drawing.Size(390, 226);
            this.lyCtrlDatos.TabIndex = 4;
            this.lyCtrlDatos.Text = "layoutControl1";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(153, 42);
            this.txtUsuario.MenuManager = this.ribCtrlMenuCompras;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(213, 20);
            this.txtUsuario.StyleController = this.lyCtrlDatos;
            this.txtUsuario.TabIndex = 7;
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Enabled = false;
            this.txtDescripcionProducto.Location = new System.Drawing.Point(153, 76);
            this.txtDescripcionProducto.MenuManager = this.ribCtrlMenuCompras;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(213, 20);
            this.txtDescripcionProducto.StyleController = this.lyCtrlDatos;
            this.txtDescripcionProducto.TabIndex = 6;
            // 
            // txtDescripcionAnomalia
            // 
            this.txtDescripcionAnomalia.Location = new System.Drawing.Point(153, 110);
            this.txtDescripcionAnomalia.MenuManager = this.ribCtrlMenuCompras;
            this.txtDescripcionAnomalia.Name = "txtDescripcionAnomalia";
            this.txtDescripcionAnomalia.Size = new System.Drawing.Size(213, 92);
            this.txtDescripcionAnomalia.StyleController = this.lyCtrlDatos;
            this.txtDescripcionAnomalia.TabIndex = 5;
            // 
            // lyCtrlGroupDatos
            // 
            this.lyCtrlGroupDatos.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lyCtrlGroupDatos.GroupBordersVisible = false;
            this.lyCtrlGroupDatos.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyGroupBoxDatosAnomalia});
            this.lyCtrlGroupDatos.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.lyCtrlGroupDatos.Location = new System.Drawing.Point(0, 0);
            this.lyCtrlGroupDatos.Name = "lyCtrlGroupDatos";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 100D;
            this.lyCtrlGroupDatos.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            this.lyCtrlGroupDatos.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
            this.lyCtrlGroupDatos.Size = new System.Drawing.Size(390, 226);
            this.lyCtrlGroupDatos.TextVisible = false;
            // 
            // lyGroupBoxDatosAnomalia
            // 
            this.lyGroupBoxDatosAnomalia.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.CtrlItemDescripcionAnomalia,
            this.CtrlItemProducto,
            this.Space2,
            this.CtrlItemUsuario,
            this.Space1});
            this.lyGroupBoxDatosAnomalia.Location = new System.Drawing.Point(0, 0);
            this.lyGroupBoxDatosAnomalia.Name = "lyGroupBoxDatosAnomalia";
            this.lyGroupBoxDatosAnomalia.Size = new System.Drawing.Size(370, 206);
            this.lyGroupBoxDatosAnomalia.Text = "Datos de la Anomalía";
            // 
            // CtrlItemDescripcionAnomalia
            // 
            this.CtrlItemDescripcionAnomalia.AppearanceItemCaption.Options.UseTextOptions = true;
            this.CtrlItemDescripcionAnomalia.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.CtrlItemDescripcionAnomalia.Control = this.txtDescripcionAnomalia;
            this.CtrlItemDescripcionAnomalia.Location = new System.Drawing.Point(0, 68);
            this.CtrlItemDescripcionAnomalia.Name = "CtrlItemDescripcionAnomalia";
            this.CtrlItemDescripcionAnomalia.Size = new System.Drawing.Size(346, 96);
            this.CtrlItemDescripcionAnomalia.Text = "Descripción de la Anomalía";
            this.CtrlItemDescripcionAnomalia.TextLocation = DevExpress.Utils.Locations.Left;
            this.CtrlItemDescripcionAnomalia.TextSize = new System.Drawing.Size(126, 13);
            // 
            // CtrlItemProducto
            // 
            this.CtrlItemProducto.Control = this.txtDescripcionProducto;
            this.CtrlItemProducto.Location = new System.Drawing.Point(0, 34);
            this.CtrlItemProducto.Name = "CtrlItemProducto";
            this.CtrlItemProducto.Size = new System.Drawing.Size(346, 24);
            this.CtrlItemProducto.Text = "Descripción del Producto";
            this.CtrlItemProducto.TextSize = new System.Drawing.Size(126, 13);
            // 
            // Space2
            // 
            this.Space2.AllowHotTrack = false;
            this.Space2.Location = new System.Drawing.Point(0, 58);
            this.Space2.MaxSize = new System.Drawing.Size(0, 10);
            this.Space2.MinSize = new System.Drawing.Size(10, 10);
            this.Space2.Name = "Space2";
            this.Space2.Size = new System.Drawing.Size(346, 10);
            this.Space2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Space2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // CtrlItemUsuario
            // 
            this.CtrlItemUsuario.Control = this.txtUsuario;
            this.CtrlItemUsuario.Location = new System.Drawing.Point(0, 0);
            this.CtrlItemUsuario.Name = "CtrlItemUsuario";
            this.CtrlItemUsuario.Size = new System.Drawing.Size(346, 24);
            this.CtrlItemUsuario.Text = "Detectado por";
            this.CtrlItemUsuario.TextSize = new System.Drawing.Size(126, 13);
            // 
            // Space1
            // 
            this.Space1.AllowHotTrack = false;
            this.Space1.Location = new System.Drawing.Point(0, 24);
            this.Space1.MaxSize = new System.Drawing.Size(0, 10);
            this.Space1.MinSize = new System.Drawing.Size(10, 10);
            this.Space1.Name = "Space1";
            this.Space1.Size = new System.Drawing.Size(346, 10);
            this.Space1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Space1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lyCtrlGroupDatosAnomalia
            // 
            this.lyCtrlGroupDatosAnomalia.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lyCtrlGroupDatosAnomalia.GroupBordersVisible = false;
            this.lyCtrlGroupDatosAnomalia.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.CtrlItemDatos});
            this.lyCtrlGroupDatosAnomalia.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.lyCtrlGroupDatosAnomalia.Location = new System.Drawing.Point(0, 0);
            this.lyCtrlGroupDatosAnomalia.Name = "lyCtrlGroupDatosAnomalia";
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            this.lyCtrlGroupDatosAnomalia.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition2});
            rowDefinition2.Height = 100D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            this.lyCtrlGroupDatosAnomalia.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition2});
            this.lyCtrlGroupDatosAnomalia.Size = new System.Drawing.Size(414, 250);
            this.lyCtrlGroupDatosAnomalia.TextVisible = false;
            // 
            // CtrlItemDatos
            // 
            this.CtrlItemDatos.Control = this.lyCtrlDatos;
            this.CtrlItemDatos.Location = new System.Drawing.Point(0, 0);
            this.CtrlItemDatos.Name = "CtrlItemDatos";
            this.CtrlItemDatos.Size = new System.Drawing.Size(394, 230);
            this.CtrlItemDatos.TextSize = new System.Drawing.Size(0, 0);
            this.CtrlItemDatos.TextVisible = false;
            // 
            // btnCancelarAnomalia
            // 
            this.btnCancelarAnomalia.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAnomalia.Appearance.Options.UseFont = true;
            this.btnCancelarAnomalia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarAnomalia.ImageOptions.Image")));
            this.btnCancelarAnomalia.Location = new System.Drawing.Point(256, 328);
            this.btnCancelarAnomalia.Name = "btnCancelarAnomalia";
            this.btnCancelarAnomalia.Size = new System.Drawing.Size(134, 45);
            this.btnCancelarAnomalia.TabIndex = 29;
            this.btnCancelarAnomalia.Text = "Cancelar";
            this.btnCancelarAnomalia.Click += new System.EventHandler(this.btnCancelarAnomalia_Click);
            // 
            // btnReportarAnomalia
            // 
            this.btnReportarAnomalia.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportarAnomalia.Appearance.Options.UseFont = true;
            this.btnReportarAnomalia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReportarAnomalia.ImageOptions.Image")));
            this.btnReportarAnomalia.Location = new System.Drawing.Point(36, 328);
            this.btnReportarAnomalia.Name = "btnReportarAnomalia";
            this.btnReportarAnomalia.Size = new System.Drawing.Size(134, 45);
            this.btnReportarAnomalia.TabIndex = 28;
            this.btnReportarAnomalia.Text = "Reportar";
            this.btnReportarAnomalia.Click += new System.EventHandler(this.btnReportarAnomalia_Click);
            // 
            // frmXtraAnomalias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 403);
            this.Controls.Add(this.btnCancelarAnomalia);
            this.Controls.Add(this.btnReportarAnomalia);
            this.Controls.Add(this.lyCtrlDatosAnomalia);
            this.Controls.Add(this.ribCtrlMenuCompras);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(454, 408);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(454, 408);
            this.Name = "frmXtraAnomalias";
            this.Ribbon = this.ribCtrlMenuCompras;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportar Anomalías del Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmXtraAnomalias_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribCtrlMenuCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlDatosAnomalia)).EndInit();
            this.lyCtrlDatosAnomalia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlDatos)).EndInit();
            this.lyCtrlDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionAnomalia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlGroupDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGroupBoxDatosAnomalia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemDescripcionAnomalia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Space2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Space1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlGroupDatosAnomalia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribCtrlMenuCompras;
        private DevExpress.XtraLayout.LayoutControl lyCtrlDatosAnomalia;
        private DevExpress.XtraLayout.LayoutControlGroup lyCtrlGroupDatosAnomalia;
        private DevExpress.XtraLayout.LayoutControl lyCtrlDatos;
        private DevExpress.XtraLayout.LayoutControlGroup lyCtrlGroupDatos;
        private DevExpress.XtraLayout.LayoutControlItem CtrlItemDatos;
        private DevExpress.XtraLayout.LayoutControlGroup lyGroupBoxDatosAnomalia;
        private DevExpress.XtraEditors.MemoEdit txtDescripcionAnomalia;
        private DevExpress.XtraLayout.LayoutControlItem CtrlItemDescripcionAnomalia;
        private DevExpress.XtraEditors.TextEdit txtDescripcionProducto;
        private DevExpress.XtraLayout.LayoutControlItem CtrlItemProducto;
        private DevExpress.XtraLayout.EmptySpaceItem Space2;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraLayout.LayoutControlItem CtrlItemUsuario;
        private DevExpress.XtraLayout.EmptySpaceItem Space1;
        private DevExpress.XtraEditors.SimpleButton btnCancelarAnomalia;
        private DevExpress.XtraEditors.SimpleButton btnReportarAnomalia;
    }
}