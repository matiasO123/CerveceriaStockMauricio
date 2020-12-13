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
    public partial class ABMStock : Form
    {

        int idBolsonGlobal = -1;
        DataSet DS = new DataSet();
        public ABMStock()
        {
            InitializeComponent();
            
        }

        private void ABMStock_Load(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            Stock stock = new Stock();
            DS = stock.MostrarProductoTipo();
            //Agrega el tipo de producto
            /*foreach (DataRow row in DS.Tables[0].Rows)
            {
                comboBoxTipo.Items.Add(row["tipoNombre"].ToString());
            }*/
            DS.Clear();


            DataGridLlenar();
        }

        private void DataGridLlenar()
        {
            //Configurando DataGrid
            DataSet DS = new DataSet();

            Stock stock = new Stock();
            DS = stock.MostrarStock();
            dataGridView2.DataSource = DS.Tables[0];
            dataGridView2.Columns["bolsonId"].Visible = false;
            dataGridView2.Columns[1].HeaderCell.Value = "Nombre";
            dataGridView2.Columns[2].HeaderCell.Value = "Unidad de medida";
            dataGridView2.Columns[3].HeaderCell.Value = "Tipo";
            dataGridView2.Columns[4].HeaderCell.Value = "Cantidad";
            dataGridView2.Columns[5].HeaderCell.Value = "P. Compra";

        }

        private void VaciarCampos()
        {
            textBoxNom.Text = "";
            comboBoxNuevo.Text = "";
            textBoxUnidad.Text = "";
            textBoxCantidad.Text = "";
            textBoxPcompra.Text = "";
        }

        //ABRE PANEL DE AGREGAR BOLSON
        private void botonAgregar_Click(object sender, EventArgs e)
        {
            panelNuevoBolson.Visible = true;
            panelNuevoBolson.BringToFront();
            BtnAgregar.Visible = true;
            BtnGuardar.Visible = false;
            DataSet DS = new DataSet();
            textBoxNom.Text = "";
            comboBoxNuevo.SelectedIndex = -1;
            textBoxUnidad.Text = "";
            textBoxCantidad.Text = "";
            textBoxPcompra.Text = "";





            Stock stock = new Stock();
            DS = stock.MostrarProductoTipo();

            comboBoxNuevo.Items.Clear();
            //Agrega el tipo de producto
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                comboBoxNuevo.Items.Add(row["tipoNombre"].ToString());
            }
            DS.Clear();
        }

        //ELIMINAR PRODUCTO CON MESSAGEBOX si-no-cancelar
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult oDlgRes;

            oDlgRes = MessageBox.Show("¿Está seguro que desea eliminar el producto seleccionado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (oDlgRes == DialogResult.Yes)
            {

                if (dataGridView2.SelectedRows.Count == 0)
                {

                    MessageBox.Show("Para eliminar el registro debes seleccionar un producto");

                }
                else
                {
                    if (dataGridView2.SelectedRows.Count > 0)
                    {
                        string Id;
                        int IdAux;
                        Id = dataGridView2.CurrentRow.Cells["bolsonId"].Value.ToString();
                        IdAux = int.Parse(Id);
                        Stock stock = new Stock();
                        if (stock.EliminarBolson(IdAux) == true)
                        {
                            MessageBox.Show("El producto se eliminó correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("El producto no se pudo eliminar");
                        }
                        DataSet DS = new DataSet();
                        stock = new Stock();
                        DS = stock.MostrarStock();
                        dataGridView2.DataSource = DS.Tables[0];


                    }

                }

            }
        }

        //EDITAR BOLSON
        

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre, tipo, unidad, cantidad, precioCompra;


            nombre = textBoxNom.Text;
            tipo = comboBoxNuevo.Text;
            unidad = textBoxUnidad.Text;            
            cantidad = textBoxCantidad.Text;
            precioCompra = textBoxPcompra.Text;

            Stock stock = new Stock();
            if (stock.BolsonValidar(nombre, tipo, unidad, cantidad, precioCompra))
            {
                long cantidadEntero = long.Parse(cantidad);
                int precioCompraEntero = int.Parse(precioCompra);


                if (stock.AgregarBolson(nombre, unidad, tipo, cantidadEntero, precioCompraEntero) == true)
                {
                    MessageBox.Show("Se creo el nuevo producto con éxito");


                    DataGridLlenar();
                    panelNuevoBolson.Visible = false;

                    VaciarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el producto");
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            Stock stock = new Stock();
            string nombre = textBoxNom.Text;
            string unidad = textBoxUnidad.Text;
            string tipo = comboBoxNuevo.Text;            
            string cantidad = textBoxCantidad.Text;
            string precioCompra = textBoxPcompra.Text;
            string bolsonId;
            int idAux, cantidadAux;
            float precioCaux;

            bolsonId = dataGridView2.CurrentRow.Cells["bolsonId"].Value.ToString();



            if (stock.BolsonValidar(nombre, tipo, unidad, cantidad, precioCompra) == true)
            {
                idAux = int.Parse(bolsonId);
                cantidadAux = int.Parse(cantidad);

                precioCaux = float.Parse(precioCompra);
                if (stock.ModificarBolson(idAux, nombre, unidad, tipo, cantidadAux, precioCaux) == true)
                {
                    MessageBox.Show("La modificacion se realizo con exito");
                }
                else
                {
                    MessageBox.Show("La modificacion no se pudo realizar");
                }

                //Vaciador de campos
                VaciarCampos();
                BtnGuardar.Enabled = false;
                panelNuevoBolson.Visible = false;
                DataGridLlenar();

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            panelNuevoBolson.Visible = false;
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            panelNuevoBolson.Visible = true;
            panelNuevoBolson.BringToFront();
            BtnAgregar.Visible = false;
            BtnGuardar.Visible = true;

            Stock stock = new Stock();
            //Toma el valor del id para traer el bolson
            int bolsonId = Int32.Parse(dataGridView2.SelectedRows[0].Cells["bolsonID"].Value.ToString());
            DataSet ddss = stock.MostrarUnBolson(bolsonId);
            DS = stock.MostrarProductoTipo();
            comboBoxNuevo.Items.Clear();
            //Agrega el tipo de producto
            foreach (DataRow row in DS.Tables[0].Rows)
            {
                comboBoxNuevo.Items.Add(row["tipoNombre"].ToString());
            }
            DS.Clear();


            textBoxNom.Text = Convert.ToString(ddss.Tables[0].Rows[0]["bolsonNombre"]);
            comboBoxNuevo.Text = Convert.ToString(ddss.Tables[0].Rows[0]["bolsonTipo"]);
            textBoxUnidad.Text = Convert.ToString(ddss.Tables[0].Rows[0]["bolsonUnidad"]);
            textBoxCantidad.Text = Convert.ToString(ddss.Tables[0].Rows[0]["bolsonCantidad"]);
            textBoxPcompra.Text = Convert.ToString(ddss.Tables[0].Rows[0]["bolsonPrecioCompra"]);


            idBolsonGlobal = Int32.Parse(Convert.ToString(ddss.Tables[0].Rows[0]["bolsonId"]));
        }
    }
}
