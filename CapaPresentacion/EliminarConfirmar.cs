using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class EliminarConfirmar : Form
    {
        public EliminarConfirmar()
        {
            InitializeComponent();
        }

        bool eliminar = false;

        public bool Eliminar { get => eliminar; set => eliminar = value; }

        private void button2_Click(object sender, EventArgs e)
        {
            Eliminar = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
