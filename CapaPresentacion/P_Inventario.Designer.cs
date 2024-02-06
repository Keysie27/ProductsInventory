namespace CapaPresentacion
{
    partial class P_Inventario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.labelInventario = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxCantidadStock = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCantidadStock = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.textBoxBuscarProducto = new System.Windows.Forms.TextBox();
            this.buttonGenerarReporte = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.labelInformeStock = new System.Windows.Forms.Label();
            this.groupBoxDetalles = new System.Windows.Forms.GroupBox();
            this.groupBoxProductos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.groupBoxDetalles.SuspendLayout();
            this.groupBoxProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridViewProductos
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(26, 72);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.RowTemplate.Height = 24;
            this.dataGridViewProductos.Size = new System.Drawing.Size(732, 271);
            this.dataGridViewProductos.TabIndex = 4;
            this.dataGridViewProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProductos_CellMouseClick);
            // 
            // labelInventario
            // 
            this.labelInventario.AutoSize = true;
            this.labelInventario.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventario.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelInventario.Location = new System.Drawing.Point(41, 12);
            this.labelInventario.Name = "labelInventario";
            this.labelInventario.Size = new System.Drawing.Size(179, 45);
            this.labelInventario.TabIndex = 5;
            this.labelInventario.Text = "Inventario";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(32, 60);
            this.textBoxNombre.MaxLength = 50;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(145, 30);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(212, 60);
            this.textBoxDescripcion.MaxLength = 200;
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(225, 62);
            this.textBoxDescripcion.TabIndex = 8;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(473, 60);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 30);
            this.textBoxPrecio.TabIndex = 9;
            // 
            // textBoxCantidadStock
            // 
            this.textBoxCantidadStock.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidadStock.Location = new System.Drawing.Point(607, 60);
            this.textBoxCantidadStock.Name = "textBoxCantidadStock";
            this.textBoxCantidadStock.Size = new System.Drawing.Size(100, 30);
            this.textBoxCantidadStock.TabIndex = 10;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelNombre.Location = new System.Drawing.Point(28, 34);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(76, 23);
            this.labelNombre.TabIndex = 11;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDescripcion.Location = new System.Drawing.Point(208, 34);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(103, 23);
            this.labelDescripcion.TabIndex = 12;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.BackColor = System.Drawing.SystemColors.Control;
            this.labelPrecio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPrecio.Location = new System.Drawing.Point(469, 34);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(59, 23);
            this.labelPrecio.TabIndex = 13;
            this.labelPrecio.Text = "Precio";
            // 
            // labelCantidadStock
            // 
            this.labelCantidadStock.AutoSize = true;
            this.labelCantidadStock.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCantidadStock.Location = new System.Drawing.Point(603, 34);
            this.labelCantidadStock.Name = "labelCantidadStock";
            this.labelCantidadStock.Size = new System.Drawing.Size(158, 23);
            this.labelCantidadStock.TabIndex = 14;
            this.labelCantidadStock.Text = "Cantidad de Stock";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAgregar.Location = new System.Drawing.Point(49, 252);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(114, 43);
            this.buttonAgregar.TabIndex = 15;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.Khaki;
            this.buttonModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonModificar.Location = new System.Drawing.Point(329, 252);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(114, 43);
            this.buttonModificar.TabIndex = 16;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEliminar.Location = new System.Drawing.Point(188, 252);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(114, 43);
            this.buttonEliminar.TabIndex = 17;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelBuscar.Location = new System.Drawing.Point(538, 30);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(81, 23);
            this.labelBuscar.TabIndex = 18;
            this.labelBuscar.Text = "Nombre:";
            // 
            // textBoxBuscarProducto
            // 
            this.textBoxBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarProducto.Location = new System.Drawing.Point(629, 27);
            this.textBoxBuscarProducto.Name = "textBoxBuscarProducto";
            this.textBoxBuscarProducto.Size = new System.Drawing.Size(132, 30);
            this.textBoxBuscarProducto.TabIndex = 19;
            this.textBoxBuscarProducto.TextChanged += new System.EventHandler(this.textBoxBuscarProducto_TextChanged);
            // 
            // buttonGenerarReporte
            // 
            this.buttonGenerarReporte.BackColor = System.Drawing.Color.LightGray;
            this.buttonGenerarReporte.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarReporte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGenerarReporte.Location = new System.Drawing.Point(656, 257);
            this.buttonGenerarReporte.Name = "buttonGenerarReporte";
            this.buttonGenerarReporte.Size = new System.Drawing.Size(177, 43);
            this.buttonGenerarReporte.TabIndex = 20;
            this.buttonGenerarReporte.Text = "Generar Reporte";
            this.buttonGenerarReporte.UseVisualStyleBackColor = false;
            this.buttonGenerarReporte.Click += new System.EventHandler(this.buttonGenerarReporte_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.LightGreen;
            this.buttonLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(679, 112);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(99, 43);
            this.buttonLimpiar.TabIndex = 21;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // labelInformeStock
            // 
            this.labelInformeStock.AutoSize = true;
            this.labelInformeStock.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformeStock.Location = new System.Drawing.Point(560, 265);
            this.labelInformeStock.Name = "labelInformeStock";
            this.labelInformeStock.Size = new System.Drawing.Size(0, 23);
            this.labelInformeStock.TabIndex = 22;
            // 
            // groupBoxDetalles
            // 
            this.groupBoxDetalles.Controls.Add(this.labelCantidadStock);
            this.groupBoxDetalles.Controls.Add(this.textBoxNombre);
            this.groupBoxDetalles.Controls.Add(this.textBoxDescripcion);
            this.groupBoxDetalles.Controls.Add(this.buttonLimpiar);
            this.groupBoxDetalles.Controls.Add(this.textBoxPrecio);
            this.groupBoxDetalles.Controls.Add(this.textBoxCantidadStock);
            this.groupBoxDetalles.Controls.Add(this.labelNombre);
            this.groupBoxDetalles.Controls.Add(this.labelDescripcion);
            this.groupBoxDetalles.Controls.Add(this.labelPrecio);
            this.groupBoxDetalles.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetalles.Location = new System.Drawing.Point(49, 78);
            this.groupBoxDetalles.Name = "groupBoxDetalles";
            this.groupBoxDetalles.Size = new System.Drawing.Size(784, 166);
            this.groupBoxDetalles.TabIndex = 23;
            this.groupBoxDetalles.TabStop = false;
            this.groupBoxDetalles.Text = "Detalles de Producto";
            // 
            // groupBoxProductos
            // 
            this.groupBoxProductos.Controls.Add(this.dataGridViewProductos);
            this.groupBoxProductos.Controls.Add(this.textBoxBuscarProducto);
            this.groupBoxProductos.Controls.Add(this.labelBuscar);
            this.groupBoxProductos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProductos.Location = new System.Drawing.Point(49, 314);
            this.groupBoxProductos.Name = "groupBoxProductos";
            this.groupBoxProductos.Size = new System.Drawing.Size(784, 362);
            this.groupBoxProductos.TabIndex = 24;
            this.groupBoxProductos.TabStop = false;
            this.groupBoxProductos.Text = "Productos";
            // 
            // P_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 699);
            this.Controls.Add(this.groupBoxProductos);
            this.Controls.Add(this.buttonGenerarReporte);
            this.Controls.Add(this.labelInformeStock);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.groupBoxDetalles);
            this.Controls.Add(this.labelInventario);
            this.Name = "P_Inventario";
            this.Text = "Inventario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.P_Inventario_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.groupBoxDetalles.ResumeLayout(false);
            this.groupBoxDetalles.PerformLayout();
            this.groupBoxProductos.ResumeLayout(false);
            this.groupBoxProductos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Label labelInventario;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxCantidadStock;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelCantidadStock;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBoxBuscarProducto;
        private System.Windows.Forms.Button buttonGenerarReporte;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label labelInformeStock;
        private System.Windows.Forms.GroupBox groupBoxDetalles;
        private System.Windows.Forms.GroupBox groupBoxProductos;
    }
}