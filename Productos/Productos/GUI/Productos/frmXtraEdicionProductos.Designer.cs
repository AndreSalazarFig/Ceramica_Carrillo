namespace Productos.GUI.Productos
{
    partial class frmXtraEdicionProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXtraEdicionProductos));
            this.ribCtrlMenuProductosEdicion = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lblIDProducto = new DevExpress.XtraEditors.LabelControl();
            this.txtIDProducto = new DevExpress.XtraEditors.TextEdit();
            this.lyCtrlDatosProducto = new DevExpress.XtraLayout.LayoutControl();
            this.txtPrecioMayoreo = new DevExpress.XtraEditors.SpinEdit();
            this.txtPrecioUnitario = new DevExpress.XtraEditors.SpinEdit();
            this.txtUnidades = new DevExpress.XtraEditors.SpinEdit();
            this.cbxCategoria = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.lyCtrlGroupDatosProducto = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyGroupBoxDatosProducto = new DevExpress.XtraLayout.LayoutControlGroup();
            this.CtrlItemDescripcion = new DevExpress.XtraLayout.LayoutControlItem();
            this.CtrlItemPrecioUnitario = new DevExpress.XtraLayout.LayoutControlItem();
            this.CtrlitemPrecioMayoreo = new DevExpress.XtraLayout.LayoutControlItem();
            this.CtrlItemCategoria = new DevExpress.XtraLayout.LayoutControlItem();
            this.CtrlItemUnidades = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnCancelarProducto = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarProducto = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribCtrlMenuProductosEdicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlDatosProducto)).BeginInit();
            this.lyCtrlDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioMayoreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioUnitario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlGroupDatosProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGroupBoxDatosProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemPrecioUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlitemPrecioMayoreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // ribCtrlMenuProductosEdicion
            // 
            this.ribCtrlMenuProductosEdicion.ExpandCollapseItem.Id = 0;
            this.ribCtrlMenuProductosEdicion.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribCtrlMenuProductosEdicion.ExpandCollapseItem});
            this.ribCtrlMenuProductosEdicion.Location = new System.Drawing.Point(0, 0);
            this.ribCtrlMenuProductosEdicion.MaxItemId = 1;
            this.ribCtrlMenuProductosEdicion.Name = "ribCtrlMenuProductosEdicion";
            this.ribCtrlMenuProductosEdicion.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribCtrlMenuProductosEdicion.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribCtrlMenuProductosEdicion.Size = new System.Drawing.Size(624, 49);
            // 
            // lblIDProducto
            // 
            this.lblIDProducto.Location = new System.Drawing.Point(12, 271);
            this.lblIDProducto.Name = "lblIDProducto";
            this.lblIDProducto.Size = new System.Drawing.Size(11, 13);
            this.lblIDProducto.TabIndex = 17;
            this.lblIDProducto.Text = "ID";
            this.lblIDProducto.Visible = false;
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.Location = new System.Drawing.Point(29, 268);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Size = new System.Drawing.Size(26, 20);
            this.txtIDProducto.TabIndex = 16;
            this.txtIDProducto.Visible = false;
            // 
            // lyCtrlDatosProducto
            // 
            this.lyCtrlDatosProducto.Controls.Add(this.txtPrecioMayoreo);
            this.lyCtrlDatosProducto.Controls.Add(this.txtPrecioUnitario);
            this.lyCtrlDatosProducto.Controls.Add(this.txtUnidades);
            this.lyCtrlDatosProducto.Controls.Add(this.cbxCategoria);
            this.lyCtrlDatosProducto.Controls.Add(this.txtDescripcion);
            this.lyCtrlDatosProducto.Location = new System.Drawing.Point(24, 70);
            this.lyCtrlDatosProducto.Name = "lyCtrlDatosProducto";
            this.lyCtrlDatosProducto.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(564, 20, 450, 400);
            this.lyCtrlDatosProducto.Root = this.lyCtrlGroupDatosProducto;
            this.lyCtrlDatosProducto.Size = new System.Drawing.Size(577, 134);
            this.lyCtrlDatosProducto.TabIndex = 23;
            this.lyCtrlDatosProducto.Text = "layoutControl1";
            // 
            // txtPrecioMayoreo
            // 
            this.txtPrecioMayoreo.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPrecioMayoreo.Location = new System.Drawing.Point(137, 90);
            this.txtPrecioMayoreo.Name = "txtPrecioMayoreo";
            this.txtPrecioMayoreo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPrecioMayoreo.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtPrecioMayoreo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtPrecioMayoreo.Properties.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtPrecioMayoreo.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPrecioMayoreo.Size = new System.Drawing.Size(149, 20);
            this.txtPrecioMayoreo.StyleController = this.lyCtrlDatosProducto;
            this.txtPrecioMayoreo.TabIndex = 20;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPrecioUnitario.Location = new System.Drawing.Point(137, 66);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPrecioUnitario.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtPrecioUnitario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtPrecioUnitario.Properties.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtPrecioUnitario.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPrecioUnitario.Size = new System.Drawing.Size(149, 20);
            this.txtPrecioUnitario.StyleController = this.lyCtrlDatosProducto;
            this.txtPrecioUnitario.TabIndex = 19;
            // 
            // txtUnidades
            // 
            this.txtUnidades.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtUnidades.Location = new System.Drawing.Point(403, 90);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUnidades.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtUnidades.Properties.IsFloatValue = false;
            this.txtUnidades.Properties.Mask.EditMask = "N00";
            this.txtUnidades.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
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
            this.txtUnidades.Size = new System.Drawing.Size(150, 20);
            this.txtUnidades.StyleController = this.lyCtrlDatosProducto;
            this.txtUnidades.TabIndex = 25;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Location = new System.Drawing.Point(403, 66);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCategoria.Size = new System.Drawing.Size(150, 20);
            this.cbxCategoria.StyleController = this.lyCtrlDatosProducto;
            this.cbxCategoria.TabIndex = 21;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(137, 42);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.NullValuePrompt = "Descripción del producto";
            this.txtDescripcion.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtDescripcion.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtDescripcion.Size = new System.Drawing.Size(416, 20);
            this.txtDescripcion.StyleController = this.lyCtrlDatosProducto;
            this.txtDescripcion.TabIndex = 7;
            // 
            // lyCtrlGroupDatosProducto
            // 
            this.lyCtrlGroupDatosProducto.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lyCtrlGroupDatosProducto.GroupBordersVisible = false;
            this.lyCtrlGroupDatosProducto.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyGroupBoxDatosProducto});
            this.lyCtrlGroupDatosProducto.Location = new System.Drawing.Point(0, 0);
            this.lyCtrlGroupDatosProducto.Name = "Root";
            this.lyCtrlGroupDatosProducto.Size = new System.Drawing.Size(577, 134);
            this.lyCtrlGroupDatosProducto.TextVisible = false;
            // 
            // lyGroupBoxDatosProducto
            // 
            this.lyGroupBoxDatosProducto.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.CtrlItemDescripcion,
            this.CtrlItemPrecioUnitario,
            this.CtrlitemPrecioMayoreo,
            this.CtrlItemCategoria,
            this.CtrlItemUnidades});
            this.lyGroupBoxDatosProducto.Location = new System.Drawing.Point(0, 0);
            this.lyGroupBoxDatosProducto.Name = "lyGroupBoxDatosProducto";
            this.lyGroupBoxDatosProducto.Size = new System.Drawing.Size(557, 114);
            this.lyGroupBoxDatosProducto.Text = "Datos del Producto";
            // 
            // CtrlItemDescripcion
            // 
            this.CtrlItemDescripcion.Control = this.txtDescripcion;
            this.CtrlItemDescripcion.Location = new System.Drawing.Point(0, 0);
            this.CtrlItemDescripcion.Name = "CtrlItemDescripcion";
            this.CtrlItemDescripcion.Size = new System.Drawing.Size(533, 24);
            this.CtrlItemDescripcion.Text = "Descripción";
            this.CtrlItemDescripcion.TextSize = new System.Drawing.Size(110, 13);
            // 
            // CtrlItemPrecioUnitario
            // 
            this.CtrlItemPrecioUnitario.Control = this.txtPrecioUnitario;
            this.CtrlItemPrecioUnitario.Location = new System.Drawing.Point(0, 24);
            this.CtrlItemPrecioUnitario.Name = "CtrlItemPrecioUnitario";
            this.CtrlItemPrecioUnitario.OptionsTableLayoutItem.ColumnIndex = 1;
            this.CtrlItemPrecioUnitario.Size = new System.Drawing.Size(266, 24);
            this.CtrlItemPrecioUnitario.Text = "Precio de Venta";
            this.CtrlItemPrecioUnitario.TextSize = new System.Drawing.Size(110, 13);
            // 
            // CtrlitemPrecioMayoreo
            // 
            this.CtrlitemPrecioMayoreo.Control = this.txtPrecioMayoreo;
            this.CtrlitemPrecioMayoreo.Location = new System.Drawing.Point(0, 48);
            this.CtrlitemPrecioMayoreo.Name = "CtrlitemPrecioMayoreo";
            this.CtrlitemPrecioMayoreo.OptionsTableLayoutItem.ColumnIndex = 1;
            this.CtrlitemPrecioMayoreo.OptionsTableLayoutItem.RowIndex = 1;
            this.CtrlitemPrecioMayoreo.Size = new System.Drawing.Size(266, 24);
            this.CtrlitemPrecioMayoreo.Text = "Precio de Mayoreo";
            this.CtrlitemPrecioMayoreo.TextSize = new System.Drawing.Size(110, 13);
            // 
            // CtrlItemCategoria
            // 
            this.CtrlItemCategoria.Control = this.cbxCategoria;
            this.CtrlItemCategoria.Location = new System.Drawing.Point(266, 24);
            this.CtrlItemCategoria.Name = "CtrlItemCategoria";
            this.CtrlItemCategoria.OptionsTableLayoutItem.RowIndex = 1;
            this.CtrlItemCategoria.Size = new System.Drawing.Size(267, 24);
            this.CtrlItemCategoria.Text = "Categoría del Producto";
            this.CtrlItemCategoria.TextSize = new System.Drawing.Size(110, 13);
            // 
            // CtrlItemUnidades
            // 
            this.CtrlItemUnidades.Control = this.txtUnidades;
            this.CtrlItemUnidades.Location = new System.Drawing.Point(266, 48);
            this.CtrlItemUnidades.Name = "CtrlItemUnidades";
            this.CtrlItemUnidades.OptionsTableLayoutItem.RowIndex = 2;
            this.CtrlItemUnidades.Size = new System.Drawing.Size(267, 24);
            this.CtrlItemUnidades.Text = "Unidades";
            this.CtrlItemUnidades.TextSize = new System.Drawing.Size(110, 13);
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProducto.Appearance.Options.UseFont = true;
            this.btnCancelarProducto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarProducto.ImageOptions.Image")));
            this.btnCancelarProducto.Location = new System.Drawing.Point(382, 227);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(134, 45);
            this.btnCancelarProducto.TabIndex = 25;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.Click += new System.EventHandler(this.btnCancelarProducto_Click);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.Appearance.Options.UseFont = true;
            this.btnGuardarProducto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarProducto.ImageOptions.Image")));
            this.btnGuardarProducto.Location = new System.Drawing.Point(109, 227);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(134, 45);
            this.btnGuardarProducto.TabIndex = 24;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // frmXtraEdicionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 296);
            this.Controls.Add(this.btnCancelarProducto);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.lyCtrlDatosProducto);
            this.Controls.Add(this.lblIDProducto);
            this.Controls.Add(this.txtIDProducto);
            this.Controls.Add(this.ribCtrlMenuProductosEdicion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(634, 301);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(634, 301);
            this.Name = "frmXtraEdicionProductos";
            this.Ribbon = this.ribCtrlMenuProductosEdicion;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-----";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmXtraEdicionProductos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribCtrlMenuProductosEdicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlDatosProducto)).EndInit();
            this.lyCtrlDatosProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioMayoreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioUnitario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlGroupDatosProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGroupBoxDatosProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemPrecioUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlitemPrecioMayoreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemUnidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribCtrlMenuProductosEdicion;
        private DevExpress.XtraEditors.LabelControl lblIDProducto;
        private DevExpress.XtraEditors.TextEdit txtIDProducto;
        private DevExpress.XtraLayout.LayoutControl lyCtrlDatosProducto;
        private DevExpress.XtraEditors.SpinEdit txtPrecioMayoreo;
        private DevExpress.XtraEditors.SpinEdit txtPrecioUnitario;
        private DevExpress.XtraEditors.SpinEdit txtUnidades;
        private DevExpress.XtraEditors.ComboBoxEdit cbxCategoria;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraLayout.LayoutControlGroup lyCtrlGroupDatosProducto;
        private DevExpress.XtraLayout.LayoutControlGroup lyGroupBoxDatosProducto;
        private DevExpress.XtraLayout.LayoutControlItem CtrlItemDescripcion;
        private DevExpress.XtraLayout.LayoutControlItem CtrlItemPrecioUnitario;
        private DevExpress.XtraLayout.LayoutControlItem CtrlitemPrecioMayoreo;
        private DevExpress.XtraLayout.LayoutControlItem CtrlItemCategoria;
        private DevExpress.XtraLayout.LayoutControlItem CtrlItemUnidades;
        private DevExpress.XtraEditors.SimpleButton btnCancelarProducto;
        private DevExpress.XtraEditors.SimpleButton btnGuardarProducto;
    }
}