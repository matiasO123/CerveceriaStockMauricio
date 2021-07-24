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
        string filaSeleccionada = "0";
        
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
            GuardarFilaSeleccionada();
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
            dataGridView1.Columns[7].HeaderCell.Value = "Còd. barras";
            //dataGridView1.Columns.Add("Precio Total", "Precio Total");
            IrAFilaSeleccionada();



        }

        //Toma el valor de la fila seleccionada, antes de actualizar la tabla
        private void GuardarFilaSeleccionada()
        {
            // si hay filas seleccionadas
            if(dataGridView1.SelectedRows.Count > 0)
            {
                //Si hay más de una fila seleccionada, toma la de menor número y trabaja con esa
                if(dataGridView1.SelectedRows.Count > 1)
                {
                    int contador = 0;
                    foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if(contador == 0)
                        {
                            contador = int.Parse(row.Cells["productoId"].Value.ToString());

                        }
                        else
                        {
                            if(int.Parse(row.Cells["productoId"].Value.ToString()) < contador)
                            {
                                contador = int.Parse(row.Cells["productoId"].Value.ToString());
                            }
                        }
                    }

                    filaSeleccionada = contador.ToString();
                    
                }

                //Sólo una fila seleccionada
                else
                {
                    filaSeleccionada = dataGridView1.SelectedRows[0].Cells["productoId"].Value.ToString();
                }
            }
        }

        //Pone el foco de la tabla en la fila seleccionada(va después de actualizar la tabla)
        private void IrAFilaSeleccionada()
        {
            int filaElegida = 0;
            bool terminar = false;
            int filaElegidaAux = 0;
            if(filaSeleccionada != "0")
            {
                int filasTotales = dataGridView1.Rows.Count;
                while((terminar == false) && (filasTotales >= filaElegidaAux))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["productoId"].Value.ToString() == filaSeleccionada)
                        {
                            filaElegida = row.Index;
                            terminar = true;
                        }
                    }
                    if (filaElegida == 0)
                    {
                        filaSeleccionada = ((int.Parse(filaSeleccionada)) + 1).ToString();
                        filaElegidaAux++;
                    }

                }
                if(filaElegidaAux > filasTotales)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[filasTotales-1].Cells[1];
                }
                else
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[filaElegida].Cells[1];
                }

                

                
            }
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
            textBoxNom.Text = "";
            comboBoxNuevo.Text = "";
            textBoxDescripcion.Text = "";
            comboBoxUMedida.SelectedIndex = -1;
            textBoxCantidad.Text = "";
            textBoxPventa.Text = "";
            textBoxCodigoBarras.Text = "";

            /*comboBoxUMedida.Items.Clear();
            DS = producto.MostrarUnidadMedida();
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                comboBoxUMedida.Items.Add(row["unidadMedidaNombre"].ToString());
            }*/



        }

        //AGREGA NUEVO PRODUCTO
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string  nombre, tipo, descripcion, unidadMedida, cantidad, precioVenta, productoCodBarras;


            nombre = textBoxNom.Text;
            tipo = comboBoxNuevo.Text;
            descripcion = textBoxDescripcion.Text;
            unidadMedida = comboBoxUMedida.Text;
            cantidad = textBoxCantidad.Text;
            precioVenta = textBoxPventa.Text;
            productoCodBarras = textBoxCodigoBarras.Text;

            Producto producto = new Producto();
            if (producto.ProductoValidar(nombre, tipo, unidadMedida, cantidad, precioVenta))
            {
                long cantidadEntero = long.Parse(cantidad);
                int precioVentaEntero = int.Parse(precioVenta);
               

                if (producto.AgregarProducto(nombre, unidadMedida, tipo, descripcion, cantidadEntero, precioVentaEntero, productoCodBarras) == true)
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
                    if ((dataGridView1.SelectedRows.Count > 0) && (dataGridView1.SelectedRows.Count < 2))
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
                        /*DataSet DS = new DataSet();
                        p = new Producto();
                        DS = p.MostrarProducto();
                        dataGridView1.DataSource = DS.Tables[0];*/
                        DataGridLlenar();


                    }
                    else
                    {
                        MessageBox.Show("Elegì de a un producto a la vez!");
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
                string codBarras = textBoxCodigoBarras.Text;
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
                    if(p.ModificarProducto(idAux, nombre, unidad, tipo, descripcion, cantidadAux, precioVaux, codBarras) == true)
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

        //EDITAR - ABRE PANEL Y TRAE LOS DATOS ACTUALES
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //Pregunto si està seguro de querer editar los elementos
            DialogResult oDlgRes;

            oDlgRes = MessageBox.Show("¿Estás seguro que querés editar el producto seleccionado? \n(Tené  en cuenta que la edición de los productos puede producir confusión de datos en las facturas ya realizadas)", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (oDlgRes == DialogResult.Yes)
            {
                //Si hay filas seleccionadas...
                if(dataGridView1.SelectedRows.Count > 0 )
                {
                    
                    //Si hay sòlo una fila seleccionada, hace lo de siempre
                    if(dataGridView1.SelectedRows.Count < 2)
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

                        /*if (1 == 2){
                            comboBoxUMedida.Items.Clear();
                        }*/
                        
                        /*DS = producto.MostrarUnidadMedida();
                        foreach (DataRow row in DS.Tables[0].Rows)
                        {
                            comboBoxUMedida.Items.Add(row["unidadMedidaNombre"].ToString());
                        }*/




                        textBoxNom.Text = Convert.ToString(ddss.Tables[0].Rows[0]["productoNombre"]);
                        comboBoxNuevo.Text = Convert.ToString(ddss.Tables[0].Rows[0]["productoTipo"]);
                        textBoxDescripcion.Text = Convert.ToString(ddss.Tables[0].Rows[0]["productoDesc"]);
                        comboBoxUMedida.Text = Convert.ToString(ddss.Tables[0].Rows[0]["productoUnidadMedida"]);
                        textBoxCantidad.Text = Convert.ToString(ddss.Tables[0].Rows[0]["productoCantidad"]);
                        textBoxPventa.Text = Convert.ToString(ddss.Tables[0].Rows[0]["productoPrecioVenta"]);
                        textBoxCodigoBarras.Text = Convert.ToString(ddss.Tables[0].Rows[0]["productoCodBarras"]);


                        idProductoGlobal = Int32.Parse(Convert.ToString(ddss.Tables[0].Rows[0]["productoId"]));
                    }

                    else
                    {
                        PanelAumentoMultipleMarco.Visible = true;
                        PanelAumentoMultipleMarco.BringToFront();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Seleccionà alguna fila!");
                }
                
                
                
                
                
                
                
                
               
            }
        }

        
        
        
        
        

        //PANEL DE AUMENTOS MÙLTIPLES
        
        private void buttonCancelarAumentoMultiple_Click(object sender, EventArgs e)
        {
            PanelAumentoMultipleMarco.Visible = false;

        }

        private void buttonAceptarAumentoMultiple_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBoxAumentoPorcentaje.Text, out int porcentaje))
            {
                if(porcentaje != 0)
                {
                   
                    Decimal porcentajeDecimal = (Decimal.Parse(textBoxAumentoPorcentaje.Text)/100) + 1;
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        //Calculo el precio
                        int nuevoPrecio = Decimal.ToInt32(int.Parse(row.Cells["productoPrecioVenta"].Value.ToString()) * porcentajeDecimal);

                        //int.Parse(row.Cells["productoPrecioVenta"].Value.ToString()) * (porcentaje / 100);
                        
                        //Modifico la base de datos
                        Producto prod = new Producto();
                        prod.ModificarProductoSoloPrecio(int.Parse(row.Cells["productoId"].Value.ToString()), nuevoPrecio);
                    }
                    MessageBox.Show("Precios de productos modificados!");
                    PanelAumentoMultipleMarco.Visible = false;
                    textBoxAumentoPorcentaje.Text = "0";
                    DataGridLlenar();
                }
                else
                {
                    MessageBox.Show("El porcentaje de aumento no puede ser cero");
                }
                
            }
            else
            {
                MessageBox.Show("El porcentaje de aumento debe ser un número entero");
            }     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImprimirProducto imp = new ImprimirProducto();
            imp.ShowDialog();
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

