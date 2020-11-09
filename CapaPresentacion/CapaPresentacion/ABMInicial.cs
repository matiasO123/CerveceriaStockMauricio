using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAccesoDatos;

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

            //Configurando DataGrid
            
            ConexionGeneral CG = new ConexionGeneral();
            CG.DBCreator();
            DS = CG.Consultor("");
            dataGridView1.DataSource = DS.Tables[0];
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
    }
}
