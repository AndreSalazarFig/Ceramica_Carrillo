using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CeramicaCarrillo.Model;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.Entity;

namespace Productos.GUI.Ventas
{
    public partial class frmXtraUCRegistroVentas : DevExpress.XtraEditors.XtraUserControl
    {
        public static BDCarrilloEntities datos = null;

        public frmXtraUCRegistroVentas()
        {
            InitializeComponent();
        }

        private void frmXtraUCRegistroV_Load(object sender, EventArgs e)
        {
            //CargarDatosMaestro();
            //dtgDatos.OptionsDetail.EnableMasterViewMode = true;
            //dtgDatos.SetMasterRowExpanded(1, true);
            folioTableAdapter.Fill(dsPrueba1.Folio);
            detalleTableAdapter1.Fill(dsPrueba1.Detalle);
        }
    }
}