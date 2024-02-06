namespace CapaPresentacion
{
    partial class P_Reporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelInformeStock = new System.Windows.Forms.Label();
            this.labelFechaActual = new System.Windows.Forms.Label();
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContacto = new System.Windows.Forms.Label();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.labelFecha = new System.Windows.Forms.Label();
            this.groupBoxInventario = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            this.groupBoxInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInformeStock
            // 
            this.labelInformeStock.AutoSize = true;
            this.labelInformeStock.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformeStock.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelInformeStock.Location = new System.Drawing.Point(19, 9);
            this.labelInformeStock.Name = "labelInformeStock";
            this.labelInformeStock.Size = new System.Drawing.Size(433, 46);
            this.labelInformeStock.TabIndex = 0;
            this.labelInformeStock.Text = "Informe de Nivel de Stock";
            // 
            // labelFechaActual
            // 
            this.labelFechaActual.AutoSize = true;
            this.labelFechaActual.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaActual.Location = new System.Drawing.Point(162, 402);
            this.labelFechaActual.Name = "labelFechaActual";
            this.labelFechaActual.Size = new System.Drawing.Size(96, 23);
            this.labelFechaActual.TabIndex = 1;
            this.labelFechaActual.Text = "00/00/0000";
            // 
            // dataGridViewReporte
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewReporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReporte.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReporte.Location = new System.Drawing.Point(15, 33);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewReporte.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewReporte.RowTemplate.Height = 24;
            this.dataGridViewReporte.Size = new System.Drawing.Size(615, 249);
            this.dataGridViewReporte.TabIndex = 7;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(13, 403);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(68, 23);
            this.labelUsuario.TabIndex = 9;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContacto.Location = new System.Drawing.Point(14, 377);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(57, 23);
            this.labelContacto.TabIndex = 10;
            this.labelContacto.Text = "Firma:";
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonImprimir.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonImprimir.Location = new System.Drawing.Point(536, 376);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(106, 49);
            this.buttonImprimir.TabIndex = 11;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = false;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(162, 376);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(59, 23);
            this.labelFecha.TabIndex = 12;
            this.labelFecha.Text = "Fecha:";
            // 
            // groupBoxInventario
            // 
            this.groupBoxInventario.Controls.Add(this.dataGridViewReporte);
            this.groupBoxInventario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInventario.Location = new System.Drawing.Point(12, 64);
            this.groupBoxInventario.Name = "groupBoxInventario";
            this.groupBoxInventario.Size = new System.Drawing.Size(649, 296);
            this.groupBoxInventario.TabIndex = 13;
            this.groupBoxInventario.TabStop = false;
            this.groupBoxInventario.Text = "Inventario";
            // 
            // P_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 446);
            this.Controls.Add(this.groupBoxInventario);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.labelContacto);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelFechaActual);
            this.Controls.Add(this.labelInformeStock);
            this.Name = "P_Reporte";
            this.Text = "Reporte";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            this.groupBoxInventario.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformeStock;
        private System.Windows.Forms.Label labelFechaActual;
        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.GroupBox groupBoxInventario;
    }
}