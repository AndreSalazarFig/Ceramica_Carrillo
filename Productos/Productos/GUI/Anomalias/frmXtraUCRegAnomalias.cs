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

namespace CeramicaCarrillo.GUI.Anomalias
{
    public partial class frmXtraUCRegAnomalias : DevExpress.XtraEditors.XtraUserControl
    {
        public static BDCarrilloEntities bdCarrillo = null;

        public frmXtraUCRegAnomalias()
        {
            InitializeComponent();

            CargarDatos();
        }

        private void CargarDatos()
        {
            anomaliasTableAdapter.Fill(dsRegAnomalias.Anomalias);
            gridControl1.DataSource = anomaliasBindingSource;
        }
    }
}
