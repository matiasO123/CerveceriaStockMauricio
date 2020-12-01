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
    public partial class ABMProductos : Form
    {


        DataSet DS = new DataSet();        
        
        public ABMProductos()
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
            Producto stock = new Producto();
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

            Producto stock = new Producto();
            DS = stock.MostrarProducto();
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Columns["productoId"].Visible = false;
            dataGridView1.Columns["productoPrecioVenta"].Visible = false;
            
        }

        



        //BOTONES DEL ABM DE PRODUCTOS
        private void botonBuscar_Click(object sender, EventArgs e)
                {
                    DataSet DS = new DataSet();
                    Producto stock = new Producto();
                    DS = stock.MostrarProductoFiltro(textBoxNombre.Text, comboBoxTipo.Text, comboBoxProveedor.Text);
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
            Producto stock = new Producto();
            DS = stock.MostrarProductoTipo();
            comboBoxNuevo.Items.Clear();
            //Agrega el tipo de producto
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                comboBoxNuevo.Items.Add(row["tipoNombre"].ToString());
            }
            DS.Clear();

            comboBoxUMedida.Items.Clear();
            DS = stock.MostrarUnidadMedida();
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                comboBoxUMedida.Items.Add(row["unidadMedidaNombre"].ToString());
            }

            

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string  nombre, tipo, descripcion, unidadMedida, cantidad, precioVenta;


            nombre = textBoxNom.Text;
            tipo = comboBoxNuevo.Text;
            descripcion = textBoxDescripcion.Text;
            unidadMedida = comboBoxUMedida.Text;
            cantidad = textBoxCantidad.Text;
            precioVenta = textBoxPventa.Text;
            
           

            Producto producto = new Producto();
            if (producto.ProductoValidar(nombre, tipo, unidadMedida, cantidad, precioVenta))
            {
                long cantidadEntero = long.Parse(cantidad);
                int precioVentaEntero = int.Parse(precioVenta);
               

                if (producto.AgregarProducto(nombre, unidadMedida, tipo, descripcion, cantidadEntero, precioVentaEntero) == true)
                {
                    MessageBox.Show("Se creo el nuevo producto con éxito");
                    

                    DataGridLlenar();
                    panelNuevoProducto.Visible = false;
                    textBoxNom.Text = "";
                    comboBoxNuevo.Text = "";
                    textBoxDescripcion.Text = "";
                    comboBoxUMedida.Text = "";
                    textBoxCantidad.Text = "";
                    textBoxPventa.Text = "";
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
            Producto sto = new Producto();
            string nombre  = textBoxNombre.Text;
            string tipo = comboBoxTipo.Text;
            string proveedor = comboBoxProveedor.Text;
            

            DS = sto.MostrarProductoFiltro(nombre, tipo, proveedor );
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
                        Producto p = new Producto();
                        if (p.EliminarProducto(IdAux) == true)
                        {
                            MessageBox.Show("El producto se eliminó correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("El producto no se pudo eliminar");
                        }
                        DataSet DS = new DataSet();
                        p = new Producto();
                        DS = p.MostrarProducto();
                        dataGridView1.DataSource = DS.Tables[0];


                    }
                    
                }

            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nombre, unidad, tipo, descripcion, cantidad, precioCompra, productoId;
                int idAux, cantidadAux;
                float precioCaux;


                Producto s = new Producto();
                
                nombre = dataGridView1.CurrentRow.Cells["productoNombre"].Value.ToString();
                unidad = dataGridView1.CurrentRow.Cells["productoUnidadMedida"].Value.ToString();
                tipo = dataGridView1.CurrentRow.Cells["productoTipo"].Value.ToString();
                descripcion = dataGridView1.CurrentRow.Cells["productoDesc"].Value.ToString();
                cantidad = dataGridView1.CurrentRow.Cells["productoCantidad"].Value.ToString();
                precioCompra = dataGridView1.CurrentRow.Cells["productoPrecioCompra"].Value.ToString();
                
               
                productoId = dataGridView1.CurrentRow.Cells["productoId"].Value.ToString();
                idAux = int.Parse(productoId);
                cantidadAux = int.Parse(cantidad);
                
                precioCaux = float.Parse(precioCompra);


                if (s.ModificarProducto(idAux, nombre, unidad, tipo, descripcion, cantidadAux, precioCaux) == true)
                {
                    MessageBox.Show("La modificacion se realizo con exito");
                }
                else
                {
                    MessageBox.Show("La modificacion no se pudo realizar");
                }
                DataSet DS = new DataSet();
                s = new Producto();
                DS = s.MostrarProducto();
                dataGridView1.DataSource = DS.Tables[0];


            }
            else
            {
                MessageBox.Show("Seleccione la fila modificar");
            }

        }
    }
}

