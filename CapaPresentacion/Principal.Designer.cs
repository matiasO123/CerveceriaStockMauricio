namespace CapaPresentacion
{
    partial class Principal
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(236, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(989, 475);
            this.panelContenedor.TabIndex = 58;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.BackgroundImage = global::CapaPresentacion.Properties.Resources.fondo2;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnStock);
            this.panelMenu.Controls.Add(this.btnProductos);
            this.panelMenu.Controls.Add(this.btnFacturas);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(236, 475);
            this.panelMenu.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CapaPresentacion.Properties.Resources.Principal;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 138);
            this.panel1.TabIndex = 11;
            // 
            // btnStock
            // 
            this.btnStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStock.BackColor = System.Drawing.Color.Transparent;
            this.btnStock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStock.FlatAppearance.BorderSize = 2;
            this.btnStock.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14F, System.Drawing.FontStyle.Bold);
            this.btnStock.ForeColor = System.Drawing.Color.Black;
            this.btnStock.Location = new System.Drawing.Point(0, 314);
            this.btnStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(236, 50);
            this.btnStock.TabIndex = 8;
            this.btnStock.Text = "STOCK";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProductos.FlatAppearance.BorderSize = 2;
            this.btnProductos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14F, System.Drawing.FontStyle.Bold);
            this.btnProductos.ForeColor = System.Drawing.Color.Black;
            this.btnProductos.Location = new System.Drawing.Point(0, 383);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(236, 50);
            this.btnProductos.TabIndex = 10;
            this.btnProductos.Text = "LISTA DE PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFacturas.BackColor = System.Drawing.Color.Transparent;
            this.btnFacturas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFacturas.FlatAppearance.BorderSize = 2;
            this.btnFacturas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnFacturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14F, System.Drawing.FontStyle.Bold);
            this.btnFacturas.ForeColor = System.Drawing.Color.Black;
            this.btnFacturas.Location = new System.Drawing.Point(0, 176);
            this.btnFacturas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(236, 50);
            this.btnFacturas.TabIndex = 9;
            this.btnFacturas.Text = "FACTURAS";
            this.btnFacturas.UseVisualStyleBackColor = false;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "LISTA DE FACTURAS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1225, 475);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button button1;
    }
}