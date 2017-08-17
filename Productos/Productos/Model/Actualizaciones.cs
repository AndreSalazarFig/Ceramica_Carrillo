using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using dataApartados = CeramicaCarrillo.Model.dsSisApartadoTableAdapters;
using dataAcciones = CeramicaCarrillo.Model.dsRegistroActividadesTableAdapters;
using dataAnomalias = CeramicaCarrillo.Model.dsRegAnomaliasTableAdapters;
using dataCompras = CeramicaCarrillo.Model.dsRegComprasTableAdapters;
using dataVentas = CeramicaCarrillo.Model.dsPruebaTableAdapters;

using System.Windows.Forms;

namespace CeramicaCarrillo.Model
{
    class Actualizaciones
    {
        private static BindingSource dataBindingSource = null;
        public static BDCarrilloEntities bdCarrillo = null;
        public static DevExpress.XtraGrid.GridControl
            dtgPersonal = null,
            dtgProductos = null,
            dtgTiposCategorias = null,
            dtgApartados = null,
            dtgAcciones = null,
            dtgAnomalias = null,
            dtgCompras = null,
            dtgVentas = null;

        public Actualizaciones()
        {

        }

        #region Actualización de los Grids pertenecientes a los Catálogos

        public static void ActualizarPersonal()
        {
            dtgPersonal.DataSource = (from tbPersonal in bdCarrillo.Personal
                                   let NombreCompleto = tbPersonal.Nombre + " " + tbPersonal.Apellido
                                   where tbPersonal.Status == true
                                   select new
                                   {
                                       tbPersonal.IdPersonal,
                                       NombreCompleto,
                                       tbPersonal.Usuario,
                                       tbPersonal.Contrasena,
                                       tbPersonal.Telefono,
                                       tbPersonal.Movil,
                                       tbPersonal.Direccion,
                                       tbPersonal.FechaNacimiento,
                                       tbPersonal.Puesto
                                   }).ToList();
        }

        public static void ActualizarProductos()
        {
            dtgProductos.DataSource = (from tbProductos in bdCarrillo.Productos
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

        public static void ActualizarTiposCategorias()
        {
            try
            {
                dtgTiposCategorias.DataSource = bdCarrillo.TipoProductos.ToList();
            }
            catch (Exception f)
            {
                new ArchivosLocales().Mensajes('*', "");
            }
        }

        #endregion

        #region Actualización de los DataSet

        public static void ActualizarAcciones()
        {
            dataBindingSource = new BindingSource();

            dsRegistroActividades dsActividades = new dsRegistroActividades();

            dataAcciones.ActividadesTableAdapter adpActividades = new dataAcciones.ActividadesTableAdapter();

            adpActividades.Fill(dsActividades.Actividades);

            dataBindingSource.DataSource = dsActividades;
            dataBindingSource.DataMember = "Actividades";

            dtgAcciones.DataSource = dataBindingSource;
        }

        public static void ActualizarAnomalias()
        {
            dataBindingSource = new BindingSource();

            dsRegAnomalias dsAnomalias = new dsRegAnomalias();

            dataAnomalias.AnomaliasTableAdapter adpAnomalias = new dataAnomalias.AnomaliasTableAdapter();

            adpAnomalias.Fill(dsAnomalias.Anomalias);

            dataBindingSource.DataSource = dsAnomalias;
            dataBindingSource.DataMember = "Anomalias";

            dtgAnomalias.DataSource = dataBindingSource;
        }

        public static void ActualizarApartados()
        {
            dataBindingSource = new BindingSource();

            dsSisApartado dsApartados = new dsSisApartado();
            dataApartados.FolioApartadoTableAdapter adpFolio = new dataApartados.FolioApartadoTableAdapter();
            dataApartados.AbonosApartadoTableAdapter adpApartado = new dataApartados.AbonosApartadoTableAdapter();
            dataApartados.ProductosApartadoTableAdapter adpProductos = new dataApartados.ProductosApartadoTableAdapter();

            adpFolio.Fill(dsApartados.FolioApartado);
            adpApartado.Fill(dsApartados.AbonosApartado);
            adpProductos.Fill(dsApartados.ProductosApartado);

            dataBindingSource.DataSource = dsApartados;
            dataBindingSource.DataMember = "FolioApartado";

            dtgApartados.DataSource = dataBindingSource;
        }

        public static void ActualizarCompras()
        {
            dataBindingSource = new BindingSource();

            dsRegCompras dsCompras = new dsRegCompras();
            dataCompras.ComprasTableAdapter adpCompras = new dataCompras.ComprasTableAdapter();

            adpCompras.Fill(dsCompras.Compras);

            dataBindingSource.DataSource = dsCompras;
            dataBindingSource.DataMember = "Compras";

            dtgCompras.DataSource = dataBindingSource;
        }

        public static void ActualizarVentas()
        {
            dataBindingSource = new BindingSource();

            dsPrueba dsVentas = new dsPrueba();
            dataVentas.FolioTableAdapter adpFolio = new dataVentas.FolioTableAdapter();
            dataVentas.DetalleTableAdapter adpDetalle = new dataVentas.DetalleTableAdapter();

            adpFolio.Fill(dsVentas.Folio);
            adpDetalle.Fill(dsVentas.Detalle);

            dataBindingSource.DataSource = dsVentas;
            dataBindingSource.DataMember = "Folio";

            dtgVentas.DataSource = dataBindingSource;
        }

        #endregion
    }
}