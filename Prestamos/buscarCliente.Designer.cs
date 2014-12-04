namespace Prestamos
{
    partial class buscarCliente
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
            this.bcDataGridView = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamistaDataSet = new Prestamos.PrestamistaDataSet();
            this.bcBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientesTableAdapter = new Prestamos.PrestamistaDataSetTableAdapters.clientesTableAdapter();
            this.eccancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bcDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamistaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bcDataGridView
            // 
            this.bcDataGridView.AllowUserToAddRows = false;
            this.bcDataGridView.AllowUserToDeleteRows = false;
            this.bcDataGridView.AutoGenerateColumns = false;
            this.bcDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bcDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn});
            this.bcDataGridView.DataSource = this.clientesBindingSource;
            this.bcDataGridView.Location = new System.Drawing.Point(32, 65);
            this.bcDataGridView.MultiSelect = false;
            this.bcDataGridView.Name = "bcDataGridView";
            this.bcDataGridView.ReadOnly = true;
            this.bcDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bcDataGridView.Size = new System.Drawing.Size(394, 150);
            this.bcDataGridView.TabIndex = 7;
            this.bcDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bcDataGridView_CellDoubleClick);
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idClienteDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cedulaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.direccionDataGridViewTextBoxColumn.Width = 300;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.prestamistaDataSet;
            // 
            // prestamistaDataSet
            // 
            this.prestamistaDataSet.DataSetName = "PrestamistaDataSet";
            this.prestamistaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bcBusqueda
            // 
            this.bcBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcBusqueda.Location = new System.Drawing.Point(144, 28);
            this.bcBusqueda.Name = "bcBusqueda";
            this.bcBusqueda.Size = new System.Drawing.Size(178, 22);
            this.bcBusqueda.TabIndex = 5;
            this.bcBusqueda.TextChanged += new System.EventHandler(this.bcBusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar cliente";
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // eccancelar
            // 
            this.eccancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eccancelar.Location = new System.Drawing.Point(328, 28);
            this.eccancelar.Name = "eccancelar";
            this.eccancelar.Size = new System.Drawing.Size(76, 22);
            this.eccancelar.TabIndex = 8;
            this.eccancelar.Text = "Insertar";
            this.eccancelar.UseVisualStyleBackColor = true;
            this.eccancelar.Click += new System.EventHandler(this.eccancelar_Click);
            // 
            // buscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 242);
            this.Controls.Add(this.eccancelar);
            this.Controls.Add(this.bcDataGridView);
            this.Controls.Add(this.bcBusqueda);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "buscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar cliente";
            this.Load += new System.EventHandler(this.buscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bcDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamistaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bcDataGridView;
        private System.Windows.Forms.TextBox bcBusqueda;
        private System.Windows.Forms.Label label1;
        private PrestamistaDataSet prestamistaDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private PrestamistaDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button eccancelar;
    }
}