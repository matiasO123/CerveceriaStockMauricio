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
    public partial class FacturaLista : Form
    {
        public FacturaLista()
        {
            InitializeComponent();
        }

        private void FacturaLista_Load(object sender, EventArgs e)
        {
            Factura fact = new Factura();
            dataGridView1.DataSource = fact.FacturaMostrar().Tables[0];
            panel1.Visible = false;
        }


        //ABRE PANEL CON LOS DETALLES DE LA FACTURA
        private void botonVerFactura_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();
            
            Int32 selectedRowCount =
        dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                MessageBox.Show( "" + dataGridView1.SelectedRows[0].Cells["facturaNombre"].Value.ToString());
                
            }
        }

        private void buttonCerrarFactura_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
