using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FacturaVer : Form
    {
        public FacturaVer()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(objBitmap, 0, 0);
        }
        Bitmap memoryImage, objBitmap;
        private void buttonCerrarFactura_Click(object sender, EventArgs e)
        {
            




            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);

            PrintDialog printdlg = new PrintDialog();
            PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();

            // preview the assigned document or you can create a different previewButton for it
            printPrvDlg.Document = pd;
            printPrvDlg.ShowDialog(); // this shows the preview and then show the Printer Dlg below

            printdlg.Document = pd;

            if (printdlg.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }


        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        
            {
            Graphics myGraphics = this.CreateGraphics();

            //Calculo posiciones y tamaños absolutos

            Size s = new Size(800, 800);
            //Creo una imagen usando los parámetros de posició y tamaño absoluto
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            //Al gráfico le cargo el molde de la imagen
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);

            memoryGraphics.CopyFromScreen(800, 800, 0, 0, s);
            objBitmap = new Bitmap(memoryImage, new Size(500, 500));
            //printDocument1.Print();
            


            Single yPos = 0;
            Single leftMargin = e.MarginBounds.Left;
            Single topMargin = e.MarginBounds.Top;
            //Image img = Image.FromFile("logo.bmp");
            Rectangle logo = new Rectangle(40, 40, 50, 50);
            using (Font printFont = new Font("Arial", 20.0f))
            {
                e.Graphics.DrawImage(objBitmap, logo);
                e.Graphics.DrawString("Header", printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
            }
            using (SolidBrush blueBrush = new SolidBrush(Color.Black))
            {
                Rectangle rect = new Rectangle(100, 100, 500, 120);
                e.Graphics.FillRectangle(blueBrush, rect);
            }
        }

       
    }
}
