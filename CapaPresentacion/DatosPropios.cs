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
    public partial class DatosPropios : Form
    {
        public DatosPropios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatosPropio dp = new DatosPropio();
            dp.GuardarDatos(textBoxNombre.Text, textBoxDireccion.Text, textBoxTelefono.Text);
            this.Close();
            this.Dispose();
        }

        private void DatosPropios_Load(object sender, EventArgs e)
        {
            DatosPropio dp = new DatosPropio();
            DataSet DDSS = new DataSet();
            DDSS = dp.MostrarDatos();
            if(DDSS.Tables[0].Rows.Count > 0)
            {
                textBoxNombre.Text = DDSS.Tables[0].Rows[0]["proveedorNombre"].ToString();
                textBoxDireccion.Text = DDSS.Tables[0].Rows[0]["proveedorCuit"].ToString();
                textBoxTelefono.Text = DDSS.Tables[0].Rows[0]["proveedorDetalle"].ToString();
            }
            
        }
    }
}
