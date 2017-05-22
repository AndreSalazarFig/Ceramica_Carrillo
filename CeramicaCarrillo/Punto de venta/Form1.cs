using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.DAO;
using Library.BO;

namespace Punto_de_venta
{
    public partial class Form1 : Form
    {
        ConexionBD conexion = new ConexionBD();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Resolucion oResolucion = new Resolucion();
            oResolucion.ajustarResolucion(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor = textBox1.Text;
            string valor2 = textBox2.Text;
            foreach (Control item in this.Controls)
            {
                if (item.Name == "txtValor")
                {
                    valor = item.Text;
                }
            }
            string comando = "insert into personal(Nombre,Apellido) values('"+ valor +"','"+ valor2 +"')";
            MessageBox.Show("Valor = "+conexion.EjecutarComando(comando));
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Resolucion oResolucion = new Resolucion();
            oResolucion.ajustarResolucion(this);
        }
    }
}
