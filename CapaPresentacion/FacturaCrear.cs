﻿using System;
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


        //constructor para cargar la factura para editarla
        public FacturaCrear(int id, string nombre, string descuento, string fecha)
        {
            InitializeComponent();

            //DATA GRID
            idFactura = id;
            Factura fact = new Factura();
            fact.FacturaEditarMostrarFactura(id);
            dataGridViewEditar.Visible = true;

            //recorrer el dataset e ir agregando en la tabla
            DataSet ddss = new DataSet();
            ddss = fact.FacturaEditarMostrarProductos(id);

            foreach (DataRow rowi in ddss.Tables[0].Rows) { }

            //dataGridViewEditar.DataSource = fact.FacturaEditarMostrarProductos(id).Tables[0];
            dataGridViewEditar.Columns.Add("Precio Total", "Precio Total");
            dataGridView1.Visible = false;

            
            
            //DETALLE DE FACTURA
            textBoxNombre.Text = nombre;
            facturaFecha.Text = fecha;
            textoDescuento.Text = descuento;



            //BOTONES
            buttonCerrarFactura.Visible = true;
            buttonCerrarFactura.Enabled = true;
            buttonCrearFactura.Visible = false;
            buttonGuardar.Visible = true;
            buttonEliminarProducto.Visible = true;
            buttonEliminarProducto.Enabled = true;
            buttonAgregarProducto.Visible = false;
            buttonAgregarProductoEditar.Visible = true;


        }
        private int id;
        private int idFactura = 0;

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

            if(idFactura != 0)
            {
                int contador = 0;
                foreach (DataGridViewRow rowi in dataGridViewEditar.Rows)
                {
                    int cuenta = int.Parse(rowi.Cells["Precio x Bulto"].Value.ToString()) * int.Parse(rowi.Cells["Cant. Bultos"].Value.ToString());
                    rowi.Cells["Precio Total"].Value = cuenta;
                    contador = contador + cuenta;


                }

                labelPrecioFinalEntero.Text = contador.ToString();
            }
            
        }

        private void agregarProd_Click(object sender, EventArgs e)
        {
            panelAgregarProd.Visible = true;
            panelAgregarProd.BringToFront();
            DataGridLlenar();
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            panelAgregarProd.Visible = false;
            textBox2.Text = "";
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
            buttonAgregarProductoEditar.Enabled = true;
            buttonCrearFactura.Enabled = true;

            textBox2.Text = "";
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
            buttonAgregarProductoEditar.Enabled = false;



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
                    //Vaciar campos
                    textBoxNombre.Text = "";
                    textoDescuento.Text = "";
                    labelPrecioFinalEntero.Text = "";
                    //dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    buttonCrearFactura.Enabled = false;

                }
                
            }

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            Producto sto = new Producto();
            string nombre = textBox2.Text;
            
            


            DS = sto.MostrarProductoFiltro(nombre, "");
            //dataGridView1.DataSource = null;
            if (DS != null)
            {
                dataGridView2.DataSource = DS.Tables[0];
            }
        }

        private void buttonCerrarFactura_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void buttonEliminarProducto_Click(object sender, EventArgs e)
        {
            DialogResult oDlgRes;

            oDlgRes = MessageBox.Show("¿Está seguro que querés eliminar el producto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (oDlgRes == DialogResult.Yes)
            {

                if (dataGridViewEditar.SelectedRows.Count == 0)
                {

                    MessageBox.Show("Seleccioná un producto");

                }
                else
                {
                    if (dataGridViewEditar.SelectedRows.Count > 0)
                    {
                        
                        dataGridViewEditar.Rows.RemoveAt(dataGridViewEditar.SelectedRows[0].Index);
                        dataGridViewEditar.Refresh();
                        actualizarPrecioFinal();

                    }

                }

            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
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

                foreach (DataGridViewRow fila in dataGridViewEditar.Rows)
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
                    fact.FacturaEditar(idFactura, nombre, fecha, descuento, total);
                    idFactura = fact.FacturaProductoUltimoID();
                    fact.EditarEliminarProductosFactura(idFactura);
                    foreach (DataGridViewRow fila in dataGridViewEditar.Rows)
                    {
                        fact.ProductoAgregar(idFactura, fila.Cells[0].Value.ToString(), fila.Cells[3].Value.ToString(), fila.Cells[4].Value.ToString());
                        MessageBox.Show("Factura Editada");
                        this.Dispose();
                        this.Close();

                    }
                    
                    

                }
                else
                {
                    MessageBox.Show("Hubo en error en la carga de datos");
                }

            }
        }

        private void buttonAgregarProductoEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            this.dataGridViewEditar.Rows.Add(id, textoProducto.Text, textoUnidad.Text, textBoxCantidad.Text, labelPrecio.Text, labelPrecioTotal.Text);



            textoProducto.Text = "";
            labelPrecio.Text = "";
            textoUnidad.Text = "";
            textBoxCantidad.Text = "";
            labelPrecioTotal.Text = "";
            buttonAgregarProducto.Enabled = false;

            actualizarPrecioFinal();
        }
    }
}
