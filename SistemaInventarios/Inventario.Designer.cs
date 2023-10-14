namespace SistemaInventarios
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.Inventario_AjustesBtn = new System.Windows.Forms.Button();
            this.Entrada_SalirBtn = new System.Windows.Forms.Button();
            this.Inventario_InventarioBtn = new System.Windows.Forms.Button();
            this.Inventario_EntradaBtn = new System.Windows.Forms.Button();
            this.Inventario_SalidaBTn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Inventario_GridView1 = new System.Windows.Forms.DataGridView();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaInventarioDataSet1 = new SistemaInventarios.SistemaInventarioDataSet1();
            this.Inventario_ReporteBtn = new System.Windows.Forms.Button();
            this.sistemaInventarioDataSet = new SistemaInventarios.SistemaInventarioDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new SistemaInventarios.SistemaInventarioDataSetTableAdapters.ProductosTableAdapter();
            this.productosTableAdapter1 = new SistemaInventarios.SistemaInventarioDataSet1TableAdapters.ProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventario_GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaInventarioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaInventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Inventario_AjustesBtn
            // 
            this.Inventario_AjustesBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Inventario_AjustesBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventario_AjustesBtn.Location = new System.Drawing.Point(65, 533);
            this.Inventario_AjustesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inventario_AjustesBtn.Name = "Inventario_AjustesBtn";
            this.Inventario_AjustesBtn.Size = new System.Drawing.Size(132, 62);
            this.Inventario_AjustesBtn.TabIndex = 11;
            this.Inventario_AjustesBtn.Text = "AJUSTES";
            this.Inventario_AjustesBtn.UseVisualStyleBackColor = false;
            this.Inventario_AjustesBtn.Click += new System.EventHandler(this.Inventario_AjustesBtn_Click);
            // 
            // Entrada_SalirBtn
            // 
            this.Entrada_SalirBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Entrada_SalirBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrada_SalirBtn.Location = new System.Drawing.Point(65, 763);
            this.Entrada_SalirBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Entrada_SalirBtn.Name = "Entrada_SalirBtn";
            this.Entrada_SalirBtn.Size = new System.Drawing.Size(132, 62);
            this.Entrada_SalirBtn.TabIndex = 10;
            this.Entrada_SalirBtn.Text = "SALIR";
            this.Entrada_SalirBtn.UseVisualStyleBackColor = false;
            this.Entrada_SalirBtn.Click += new System.EventHandler(this.Entrada_SalirBtn_Click);
            // 
            // Inventario_InventarioBtn
            // 
            this.Inventario_InventarioBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Inventario_InventarioBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventario_InventarioBtn.Location = new System.Drawing.Point(65, 383);
            this.Inventario_InventarioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inventario_InventarioBtn.Name = "Inventario_InventarioBtn";
            this.Inventario_InventarioBtn.Size = new System.Drawing.Size(132, 62);
            this.Inventario_InventarioBtn.TabIndex = 9;
            this.Inventario_InventarioBtn.Text = "INVENTARIO";
            this.Inventario_InventarioBtn.UseVisualStyleBackColor = false;
            this.Inventario_InventarioBtn.Click += new System.EventHandler(this.Inventario_InventarioBtn_Click);
            // 
            // Inventario_EntradaBtn
            // 
            this.Inventario_EntradaBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Inventario_EntradaBtn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventario_EntradaBtn.Location = new System.Drawing.Point(65, 224);
            this.Inventario_EntradaBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inventario_EntradaBtn.Name = "Inventario_EntradaBtn";
            this.Inventario_EntradaBtn.Size = new System.Drawing.Size(132, 62);
            this.Inventario_EntradaBtn.TabIndex = 8;
            this.Inventario_EntradaBtn.Text = "ENTRADA";
            this.Inventario_EntradaBtn.UseVisualStyleBackColor = false;
            this.Inventario_EntradaBtn.Click += new System.EventHandler(this.Inventario_EntradaBtn_Click);
            // 
            // Inventario_SalidaBTn
            // 
            this.Inventario_SalidaBTn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Inventario_SalidaBTn.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventario_SalidaBTn.Location = new System.Drawing.Point(65, 73);
            this.Inventario_SalidaBTn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inventario_SalidaBTn.Name = "Inventario_SalidaBTn";
            this.Inventario_SalidaBTn.Size = new System.Drawing.Size(132, 62);
            this.Inventario_SalidaBTn.TabIndex = 7;
            this.Inventario_SalidaBTn.Text = "SALIDA";
            this.Inventario_SalidaBTn.UseVisualStyleBackColor = false;
            this.Inventario_SalidaBTn.Click += new System.EventHandler(this.Inventario_SalidaBTn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 837);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Inventario_GridView1
            // 
            this.Inventario_GridView1.AutoGenerateColumns = false;
            this.Inventario_GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inventario_GridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proveedorDataGridViewTextBoxColumn,
            this.unidadDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn});
            this.Inventario_GridView1.DataSource = this.productosBindingSource1;
            this.Inventario_GridView1.Location = new System.Drawing.Point(600, 15);
            this.Inventario_GridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inventario_GridView1.Name = "Inventario_GridView1";
            this.Inventario_GridView1.RowHeadersWidth = 51;
            this.Inventario_GridView1.Size = new System.Drawing.Size(732, 708);
            this.Inventario_GridView1.TabIndex = 12;
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            this.proveedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // unidadDataGridViewTextBoxColumn
            // 
            this.unidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad";
            this.unidadDataGridViewTextBoxColumn.HeaderText = "Unidad";
            this.unidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadDataGridViewTextBoxColumn.Name = "unidadDataGridViewTextBoxColumn";
            this.unidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Producto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "Nombre_Producto";
            this.nombreProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            this.nombreProductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataMember = "Productos";
            this.productosBindingSource1.DataSource = this.sistemaInventarioDataSet1;
            // 
            // sistemaInventarioDataSet1
            // 
            this.sistemaInventarioDataSet1.DataSetName = "SistemaInventarioDataSet1";
            this.sistemaInventarioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Inventario_ReporteBtn
            // 
            this.Inventario_ReporteBtn.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventario_ReporteBtn.Location = new System.Drawing.Point(869, 743);
            this.Inventario_ReporteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inventario_ReporteBtn.Name = "Inventario_ReporteBtn";
            this.Inventario_ReporteBtn.Size = new System.Drawing.Size(199, 80);
            this.Inventario_ReporteBtn.TabIndex = 13;
            this.Inventario_ReporteBtn.Text = "Imprimir Reporte";
            this.Inventario_ReporteBtn.UseVisualStyleBackColor = true;
            // 
            // sistemaInventarioDataSet
            // 
            this.sistemaInventarioDataSet.DataSetName = "SistemaInventarioDataSet";
            this.sistemaInventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.sistemaInventarioDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // productosTableAdapter1
            // 
            this.productosTableAdapter1.ClearBeforeFill = true;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1683, 828);
            this.Controls.Add(this.Inventario_ReporteBtn);
            this.Controls.Add(this.Inventario_GridView1);
            this.Controls.Add(this.Inventario_AjustesBtn);
            this.Controls.Add(this.Entrada_SalirBtn);
            this.Controls.Add(this.Inventario_InventarioBtn);
            this.Controls.Add(this.Inventario_EntradaBtn);
            this.Controls.Add(this.Inventario_SalidaBTn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1701, 875);
            this.MinimumSize = new System.Drawing.Size(1701, 875);
            this.Name = "Inventario";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventario_GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaInventarioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaInventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Inventario_AjustesBtn;
        private System.Windows.Forms.Button Entrada_SalirBtn;
        private System.Windows.Forms.Button Inventario_InventarioBtn;
        private System.Windows.Forms.Button Inventario_EntradaBtn;
        private System.Windows.Forms.Button Inventario_SalidaBTn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView Inventario_GridView1;
        private System.Windows.Forms.Button Inventario_ReporteBtn;
        private SistemaInventarioDataSet sistemaInventarioDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private SistemaInventarioDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private SistemaInventarioDataSet1 sistemaInventarioDataSet1;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private SistemaInventarioDataSet1TableAdapters.ProductosTableAdapter productosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
    }
}