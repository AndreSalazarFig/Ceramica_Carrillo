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
            if (txtId.Text != "") { oProductos.IdProductos = Convert.ToInt32(txtId.Text); }
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
            limpiarControles();
            activar_desactivarBotones(0);
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
            AsignarEventosTXT();
            activar_desactivarBotones(0);
            limpiarControles();
        }

        private void dgvTabla_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posicion = e.RowIndex;

            if (posicion >= 0)
            {
                txtId.Text = dgvTabla.Rows[posicion].Cells[0].Value.ToString().Trim();
                txtNombre.Text = dgvTabla.Rows[posicion].Cells[1].Value.ToString().Trim();
                txtDescripcion.Text = dgvTabla.Rows[posicion].Cells[2].Value.ToString().Trim();
                txtPrecioCompra.Text = dgvTabla.Rows[posicion].Cells[3].Value.ToString().Trim();
                txtPrecioVenta.Text = dgvTabla.Rows[posicion].Cells[4].Value.ToString();
                txtUnidades.Text = dgvTabla.Rows[posicion].Cells[5].Value.ToString();
                try
                {
                    picImagen.Image = null;
                    if (dgvTabla.Rows[posicion].Cells[6].Value.ToString() != "")
                    {
                        Byte[] arreglo = (Byte[])dgvTabla.Rows[posicion].Cells[6].Value;
                        archivo.recuperarImagen(arreglo, picImagen);
                    }
                }
                catch (Exception) { }
                activar_desactivarBotones(1);
            }
        }

        private void limpiarControles()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPrecioCompra.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtUnidades.Text = string.Empty;
            picImagen.Image = null;
            txtNombre.Focus();
            llenarTabla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            activar_desactivarBotones(0);
            limpiarControles();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var edicion = bdcarrillo.Productos.Find(Convert.ToInt32(txtId.Text));
            if (edicion != null)
            {
                var productos = RecuperarDatos();
                edicion.Nombre = productos.Nombre;
                edicion.Descripcion = productos.Descripcion;
                edicion.PrecioCompra = productos.PrecioCompra;
                edicion.PrecioVenta = productos.PrecioVenta;
                edicion.Unidades = productos.Unidades;
                if (productos.Folio != null)
                {
                    edicion.Foto = productos.Foto;
                }
                bdcarrillo.SaveChanges();
                limpiarControles();
                activar_desactivarBotones(0);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var eliminar = bdcarrillo.Productos.Find(Convert.ToInt32(txtId.Text));
            bdcarrillo.Productos.Remove(eliminar);
            bdcarrillo.SaveChanges();
            limpiarControles();
            activar_desactivarBotones(0);
        }

        private void activar_desactivarBotones(int i) {
            if (i == 0)
            {
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else {
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void AsignarEventosTXT()
        {
            txtNombre.KeyPress += archivo.Letras;
            txtDescripcion.KeyPress += archivo.Letras;
            txtPrecioCompra.KeyPress += archivo.Numeros;
            txtPrecioVenta.KeyPress += archivo.Numeros;
            txtUnidades.KeyPress += archivo.Numeros;
        }
    }
}
