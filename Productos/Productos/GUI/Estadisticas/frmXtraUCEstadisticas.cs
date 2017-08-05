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
using DevExpress.XtraCharts;
using CeramicaCarrillo.Model;

namespace CeramicaCarrillo.GUI.Estadisticas
{
    public partial class frmXtraUCEstadisticas : DevExpress.XtraEditors.XtraUserControl
    {
        public static BDCarrilloEntities datos = null;

        public frmXtraUCEstadisticas()
        {
            InitializeComponent();
            CargarMeses();
        }

        private void CargarMeses()
        {
            comprasEstadisticasTableAdapter1.Fill(dsEstadisticas1.ComprasEstadisticas);
            ventasEstadisticasTableAdapter.Fill(dsEstadisticas.VentasEstadisticas);
            tmrTiempo.Start();
        }

        private void CargarInformacion()
        {
            var totalVenta = (from f in datos.Folio
                               join d in datos.DetalleFolio on f.IdFolio equals d.IdFolio
                               where f.FechaVenta.Month == DateTime.Now.Month
                               select f.TotalVenta);
            
        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            txtHora.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }
    }
}
