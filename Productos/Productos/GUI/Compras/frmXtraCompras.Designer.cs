namespace Productos.GUI.Compras
{
    partial class frmXtraCompras
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXtraCompras));
            this.ribCtrlMenuCompras = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lyCtrlDatosCompra = new DevExpress.XtraLayout.LayoutControl();
            this.lyCtrlDatos = new DevExpress.XtraLayout.LayoutControl();
            this.txtDescripcionCompra = new DevExpress.XtraEditors.TextEdit();
            this.txtUnidades = new DevExpress.XtraEditors.SpinEdit();
            this.txtPrecioCompra = new DevExpress.XtraEditors.SpinEdit();
            this.txtTotal = new DevExpress.XtraEditors.SpinEdit();
            this.txtDescripcionProducto = new DevExpress.XtraEditors.TextEdit();
            this.lyDatos = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyGroupBoxDatosCompra = new DevExpress.XtraLayout.LayoutControlGroup();
            this.CtrlItemDescripcionCompra = new DevExpress.XtraLayout.LayoutControlItem();
            this.CtrlItemUnidades = new DevExpress.XtraLayout.LayoutControlItem();
            this.CtrlItemPrecioCompra = new DevExpress.XtraLayout.LayoutControlItem();
            this.CtrlItemTotal = new DevExpress.XtraLayout.LayoutControlItem();
            this.Space2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.Space1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.Space3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.CtrlItemDescripcionProducto = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lyCtrlGroupDatosCompra = new DevExpress.XtraLayout.LayoutControlGroup();
            this.CtrlItemDatosCompra = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnCancelarProducto = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregarCompra = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribCtrlMenuCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlDatosCompra)).BeginInit();
            this.lyCtrlDatosCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlDatos)).BeginInit();
            this.lyCtrlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGroupBoxDatosCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemDescripcionCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Space2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Space1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Space3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemDescripcionProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlGroupDatosCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemDatosCompra)).BeginInit();
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
            this.ribCtrlMenuCompras.Size = new System.Drawing.Size(506, 49);
            // 
            // lyCtrlDatosCompra
            // 
            this.lyCtrlDatosCompra.Controls.Add(this.lyCtrlDatos);
            this.lyCtrlDatosCompra.Location = new System.Drawing.Point(12, 55);
            this.lyCtrlDatosCompra.Name = "lyCtrlDatosCompra";
            this.lyCtrlDatosCompra.Root = this.lyCtrlGroupDatosCompra;
            this.lyCtrlDatosCompra.Size = new System.Drawing.Size(477, 212);
            this.lyCtrlDatosCompra.TabIndex = 2;
            this.lyCtrlDatosCompra.Text = "layoutControl1";
            // 
            // lyCtrlDatos
            // 
            this.lyCtrlDatos.Controls.Add(this.txtDescripcionCompra);
            this.lyCtrlDatos.Controls.Add(this.txtUnidades);
            this.lyCtrlDatos.Controls.Add(this.txtPrecioCompra);
            this.lyCtrlDatos.Controls.Add(this.txtTotal);
            this.lyCtrlDatos.Controls.Add(this.txtDescripcionProducto);
            this.lyCtrlDatos.Location = new System.Drawing.Point(12, 12);
            this.lyCtrlDatos.Name = "lyCtrlDatos";
            this.lyCtrlDatos.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(533, 36, 450, 400);
            this.lyCtrlDatos.Root = this.lyDatos;
            this.lyCtrlDatos.Size = new System.Drawing.Size(453, 188);
            this.lyCtrlDatos.TabIndex = 4;
            this.lyCtrlDatos.Text = "layoutControl1";
            // 
            // txtDescripcionCompra
            // 
            this.txtDescripcionCompra.Location = new System.Drawing.Point(147, 76);
            this.txtDescripcionCompra.MenuManager = this.ribCtrlMenuCompras;
            this.txtDescripcionCompra.Name = "txtDescripcionCompra";
            this.txtDescripcionCompra.Size = new System.Drawing.Size(282, 20);
            this.txtDescripcionCompra.StyleController = this.lyCtrlDatos;
            this.txtDescripcionCompra.TabIndex = 4;
            // 
            // txtUnidades
            // 
            this.txtUnidades.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtUnidades.Location = new System.Drawing.Point(147, 110);
            this.txtUnidades.MenuManager = this.ribCtrlMenuCompras;
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUnidades.Properties.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtUnidades.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtUnidades.Size = new System.Drawing.Size(77, 20);
            this.txtUnidades.StyleController = this.lyCtrlDatos;
            this.txtUnidades.TabIndex = 8;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPrecioCompra.Location = new System.Drawing.Point(147, 144);
            this.txtPrecioCompra.MenuManager = this.ribCtrlMenuCompras;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPrecioCompra.Properties.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtPrecioCompra.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPrecioCompra.Size = new System.Drawing.Size(77, 20);
            this.txtPrecioCompra.StyleController = this.lyCtrlDatos;
            this.txtPrecioCompra.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTotal.Location = new System.Drawing.Point(351, 144);
            this.txtTotal.MenuManager = this.ribCtrlMenuCompras;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTotal.Properties.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtTotal.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTotal.Size = new System.Drawing.Size(78, 20);
            this.txtTotal.StyleController = this.lyCtrlDatos;
            this.txtTotal.TabIndex = 10;
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Enabled = false;
            this.txtDescripcionProducto.Location = new System.Drawing.Point(147, 42);
            this.txtDescripcionProducto.MenuManager = this.ribCtrlMenuCompras;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(282, 20);
            this.txtDescripcionProducto.StyleController = this.lyCtrlDatos;
            this.txtDescripcionProducto.TabIndex = 11;
            // 
            // lyDatos
            // 
            this.lyDatos.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lyDatos.GroupBordersVisible = false;
            this.lyDatos.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyGroupBoxDatosCompra});
            this.lyDatos.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.lyDatos.Location = new System.Drawing.Point(0, 0);
            this.lyDatos.Name = "Root";
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 100D;
            this.lyDatos.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition3});
            rowDefinition3.Height = 100D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            this.lyDatos.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition3});
            this.lyDatos.Size = new System.Drawing.Size(453, 188);
            this.lyDatos.TextVisible = false;
            // 
            // lyGroupBoxDatosCompra
            // 
            this.lyGroupBoxDatosCompra.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.CtrlItemDescripcionCompra,
            this.CtrlItemUnidades,
            this.CtrlItemPrecioCompra,
            this.CtrlItemTotal,
            this.Space2,
            this.Space1,
            this.Space3,
            this.CtrlItemDescripcionProducto,
            this.emptySpaceItem1});
            this.lyGroupBoxDatosCompra.Location = new System.Drawing.Point(0, 0);
            this.lyGroupBoxDatosCompra.Name = "lyGroupBoxDatosCompra";
            this.lyGroupBoxDatosCompra.Size = new System.Drawing.Size(433, 168);
            this.lyGroupBoxDatosCompra.Text = "Detalles de la compra";
            // 
            // CtrlItemDescripcionCompra
            // 
            this.CtrlItemDescripcionCompra.Control = this.txtDescripcionCompra;
            this.CtrlItemDescripcionCompra.Location = new System.Drawing.Point(0, 34);
            this.CtrlItemDescripcionCompra.Name = "CtrlItemDescripcionCompra";
            this.CtrlItemDescripcionCompra.Size = new System.Drawing.Size(409, 24);
            this.CtrlItemDescripcionCompra.Text = "Descripción de la Compra";
            this.CtrlItemDescripcionCompra.TextSize = new System.Drawing.Size(120, 13);
            // 
            // CtrlItemUnidades
            // 
            this.CtrlItemUnidades.Control = this.txtUnidades;
            this.CtrlItemUnidades.Location = new System.Drawing.Point(0, 68);
            this.CtrlItemUnidades.Name = "CtrlItemUnidades";
            this.CtrlItemUnidades.Size = new System.Drawing.Size(204, 24);
            this.CtrlItemUnidades.Text = "Unidades Adquiridas";
            this.CtrlItemUnidades.TextSize = new System.Drawing.Size(120, 13);
            // 
            // CtrlItemPrecioCompra
            // 
            this.CtrlItemPrecioCompra.Control = this.txtPrecioCompra;
            this.CtrlItemPrecioCompra.Location = new System.Drawing.Point(0, 102);
            this.CtrlItemPrecioCompra.Name = "CtrlItemPrecioCompra";
            this.CtrlItemPrecioCompra.Size = new System.Drawing.Size(204, 24);
            this.CtrlItemPrecioCompra.Text = "Precio de Compra";
            this.CtrlItemPrecioCompra.TextSize = new System.Drawing.Size(120, 13);
            // 
            // CtrlItemTotal
            // 
            this.CtrlItemTotal.Control = this.txtTotal;
            this.CtrlItemTotal.Location = new System.Drawing.Point(204, 102);
            this.CtrlItemTotal.Name = "CtrlItemTotal";
            this.CtrlItemTotal.Size = new System.Drawing.Size(205, 24);
            this.CtrlItemTotal.Text = "Total de la Compra";
            this.CtrlItemTotal.TextSize = new System.Drawing.Size(120, 13);
            // 
            // Space2
            // 
            this.Space2.AllowHotTrack = false;
            this.Space2.Location = new System.Drawing.Point(204, 68);
            this.Space2.MaxSize = new System.Drawing.Size(0, 24);
            this.Space2.MinSize = new System.Drawing.Size(104, 24);
            this.Space2.Name = "Space2";
            this.Space2.Size = new System.Drawing.Size(205, 24);
            this.Space2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Space2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Space1
            // 
            this.Space1.AllowHotTrack = false;
            this.Space1.Location = new System.Drawing.Point(0, 58);
            this.Space1.MaxSize = new System.Drawing.Size(0, 10);
            this.Space1.MinSize = new System.Drawing.Size(10, 10);
            this.Space1.Name = "Space1";
            this.Space1.Size = new System.Drawing.Size(409, 10);
            this.Space1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Space1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Space3
            // 
            this.Space3.AllowHotTrack = false;
            this.Space3.Location = new System.Drawing.Point(0, 92);
            this.Space3.MaxSize = new System.Drawing.Size(0, 10);
            this.Space3.MinSize = new System.Drawing.Size(10, 10);
            this.Space3.Name = "Space3";
            this.Space3.Size = new System.Drawing.Size(409, 10);
            this.Space3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Space3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // CtrlItemDescripcionProducto
            // 
            this.CtrlItemDescripcionProducto.Control = this.txtDescripcionProducto;
            this.CtrlItemDescripcionProducto.Location = new System.Drawing.Point(0, 0);
            this.CtrlItemDescripcionProducto.Name = "CtrlItemDescripcionProducto";
            this.CtrlItemDescripcionProducto.Size = new System.Drawing.Size(409, 24);
            this.CtrlItemDescripcionProducto.Text = "Descripción del Producto";
            this.CtrlItemDescripcionProducto.TextSize = new System.Drawing.Size(120, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(409, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lyCtrlGroupDatosCompra
            // 
            this.lyCtrlGroupDatosCompra.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lyCtrlGroupDatosCompra.GroupBordersVisible = false;
            this.lyCtrlGroupDatosCompra.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.CtrlItemDatosCompra});
            this.lyCtrlGroupDatosCompra.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.lyCtrlGroupDatosCompra.Location = new System.Drawing.Point(0, 0);
            this.lyCtrlGroupDatosCompra.Name = "lyCtrlGroupDatosCompra";
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition4.Width = 100D;
            this.lyCtrlGroupDatosCompra.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition4});
            rowDefinition4.Height = 100D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            this.lyCtrlGroupDatosCompra.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition4});
            this.lyCtrlGroupDatosCompra.Size = new System.Drawing.Size(477, 212);
            this.lyCtrlGroupDatosCompra.TextVisible = false;
            // 
            // CtrlItemDatosCompra
            // 
            this.CtrlItemDatosCompra.Control = this.lyCtrlDatos;
            this.CtrlItemDatosCompra.Location = new System.Drawing.Point(0, 0);
            this.CtrlItemDatosCompra.Name = "CtrlItemDatosCompra";
            this.CtrlItemDatosCompra.Size = new System.Drawing.Size(457, 192);
            this.CtrlItemDatosCompra.TextSize = new System.Drawing.Size(0, 0);
            this.CtrlItemDatosCompra.TextVisible = false;
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProducto.Appearance.Options.UseFont = true;
            this.btnCancelarProducto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarProducto.ImageOptions.Image")));
            this.btnCancelarProducto.Location = new System.Drawing.Point(319, 284);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(134, 45);
            this.btnCancelarProducto.TabIndex = 27;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.Click += new System.EventHandler(this.btnCancelarProducto_Click);
            // 
            // btnAgregarCompra
            // 
            this.btnAgregarCompra.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCompra.Appearance.Options.UseFont = true;
            this.btnAgregarCompra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCompra.ImageOptions.Image")));
            this.btnAgregarCompra.Location = new System.Drawing.Point(46, 284);
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Size = new System.Drawing.Size(134, 45);
            this.btnAgregarCompra.TabIndex = 26;
            this.btnAgregarCompra.Text = "Agregar";
            this.btnAgregarCompra.Click += new System.EventHandler(this.btnAgregarCompra_Click);
            // 
            // frmXtraCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 368);
            this.Controls.Add(this.btnCancelarProducto);
            this.Controls.Add(this.btnAgregarCompra);
            this.Controls.Add(this.lyCtrlDatosCompra);
            this.Controls.Add(this.ribCtrlMenuCompras);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(516, 373);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(516, 373);
            this.Name = "frmXtraCompras";
            this.Ribbon = this.ribCtrlMenuCompras;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Compra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmXtraCompras_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribCtrlMenuCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlDatosCompra)).EndInit();
            this.lyCtrlDatosCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlDatos)).EndInit();
            this.lyCtrlDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGroupBoxDatosCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemDescripcionCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Space2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Space1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Space3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemDescripcionProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlGroupDatosCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemDatosCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribCtrlMenuCompras;
        private DevExpress.XtraLayout.LayoutControl lyCtrlDatosCompra;
        private DevExpress.XtraLayout.LayoutControlGroup lyCtrlGroupDatosCompra;
        private DevExpress.XtraLayout.LayoutControl lyCtrlDatos;
        private DevExpress.XtraLayout.LayoutControlGroup lyDatos;
        private DevExpress.XtraLayout.LayoutControlItem CtrlItemDatosCompra;
        private DevExpress.XtraEditors.TextEdit txtDescripcionCompra;
        private DevExpress.XtraLayout.LayoutControlGroup lyGroupBoxDatosCompra;
        private DevExpress.XtraLayout.LayoutControlItem CtrlItemDescripcionCompra;
        private DevExpress.XtraEditors.SpinEdit txtUnidades;
        private DevExpress.XtraLayout.LayoutControlItem CtrlItemUnidades;
        private DevExpress.XtraEditors.SpinEdit txtPrecioCompra;
        private DevExpress.XtraEditors.SpinEdit txtTotal;
        private DevExpress.XtraLayout.LayoutControlItem CtrlItemPrecioCompra;
        private DevExpress.XtraLayout.LayoutControlItem CtrlItemTotal;
        private DevExpress.XtraLayout.EmptySpaceItem Space2;
        private DevExpress.XtraLayout.EmptySpaceItem Space1;
        private DevExpress.XtraLayout.EmptySpaceItem Space3;
        private DevExpress.XtraEditors.SimpleButton btnCancelarProducto;
        private DevExpress.XtraEditors.SimpleButton btnAgregarCompra;
        private DevExpress.XtraEditors.TextEdit txtDescripcionProducto;
        private DevExpress.XtraLayout.LayoutControlItem CtrlItemDescripcionProducto;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}