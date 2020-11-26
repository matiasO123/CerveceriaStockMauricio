using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominio;

namespace CapaPresentacion
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void DataGridLlenar()
        {
            //Configurando DataGrid
            DataSet DS = new DataSet();

            Stock stock = new Stock();
            DS = stock.MostrarStock();
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Columns["productoId"].Visible = false;
            dataGridView1.Columns["productoPrecioCompra"].Visible = false;
            dataGridView1.Columns["productoDesc"].Visible = false;
            dataGridView1.Columns["productoCantidad"].Visible = false;
            dataGridView1.Columns["productoCodigo"].Visible = false; 

        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }
    }
}
