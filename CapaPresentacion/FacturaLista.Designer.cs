
namespace CapaPresentacion
{
    partial class FacturaLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.Cliente,
            this.Fecha,
            this.Descuento,
            this.PrecioFinal});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(14, 108);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DividerHeight = 3;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(920, 301);
            this.dataGridView1.TabIndex = 1;
            // 
            // Nro
            // 
            this.Nro.HeaderText = "Nro";
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // PrecioFinal
            // 
            this.PrecioFinal.HeaderText = "Precio Final";
            this.PrecioFinal.Name = "PrecioFinal";
            this.PrecioFinal.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(4, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(386, 71);
            this.panel6.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 34F);
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 58);
            this.label1.TabIndex = 38;
            this.label1.Text = "Lista de Facturas";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.botonAgregar);
            this.panel2.Controls.Add(this.botonEliminar);
            this.panel2.Controls.Add(this.botonGuardar);
            this.panel2.Location = new System.Drawing.Point(88, 413);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 50);
            this.panel2.TabIndex = 55;
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
            this.botonAgregar.Text = "Crear Factura";
            this.botonAgregar.UseVisualStyleBackColor = true;
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
            this.botonEliminar.Text = "Ver Factura";
            this.botonEliminar.UseVisualStyleBackColor = true;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonGuardar.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardar.ForeColor = System.Drawing.Color.Black;
            this.botonGuardar.Location = new System.Drawing.Point(604, 4);
            this.botonGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(154, 43);
            this.botonGuardar.TabIndex = 8;
            this.botonGuardar.Text = "Eliminar Factura";
            this.botonGuardar.UseVisualStyleBackColor = true;
            // 
            // FacturaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturaLista";
            this.Text = "FacturaLista";
            this.Load += new System.EventHandler(this.FacturaLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFinal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonGuardar;
    }
}