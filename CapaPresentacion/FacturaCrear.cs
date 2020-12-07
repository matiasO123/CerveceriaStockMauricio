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
    public partial class FacturaCrear : Form
    {
        public FacturaCrear()
        {
            InitializeComponent();
            

        }
        private int id;
        private int idFactura;

        private void DataGridLlenar()
        {
            //Configurando DataGrid
            DataSet DS = new DataSet();

            Producto listaProd = new Producto();
            DS = listaProd.MostrarProducto();
            dataGridView2.DataSource = DS.Tables[0];
            dataGridView2.Columns["productoid"].Visible = false;
            dataGridView2.Columns["productoCantidad"].Visible = false;


        }

        private void Factura_Load(object sender, EventArgs e)
        {
            DataGridLlenar();
        }

        private void agregarProd_Click(object sender, EventArgs e)
        {
            panelAgregarProd.Visible = true;
            panelAgregarProd.BringToFront();
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            panelAgregarProd.Visible = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                textoProducto.Text = dataGridView2.SelectedRows[0].Cells["productoNombre"].Value.ToString();
                textoUnidad.Text = dataGridView2.SelectedRows[0].Cells["productoUnidadMedida"].Value.ToString();
                labelPrecio.Text = dataGridView2.SelectedRows[0].Cells["productoPrecioVenta"].Value.ToString();
                id = int.Parse(dataGridView2.SelectedRows[0].Cells["productoId"].Value.ToString());
            }
            textBoxCantidad.Text = "1";
            panelAgregarProd.Visible = false;
            buttonAgregarProducto.Enabled = true;
            buttonCrearFactura.Enabled = true;
        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            if ((int.TryParse(textBoxCantidad.Text, out int cantidad)) && (int.TryParse(labelPrecio.Text, out int precioU)))
            {
                labelPrecioTotal.Text = (precioU * cantidad).ToString();
            }
            else if ((textBoxCantidad.Text == "") && (int.TryParse(labelPrecio.Text, out precioU)))
            {
                labelPrecioTotal.Text = "0";
            }
            else if ((int.TryParse(textBoxCantidad.Text, out  cantidad)) && (labelPrecio.Text == ""))
            {
                labelPrecioTotal.Text = "0";
            }
            else
            {
                labelPrecioTotal.Text = "0";
            }
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            this.dataGridView1.Rows.Add(id, textoProducto.Text, textoUnidad.Text, textBoxCantidad.Text, labelPrecio.Text, labelPrecioTotal.Text);



            textoProducto.Text = "";
            labelPrecio.Text = "";
            textoUnidad.Text = "";
            textBoxCantidad.Text = "";
            labelPrecioTotal.Text = "";
            buttonAgregarProducto.Enabled = false;

            actualizarPrecioFinal();

            
        }

        public void actualizarPrecioFinal()
        {
            int contador = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                contador = contador + Int32.Parse(fila.Cells[5].Value.ToString());
                
                
            }
            if (Int32.TryParse(textoDescuento.Text, out int descuento))
            {
                contador = contador - descuento;
            }

            labelPrecioFinalEntero.Text = contador.ToString();
        }

        private void actualizarPrecioFinal(object sender, EventArgs e)
        {
            actualizarPrecioFinal();
        }

        private void buttonCrearFactura_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string fecha = facturaFecha.Text;
            string descuento = textoDescuento.Text;
            string total = labelPrecioFinalEntero.Text;
            bool validado = true;
            Factura fact = new Factura();
            if (fact.FacturaValidar(nombre, fecha, descuento, total))
            {
                int i = 1;

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    if (fact.ProductoValidar(fila.Cells[0].Value.ToString(), fila.Cells[3].Value.ToString(), fila.Cells[4].Value.ToString(), i))
                    {
                        i++;
                    }
                    else
                    {
                        validado = false;
                    }
                }
                if (validado)
                {
                    fact.FacturaCrear(nombre, fecha, descuento, total);
                    idFactura = fact.FacturaProductoUltimoID();
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        fact.ProductoAgregar(idFactura, fila.Cells[0].Value.ToString(), fila.Cells[3].Value.ToString(), fila.Cells[4].Value.ToString());
                        
                        
                    }
                    MessageBox.Show("Factura creada");
                }
                        
                            
                            

                       
                
                

                
            }

            
        }

        
    }
}
