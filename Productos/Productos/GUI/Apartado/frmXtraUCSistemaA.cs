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

namespace CeramicaCarrillo.GUI.Apartado
{
    public partial class frmXtraUCSistemaA : DevExpress.XtraEditors.XtraUserControl
    {
        public frmXtraUCSistemaA()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            folioApartadoTableAdapter.Fill(dsSisApartado.FolioApartado);
            abonosTableAdapter1.Fill(dsSisApartado.Abonos);
            productosApartadoTableAdapter1.Fill(dsSisApartado.ProductosApartado);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            VerReporte();
        }

        private void VerReporte()
        {
            frmXtraReporteApartado frm = new frmXtraReporteApartado();
            using (DevExpress.XtraReports.UI.ReportPrintTool imprimir = new DevExpress.XtraReports.UI.ReportPrintTool(frm))
            {
                imprimir.ShowPreviewDialog();
            }
            
        }
    }
}
