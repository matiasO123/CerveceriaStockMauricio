
namespace CapaPresentacion
{
    partial class FacturaVer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaVer));
            this.labelPrecioFinalEntero = new System.Windows.Forms.Label();
            this.labelPrecioFinal = new System.Windows.Forms.Label();
            this.textoDescuento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCerrarFactura = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.facturaFecha = new System.Windows.Forms.DateTimePicker();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoPrecioFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrecioFinalEntero
            // 
            this.labelPrecioFinalEntero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrecioFinalEntero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPrecioFinalEntero.Font = new System.Drawing.Font("Microsoft JhengHei Light", 25F);
            this.labelPrecioFinalEntero.Location = new System.Drawing.Point(815, 413);
            this.labelPrecioFinalEntero.Name = "labelPrecioFinalEntero";
            this.labelPrecioFinalEntero.Size = new System.Drawing.Size(119, 37);
            this.labelPrecioFinalEntero.TabIndex = 61;
            // 
            // labelPrecioFinal
            // 
            this.labelPrecioFinal.AutoSize = true;
            this.labelPrecioFinal.Font = new System.Drawing.Font("Microsoft JhengHei Light", 25F);
            this.labelPrecioFinal.Location = new System.Drawing.Point(719, 413);
            this.labelPrecioFinal.Name = "labelPrecioFinal";
            this.labelPrecioFinal.Size = new System.Drawing.Size(90, 43);
            this.labelPrecioFinal.TabIndex = 60;
            this.labelPrecioFinal.Text = "Final";
            // 
            // textoDescuento
            // 
            this.textoDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textoDescuento.BackColor = System.Drawing.Color.White;
            this.textoDescuento.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDescuento.Location = new System.Drawing.Point(815, 366);
            this.textoDescuento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textoDescuento.Name = "textoDescuento";
            this.textoDescuento.Size = new System.Drawing.Size(119, 25);
            this.textoDescuento.TabIndex = 57;
            this.textoDescuento.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label11.Location = new System.Drawing.Point(722, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 56;
            this.label11.Text = "Descuento";
            // 
            // buttonCerrarFactura
            // 
            this.buttonCerrarFactura.Location = new System.Drawing.Point(439, 431);
            this.buttonCerrarFactura.Name = "buttonCerrarFactura";
            this.buttonCerrarFactura.Size = new System.Drawing.Size(98, 34);
            this.buttonCerrarFactura.TabIndex = 55;
            this.buttonCerrarFactura.Text = "Cerrar Factura";
            this.buttonCerrarFactura.UseVisualStyleBackColor = true;
            this.buttonCerrarFactura.Click += new System.EventHandler(this.buttonCerrarFactura_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei Light", 30F);
            this.label10.Location = new System.Drawing.Point(856, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 50);
            this.label10.TabIndex = 46;
            // 
            // facturaFecha
            // 
            this.facturaFecha.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F);
            this.facturaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.facturaFecha.Location = new System.Drawing.Point(91, 145);
            this.facturaFecha.Name = "facturaFecha";
            this.facturaFecha.Size = new System.Drawing.Size(264, 25);
            this.facturaFecha.TabIndex = 43;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxNombre.BackColor = System.Drawing.Color.White;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(91, 100);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(264, 25);
            this.textBoxNombre.TabIndex = 42;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoId,
            this.productoNombre,
            this.UnidadMedida,
            this.productoCantidad,
            this.productoPrecio,
            this.productoPrecioFin});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(361, 83);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(573, 265);
            this.dataGridView1.TabIndex = 39;
            // 
            // ProductoId
            // 
            this.ProductoId.HeaderText = "productoId";
            this.ProductoId.Name = "ProductoId";
            this.ProductoId.Visible = false;
            // 
            // productoNombre
            // 
            this.productoNombre.HeaderText = "Nombre Producto";
            this.productoNombre.Name = "productoNombre";
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.HeaderText = "Cantidad x bulto";
            this.UnidadMedida.Name = "UnidadMedida";
            // 
            // productoCantidad
            // 
            this.productoCantidad.HeaderText = "Cant. bultos";
            this.productoCantidad.Name = "productoCantidad";
            // 
            // productoPrecio
            // 
            this.productoPrecio.HeaderText = "Precio X Bulto";
            this.productoPrecio.Name = "productoPrecio";
            // 
            // productoPrecioFin
            // 
            this.productoPrecioFin.HeaderText = "Precio Total";
            this.productoPrecioFin.Name = "productoPrecioFin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label4.Location = new System.Drawing.Point(10, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Cliente";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FacturaVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 475);
            this.Controls.Add(this.labelPrecioFinalEntero);
            this.Controls.Add(this.labelPrecioFinal);
            this.Controls.Add(this.textoDescuento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonCerrarFactura);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.facturaFecha);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturaVer";
            this.Text = "ABMFacturaLista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPrecioFinalEntero;
        private System.Windows.Forms.Label labelPrecioFinal;
        private System.Windows.Forms.TextBox textoDescuento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonCerrarFactura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker facturaFecha;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoPrecioFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}