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

namespace CeramicaCarrillo.GUI.Actividades
{
    public partial class frmXtraUCRegistroAcciones : DevExpress.XtraEditors.XtraUserControl
    {
        public frmXtraUCRegistroAcciones()
        {
            InitializeComponent();
            Actualizaciones.dtgAcciones = gridControl1;
        }

        private void frmXtraUCRegistroAcciones_Load(object sender, EventArgs e)
        {
            //Actualizaciones.dtgAcciones = gridControl1;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frnXtraReporteActividades frm = new frnXtraReporteActividades();
            using (DevExpress.XtraReports.UI.ReportPrintTool imprimir = new DevExpress.XtraReports.UI.ReportPrintTool(frm))
            {
                imprimir.ShowRibbonPreviewDialog();
            }
        }
    }
}
