using System;
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
