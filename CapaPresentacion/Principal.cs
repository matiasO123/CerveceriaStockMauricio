using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        //abrir distintos formularios dentro del contenedor principal
        private void AbrirFormHija(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ABMStock());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ABMProductos());
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ABMFactura());
        }
    }
}
