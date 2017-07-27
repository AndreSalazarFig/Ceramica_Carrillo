using System;
using CeramicaCarrillo.Model.Mensajes;
using CeramicaCarrillo.Model;

namespace CeramicaCarrillo.GUI.Inicio
{
    public partial class frmXtraCierre : DevExpress.XtraEditors.XtraForm
    {
        Cierre _cierre;
        public static Sesiones sesion = null;

        public frmXtraCierre(object oCierre)
        {
            InitializeComponent();

            _cierre = (Cierre)oCierre;
            _cierre.Accion = 'X';
        }
        
        private void pbxCerrarSesion_Click(object sender, EventArgs e)
        {
            _cierre.Accion = 'S';
            new MensajeLogOut(sesion.Id);
            this.Close();
        }

        private void pbxSalirAplicacion_Click(object sender, EventArgs e)
        {
            _cierre.Accion = 'A';
            new MensajeLogOut(sesion.Id);
            this.Close();
        }
    }
}