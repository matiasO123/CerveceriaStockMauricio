using CapaDominio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FacturaCrear : Form
    {
        // //// INICIADORES//////////////////////////////////////////////////////////////////


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
            
            dataGridView1.Visible = true;

            //Cargando los productos
            DataSet ddss = new DataSet();
            ddss = fact.FacturaEditarMostrarProductos(id);

            foreach (DataRow rowi in ddss.Tables[0].Rows)
            {
                dataGridView1.Rows.Add(rowi[0].ToString(), rowi[1].ToString(), rowi[2].ToString(), rowi[3].ToString(), rowi[4].ToString());
            }

            //Cargando los datos de la factura
            fact.FacturaEditarMostrarFactura(id);
            



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
            buttonAgregarProducto.Visible = true;
           


        }


        private int id;
        private int idFactura = 0;

        private void Factura_Load(object sender, EventArgs e)
        {
            DataGridLlenar();
            textBox3.Focus();


            //Si es una factura que se está editando
            if (idFactura != 0)
            {
                int contador = 0;
                foreach (DataGridViewRow rowi in dataGridView1.Rows)
                {
                    int cuenta = int.Parse(rowi.Cells[3].Value.ToString()) * int.Parse(rowi.Cells[4].Value.ToString());
                    rowi.Cells["productoPrecioFin"].Value = cuenta;
                    contador = contador + cuenta;


                }

                labelPrecioFinalEntero.Text = contador.ToString();
            }

        }




        // ///Ventanita de productos/////////////////////////////////////////////////////////////////


        //Carga los datos en la ventanita de productos
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


        //Cerrar el panel de de productos
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            panelAgregarProd.Visible = false;
            textBox2.Text = "";
        }


        //filtra por nombre los productos para encontrarlos más fácil
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

        //Trae el producto seleccionado de la ventanita de productos al datagrid
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
            textBoxCantidad.Focus();
            textBox2.Text = "";
            
        }




        //// BOTONES //////////////////////////////////////////////////////////////////



        private void agregarProd_Click(object sender, EventArgs e)
        {
            panelAgregarProd.Visible = true;
            panelAgregarProd.BringToFront();
            DataGridLlenar();
            
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
            textBox3.Text = "";




            actualizarPrecioFinal();
            textBox3.Focus();



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
                    textoDescuento.Text = "0";
                    labelPrecioFinalEntero.Text = "";
                    //dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    buttonCrearFactura.Enabled = false;
                    textBox3.Focus();

                }
                
            }

            
        }
       
        private void buttonEliminarProducto_Click(object sender, EventArgs e)
        {
            DialogResult oDlgRes;

            oDlgRes = MessageBox.Show("¿Está seguro que querés eliminar el producto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (oDlgRes == DialogResult.Yes)
            {

                if (dataGridView1.SelectedRows.Count == 0)
                {

                    MessageBox.Show("Seleccioná un producto");

                }
                else
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        dataGridView1.Refresh();
                        actualizarPrecioFinal();

                    }

                }

            }
        }

        





        // EXCLUSIVO EDICIÓN


        //Para salvar los cambios tras una edición
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
                    fact.FacturaEditar(idFactura, nombre, fecha, descuento, total);
                    //idFactura = fact.FacturaProductoUltimoID();
                    fact.EditarEliminarProductosFactura(idFactura);
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        fact.ProductoAgregar(idFactura, fila.Cells[0].Value.ToString(), fila.Cells[3].Value.ToString(), fila.Cells[4].Value.ToString());
                        

                    }
                    MessageBox.Show("Factura Editada");
                    this.Dispose();
                    this.Close();



                }
                else
                {
                    MessageBox.Show("Hubo en error en la carga de datos");
                }

            }
        }

        //Cerrar factura en modo 'Edición'
        private void buttonCerrarFactura_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        //Creo que no sirve...
        private void buttonAgregarProductoEditar_Click(object sender, EventArgs e)
        {
            /*DataGridViewRow row = new DataGridViewRow();
            this.dataGridView1.Rows.Add(id, textoProducto.Text, textoUnidad.Text, textBoxCantidad.Text, labelPrecio.Text, labelPrecioTotal.Text);



            textoProducto.Text = "";
            labelPrecio.Text = "";
            textoUnidad.Text = "";
            textBoxCantidad.Text = "";
            labelPrecioTotal.Text = "";
            buttonAgregarProducto.Enabled = false;

            actualizarPrecioFinal();*/
        }







        // ///// MANEJADORES DE EVENTOS/////////////////////////////////////////////////////////////////////////////



        public void actualizarPrecioFinal()
        {
            int contador = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if(fila.Cells["productoPrecioFin"].Value != null)
                {
                    contador = contador + Int32.Parse(fila.Cells["productoPrecioFin"].Value.ToString());  
                }
                 
            }
            if (Int32.TryParse(textoDescuento.Text, out int descuento))
            {
                contador = contador - descuento;
            }

            labelPrecioFinalEntero.Text = contador.ToString();
        }


        //Cambio en el descuento
        private void actualizarPrecioFinal(object sender, EventArgs e)
        {
            actualizarPrecioFinal();
        }

        //Si cambio la cantidad comprada, cambia el valor final
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
            else if ((int.TryParse(textBoxCantidad.Text, out cantidad)) && (labelPrecio.Text == ""))
            {
                labelPrecioTotal.Text = "0";
            }
            else
            {
                labelPrecioTotal.Text = "0";
            }
        }









        //OTROS
        //Cuando se carga el código de barras
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if(textBox3.Text != "")
            {
                DataSet ddtt = new DataSet();
                Producto prod = new Producto();
                ddtt = prod.MostrarUnProducto(textBox3.Text);
                if ((ddtt.Tables.Count > 0) && (ddtt.Tables[0].Rows.Count > 0))
                {
                    textoProducto.Text = ddtt.Tables[0].Rows[0]["productoNombre"].ToString();
                    textoUnidad.Text = ddtt.Tables[0].Rows[0]["productoUnidadMedida"].ToString();
                    labelPrecio.Text = ddtt.Tables[0].Rows[0]["productoPrecioVenta"].ToString();
                    id = int.Parse(ddtt.Tables[0].Rows[0]["productoId"].ToString());

                    textBoxCantidad.Text = "1";
                    panelAgregarProd.Visible = false;
                    buttonAgregarProducto.Enabled = true;

                    buttonCrearFactura.Enabled = true;

                    textBoxCantidad.Focus();
                    textBox2.Text = "";

                }
            }
            



        }
    }
}
