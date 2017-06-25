namespace Productos.GUI
{
    partial class frmXtraUCProductos
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXtraUCProductos));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions7 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions8 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtIDProducto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrecioMayoreo = new DevExpress.XtraEditors.SpinEdit();
            this.txtPrecioVenta = new DevExpress.XtraEditors.SpinEdit();
            this.cbxCategoria = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtgVistaProductos = new System.Windows.Forms.DataGridView();
            this.idProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioMayoreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnidades = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioMayoreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidades.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // windowsUIButtonPanelMain
            // 
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.Transparent;
            windowsUIButtonImageOptions5.ImageUri.Uri = "New;Size32x32;GrayScaled";
            windowsUIButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions6.Image")));
            windowsUIButtonImageOptions7.ImageUri.Uri = "Edit;Size32x32;GrayScaled";
            windowsUIButtonImageOptions8.ImageUri.Uri = "Edit/Delete;Size32x32;GrayScaled";
            this.windowsUIButtonPanelMain.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Nuevo", true, windowsUIButtonImageOptions5),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Guardar", true, windowsUIButtonImageOptions6),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Editar", true, windowsUIButtonImageOptions7),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Eliminar", true, windowsUIButtonImageOptions8)});
            this.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanelMain.EnableImageTransparency = true;
            this.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.Black;
            this.windowsUIButtonPanelMain.Location = new System.Drawing.Point(0, 344);
            this.windowsUIButtonPanelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanelMain.MaximumSize = new System.Drawing.Size(0, 60);
            this.windowsUIButtonPanelMain.MinimumSize = new System.Drawing.Size(60, 60);
            this.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.Size = new System.Drawing.Size(723, 60);
            this.windowsUIButtonPanelMain.TabIndex = 5;
            this.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanelMain.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanelMain_ButtonClick);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(172, 27);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(132, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(91, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Descripción";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(661, 22);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(11, 13);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "ID";
            this.labelControl5.Visible = false;
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.Location = new System.Drawing.Point(678, 19);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Size = new System.Drawing.Size(26, 20);
            this.txtIDProducto.TabIndex = 14;
            this.txtIDProducto.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(35, 56);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(110, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Categoría del Producto";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(356, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Precio de Venta";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(342, 56);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Precio de Mayoreo";
            // 
            // txtPrecioMayoreo
            // 
            this.txtPrecioMayoreo.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPrecioMayoreo.Location = new System.Drawing.Point(458, 53);
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
            this.txtPrecioMayoreo.Size = new System.Drawing.Size(132, 20);
            this.txtPrecioMayoreo.TabIndex = 19;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPrecioVenta.Location = new System.Drawing.Point(458, 27);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPrecioVenta.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtPrecioVenta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtPrecioVenta.Properties.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtPrecioVenta.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPrecioVenta.Size = new System.Drawing.Size(132, 20);
            this.txtPrecioVenta.TabIndex = 18;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Location = new System.Drawing.Point(172, 53);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCategoria.Size = new System.Drawing.Size(132, 20);
            this.cbxCategoria.TabIndex = 20;
            // 
            // dtgVistaProductos
            // 
            this.dtgVistaProductos.AllowUserToAddRows = false;
            this.dtgVistaProductos.AllowUserToDeleteRows = false;
            this.dtgVistaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVistaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVistaProductos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgVistaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVistaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductos,
            this.Descripcion,
            this.PrecioVenta,
            this.PrecioMayoreo,
            this.Unidades,
            this.Categoria});
            this.dtgVistaProductos.Location = new System.Drawing.Point(3, 141);
            this.dtgVistaProductos.Name = "dtgVistaProductos";
            this.dtgVistaProductos.ReadOnly = true;
            this.dtgVistaProductos.RowHeadersVisible = false;
            this.dtgVistaProductos.Size = new System.Drawing.Size(717, 195);
            this.dtgVistaProductos.TabIndex = 21;
            this.dtgVistaProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgVistaProductos_CellMouseClick);
            // 
            // idProductos
            // 
            this.idProductos.DataPropertyName = "idProductos";
            this.idProductos.HeaderText = "ID";
            this.idProductos.Name = "idProductos";
            this.idProductos.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.DataPropertyName = "PrecioVenta";
            this.PrecioVenta.HeaderText = "Precio de Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // PrecioMayoreo
            // 
            this.PrecioMayoreo.DataPropertyName = "PrecioMayoreo";
            this.PrecioMayoreo.HeaderText = "Precio de Mayoreo";
            this.PrecioMayoreo.Name = "PrecioMayoreo";
            this.PrecioMayoreo.ReadOnly = true;
            // 
            // Unidades
            // 
            this.Unidades.DataPropertyName = "Unidades";
            this.Unidades.HeaderText = "Unidades (Bodega)";
            this.Unidades.Name = "Unidades";
            this.Unidades.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "CategoriaTipo";
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(101, 82);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 13);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Unidades";
            // 
            // txtUnidades
            // 
            this.txtUnidades.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtUnidades.Location = new System.Drawing.Point(172, 79);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUnidades.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
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
            this.txtUnidades.Size = new System.Drawing.Size(132, 20);
            this.txtUnidades.TabIndex = 24;
            // 
            // frmXtraUCProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.dtgVistaProductos);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.txtPrecioMayoreo);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtIDProducto);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.windowsUIButtonPanelMain);
            this.Name = "frmXtraUCProductos";
            this.Size = new System.Drawing.Size(723, 404);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioMayoreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidades.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtIDProducto;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit txtPrecioMayoreo;
        private DevExpress.XtraEditors.SpinEdit txtPrecioVenta;
        private DevExpress.XtraEditors.ComboBoxEdit cbxCategoria;
        private System.Windows.Forms.DataGridView dtgVistaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioMayoreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SpinEdit txtUnidades;
    }
}