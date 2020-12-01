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
    public partial class ABMFactura : Form
    {
        public ABMFactura()
        {
            InitializeComponent();
        }

        private void DataGridLlenar()
        {
            //Configurando DataGrid
            DataSet DS = new DataSet();

            Stock listaPre = new Stock();
            DS = listaPre.MostrarListaPrecios();
            dataGridView2.DataSource = DS.Tables[0];
            dataGridView2.Columns["listaId"].Visible = false;

        }

        private void Factura_Load(object sender, EventArgs e)
        {
            DataGridLlenar();
        }

        private void agregarProd_Click(object sender, EventArgs e)
        {
            panelAgregarProd.Visible = true;
            
        }
    }
}
