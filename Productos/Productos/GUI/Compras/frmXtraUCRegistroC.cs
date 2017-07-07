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

namespace Productos.GUI.Compras
{
    public partial class frmXtraUCRegistroC : DevExpress.XtraEditors.XtraUserControl
    {
        public static BDCarrilloEntities datos = null;

        public frmXtraUCRegistroC()
        {
            InitializeComponent();
        }

        private void frmXtraUCRegistroC_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            var compras = (from c in datos.Compras
                           join p in datos.Productos on c.IdProductos equals p.IdProductos
                           select new
                           {
                               c.IdCompras,
                               p.Descripcion,
                               c.Fecha,
                               c.Precio,
                               c.Unidades,
                               c.Total
                           }).ToList();
            gvDatos.DataSource = compras;
        }
    }
}
