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
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using System.ComponentModel.DataAnnotations;
using System.IO;
using CeramicaCarrillo.Model;

namespace Productos.GUI.Productos
{
    public partial class frmXtraUCProductos : DevExpress.XtraEditors.XtraUserControl
    {
        public static BDCarrilloEntities bdCarrillo = null;
        public static Sesiones sesion = null;
        List<String> lstDatosProducto = null;
        ArchivosLocales oExtras = new ArchivosLocales();

        public frmXtraUCProductos()
        {
            InitializeComponent();

            CargarInfo();
        }
        
        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEdicion("Agregar Tipo de Producto", 'N');
        }
        
        private void ItemButtonAccionesProductos_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                Int32 IndexFila = dtgVistaProductos.FindRow(dtgVistaProductos.GetFocusedRow());

                switch (e.Button.Tag.ToString())
                {
                    case "EditarProducto":
                        GetDatosEdicion(IndexFila);
                        AbrirFormularioEdicion("Editar Producto", 'U');
                        break;
                    case "EliminarProducto":
                        EliminarProducto(IndexFila);
                        break;
                    case "ReportarAnomalias":
                        AbrirFormularioAnomalias(IndexFila);
                        break;
                    case "AgregarCompras":
                        AbrirFormularioCompras(IndexFila);
                        break;
                }
            }
            catch (Exception f)
            {
                oExtras.Mensajes('*', "");
            }
        }

        private void AbrirFormularioEdicion(String strTitulo, Char chAccion)
        {
            frmXtraEdicionProductos.strFormTitulo = strTitulo;
            frmXtraEdicionProductos.chAccion = chAccion;
            frmXtraEdicionProductos.lstDatosProducto = lstDatosProducto;
            frmXtraEdicionProductos.bdCarrillo = bdCarrillo;

            frmXtraEdicionProductos frm = new frmXtraEdicionProductos();

            frm.ShowDialog();

            lstDatosProducto = null;

            VistaDatos();
        }

        private void AbrirFormularioAnomalias(Int32 IndexFila)
        {
            Anomalias.frmXtraAnomalias.strProducto = dtgVistaProductos.GetRowCellValue(IndexFila, Descripcion).ToString().Trim();
            Anomalias.frmXtraAnomalias.strUsuario = sesion.Usuario;

            Anomalias.frmXtraAnomalias.bdCarrillo = bdCarrillo;

            Anomalias.frmXtraAnomalias frm = new Anomalias.frmXtraAnomalias();

            frm.ShowDialog();

            VistaDatos();
        }

        private void AbrirFormularioCompras(Int32 IndexFila)
        {
            Compras.frmXtraCompras.strProducto = dtgVistaProductos.GetRowCellValue(IndexFila, Descripcion).ToString().Trim();
            
            Compras.frmXtraCompras.bdCarrillo = bdCarrillo;

            Compras.frmXtraCompras frm = new Compras.frmXtraCompras();

            frm.ShowDialog();

            VistaDatos();
        }

        private void GetDatosEdicion(Int32 IndexFila)
        {
            lstDatosProducto = new List<string>();

            lstDatosProducto.Add(dtgVistaProductos.GetRowCellValue(IndexFila, IdProductos).ToString().Trim());
            lstDatosProducto.Add(dtgVistaProductos.GetRowCellValue(IndexFila, Descripcion).ToString().Trim());
            lstDatosProducto.Add(dtgVistaProductos.GetRowCellValue(IndexFila, PrecioVenta).ToString().Trim());
            lstDatosProducto.Add(dtgVistaProductos.GetRowCellValue(IndexFila, PrecioMayoreo).ToString().Trim());
            lstDatosProducto.Add(dtgVistaProductos.GetRowCellValue(IndexFila, Unidades).ToString().Trim());
            lstDatosProducto.Add(dtgVistaProductos.GetRowCellValue(IndexFila, CategoriaTipo).ToString().Trim());
        }

        private void EliminarProducto(Int32 IndexFila)
        {
            try
            {
                if (oExtras.Mensajes('X', "") == DialogResult.Yes)
                {
                    Int32 IDProducto = Convert.ToInt32(dtgVistaProductos.GetRowCellValue(IndexFila, IdProductos).ToString().Trim());

                    var edicion = bdCarrillo.Productos.Find(IDProducto);

                    if (edicion != null)
                    {
                        edicion.Status = false;

                        bdCarrillo.SaveChanges();

                        oExtras.Mensajes('D', "Éxito");
                    }

                    VistaDatos();
                }
            }
            catch (Exception f)
            {
                oExtras.Mensajes('D', "Error");
            }
        }

        private void Administrador()
        {
            if (sesion.Admin != true)
            {
                ItemButtonAccionesProductos.Buttons[0].Enabled = false;
                ItemButtonAccionesProductos.Buttons[1].Enabled = false;
            }
        }

        private void VistaDatos()
        {
            dtgVista.DataSource = (from tbProductos in bdCarrillo.Productos
                                   join tbCategorias in bdCarrillo.Categorias on tbProductos.idCategoria equals tbCategorias.idCategoria into tbLeft1
                                   from tbRight1 in tbLeft1.DefaultIfEmpty()
                                   join tbTipos in bdCarrillo.TipoProductos on tbRight1.idTipoProducto equals tbTipos.idTipoProducto into tbLeft2
                                   from tbRight2 in tbLeft2.DefaultIfEmpty()
                                   let CategoriaTipo = tbRight1.NombreCategoria + "-" + tbRight2.NombreTipo
                                   where tbProductos.Status == true
                                   select new
                                   {
                                       tbProductos.IdProductos,
                                       tbProductos.Descripcion,
                                       tbProductos.PrecioVenta,
                                       tbProductos.PrecioMayoreo,
                                       tbProductos.Unidades,
                                       tbProductos.Status,
                                       CategoriaTipo
                                   }).ToList();
        }

        private void CargarInfo()
        {
            Administrador();
            VistaDatos();
        }
    }
}