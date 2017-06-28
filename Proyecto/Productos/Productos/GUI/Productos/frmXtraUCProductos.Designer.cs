namespace Productos.GUI.Productos
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXtraUCProductos));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.dtgVistaProductos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdProductos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PrecioVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PrecioMayoreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Unidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CategoriaTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAgregarProductos = new DevExpress.XtraEditors.SimpleButton();
            this.Acciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemButtonAccionesProductos = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonAccionesProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVistaProductos
            // 
            this.dtgVistaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVistaProductos.Location = new System.Drawing.Point(3, 117);
            this.dtgVistaProductos.MainView = this.gridView1;
            this.dtgVistaProductos.Name = "dtgVistaProductos";
            this.dtgVistaProductos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemButtonAccionesProductos});
            this.dtgVistaProductos.Size = new System.Drawing.Size(717, 284);
            this.dtgVistaProductos.TabIndex = 0;
            this.dtgVistaProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdProductos,
            this.Descripcion,
            this.PrecioVenta,
            this.PrecioMayoreo,
            this.Unidades,
            this.Status,
            this.CategoriaTipo,
            this.Acciones});
            this.gridView1.GridControl = this.dtgVistaProductos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Búsquedas...";
            // 
            // IdProductos
            // 
            this.IdProductos.Caption = "Clave";
            this.IdProductos.FieldName = "IdProductos";
            this.IdProductos.Name = "IdProductos";
            this.IdProductos.Visible = true;
            this.IdProductos.VisibleIndex = 0;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripción";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 1;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.Caption = "Precio Unitario";
            this.PrecioVenta.FieldName = "PrecioVenta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Visible = true;
            this.PrecioVenta.VisibleIndex = 2;
            // 
            // PrecioMayoreo
            // 
            this.PrecioMayoreo.Caption = "Precio de Mayoreo";
            this.PrecioMayoreo.FieldName = "PrecioMayoreo";
            this.PrecioMayoreo.Name = "PrecioMayoreo";
            this.PrecioMayoreo.Visible = true;
            this.PrecioMayoreo.VisibleIndex = 3;
            // 
            // Unidades
            // 
            this.Unidades.Caption = "Unidades (Stock)";
            this.Unidades.FieldName = "Unidades";
            this.Unidades.Name = "Unidades";
            this.Unidades.Visible = true;
            this.Unidades.VisibleIndex = 4;
            // 
            // Status
            // 
            this.Status.Caption = "Estado";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 5;
            // 
            // CategoriaTipo
            // 
            this.CategoriaTipo.Caption = "Categoría y Tipo";
            this.CategoriaTipo.FieldName = "CategoriaTipo";
            this.CategoriaTipo.Name = "CategoriaTipo";
            this.CategoriaTipo.Visible = true;
            this.CategoriaTipo.VisibleIndex = 6;
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.AllowFocus = false;
            this.btnAgregarProductos.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductos.Appearance.Options.UseFont = true;
            this.btnAgregarProductos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAgregarProductos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProductos.ImageOptions.Image")));
            this.btnAgregarProductos.Location = new System.Drawing.Point(3, 30);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(206, 42);
            this.btnAgregarProductos.TabIndex = 1;
            this.btnAgregarProductos.Text = "Agregar Productos";
            this.btnAgregarProductos.ToolTip = "Agregar nuevos productos al sistema";
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // Acciones
            // 
            this.Acciones.Caption = "Acciones";
            this.Acciones.ColumnEdit = this.ItemButtonAccionesProductos;
            this.Acciones.Name = "Acciones";
            this.Acciones.Visible = true;
            this.Acciones.VisibleIndex = 7;
            // 
            // ItemButtonAccionesProductos
            // 
            this.ItemButtonAccionesProductos.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.ItemButtonAccionesProductos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Editar registro"),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Eliminar registro"),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Reportar anomalía")});
            this.ItemButtonAccionesProductos.Name = "ItemButtonAccionesProductos";
            this.ItemButtonAccionesProductos.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmXtraUCProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.btnAgregarProductos);
            this.Controls.Add(this.dtgVistaProductos);
            this.Name = "frmXtraUCProductos";
            this.Size = new System.Drawing.Size(723, 404);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonAccionesProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtgVistaProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdProductos;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn PrecioVenta;
        private DevExpress.XtraGrid.Columns.GridColumn PrecioMayoreo;
        private DevExpress.XtraGrid.Columns.GridColumn Unidades;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn CategoriaTipo;
        private DevExpress.XtraEditors.SimpleButton btnAgregarProductos;
        private DevExpress.XtraGrid.Columns.GridColumn Acciones;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonAccionesProductos;
    }
}