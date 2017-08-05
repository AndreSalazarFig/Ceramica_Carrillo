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
        public static DevExpress.XtraGrid.GridControl
            dtgApartados = null,
            dtgAcciones = null, 
            dtgAnomalias = null, 
            dtgCompras = null, 
            dtgVentas = null;

        public Actualizaciones()
        {

        }
        
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
    }
}