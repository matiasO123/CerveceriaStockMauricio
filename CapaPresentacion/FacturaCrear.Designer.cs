namespace CapaPresentacion
{
    partial class FacturaCrear
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoPrecioFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.facturaFecha = new System.Windows.Forms.DateTimePicker();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textoProducto = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panelAgregarProd = new System.Windows.Forms.Panel();
            this.textoUnidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAgregarProducto = new System.Windows.Forms.Button();
            this.buttonCrearFactura = new System.Windows.Forms.Button();
            this.buttonCerrarFactura = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textoDescuento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelPrecioTotal = new System.Windows.Forms.Label();
            this.labelPrecioFinal = new System.Windows.Forms.Label();
            this.labelPrecioFinalEntero = new System.Windows.Forms.Label();
            this.agregarProd = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelAgregarProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agregarProd)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei Light", 30F);
            this.label2.Location = new System.Drawing.Point(574, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label3.Location = new System.Drawing.Point(7, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label4.Location = new System.Drawing.Point(7, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(380, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(558, 265);
            this.dataGridView1.TabIndex = 4;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label7.Location = new System.Drawing.Point(7, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label5.Location = new System.Drawing.Point(7, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio U.";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.White;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(88, 27);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(264, 25);
            this.textBoxNombre.TabIndex = 8;
            // 
            // facturaFecha
            // 
            this.facturaFecha.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F);
            this.facturaFecha.Location = new System.Drawing.Point(88, 72);
            this.facturaFecha.Name = "facturaFecha";
            this.facturaFecha.Size = new System.Drawing.Size(264, 25);
            this.facturaFecha.TabIndex = 10;
            // 
            // labelPrecio
            // 
            this.labelPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.labelPrecio.Location = new System.Drawing.Point(88, 212);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(63, 22);
            this.labelPrecio.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label9.Location = new System.Drawing.Point(631, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Descuento";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(724, 363);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 26);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei Light", 30F);
            this.label10.Location = new System.Drawing.Point(856, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 50);
            this.label10.TabIndex = 19;
            // 
            // textoProducto
            // 
            this.textoProducto.BackColor = System.Drawing.Color.White;
            this.textoProducto.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoProducto.Location = new System.Drawing.Point(88, 115);
            this.textoProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textoProducto.Name = "textoProducto";
            this.textoProducto.Size = new System.Drawing.Size(221, 25);
            this.textoProducto.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft JhengHei Light", 24F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(213, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(296, 40);
            this.label17.TabIndex = 29;
            this.label17.Text = "Lista de productos";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(527, 367);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(154, 34);
            this.BtnCancelar.TabIndex = 50;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(355, 367);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(154, 34);
            this.BtnGuardar.TabIndex = 51;
            this.BtnGuardar.Text = "Aceptar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView2.Location = new System.Drawing.Point(34, 88);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(660, 240);
            this.dataGridView2.TabIndex = 52;
            // 
            // panelAgregarProd
            // 
            this.panelAgregarProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAgregarProd.BackColor = System.Drawing.Color.Black;
            this.panelAgregarProd.Controls.Add(this.dataGridView2);
            this.panelAgregarProd.Controls.Add(this.BtnGuardar);
            this.panelAgregarProd.Controls.Add(this.BtnCancelar);
            this.panelAgregarProd.Controls.Add(this.label17);
            this.panelAgregarProd.Controls.Add(this.label9);
            this.panelAgregarProd.Controls.Add(this.textBox1);
            this.panelAgregarProd.Controls.Add(this.label2);
            this.panelAgregarProd.Location = new System.Drawing.Point(104, 39);
            this.panelAgregarProd.Name = "panelAgregarProd";
            this.panelAgregarProd.Size = new System.Drawing.Size(722, 417);
            this.panelAgregarProd.TabIndex = 21;
            this.panelAgregarProd.Visible = false;
            // 
            // textoUnidad
            // 
            this.textoUnidad.BackColor = System.Drawing.Color.White;
            this.textoUnidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoUnidad.Enabled = false;
            this.textoUnidad.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoUnidad.Location = new System.Drawing.Point(88, 162);
            this.textoUnidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textoUnidad.Name = "textoUnidad";
            this.textoUnidad.Size = new System.Drawing.Size(63, 25);
            this.textoUnidad.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label8.Location = new System.Drawing.Point(7, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Unidad";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.BackColor = System.Drawing.Color.White;
            this.textBoxCantidad.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(256, 162);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(96, 25);
            this.textBoxCantidad.TabIndex = 24;
            this.textBoxCantidad.TextChanged += new System.EventHandler(this.textBoxCantidad_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label6.Location = new System.Drawing.Point(174, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cantidad";
            // 
            // buttonAgregarProducto
            // 
            this.buttonAgregarProducto.Enabled = false;
            this.buttonAgregarProducto.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.buttonAgregarProducto.Location = new System.Drawing.Point(11, 251);
            this.buttonAgregarProducto.Name = "buttonAgregarProducto";
            this.buttonAgregarProducto.Size = new System.Drawing.Size(341, 34);
            this.buttonAgregarProducto.TabIndex = 27;
            this.buttonAgregarProducto.Text = "Agregar producto";
            this.buttonAgregarProducto.UseVisualStyleBackColor = true;
            this.buttonAgregarProducto.Click += new System.EventHandler(this.buttonAgregarProducto_Click);
            // 
            // buttonCrearFactura
            // 
            this.buttonCrearFactura.Enabled = false;
            this.buttonCrearFactura.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.buttonCrearFactura.Location = new System.Drawing.Point(11, 331);
            this.buttonCrearFactura.Name = "buttonCrearFactura";
            this.buttonCrearFactura.Size = new System.Drawing.Size(341, 34);
            this.buttonCrearFactura.TabIndex = 28;
            this.buttonCrearFactura.Text = "Crear Factura";
            this.buttonCrearFactura.UseVisualStyleBackColor = true;
            this.buttonCrearFactura.Click += new System.EventHandler(this.buttonCrearFactura_Click);
            // 
            // buttonCerrarFactura
            // 
            this.buttonCerrarFactura.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.buttonCerrarFactura.Location = new System.Drawing.Point(3, 58);
            this.buttonCerrarFactura.Name = "buttonCerrarFactura";
            this.buttonCerrarFactura.Size = new System.Drawing.Size(124, 34);
            this.buttonCerrarFactura.TabIndex = 29;
            this.buttonCerrarFactura.Text = "Cerrar Factura";
            this.buttonCerrarFactura.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label11.Location = new System.Drawing.Point(340, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Descuento";
            // 
            // textoDescuento
            // 
            this.textoDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textoDescuento.BackColor = System.Drawing.Color.White;
            this.textoDescuento.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDescuento.Location = new System.Drawing.Point(429, 13);
            this.textoDescuento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textoDescuento.Name = "textoDescuento";
            this.textoDescuento.Size = new System.Drawing.Size(119, 25);
            this.textoDescuento.TabIndex = 31;
            this.textoDescuento.Text = "0";
            this.textoDescuento.TextChanged += new System.EventHandler(this.actualizarPrecioFinal);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label12.Location = new System.Drawing.Point(160, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Precio Total";
            // 
            // labelPrecioTotal
            // 
            this.labelPrecioTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrecioTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPrecioTotal.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.labelPrecioTotal.Location = new System.Drawing.Point(256, 210);
            this.labelPrecioTotal.Name = "labelPrecioTotal";
            this.labelPrecioTotal.Size = new System.Drawing.Size(96, 22);
            this.labelPrecioTotal.TabIndex = 33;
            // 
            // labelPrecioFinal
            // 
            this.labelPrecioFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrecioFinal.AutoSize = true;
            this.labelPrecioFinal.Font = new System.Drawing.Font("Microsoft JhengHei Light", 25F);
            this.labelPrecioFinal.Location = new System.Drawing.Point(333, 55);
            this.labelPrecioFinal.Name = "labelPrecioFinal";
            this.labelPrecioFinal.Size = new System.Drawing.Size(90, 43);
            this.labelPrecioFinal.TabIndex = 34;
            this.labelPrecioFinal.Text = "Final";
            // 
            // labelPrecioFinalEntero
            // 
            this.labelPrecioFinalEntero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrecioFinalEntero.BackColor = System.Drawing.Color.White;
            this.labelPrecioFinalEntero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrecioFinalEntero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPrecioFinalEntero.Font = new System.Drawing.Font("Microsoft JhengHei Light", 25F);
            this.labelPrecioFinalEntero.Location = new System.Drawing.Point(429, 54);
            this.labelPrecioFinalEntero.Name = "labelPrecioFinalEntero";
            this.labelPrecioFinalEntero.Size = new System.Drawing.Size(119, 37);
            this.labelPrecioFinalEntero.TabIndex = 35;
            // 
            // agregarProd
            // 
            this.agregarProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.agregarProd.Image = global::CapaPresentacion.Properties.Resources.round_add_circle_outline_black_18dp;
            this.agregarProd.Location = new System.Drawing.Point(316, 110);
            this.agregarProd.Name = "agregarProd";
            this.agregarProd.Size = new System.Drawing.Size(36, 36);
            this.agregarProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.agregarProd.TabIndex = 16;
            this.agregarProd.TabStop = false;
            this.agregarProd.Click += new System.EventHandler(this.agregarProd_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.agregarProd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelPrecioTotal);
            this.panel1.Controls.Add(this.buttonCrearFactura);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonAgregarProducto);
            this.panel1.Controls.Add(this.textBoxCantidad);
            this.panel1.Controls.Add(this.textoProducto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.labelPrecio);
            this.panel1.Controls.Add(this.textoUnidad);
            this.panel1.Controls.Add(this.facturaFecha);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 383);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.buttonCerrarFactura);
            this.panel2.Controls.Add(this.labelPrecioFinal);
            this.panel2.Controls.Add(this.labelPrecioFinalEntero);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textoDescuento);
            this.panel2.Location = new System.Drawing.Point(380, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 110);
            this.panel2.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(4, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(938, 417);
            this.panel3.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 34F);
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 58);
            this.label1.TabIndex = 38;
            this.label1.Text = "Facturas ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(4, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 79);
            this.panel4.TabIndex = 38;
            // 
            // FacturaCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.fondoPrincipal;
            this.ClientSize = new System.Drawing.Size(946, 475);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelAgregarProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturaCrear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerveceria Mauricio";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelAgregarProd.ResumeLayout(false);
            this.panelAgregarProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agregarProd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.DateTimePicker facturaFecha;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.PictureBox agregarProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textoProducto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panelAgregarProd;
        private System.Windows.Forms.TextBox textoUnidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAgregarProducto;
        private System.Windows.Forms.Button buttonCrearFactura;
        private System.Windows.Forms.Button buttonCerrarFactura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textoDescuento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelPrecioTotal;
        private System.Windows.Forms.Label labelPrecioFinal;
        private System.Windows.Forms.Label labelPrecioFinalEntero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoPrecioFin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
    }
}