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
            LlenarGrid();
        }

        private void LlenarGrid()
        {
            Factura fact = new Factura();
            dataGridView1.DataSource = fact.FacturaMostrar().Tables[0];
            panel1.Visible = false;
            dataGridView1.Columns[0].HeaderText = "Nro";
            dataGridView1.Columns[1].HeaderCell.Value = "Cliente";
            dataGridView1.Columns[2].HeaderCell.Value = "Fecha";
            dataGridView1.Columns[3].HeaderCell.Value = "Descuento";
            dataGridView1.Columns[4].HeaderCell.Value = "Precio final";

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
                textBoxNombre.Text = dataGridView1.SelectedRows[0].Cells["facturaNombre"].Value.ToString();
                textoDescuento.Text = dataGridView1.SelectedRows[0].Cells["facturaDescuento"].Value.ToString();
                facturaFecha.Text = dataGridView1.SelectedRows[0].Cells["facturaFecha"].Value.ToString();
                labelPrecioFinalEntero.Text = dataGridView1.SelectedRows[0].Cells["facturaTotal"].Value.ToString();
                DataSet DDSS = new DataSet();
                Factura fact = new Factura();
                
                dataGridView2.DataSource = fact.FacturaProductosMostrar(int.Parse(dataGridView1.SelectedRows[0].Cells["facturaID"].Value.ToString())).Tables[0];
                dataGridView2.Columns[0].HeaderText = "Producto";
                
                dataGridView2.Columns[1].HeaderCell.Value = "Cantidad x bulto";
                dataGridView2.Columns[2].HeaderCell.Value = "Cantidad de bultos";
                dataGridView2.Columns[3].HeaderCell.Value = "Precio x bulto";
                dataGridView2.Columns.Add("Precio Total", "Precio Total");
                
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {

                    row.Cells["Precio Total"].Value = (int.Parse(row.Cells["productoCantidad"].Value.ToString())) * (int.Parse(row.Cells["productoPrecioUnitario"].Value.ToString()));

                    
                }

            }
        }

        private void buttonCerrarFactura_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
        dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                if (MessageBox.Show("Estás seguro de eliminar esta factura?", "Tender Amount",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Factura fact = new Factura();
                fact.FacturaEliminar(int.Parse(dataGridView1.SelectedRows[0].Cells["facturaID"].Value.ToString()));
                    LlenarGrid();
                }
                
                

            }
        }
    }
}
