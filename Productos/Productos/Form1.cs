using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using Productos.Model;

namespace Productos
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BDCarrilloEntities bdcarrillo = new BDCarrilloEntities();
        ArchivosLocales archivo = new ArchivosLocales();
        Model.Productos oProductos;

        public Form1()
        {
            InitializeComponent();
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.XtraGrid.GridControl gcDatos = new DevExpress.XtraGrid.GridControl();
            gcDatos.DataSource = gvDatos.DataSource;
            gcDatos.ShowRibbonPrintPreview();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gvDatos.AutoGenerateColumns = false;
            AsignarEventosTXT();
            activar_desactivarBotones(0);
            limpiarControles();
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

        private void gvDatos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int posicion = e.RowIndex;

            if (posicion >= 0)
            {
                txtId.Text = gvDatos.Rows[posicion].Cells[0].Value.ToString().Trim();
                txtNombre.Text = gvDatos.Rows[posicion].Cells[1].Value.ToString().Trim();
                txtDescripcion.Text = gvDatos.Rows[posicion].Cells[2].Value.ToString().Trim();
                txtPrecioCompra.Text = gvDatos.Rows[posicion].Cells[3].Value.ToString().Trim();
                txtPrecioVenta.Text = gvDatos.Rows[posicion].Cells[4].Value.ToString();
                txtUnidades.Text = gvDatos.Rows[posicion].Cells[5].Value.ToString();
                try
                {
                    picImagen.Image = null;
                    if (gvDatos.Rows[posicion].Cells[6].Value.ToString() != "")
                    {
                        Byte[] arreglo = (Byte[])gvDatos.Rows[posicion].Cells[6].Value;
                        archivo.recuperarImagen(arreglo, picImagen);
                    }
                }
                catch (Exception) { }
                activar_desactivarBotones(1);
            }
        }

        private void activar_desactivarBotones(int i)
        {
            if (i == 0)
            {
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
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

        private Model.Productos RecuperarDatos()
        {
            oProductos = new Model.Productos()
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

        private void btnGuardar_Click(object sender, ItemClickEventArgs e)
        {
            bdcarrillo.Productos.Add(RecuperarDatos());
            bdcarrillo.SaveChanges();
            limpiarControles();
            activar_desactivarBotones(0);
        }

        private void llenarTabla()
        {
            var datos = (from u in bdcarrillo.Productos select u);
            gvDatos.DataSource = datos.ToList();
        }

        private void btnCancelar_Click(object sender, ItemClickEventArgs e)
        {
            activar_desactivarBotones(0);
            limpiarControles();
        }

        private void btnEditar_Click(object sender, ItemClickEventArgs e)
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
                if (productos.Foto != null)
                {
                    edicion.Foto = productos.Foto;
                }
                bdcarrillo.SaveChanges();
                limpiarControles();
                activar_desactivarBotones(0);
            }
        }

        private void btnEliminar_Click(object sender, ItemClickEventArgs e)
        {
            var eliminar = bdcarrillo.Productos.Find(Convert.ToInt32(txtId.Text));
            bdcarrillo.Productos.Remove(eliminar);
            bdcarrillo.SaveChanges();
            limpiarControles();
            activar_desactivarBotones(0);
        }

        private void txtIDBuscar_EditValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void txtNombreBuscar_EditValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnBorrarBusqueda_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtIDBuscar.EditValue = null;
            txtNombreBuscar.EditValue = null;
            llenarTabla();
        }

        private void Buscar()
        {
            llenarTabla();
            int id = -1;
            string nombre = "";
            try
            {
                if (txtIDBuscar.EditValue != null || txtIDBuscar.EditValue.ToString() != "")
                {
                    id = Convert.ToInt32(txtIDBuscar.EditValue);
                }
                if (txtNombreBuscar.EditValue != null || txtNombreBuscar.EditValue.ToString() != "")
                {
                    nombre = txtNombreBuscar.EditValue.ToString();
                }
            
            } catch (Exception) {  }
            if (id > -1 && nombre != "")
            {
                var datos = (from u in bdcarrillo.Productos
                             where u.IdProductos == id && u.Nombre == nombre
                             select u);
                gvDatos.DataSource = datos.ToList();
            }
            else
            {
                if (nombre != "")
                {
                    var datos = (from u in bdcarrillo.Productos
                                 where u.Nombre == nombre
                                 select u);
                    gvDatos.DataSource = datos.ToList();
                }
                else
                {
                    if (id > -1)
                    {
                        var datos = (from u in bdcarrillo.Productos
                                     where u.IdProductos == id
                                     select u);
                        gvDatos.DataSource = datos.ToList();
                    }
                }
            }
        }
    }
}