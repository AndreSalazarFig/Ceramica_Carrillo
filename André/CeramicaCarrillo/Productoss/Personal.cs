using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productoss.Utilidades;

namespace Productoss
{
    public partial class Personal : Form
    {
        Model.BDCarrilloEntities BDCarrillo = new Model.BDCarrilloEntities();
        ArchivosLocales archivo = new ArchivosLocales();

        public Personal()
        {
            InitializeComponent();

            AsignarEventosTXT();
            VistaDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dtgVistaPersonal_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int IndexRow = e.RowIndex;

            if (IndexRow >= 0)
            {
                txtID.Text = dtgVistaPersonal.Rows[IndexRow].Cells[0].Value.ToString().Trim();
                txtNombres.Text = dtgVistaPersonal.Rows[IndexRow].Cells[1].Value.ToString().Trim();
                txtApellidos.Text = dtgVistaPersonal.Rows[IndexRow].Cells[2].Value.ToString().Trim();
                dtpFechaNacimiento.Value = DateTime.Parse(dtgVistaPersonal.Rows[IndexRow].Cells[6].Value.ToString().Trim());
                txtTelefono.Text = dtgVistaPersonal.Rows[IndexRow].Cells[3].Value.ToString();
                txtMovil.Text = dtgVistaPersonal.Rows[IndexRow].Cells[4].Value.ToString();
                txtDireccion.Text = dtgVistaPersonal.Rows[IndexRow].Cells[5].Value.ToString();
                txtPuesto.Text = dtgVistaPersonal.Rows[IndexRow].Cells[7].Value.ToString();
            }
        }

        private void GuardarDatos()
        {
            BDCarrillo.Personal.Add(RecuperarDatos());
            BDCarrillo.SaveChanges();
            VistaDatos();
            LimpiarCampos();
        }

        private void ModificarDatos()
        {
            var OBPersonal = BDCarrillo.Personal.Find(Convert.ToInt64(txtID.Text));

            if (OBPersonal != null)
            {
                var DatosPersonal = RecuperarDatos();

                OBPersonal.Nombre = DatosPersonal.Nombre;
                OBPersonal.Apellido = DatosPersonal.Apellido;
                OBPersonal.Telefono = DatosPersonal.Telefono;
                OBPersonal.Movil = DatosPersonal.Movil;
                OBPersonal.Direccion = DatosPersonal.Direccion;
                OBPersonal.FechaNacimiento = DatosPersonal.FechaNacimiento;
                OBPersonal.Puesto = DatosPersonal.Puesto;

                BDCarrillo.SaveChanges();
                VistaDatos();
                LimpiarCampos();
            }
        }

        private void EliminarDatos()
        {
            var OBPersonal = BDCarrillo.Personal.Find(Convert.ToInt64(txtID.Text));
            BDCarrillo.Personal.Remove(OBPersonal);
            BDCarrillo.SaveChanges();
            VistaDatos();
            LimpiarCampos();
        }

        private void BuscarDatos()
        {

        }

        private void VistaDatos()
        {
            dtgVistaPersonal.AutoGenerateColumns = false;
            dtgVistaPersonal.DataSource = BDCarrillo.Personal.ToList();
        }

        private Model.Personal RecuperarDatos()
        {
            Model.Personal OBPersonal = new Model.Personal
            {
                Nombre = txtNombres.Text.Trim(),
                Apellido = txtApellidos.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Movil = txtMovil.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                FechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Text),
                Puesto = txtPuesto.Text.Trim()
            };

            return OBPersonal;
        }

        private void AsignarEventosTXT()
        {
            txtNombres.KeyPress += archivo.Letras;
            txtApellidos.KeyPress += archivo.Letras;
            txtPuesto.KeyPress += archivo.Letras;
            txtTelefono.KeyPress += archivo.Numeros;
            txtMovil.KeyPress += archivo.Numeros;
        }

        private void LimpiarCampos()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }

                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
            }
        }
        
    }
}
