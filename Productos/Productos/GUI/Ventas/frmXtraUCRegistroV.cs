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
using Productos.Model;

namespace Productos.GUI.Ventas
{
    public partial class frmXtraUCRegistroV : DevExpress.XtraEditors.XtraUserControl
    {
        public static BDCarrilloEntities datos = null;

        public frmXtraUCRegistroV()
        {
            InitializeComponent();
        }

        private void frmXtraUCRegistroV_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            var ventas = (from v in datos.Folio
                          join p in datos.Personal on v.IdPersonal equals p.IdPersonal
                          select new
                          {
                              v.IdFolio,
                              v.FechaVenta,
                              p.Nombre,
                              p.Apellido,
                              v.TotalVenta
                          }).ToList();
            gvDatos.DataSource = ventas;
        }
    }
}
