namespace CapaPresentacion
{
    partial class ABMProductos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBusquedaTipo = new System.Windows.Forms.Label();
            this.labelBusquedaNombre = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.botonLlenarTabla = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.panelNuevoProducto = new System.Windows.Forms.Panel();
            this.comboBoxUMedida = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxNuevo = new System.Windows.Forms.ComboBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBoxPventa = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelNuevoProducto.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(14, 169);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(920, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.botonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAgregar.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.ForeColor = System.Drawing.Color.Black;
            this.botonAgregar.Location = new System.Drawing.Point(3, 4);
            this.botonAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(154, 43);
            this.botonAgregar.TabIndex = 1;
            this.botonAgregar.Text = "Agregar Producto";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.botonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBuscar.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscar.Location = new System.Drawing.Point(545, 25);
            this.botonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(173, 47);
            this.botonBuscar.TabIndex = 3;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxNombre.BackColor = System.Drawing.Color.White;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(189, 44);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(153, 30);
            this.textBoxNombre.TabIndex = 4;
            this.textBoxNombre.Visible = false;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.Busqueda);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxTipo.BackColor = System.Drawing.Color.White;
            this.comboBoxTipo.Font = new System.Drawing.Font("Microsoft JhengHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(360, 43);
            this.comboBoxTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(153, 25);
            this.comboBoxTipo.TabIndex = 5;
            this.comboBoxTipo.Visible = false;
            this.comboBoxTipo.TextChanged += new System.EventHandler(this.Busqueda);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEliminar.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminar.ForeColor = System.Drawing.Color.Black;
            this.botonEliminar.Location = new System.Drawing.Point(309, 4);
            this.botonEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(154, 43);
            this.botonEliminar.TabIndex = 7;
            this.botonEliminar.Text = "Eliminar Producto";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botonGuardar.Enabled = false;
            this.botonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonGuardar.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardar.ForeColor = System.Drawing.Color.White;
            this.botonGuardar.Location = new System.Drawing.Point(357, 367);
            this.botonGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(154, 34);
            this.botonGuardar.TabIndex = 8;
            this.botonGuardar.Text = "Guardar ";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelBusquedaTipo);
            this.panel1.Controls.Add(this.labelBusquedaNombre);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.botonLlenarTabla);
            this.panel1.Controls.Add(this.botonBuscar);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.comboBoxTipo);
            this.panel1.Location = new System.Drawing.Point(14, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 107);
            this.panel1.TabIndex = 9;
            // 
            // labelBusquedaTipo
            // 
            this.labelBusquedaTipo.AutoSize = true;
            this.labelBusquedaTipo.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.labelBusquedaTipo.Location = new System.Drawing.Point(356, 19);
            this.labelBusquedaTipo.Name = "labelBusquedaTipo";
            this.labelBusquedaTipo.Size = new System.Drawing.Size(42, 20);
            this.labelBusquedaTipo.TabIndex = 10;
            this.labelBusquedaTipo.Text = "Tipo";
            this.labelBusquedaTipo.Visible = false;
            // 
            // labelBusquedaNombre
            // 
            this.labelBusquedaNombre.AutoSize = true;
            this.labelBusquedaNombre.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.labelBusquedaNombre.Location = new System.Drawing.Point(185, 20);
            this.labelBusquedaNombre.Name = "labelBusquedaNombre";
            this.labelBusquedaNombre.Size = new System.Drawing.Size(70, 20);
            this.labelBusquedaNombre.TabIndex = 9;
            this.labelBusquedaNombre.Text = "Nombre";
            this.labelBusquedaNombre.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(189, 71);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(153, 3);
            this.panel7.TabIndex = 8;
            this.panel7.Visible = false;
            // 
            // botonLlenarTabla
            // 
            this.botonLlenarTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.botonLlenarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonLlenarTabla.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLlenarTabla.Location = new System.Drawing.Point(735, 25);
            this.botonLlenarTabla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonLlenarTabla.Name = "botonLlenarTabla";
            this.botonLlenarTabla.Size = new System.Drawing.Size(173, 47);
            this.botonLlenarTabla.TabIndex = 7;
            this.botonLlenarTabla.Text = "Todos los Productos";
            this.botonLlenarTabla.UseVisualStyleBackColor = true;
            this.botonLlenarTabla.Click += new System.EventHandler(this.botonLlenarTabla_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.BtnEditar);
            this.panel2.Controls.Add(this.botonAgregar);
            this.panel2.Controls.Add(this.botonEliminar);
            this.panel2.Location = new System.Drawing.Point(88, 413);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 50);
            this.panel2.TabIndex = 10;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.Black;
            this.BtnEditar.Location = new System.Drawing.Point(604, 4);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(154, 43);
            this.BtnEditar.TabIndex = 9;
            this.BtnEditar.Text = "Editar Producto";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // panelNuevoProducto
            // 
            this.panelNuevoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNuevoProducto.BackColor = System.Drawing.Color.Black;
            this.panelNuevoProducto.Controls.Add(this.comboBoxUMedida);
            this.panelNuevoProducto.Controls.Add(this.label10);
            this.panelNuevoProducto.Controls.Add(this.comboBoxNuevo);
            this.panelNuevoProducto.Controls.Add(this.BtnAgregar);
            this.panelNuevoProducto.Controls.Add(this.botonGuardar);
            this.panelNuevoProducto.Controls.Add(this.BtnCancelar);
            this.panelNuevoProducto.Controls.Add(this.panel5);
            this.panelNuevoProducto.Controls.Add(this.panel4);
            this.panelNuevoProducto.Controls.Add(this.panel3);
            this.panelNuevoProducto.Controls.Add(this.panel8);
            this.panelNuevoProducto.Controls.Add(this.textBoxPventa);
            this.panelNuevoProducto.Controls.Add(this.textBoxCantidad);
            this.panelNuevoProducto.Controls.Add(this.textBoxDescripcion);
            this.panelNuevoProducto.Controls.Add(this.textBoxNom);
            this.panelNuevoProducto.Controls.Add(this.label7);
            this.panelNuevoProducto.Controls.Add(this.label5);
            this.panelNuevoProducto.Controls.Add(this.label4);
            this.panelNuevoProducto.Controls.Add(this.label3);
            this.panelNuevoProducto.Controls.Add(this.label2);
            this.panelNuevoProducto.Location = new System.Drawing.Point(127, 12);
            this.panelNuevoProducto.Name = "panelNuevoProducto";
            this.panelNuevoProducto.Size = new System.Drawing.Size(722, 417);
            this.panelNuevoProducto.TabIndex = 11;
            this.panelNuevoProducto.Visible = false;
            // 
            // comboBoxUMedida
            // 
            this.comboBoxUMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxUMedida.BackColor = System.Drawing.Color.Black;
            this.comboBoxUMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUMedida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxUMedida.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14F);
            this.comboBoxUMedida.ForeColor = System.Drawing.Color.White;
            this.comboBoxUMedida.FormattingEnabled = true;
            this.comboBoxUMedida.Location = new System.Drawing.Point(286, 191);
            this.comboBoxUMedida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxUMedida.Name = "comboBoxUMedida";
            this.comboBoxUMedida.Size = new System.Drawing.Size(395, 32);
            this.comboBoxUMedida.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(42, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 24);
            this.label10.TabIndex = 54;
            this.label10.Text = "Unidad de medida";
            // 
            // comboBoxNuevo
            // 
            this.comboBoxNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBoxNuevo.BackColor = System.Drawing.Color.Black;
            this.comboBoxNuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxNuevo.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14F);
            this.comboBoxNuevo.ForeColor = System.Drawing.Color.White;
            this.comboBoxNuevo.FormattingEnabled = true;
            this.comboBoxNuevo.Location = new System.Drawing.Point(286, 107);
            this.comboBoxNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxNuevo.Name = "comboBoxNuevo";
            this.comboBoxNuevo.Size = new System.Drawing.Size(395, 32);
            this.comboBoxNuevo.TabIndex = 3;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(185, 367);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(154, 34);
            this.BtnAgregar.TabIndex = 51;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnGuardar_Click);
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(286, 316);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(395, 3);
            this.panel5.TabIndex = 49;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(286, 272);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 3);
            this.panel4.TabIndex = 47;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(286, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 3);
            this.panel3.TabIndex = 46;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(286, 81);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(395, 3);
            this.panel8.TabIndex = 44;
            // 
            // textBoxPventa
            // 
            this.textBoxPventa.BackColor = System.Drawing.Color.Black;
            this.textBoxPventa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPventa.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxPventa.ForeColor = System.Drawing.Color.White;
            this.textBoxPventa.Location = new System.Drawing.Point(286, 296);
            this.textBoxPventa.Name = "textBoxPventa";
            this.textBoxPventa.Size = new System.Drawing.Size(395, 25);
            this.textBoxPventa.TabIndex = 7;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.BackColor = System.Drawing.Color.Black;
            this.textBoxCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCantidad.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxCantidad.ForeColor = System.Drawing.Color.White;
            this.textBoxCantidad.Location = new System.Drawing.Point(286, 252);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(395, 25);
            this.textBoxCantidad.TabIndex = 6;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.BackColor = System.Drawing.Color.Black;
            this.textBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescripcion.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxDescripcion.ForeColor = System.Drawing.Color.White;
            this.textBoxDescripcion.Location = new System.Drawing.Point(286, 151);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(395, 25);
            this.textBoxDescripcion.TabIndex = 4;
            // 
            // textBoxNom
            // 
            this.textBoxNom.BackColor = System.Drawing.Color.Black;
            this.textBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxNom.ForeColor = System.Drawing.Color.White;
            this.textBoxNom.Location = new System.Drawing.Point(286, 59);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(395, 25);
            this.textBoxNom.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 24);
            this.label7.TabIndex = 40;
            this.label7.Text = "Precio Venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Descripción";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(4, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(386, 71);
            this.panel6.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 34F);
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 58);
            this.label1.TabIndex = 38;
            this.label1.Text = "Lista de Precios";
            // 
            // ABMProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.fondoPrincipal;
            this.ClientSize = new System.Drawing.Size(946, 475);
            this.Controls.Add(this.panelNuevoProducto);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei Light", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ABMProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerveceria Mauricio";
            this.Load += new System.EventHandler(this.ABMInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelNuevoProducto.ResumeLayout(false);
            this.panelNuevoProducto.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelNuevoProducto;
        private System.Windows.Forms.ComboBox comboBoxNuevo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBoxPventa;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxUMedida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button botonLlenarTabla;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelBusquedaTipo;
        private System.Windows.Forms.Label labelBusquedaNombre;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
    }
}

