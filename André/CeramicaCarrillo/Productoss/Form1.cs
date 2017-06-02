using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productoss.Model;
using Productoss.Utilidades;

namespace Productoss
{
    public partial class Form1 : Form
    {
        BDCarrilloEntities bdcarrillo = new BDCarrilloEntities();
        Productos oProductos;
        ArchivosLocales archivo = new ArchivosLocales();

        public Form1()
        {
            InitializeComponent();
        }

        private Productos RecuperarDatos()
        {
            oProductos = new Productos()
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                PrecioCompra = Convert.ToDouble(txtPrecioCompra.Text),
                PrecioVenta = Convert.ToDouble(txtPrecioVenta.Text),
                Unidades = Convert.ToInt32(txtUnidades.Text)
            };
            if (picImagen.Image != null)
            {
                oProductos.Foto = archivo.arregloFoto(picImagen);
            }
            return oProductos;
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            archivo.buscarImagen(txtFoto, picImagen);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bdcarrillo.Productos.Add(RecuperarDatos());
            bdcarrillo.SaveChanges();
            llenarTabla();
        }

        private void llenarTabla()
        {
            var datos = (from u in bdcarrillo.Productos select u);
            dgvTabla.DataSource = datos.ToList();
            dgvTabla.Columns[6].Visible = false;
            dgvTabla.Columns[7].Visible = false;
            dgvTabla.Columns[8].Visible = false;
            dgvTabla.Columns[9].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void dgvTabla_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
