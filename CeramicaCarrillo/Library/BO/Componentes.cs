using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.BO
{
    public class Componentes
    {
        int espacio;
        double multiplo;
        Form formulario;

        public Componentes(int Espacio, int Multiplo, Form Formulario)
        {
            this.espacio = Espacio;
            this.multiplo = Multiplo;
            this.formulario = Formulario;
        }

        public void GestionPersonal()
        {
            TextBox txtValor = new TextBox();
            txtValor.Name = "txtValor";
            txtValor.SetBounds(10, 10,100, 10);
            formulario.Controls.Add(txtValor);
            
        }


    }
}
