using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Productoss.Utilidades
{
    public class ArchivosLocales
    {
        OpenFileDialog abrirDialog;
        SaveFileDialog guardarDialog;

        public ArchivosLocales()
        {
            abrirDialog = new OpenFileDialog();
            guardarDialog = new SaveFileDialog();
        }

        public void buscarImagen(TextBox nombreImagen, PictureBox imagen)
        {
            abrirDialog.Filter = "Tipo imagen|*.jpg;*.jpeg;*.png";
            abrirDialog.Title = "Buscar imagen";
            abrirDialog.Multiselect = false;
            if (abrirDialog.ShowDialog() == DialogResult.OK)
            {
                nombreImagen.Text = abrirDialog.FileName;
                imagen.Image = Image.FromFile(nombreImagen.Text);
            }
        }

        public Byte[] arregloFoto(PictureBox imagen)
        {
           using (var ms = new MemoryStream())
            {
                imagen.Image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

    }
}
