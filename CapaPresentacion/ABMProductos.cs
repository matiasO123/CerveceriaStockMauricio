using CapaDominio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ABMProductos : Form
    {

        int idProductoGlobal = -1;
        DataSet DS = new DataSet();
        
        public ABMProductos()
        {
            InitializeComponent();
            
        }

        private void ABMInicial_Load(object sender, EventArgs e)
        {



            //Configurando controles
            textBoxNombre.Visible = false;
            //comboBoxProveedor.Visible = false;

            //comboBoxProveedor.Items.Insert(0, "");

            //comboBoxProveedor.SelectedIndex = 0;
            comboBoxTipo.Items.Insert(0, "");
            comboBoxTipo.SelectedIndex = 0;
           

            panelNuevoProducto.Visible = false;
            DataSet DS = new DataSet();
            Producto producto = new Producto();
            DS = producto.MostrarProductoTipo();
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

            Producto producto = new Producto();
            DS = producto.MostrarProducto();
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Columns["productoId"].Visible = false;
            dataGridView1.Columns["productoCantidad"].Visible = false;
            dataGridView1.Columns[1].HeaderCell.Value = "Nombre";
            dataGridView1.Columns[2].HeaderCell.Value = "Unidad de medida";
            dataGridView1.Columns[3].HeaderCell.Value = "Tipo";
            dataGridView1.Columns[4].HeaderCell.Value = "Descripción";
            dataGridView1.Columns[6].HeaderCell.Value = "P. Venta";
            //dataGridView1.Columns.Add("Precio Total", "Precio Total");




        }

        



        //BOTONES DEL ABM DE PRODUCTOS
        private void botonBuscar_Click(object sender, EventArgs e)
                {
                    DataSet DS = new DataSet();
                    Producto producto = new Producto();
                    DS = producto.MostrarProductoFiltro(textBoxNombre.Text, comboBoxTipo.Text);
                    textBoxNombre.Visible = true;
                    //comboBoxProveedor.Visible = true;
                    comboBoxTipo.Visible = true;
                    labelBusquedaNombre.Visible = true;
                    labelBusquedaTipo.Visible = true;
                    //labelBusquedaProveedor.Visible = true;

                }

        //ABRE PANEL DE AGREGAR PRODUCTO
        private void botonAgregar_Click(object sender, EventArgs e)
        {
            panelNuevoProducto.Visible = true;
            panelNuevoProducto.BringToFront();
            BtnAgregar.Enabled = true;
            botonGuardar.Enabled = false;
            DataSet DS = new DataSet();

            Producto producto = new Producto();
            DS = producto.MostrarProductoTipo();

            comboBoxNuevo.Items.Clear();
            //Agrega el tipo de producto
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                comboBoxNuevo.Items.Add(row["tipoNombre"].ToString());
            }
            DS.Clear();

            comboBoxUMedida.Items.Clear();
            DS = producto.MostrarUnidadMedida();
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                comboBoxUMedida.Items.Add(row["unidadMedidaNombre"].ToString());
            }

            

        }

        //AGREGA NUEVO PRODUCTO
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

                    VaciarCampos();
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
            //string proveedor = comboBoxProveedor.Text;
            

            DS = sto.MostrarProductoFiltro(nombre, tipo);
            //dataGridView1.DataSource = null;
            if(DS != null)
            {
                dataGridView1.DataSource = DS.Tables[0];
            }
            
        }

        private void botonLlenarTabla_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            comboBoxTipo.Text = "";
            DataGridLlenar();

        }

        //VACIA LOS CAMPOS

        private void VaciarCampos()
        {
            textBoxNom.Text = "";
            comboBoxNuevo.Text = "";
            textBoxDescripcion.Text = "";
            comboBoxUMedida.Text = "";
            textBoxCantidad.Text = "";
            textBoxPventa.Text = "";
        }








       //ELIMINAR PRODUCTO CON MESSAGEBOX si-no-cancelar
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult oDlgRes;

            oDlgRes = MessageBox.Show("¿Está seguro que querés eliminar el producto seleccionado? \n(Tené  en cuenta que la eliminación de los productos puede producir perdida de datos en las facturas ya realizadas)","Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

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

        //GUARDA CAMBIOS DEL PRODUCTO
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            
                Producto p = new Producto();
                string nombre = textBoxNom.Text;
                string unidad = comboBoxUMedida.Text;
                string tipo = comboBoxNuevo.Text;
                string descripcion = textBoxDescripcion.Text;
                string cantidad = textBoxCantidad.Text;
                string precioVenta = textBoxPventa.Text;
                string productoId;
                int idAux, cantidadAux;
                float precioVaux;

                
                /*nombre = dataGridView1.CurrentRow.Cells["productoNombre"].Value.ToString();
                unidad = dataGridView1.CurrentRow.Cells["productoUnidadMedida"].Value.ToString();
                tipo = dataGridView1.CurrentRow.Cells["productoTipo"].Value.ToString();
                descripcion = dataGridView1.CurrentRow.Cells["productoDesc"].Value.ToString();
                cantidad = dataGridView1.CurrentRow.Cells["productoCantidad"].Value.ToString();
                precioVenta = dataGridView1.CurrentRow.Cells["productoPrecioVenta"].Value.ToString(); */                         
               
                productoId = dataGridView1.CurrentRow.Cells["productoId"].Value.ToString();
                


                if (p.ProductoValidar(nombre, tipo, unidad, cantidad, precioVenta) == true)
                {
                    idAux = int.Parse(productoId);
                    cantidadAux = int.Parse(cantidad);

                    precioVaux = float.Parse(precioVenta);
                    if(p.ModificarProducto(idAux, nombre, unidad, tipo, descripcion, cantidadAux, precioVaux) == true)
                    {
                    MessageBox.Show("La modificacion se realizo con exito");
                    }
                    else
                    {
                    MessageBox.Show("La modificacion no se pudo realizar");
                    }

                    //Vaciador de campos
                    VaciarCampos();
                    botonGuardar.Enabled = false;
                    panelNuevoProducto.Visible = false;
                    DataGridLlenar();

                }

            
           
                
                /*DataSet DS = new DataSet();
                p = new Producto();
                DS = p.MostrarProducto();
                dataGridView1.DataSource = DS.Tables[0];*/



        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DialogResult oDlgRes;

            oDlgRes = MessageBox.Show("¿Estás seguro que querés editar el producto seleccionado? \n(Tené  en cuenta que la edición de los productos puede producir confusión de datos en las facturas ya realizadas)", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (oDlgRes == DialogResult.Yes)
            {

                panelNuevoProducto.Visible = true;
                panelNuevoProducto.BringToFront();
                BtnAgregar.Enabled = false;
                botonGuardar.Enabled = true;

                Producto producto = new Producto();
                //Toma el valor del id para traer el producto
                int productoId = Int32.Parse(dataGridView1.SelectedRows[0].Cells["productoId"].Value.ToString());
                DataSet ddss = producto.MostrarUnProducto(productoId);
                DS = producto.MostrarProductoTipo();
                comboBoxNuevo.Items.Clear();
                //Agrega el tipo de producto
                foreach (DataRow row in DS.Tables[0].Rows)
                {
                    comboBoxNuevo.Items.Add(row["tipoNombre"].ToString());
                }
                DS.Clear();

                comboBoxUMedida.Items.Clear();
                DS = producto.MostrarUnidadMedida();
                foreach (DataRow row in DS.Tables[0].Rows)
                {
                    comboBoxUMedida.Items.Add(row["unidadMedidaNombre"].ToString());
                }




                textBoxNom.Text = Convert.ToString(ddss.Tables[0].Rows[0]["productoNombre"]);
                comboBoxNuevo.Text = Convert.ToString(ddss.Tables[0].Rows[0]["productoTipo"]);
                textBoxDescripcion.Text = Convert.ToString(ddss.Tables[0].Rows[0]["productoDesc"]);
                comboBoxUMedida.Text = Convert.ToString(ddss.Tables[0].Rows[0]["productoUnidadMedida"]);
                textBoxCantidad.Text = Convert.ToString(ddss.Tables[0].Rows[0]["productoCantidad"]);
                textBoxPventa.Text = Convert.ToString(ddss.Tables[0].Rows[0]["productoPrecioVenta"]);


                idProductoGlobal = Int32.Parse(Convert.ToString(ddss.Tables[0].Rows[0]["productoId"]));
            }
        }

        ///////////////IMPRIMIRRRRRRRR\\\\\\\\\\\\\

        /*private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }


        Bitmap bmp;
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }*/
    }
}

