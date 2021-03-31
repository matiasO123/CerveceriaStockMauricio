using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AccesoDatos;


namespace CapaPresentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            
        }


        

        //abrir distintos formularios dentro del contenedor principal
        private void AbrirFormHija(object formHija)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f != this)
                {
                    f.Dispose();
                    f.Close();
                }

            }




            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ABMStock());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ABMProductos());
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            panelContenedor.Visible = true;
            AbrirFormHija(new FacturaCrear());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FacturaLista());
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {


            panelContenedor.BringToFront();
            panelMenu.BringToFront();


        }

        private void Principal_Load(object sender, EventArgs e)
        {
            ConexionGeneral CG = new ConexionGeneral();
            CG.DBCreator();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelContenedor.Visible = true;
            AbrirFormHija(new Finales());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Impresion imp = new Impresion(3);
            imp.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e, string _data, string _filename)
        {
           
                

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
