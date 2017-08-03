using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicaCarrillo.Model.Mensajes
{
    public class MensajeCompras : Mensaje
    {
        public MensajeCompras(int personal) : base(personal)
        {
        }

        public override void IngresarAccion(int personal)
        {
            TextoMensaje = BuscarPersonal(personal) + " ha registrado una Compra.";
        }
    }
}