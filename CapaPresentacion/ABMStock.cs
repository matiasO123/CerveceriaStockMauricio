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
    public partial class ABMStock : Form
    {
        public ABMStock()
        {
            InitializeComponent();
            //btnStock.Enabled = false;
        }

        //MENU/////////////////////////////
        private void btnStock_Click(object sender, EventArgs e)
        {
            ABMStock stock = new ABMStock();
            this.Hide();
            stock.ShowDialog();
            this.Close();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {

            ABMFactura fac = new ABMFactura();
            this.Hide();
            fac.ShowDialog();
            this.Close();
            
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ABMProductos prod = new ABMProductos();
            this.Hide();
            prod.ShowDialog();
            this.Close();
            
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {

        }
        //MENU/////////////////////////////
    }
}
