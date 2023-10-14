namespace SistemaInventarios
{
    partial class ReporteSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteSalida));
            this.ReporteSalidaGrid = new System.Windows.Forms.DataGridView();
            this.iDSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProductosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaInventarioDataSet5 = new SistemaInventarios.SistemaInventarioDataSet5();
            this.sistemaInventarioDataSet4 = new SistemaInventarios.SistemaInventarioDataSet4();
            this.salidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salidasTableAdapter = new SistemaInventarios.SistemaInventarioDataSet4TableAdapters.SalidasTableAdapter();
            this.VolverSalidaBtn = new System.Windows.Forms.Button();
            this.salidasTableAdapter1 = new SistemaInventarios.SistemaInventarioDataSet5TableAdapters.SalidasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteSalidaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaInventarioDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaInventarioDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteSalidaGrid
            // 
            this.ReporteSalidaGrid.AutoGenerateColumns = false;
            this.ReporteSalidaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReporteSalidaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSalidaDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.cantidadProductosDataGridViewTextBoxColumn,
            this.fechaSalidaDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn});
            this.ReporteSalidaGrid.DataSource = this.salidasBindingSource1;
            this.ReporteSalidaGrid.Location = new System.Drawing.Point(430, 100);
            this.ReporteSalidaGrid.Name = "ReporteSalidaGrid";
            this.ReporteSalidaGrid.RowHeadersWidth = 51;
            this.ReporteSalidaGrid.RowTemplate.Height = 24;
            this.ReporteSalidaGrid.Size = new System.Drawing.Size(913, 631);
            this.ReporteSalidaGrid.TabIndex = 0;
            // 
            // iDSalidaDataGridViewTextBoxColumn
            // 
            this.iDSalidaDataGridViewTextBoxColumn.DataPropertyName = "ID_Salida";
            this.iDSalidaDataGridViewTextBoxColumn.HeaderText = "ID_Salida";
            this.iDSalidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDSalidaDataGridViewTextBoxColumn.Name = "iDSalidaDataGridViewTextBoxColumn";
            this.iDSalidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSalidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadProductosDataGridViewTextBoxColumn
            // 
            this.cantidadProductosDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_Productos";
            this.cantidadProductosDataGridViewTextBoxColumn.HeaderText = "Cantidad_Productos";
            this.cantidadProductosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadProductosDataGridViewTextBoxColumn.Name = "cantidadProductosDataGridViewTextBoxColumn";
            this.cantidadProductosDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaSalidaDataGridViewTextBoxColumn
            // 
            this.fechaSalidaDataGridViewTextBoxColumn.DataPropertyName = "FechaSalida";
            this.fechaSalidaDataGridViewTextBoxColumn.HeaderText = "FechaSalida";
            this.fechaSalidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaSalidaDataGridViewTextBoxColumn.Name = "fechaSalidaDataGridViewTextBoxColumn";
            this.fechaSalidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.Width = 125;
            // 
            // salidasBindingSource1
            // 
            this.salidasBindingSource1.DataMember = "Salidas";
            this.salidasBindingSource1.DataSource = this.sistemaInventarioDataSet5;
            // 
            // sistemaInventarioDataSet5
            // 
            this.sistemaInventarioDataSet5.DataSetName = "SistemaInventarioDataSet5";
            this.sistemaInventarioDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemaInventarioDataSet4
            // 
            this.sistemaInventarioDataSet4.DataSetName = "SistemaInventarioDataSet4";
            this.sistemaInventarioDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salidasBindingSource
            // 
            this.salidasBindingSource.DataMember = "Salidas";
            this.salidasBindingSource.DataSource = this.sistemaInventarioDataSet4;
            // 
            // salidasTableAdapter
            // 
            this.salidasTableAdapter.ClearBeforeFill = true;
            // 
            // VolverSalidaBtn
            // 
            this.VolverSalidaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.VolverSalidaBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverSalidaBtn.Location = new System.Drawing.Point(77, 178);
            this.VolverSalidaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.VolverSalidaBtn.Name = "VolverSalidaBtn";
            this.VolverSalidaBtn.Size = new System.Drawing.Size(264, 103);
            this.VolverSalidaBtn.TabIndex = 22;
            this.VolverSalidaBtn.Text = "Volver";
            this.VolverSalidaBtn.UseVisualStyleBackColor = false;
            this.VolverSalidaBtn.Click += new System.EventHandler(this.VolverSalidaBtn_Click);
            // 
            // salidasTableAdapter1
            // 
            this.salidasTableAdapter1.ClearBeforeFill = true;
            // 
            // ReporteSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.VolverSalidaBtn);
            this.Controls.Add(this.ReporteSalidaGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1701, 875);
            this.MinimumSize = new System.Drawing.Size(1701, 875);
            this.Name = "ReporteSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteSalida";
            this.Load += new System.EventHandler(this.ReporteSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteSalidaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaInventarioDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaInventarioDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReporteSalidaGrid;
        private SistemaInventarioDataSet4 sistemaInventarioDataSet4;
        private System.Windows.Forms.BindingSource salidasBindingSource;
        private SistemaInventarioDataSet4TableAdapters.SalidasTableAdapter salidasTableAdapter;
        private System.Windows.Forms.Button VolverSalidaBtn;
        private SistemaInventarioDataSet5 sistemaInventarioDataSet5;
        private System.Windows.Forms.BindingSource salidasBindingSource1;
        private SistemaInventarioDataSet5TableAdapters.SalidasTableAdapter salidasTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProductosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
    }
}