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

            comboBoxProveedor.Items.Insert(0, "");

            comboBoxProveedor.SelectedIndex = 0;
            comboBoxTipo.Items.Insert(0, "");
            comboBoxTipo.SelectedIndex = 0;

            panelNuevoProducto.Visible = false;
            DataSet DS = new DataSet();
            Stock stock = new Stock();
            DS = stock.MostrarProductoTipo();
            //Agrega el tipo de producto
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                comboBoxTipo.Items.Add(row["tipoNombre"].ToString());
            }
            DS.Clear();


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
            DataSet DS = new DataSet();
            Stock stock = new Stock();
            DS = stock.MostrarStockFiltro(textBoxNombre.Text, comboBoxTipo.Text, comboBoxProveedor.Text);
            textBoxNombre.Visible = true;
            comboBoxProveedor.Visible = true;
            comboBoxTipo.Visible = true;
            labelBusquedaNombre.Visible = true;
            labelBusquedaTipo.Visible = true;
            labelBusquedaProveedor.Visible = true;

        }



        private void botonAgregar_Click(object sender, EventArgs e)
        {
            panelNuevoProducto.Visible = true;
            panelNuevoProducto.BringToFront();
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
           

            Stock producto = new Stock();
            if (producto.ProductoValidar(codigo, nombre, tipo, unidadMedida, cantidad, precioCompra, precioVenta))
            {
                long cantidadEntero = long.Parse(cantidad);
                int precioCompraEntero = int.Parse(precioCompra);
                int precioVentaEntero = int.Parse(precioVenta);

                if (producto.AgregarProducto(codigo, nombre, tipo, descripcion, cantidadEntero, precioCompraEntero, precioVentaEntero) == true)
                {
                    MessageBox.Show("Se creo el nuevo producto con éxito");
                    

                    DataGridLlenar();
                    panelNuevoProducto.Visible = false;
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el producto");
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
            string nombre  = textBoxNombre.Text;
            string tipo = comboBoxTipo.Text;
            string proveedor = comboBoxProveedor.Text;
            

            DS = sto.MostrarStockFiltro(nombre, tipo, proveedor );
            //dataGridView1.DataSource = null;
            if(DS != null)
            {
                dataGridView1.DataSource = DS.Tables[0];
            }
            
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

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string codigo, nombre, tipo, descripcion, cantidad, precioCompra, precioVenta, productoId;
                int idAux, cantidadAux;
                float precioVaux, precioCaux;


                Stock s = new Stock();
                codigo = dataGridView1.CurrentRow.Cells["productoCodigo"].Value.ToString();
                nombre = dataGridView1.CurrentRow.Cells["productoNombre"].Value.ToString();
                tipo = dataGridView1.CurrentRow.Cells["productoTipo"].Value.ToString();
                descripcion = dataGridView1.CurrentRow.Cells["productoDesc"].Value.ToString();
                cantidad = dataGridView1.CurrentRow.Cells["productoCantidad"].Value.ToString();
                precioCompra = dataGridView1.CurrentRow.Cells["productoPrecioCompra"].Value.ToString();
                precioVenta = dataGridView1.CurrentRow.Cells["productoPrecioVenta"].Value.ToString();
               
                productoId = dataGridView1.CurrentRow.Cells["productoId"].Value.ToString();
                idAux = int.Parse(productoId);
                cantidadAux = int.Parse(cantidad);
                precioVaux = float.Parse(precioVenta);
                precioCaux = float.Parse(precioCompra);


                if (s.ModificarStock(idAux, codigo, nombre, tipo, descripcion, cantidadAux, precioCaux, precioVaux) == true)
                {
                    MessageBox.Show("La modificacion se realizo con exito");
                }
                else
                {
                    MessageBox.Show("La modificacion no se pudo realizar");
                }
                DataSet DS = new DataSet();
                s = new Stock();
                DS = s.MostrarStock();
                dataGridView1.DataSource = DS.Tables[0];


            }
            else
            {
                MessageBox.Show("Seleccione la fila modificar");
            }

        }
    }
}

