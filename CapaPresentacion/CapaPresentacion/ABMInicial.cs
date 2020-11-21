﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using CapaDominio;

namespace CapaPresentacion
{
    public partial class ABMInicial : Form
    {


        DataSet DS = new DataSet();
        public ABMInicial()
        {
            InitializeComponent();
            
        }

        private void ABMInicial_Load(object sender, EventArgs e)
        {
            
            

            //Configurando controles
            textBoxNombre.Visible = false;
            comboBoxProveedor.Visible = false;
            comboBoxTipo.Visible = false;
            comboBoxProveedor.Items.Insert(0, "Selecciona proveedor");
            comboBoxProveedor.SelectedIndex = 0;
            comboBoxTipo.Items.Insert(0, "Seleccionar el tipo");
            comboBoxTipo.SelectedIndex = 0;

            DataGridLlenar();
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
            dataGridView1.Columns["productoPrecioVenta"].Visible = false;
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Visible = true;
            comboBoxProveedor.Visible = true;
            comboBoxTipo.Visible = true;
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTipo.SelectedIndex != 0)
            {
                DataView dv;
                dv = new DataView(DS.Tables[0], "productoTipo = '" + comboBoxTipo.Text + "'", "type Desc", DataViewRowState.CurrentRows);
                dataGridView1.DataSource = dv;
            }
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            panelNuevoProducto.Visible = true;
            DataSet DS = new DataSet();
            Stock stock = new Stock();
            DS = stock.MostrarProductoTipo();
            //Agrega el tipo de producto
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                comboBoxNuevo.Items.Add(row["tipoNombre"].ToString());
            }
            DS.Clear();

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string codigo, nombre, tipo, descripcion;
            

            codigo = textBoxCodigo.Text;
            nombre = textBoxNom.Text;            
            tipo = comboBoxNuevo.Text;
            descripcion = textBoxDescripcion.Text;
            
            int cantidad = Int32.Parse(textBoxCantidad.Text);

            float precioCompra = float.Parse(textBoxPcompra.Text);
            float precioVenta = float.Parse(textBoxPventa.Text);
            //Convert.ToSingle(precioCompra);

            Stock producto = new Stock();

            if (producto.AgregarProducto(codigo, nombre, tipo, descripcion, cantidad, precioCompra, precioVenta) == true)
            {
                MessageBox.Show("se guardo el producto");
                //MessageBox.Show("Desea agregar el nuevo producto?", "Confirmar", MessageBoxButtons.YesNoCancel);
                //Configurando DataGrid

                DataGridLlenar();
                panelNuevoProducto.Visible = false;
            }
            else
            {
                MessageBox.Show("Error al cargar");
            }


            


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            panelNuevoProducto.Visible = false;
        }

       
    }
}
