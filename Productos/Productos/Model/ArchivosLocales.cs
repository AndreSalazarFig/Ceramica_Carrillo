using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Productos.Model
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

        public void recuperarImagen(Byte[] byteArray, PictureBox imagen)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArray, 0, byteArray.Length);
                ms.Write(byteArray, 0, byteArray.Length);
                imagen.Image = Image.FromStream(ms, true);//Exception occurs here
            }
            catch { }
        }

        public void Numeros(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        public void Letras(object sender, KeyPressEventArgs e)
        {
            String txtName = ((TextBox)sender).Name;

            switch (txtName)
            {
                case "txtNombres":
                case "txtApellidos":
                    if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (Char)Keys.Space && e.KeyChar != (Char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                    break;

                case "txtPuesto":
                    if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (Char)Keys.Space && e.KeyChar != (Char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }

    }
}
