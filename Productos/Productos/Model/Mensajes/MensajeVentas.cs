using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicaCarrillo.Model.Mensajes
{
    public class MensajeVentaRealizada : Mensaje
    {
        public MensajeVentaRealizada(int personal) : base(personal)
        {
        }

        public override void IngresarAccion(int personal)
        {
            TextoMensaje += " realizó una venta";
        }
    }

    public class MensajeApartadoRealizado : Mensaje
    {
        public MensajeApartadoRealizado(int personal) : base(personal)
        {
        }

        public override void IngresarAccion(int personal)
        {
            TextoMensaje += " realizó un apartado";
        }
    }
}
