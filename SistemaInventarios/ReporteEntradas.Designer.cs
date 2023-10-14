namespace SistemaInventarios
{
    partial class ReporteEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteEntradas));
            this.ReporteEntradaGrid = new System.Windows.Forms.DataGridView();
            this.sistemaInventarioDataSet3 = new SistemaInventarios.SistemaInventarioDataSet3();
            this.entradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entradasTableAdapter = new SistemaInventarios.SistemaInventarioDataSet3TableAdapters.EntradasTableAdapter();
            this.iDEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProductosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolverEntradaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEntradaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaInventarioDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteEntradaGrid
            // 
            this.ReporteEntradaGrid.AutoGenerateColumns = false;
            this.ReporteEntradaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReporteEntradaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEntradaDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.cantidadProductosDataGridViewTextBoxColumn,
            this.fechaEntradaDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn});
            this.ReporteEntradaGrid.DataSource = this.entradasBindingSource;
            this.ReporteEntradaGrid.Location = new System.Drawing.Point(326, 29);
            this.ReporteEntradaGrid.Name = "ReporteEntradaGrid";
            this.ReporteEntradaGrid.RowHeadersWidth = 51;
            this.ReporteEntradaGrid.RowTemplate.Height = 24;
            this.ReporteEntradaGrid.Size = new System.Drawing.Size(1080, 650);
            this.ReporteEntradaGrid.TabIndex = 0;
            // 
            // sistemaInventarioDataSet3
            // 
            this.sistemaInventarioDataSet3.DataSetName = "SistemaInventarioDataSet3";
            this.sistemaInventarioDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entradasBindingSource
            // 
            this.entradasBindingSource.DataMember = "Entradas";
            this.entradasBindingSource.DataSource = this.sistemaInventarioDataSet3;
            // 
            // entradasTableAdapter
            // 
            this.entradasTableAdapter.ClearBeforeFill = true;
            // 
            // iDEntradaDataGridViewTextBoxColumn
            // 
            this.iDEntradaDataGridViewTextBoxColumn.DataPropertyName = "ID_Entrada";
            this.iDEntradaDataGridViewTextBoxColumn.HeaderText = "ID_Entrada";
            this.iDEntradaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDEntradaDataGridViewTextBoxColumn.Name = "iDEntradaDataGridViewTextBoxColumn";
            this.iDEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDEntradaDataGridViewTextBoxColumn.Width = 125;
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            this.proveedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadProductosDataGridViewTextBoxColumn
            // 
            this.cantidadProductosDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Productos";
            this.cantidadProductosDataGridViewTextBoxColumn.HeaderText = "Cantidad_Productos";
            this.cantidadProductosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadProductosDataGridViewTextBoxColumn.Name = "cantidadProductosDataGridViewTextBoxColumn";
            this.cantidadProductosDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaEntradaDataGridViewTextBoxColumn
            // 
            this.fechaEntradaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Entrada";
            this.fechaEntradaDataGridViewTextBoxColumn.HeaderText = "Fecha_Entrada";
            this.fechaEntradaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaEntradaDataGridViewTextBoxColumn.Name = "fechaEntradaDataGridViewTextBoxColumn";
            this.fechaEntradaDataGridViewTextBoxColumn.Width = 125;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.Width = 125;
            // 
            // VolverEntradaBtn
            // 
            this.VolverEntradaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.VolverEntradaBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverEntradaBtn.Location = new System.Drawing.Point(33, 97);
            this.VolverEntradaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.VolverEntradaBtn.Name = "VolverEntradaBtn";
            this.VolverEntradaBtn.Size = new System.Drawing.Size(264, 103);
            this.VolverEntradaBtn.TabIndex = 21;
            this.VolverEntradaBtn.Text = "Volver";
            this.VolverEntradaBtn.UseVisualStyleBackColor = false;
            this.VolverEntradaBtn.Click += new System.EventHandler(this.VolverEntradaBtn_Click);
            // 
            // ReporteEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.VolverEntradaBtn);
            this.Controls.Add(this.ReporteEntradaGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1701, 875);
            this.MinimumSize = new System.Drawing.Size(1701, 875);
            this.Name = "ReporteEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteEntradas";
            this.Load += new System.EventHandler(this.ReporteEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteEntradaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaInventarioDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReporteEntradaGrid;
        private SistemaInventarioDataSet3 sistemaInventarioDataSet3;
        private System.Windows.Forms.BindingSource entradasBindingSource;
        private SistemaInventarioDataSet3TableAdapters.EntradasTableAdapter entradasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProductosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button VolverEntradaBtn;
    }
}