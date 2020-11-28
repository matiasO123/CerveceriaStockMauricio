namespace CapaPresentacion
{
    partial class ABMFactura
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.agregarProd = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panelAgregarProd = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agregarProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelAgregarProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 35F);
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei Light", 30F);
            this.label2.Location = new System.Drawing.Point(652, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label3.Location = new System.Drawing.Point(43, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label4.Location = new System.Drawing.Point(43, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
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
            this.productoNombre,
            this.UnidadMedida,
            this.productoCantidad,
            this.productoPrecio,
            this.productoPrecioFin});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(416, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(518, 265);
            this.dataGridView1.TabIndex = 4;
            // 
            // productoNombre
            // 
            this.productoNombre.HeaderText = "Nombre Producto";
            this.productoNombre.Name = "productoNombre";
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.HeaderText = "Bulto";
            this.UnidadMedida.Name = "UnidadMedida";
            // 
            // productoCantidad
            // 
            this.productoCantidad.HeaderText = "Cantidad";
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
            this.label7.Location = new System.Drawing.Point(43, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label5.Location = new System.Drawing.Point(43, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxNombre.BackColor = System.Drawing.Color.White;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(124, 149);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(188, 26);
            this.textBoxNombre.TabIndex = 8;
            this.textBoxNombre.Visible = false;
            // 
            // facturaFecha
            // 
            this.facturaFecha.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F);
            this.facturaFecha.Location = new System.Drawing.Point(124, 194);
            this.facturaFecha.Name = "facturaFecha";
            this.facturaFecha.Size = new System.Drawing.Size(188, 25);
            this.facturaFecha.TabIndex = 10;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.labelPrecio.Location = new System.Drawing.Point(121, 334);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(30, 20);
            this.labelPrecio.TabIndex = 14;
            this.labelPrecio.Text = "$...";
            // 
            // agregarProd
            // 
            this.agregarProd.Image = global::CapaPresentacion.Properties.Resources.round_add_circle_outline_black_18dp;
            this.agregarProd.Location = new System.Drawing.Point(319, 231);
            this.agregarProd.Name = "agregarProd";
            this.agregarProd.Size = new System.Drawing.Size(36, 36);
            this.agregarProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.agregarProd.TabIndex = 16;
            this.agregarProd.TabStop = false;
            this.agregarProd.Click += new System.EventHandler(this.agregarProd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label9.Location = new System.Drawing.Point(171, 334);
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
            this.textBox1.Location = new System.Drawing.Point(263, 328);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 26);
            this.textBox1.TabIndex = 18;
            this.textBox1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei Light", 30F);
            this.label10.Location = new System.Drawing.Point(829, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 50);
            this.label10.TabIndex = 19;
            this.label10.Text = "$...";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(125, 237);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 26);
            this.textBox2.TabIndex = 20;
            this.textBox2.Visible = false;
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
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
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
            this.panelAgregarProd.Location = new System.Drawing.Point(157, 27);
            this.panelAgregarProd.Name = "panelAgregarProd";
            this.panelAgregarProd.Size = new System.Drawing.Size(722, 417);
            this.panelAgregarProd.TabIndex = 21;
            this.panelAgregarProd.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(124, 284);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 26);
            this.textBox3.TabIndex = 26;
            this.textBox3.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label8.Location = new System.Drawing.Point(43, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Unidad";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxCantidad.BackColor = System.Drawing.Color.White;
            this.textBoxCantidad.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(262, 284);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCantidad.Multiline = true;
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(50, 26);
            this.textBoxCantidad.TabIndex = 24;
            this.textBoxCantidad.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.label6.Location = new System.Drawing.Point(182, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cantidad";
            // 
            // ABMFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 475);
            this.Controls.Add(this.panelAgregarProd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.agregarProd);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.facturaFecha);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label6);
            this.Name = "ABMFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerveceria Mauricio";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agregarProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelAgregarProd.ResumeLayout(false);
            this.panelAgregarProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn productoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoPrecioFin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panelAgregarProd;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label6;
    }
}