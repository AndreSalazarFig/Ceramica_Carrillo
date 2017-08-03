using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicaCarrillo.Model.Mensajes
{
    public abstract class MensajeTiposCategorias : Mensaje
    {
        public MensajeTiposCategorias(int personal) : base(personal)
        {
        }
    }

    #region Mensajes para los 'Tipos de Productos'
    public class MIngresoTipo : MensajeTiposCategorias
    {
        public MIngresoTipo(int personal) : base(personal)
        {
        }

        public override void IngresarAccion(int personal)
        {
            TextoMensaje = BuscarPersonal(personal) + " ha creado un nuevo Tipo de Producto.";
        }
    }

    public class MCambioTipo : MensajeTiposCategorias
    {
        public MCambioTipo(int personal) : base(personal)
        {
        }

        public override void IngresarAccion(int personal)
        {
            TextoMensaje = BuscarPersonal(personal) + " ha cambiado la información de un Tipo de Producto.";
        }
    }

    public class MSalidaTipo : MensajeTiposCategorias
    {
        public MSalidaTipo(int personal) : base(personal)
        {
        }

        public override void IngresarAccion(int personal)
        {
            TextoMensaje = BuscarPersonal(personal) + " ha eliminado un Tipo de Producto.";
        }
    }
    #endregion

    #region Mensaje para las Categorías de los Productos
    public class MIngresoCategoria : MensajeTiposCategorias
    {
        public MIngresoCategoria(int personal) : base(personal)
        {
        }

        public override void IngresarAccion(int personal)
        {
            TextoMensaje = BuscarPersonal(personal) + " ha creado un nuevo Departamento.";
        }
    }

    public class MCambioCategoria : MensajeTiposCategorias
    {
        public MCambioCategoria(int personal) : base(personal)
        {
        }

        public override void IngresarAccion(int personal)
        {
            TextoMensaje = BuscarPersonal(personal) + " ha cambiado la información de un Departamento.";
        }
    }

    public class MSalidaCategoria : MensajeTiposCategorias
    {
        public MSalidaCategoria(int personal) : base(personal)
        {
        }

        public override void IngresarAccion(int personal)
        {
            TextoMensaje = BuscarPersonal(personal) + " ha eliminado un Departamento.";
        }
    }
    #endregion
}