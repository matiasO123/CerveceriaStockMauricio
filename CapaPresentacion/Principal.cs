using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AccesoDatos;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

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
            CG.AgregarColumnaBarcode();
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


        
        private void button3_Click_1(object sender, EventArgs e)
        {
            /*string barcode = "* "+ "10" + " *";


            Bitmap bm = new Bitmap(barcode.Length * 40, 150);
            using (Graphics grap = Graphics.FromImage(bm))
            {
                Font oFont = new System.Drawing.Font("IDAutomationHC39M Free Version", 20);

                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                grap.FillRectangle(white, 0, 0, bm.Width, bm.Height);
                grap.DrawString(barcode, oFont, black, point);
            }


            using(MemoryStream ms = new MemoryStream())
            {
                bm.Save(ms, ImageFormat.Png);
                pictureBox1.Image = bm;
                pictureBox1.Height = bm.Height;
                pictureBox1.Width = int.Parse((bm.Width * 1).ToString());
            }*/
           
        }
    }
}
