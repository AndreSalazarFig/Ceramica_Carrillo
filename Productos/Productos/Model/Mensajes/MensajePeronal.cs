using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CeramicaCarrillo.Model.Mensajes;

namespace CeramicaCarrillo.Model.Mensajes
{
    public abstract class MensajePersonal : Mensaje
    {
        public MensajePersonal(int personal) : base(personal)
        {
        }
    }

    public class MIngresoPersonal : MensajePersonal
    {
        public MIngresoPersonal(int personal) : base(personal)
        {
        }

        public override void IngresarAccion(int personal)
        {
            TextoMensaje = BuscarPersonal(personal) + " ha dado de alta a un nuevo Personal.";
        }
    }

    public class MCambioPersonal : MensajePersonal
    {
        public MCambioPersonal(int personal) : base(personal)
        {
        }

        public override void IngresarAccion(int personal)
        {
            TextoMensaje = BuscarPersonal(personal) + " ha cambiado la información de un Personal.";
        }
    }

    public class MSalidaPersonal : MensajePersonal
    {
        public MSalidaPersonal(int personal) : base(personal)
        {
        }

        public override void IngresarAccion(int personal)
        {
            TextoMensaje = BuscarPersonal(personal) + " ha eliminado a un Personal.";
        }
    }
}