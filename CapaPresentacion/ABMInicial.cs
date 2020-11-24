using System;
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

            DS = stock.MostrarUnidadMedida();
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                comboBoxUMedida.Items.Add(row["unidadMedidaNombre"].ToString());
            }

            textBoxCodigo.Focus();

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string codigo, nombre, tipo, descripcion, unidadMedida, cantidad, precioCompra, precioVenta;


            codigo = textBoxCodigo.Text;
            nombre = textBoxNom.Text;
            tipo = comboBoxNuevo.Text;
            descripcion = textBoxDescripcion.Text;
            unidadMedida = comboBoxUMedida.Text;
            cantidad = textBoxCantidad.Text;
            precioCompra = textBoxPcompra.Text;
            precioVenta = textBoxPventa.Text;
            //Convert.ToSingle(precioCompra);

            Stock producto = new Stock();
            if (producto.ProductoValidar(codigo, nombre, tipo, unidadMedida, cantidad, precioCompra, precioVenta))
            {
                long cantidadEntero = long.Parse(cantidad);
                int precioCompraEntero = int.Parse(precioCompra);
                int precioVentaEntero = int.Parse(precioVenta);

                if (producto.AgregarProducto(codigo, nombre, tipo, descripcion, cantidadEntero, precioCompraEntero, precioVentaEntero) == true)
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






        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            panelNuevoProducto.Visible = false;
        }

        private void Busqueda(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            Stock sto = new Stock();
            DS = sto.MostrarStockFiltro(textBoxNombre.Text, comboBoxTipo.Text, comboBoxProveedor.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void botonLlenarTabla_Click(object sender, EventArgs e)
        {
            DataGridLlenar();
        }


       //ELIMINAR PRODUCTO CON MESSAGEBOX si-no-cancelar
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult oDlgRes;

            oDlgRes = MessageBox.Show("¿Está seguro que desea eliminar el producto seleccionado ?","Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (oDlgRes == DialogResult.Yes)
            {

                if (dataGridView1.SelectedRows.Count == 0)
                {

                    MessageBox.Show("Para eliminar el registro debes seleccionar un producto");

                }
                else
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        string Id;
                        int IdAux;
                        Id = dataGridView1.CurrentRow.Cells["productoId"].Value.ToString();
                        IdAux = int.Parse(Id);
                        Stock p = new Stock();
                        if (p.EliminarStock(IdAux) == true)
                        {
                            MessageBox.Show("El producto se eliminó correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("El producto no se pudo eliminar");
                        }
                        DataSet DS = new DataSet();
                        p = new Stock();
                        DS = p.MostrarStock();
                        dataGridView1.DataSource = DS.Tables[0];


                    }
                    
                }

            }
        }
    }
}

