using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BO
{
    public class Resolucion
    {
        public void ajustarResolucion(System.Windows.Forms.Form formulario)
        {
            String ancho = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width.ToString();//Obtengo el ancho de la pantalla
            String alto = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height.ToString();//Obtengo el alto de la pantalla
            String tamano = ancho + "x" + alto;//Concateno para utilizarlo en el switch
            switch (tamano)
            {
                case "800x600":
                    cambiarResolucion(formulario, 110F, 110F);//Hago el ajuste con esta función
                    break;
                case "1024x600":
                    cambiarResolucion(formulario, 96F, 110F);
                    break;
                case "1360x768":
                    cambiarResolucion(formulario, 1360F, 768F);
                    Componentes comp = new Componentes(10, 10, formulario);
                    comp.GestionPersonal();
                    break;
                default:
                    cambiarResolucion(formulario, 200F, 220F);
                    break;
            }
        }

        private static void cambiarResolucion(System.Windows.Forms.Form formulario, float ancho, float alto)
        {
            formulario.AutoScaleDimensions = new System.Drawing.SizeF(ancho, alto); //Ajusto la resolución
            formulario.Size = new System.Drawing.Size(Convert.ToInt32(ancho), Convert.ToInt32(alto));
            formulario.PerformAutoScale(); //Escalo el control contenedor y sus elementos secundarios.
        }
    }
}
