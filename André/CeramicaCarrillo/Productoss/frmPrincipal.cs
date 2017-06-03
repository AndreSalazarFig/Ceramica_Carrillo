using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productoss
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Productos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (scMenu.Panel2.Controls.Count > 0)
                scMenu.Panel2.Controls.RemoveAt(0);
            Form1 hijo1 = new Form1();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            scMenu.Panel2.Controls.Add(hijo1);
            scMenu.Panel2.Tag = hijo1;
            hijo1.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            scMenu.IsSplitterFixed = false;
            scMenu.SplitterDistance = scMenu.Width / 7;
            scMenu.IsSplitterFixed = true;
        }

        private void Empleados_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (scMenu.Panel2.Controls.Count > 0)
                scMenu.Panel2.Controls.RemoveAt(0);
            Personal hijo1 = new Personal();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            scMenu.Panel2.Controls.Add(hijo1);
            scMenu.Panel2.Tag = hijo1;
            hijo1.Show();
        }
    }
}
