using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominio;

namespace CapaPresentacion
{
    public partial class FacturaLista : Form
    {
        public FacturaLista()
        {
            InitializeComponent();
        }

        private void FacturaLista_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void LlenarGrid()
        {
            Factura fact = new Factura();
            dataGridView1.DataSource = fact.FacturaMostrar().Tables[0];
            panel1.Visible = false;
            dataGridView1.Columns[0].HeaderText = "Nro";
            dataGridView1.Columns[1].HeaderCell.Value = "Cliente";
            dataGridView1.Columns[2].HeaderCell.Value = "Fecha";
            dataGridView1.Columns[3].HeaderCell.Value = "Descuento";
            dataGridView1.Columns[4].HeaderCell.Value = "Precio final";

        }


        //ABRE PANEL CON LOS DETALLES DE LA FACTURA
        private void botonVerFactura_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();

            Int32 selectedRowCount =
        dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                textBoxNombre.Text = dataGridView1.SelectedRows[0].Cells["facturaNombre"].Value.ToString();
                textoDescuento.Text = dataGridView1.SelectedRows[0].Cells["facturaDescuento"].Value.ToString();
                facturaFecha.Text = dataGridView1.SelectedRows[0].Cells["facturaFecha"].Value.ToString();
                int value = int.Parse(dataGridView1.SelectedRows[0].Cells["facturaTotal"].Value.ToString());
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                // Displays the same value with a blank as the separator.
                nfi.CurrencyGroupSeparator = ".";
                labelPrecioFinalEntero.Text = value.ToString("C0", nfi);
                
                DataSet DDSS = new DataSet();
                Factura fact = new Factura();

                dataGridView2.DataSource = fact.FacturaProductosMostrar(int.Parse(dataGridView1.SelectedRows[0].Cells["facturaID"].Value.ToString())).Tables[0];
                dataGridView2.Columns[0].HeaderText = "Producto";

                dataGridView2.Columns[1].HeaderCell.Value = "Cantidad x bulto";
                dataGridView2.Columns[2].HeaderCell.Value = "Cantidad de bultos";
                dataGridView2.Columns[3].HeaderCell.Value = "Precio x bulto";
                dataGridView2.Columns.Add("Precio Total", "Precio Total");

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {

                    row.Cells["Precio Total"].Value = (int.Parse(row.Cells["productoCantidad"].Value.ToString())) * (int.Parse(row.Cells["productoPrecioUnitario"].Value.ToString()));


                }

            }
        }

        private void buttonCerrarFactura_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }



        private void botonEliminar_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
        dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                if (MessageBox.Show("Estás seguro de eliminar esta factura?", "Tender Amount",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Factura fact = new Factura();
                    fact.FacturaEliminar(int.Parse(dataGridView1.SelectedRows[0].Cells["facturaID"].Value.ToString()));
                    LlenarGrid();
                }



            }
        }
        Bitmap bitmap;
        Bitmap memoryImage;
        Bitmap objBitmap;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           //Acá va el margen
            //e.Graphics.DrawImage(objBitmap, 0, 0);

        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
           
            buttonCerrarFactura.Visible = false;
            buttonImprimir.Visible = false;

            CaptureScreen();
            printDocument1.Print();
            buttonCerrarFactura.Visible = true;
            buttonImprimir.Visible = true;

        }

        private void CaptureScreen()
        {
            //Creo un gráfico
            Graphics myGraphics = this.CreateGraphics();

            //Calculo posiciones y tamaños absolutos
            Point startPoint = panel1.PointToScreen(new Point());
            Point endPoint = puntoFinal.PointToScreen(new Point());
            int ancho = endPoint.X - startPoint.X;
            int alto = endPoint.Y - startPoint.Y;
            Size s = new Size(ancho, alto);
            //Creo una imagen usando los parámetros de posició y tamaño absoluto
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            //Al gráfico le cargo el molde de la imagen
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            
            memoryGraphics.CopyFromScreen(startPoint.X, startPoint.Y, 0, 0, s);
            objBitmap = new Bitmap(memoryImage, new Size(750, alto));
            





        }*/
        int alto;
        private void button1_Click(object sender, EventArgs e)
        {
            buttonCerrarFactura.Visible = false;
            buttonImprimir.Visible = false;
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);



            
            //Creo un gráfico
            Graphics myGraphics = this.CreateGraphics();

            //Calculo posiciones y tamaños absolutos
            Point startPoint = panel1.PointToScreen(new Point());
            Point endPoint = puntoFinal.PointToScreen(new Point());
            int ancho = endPoint.X - startPoint.X;
            alto = endPoint.Y - startPoint.Y;
            Size s = new Size(ancho, alto);
            //Creo una imagen usando los parámetros de posició y tamaño absoluto
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            //Al gráfico le cargo el molde de la imagen
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);

            memoryGraphics.CopyFromScreen(startPoint.X, startPoint.Y, 0, 0, s);
            objBitmap = new Bitmap(memoryImage, new Size(750, alto));




            PrintDialog printdlg = new PrintDialog();
            PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();

            // preview the assigned document or you can create a different previewButton for it
            printPrvDlg.Document = pd;
            
            
            printdlg.Document = pd;
            printPrvDlg.ShowDialog();
            if (printdlg.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
            buttonCerrarFactura.Visible = true;
            buttonImprimir.Visible = true;
        }


        private void pd_PrintPage(object sender, PrintPageEventArgs e)

        {
            
            Rectangle logo = new Rectangle(0, 0, 750, alto);
            e.Graphics.DrawImage(objBitmap, 0,0);

            /*Single yPos = 0;
            Single leftMargin = e.MarginBounds.Left;
            Single topMargin = e.MarginBounds.Top;*/
            //Image img = Image.FromFile("logo.bmp");
            
            /*using (Font printFont = new Font("Arial", 20.0f))
            {
                e.Graphics.DrawImage(objBitmap, logo);
                e.Graphics.DrawString("Header", printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
            }
            using (SolidBrush blueBrush = new SolidBrush(Color.Black))
            {
                Rectangle rect = new Rectangle(100, 100, 500, 120);
                e.Graphics.FillRectangle(blueBrush, rect);
            }*/
            
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarConfirmar ec = new EliminarConfirmar();
            ec.ShowDialog();
            if (ec.Eliminar)
            {
                Factura fact = new Factura();
                fact.FacturaEliminar(int.Parse(dataGridView1.SelectedRows[0].Cells["facturaID"].Value.ToString()));
            }
            ec.Dispose();
            ec.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            FacturaCrear fc = new FacturaCrear(int.Parse(dataGridView1.SelectedRows[0].Cells["facturaID"].Value.ToString()));
            fc.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
