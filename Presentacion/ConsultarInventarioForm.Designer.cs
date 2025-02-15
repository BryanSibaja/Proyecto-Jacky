namespace Presentacion
{
    partial class ConsultarInventarioForm
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
            components = new System.ComponentModel.Container();
            InventarioDataGridView = new DataGridView();
            videojuegosXTiendaEntidadBindingSource = new BindingSource(components);
            Tienda = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Videojuego = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            existenciasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)InventarioDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)videojuegosXTiendaEntidadBindingSource).BeginInit();
            SuspendLayout();
            // 
            // InventarioDataGridView
            // 
            InventarioDataGridView.AllowUserToAddRows = false;
            InventarioDataGridView.AllowUserToDeleteRows = false;
            InventarioDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InventarioDataGridView.AutoGenerateColumns = false;
            InventarioDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventarioDataGridView.Columns.AddRange(new DataGridViewColumn[] { Tienda, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Videojuego, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, existenciasDataGridViewTextBoxColumn });
            InventarioDataGridView.DataSource = videojuegosXTiendaEntidadBindingSource;
            InventarioDataGridView.Location = new Point(12, 12);
            InventarioDataGridView.Name = "InventarioDataGridView";
            InventarioDataGridView.ReadOnly = true;
            InventarioDataGridView.Size = new Size(748, 413);
            InventarioDataGridView.TabIndex = 0;
            // 
            // videojuegosXTiendaEntidadBindingSource
            // 
            videojuegosXTiendaEntidadBindingSource.DataSource = typeof(Entidades.VideojuegosXTiendaEntidad);
            // 
            // Tienda
            // 
            Tienda.DataPropertyName = "Tienda";
            Tienda.HeaderText = "Tienda id";
            Tienda.Name = "Tienda";
            Tienda.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Tienda";
            dataGridViewTextBoxColumn1.HeaderText = "Tienda nombre";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Tienda";
            dataGridViewTextBoxColumn2.HeaderText = "Tienda direccion";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Videojuego
            // 
            Videojuego.DataPropertyName = "Videojuego";
            Videojuego.HeaderText = "Videojuego id";
            Videojuego.Name = "Videojuego";
            Videojuego.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Videojuego";
            dataGridViewTextBoxColumn3.HeaderText = "Videojuego nombre";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Videojuego";
            dataGridViewTextBoxColumn4.HeaderText = "Videojuego tipo";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // existenciasDataGridViewTextBoxColumn
            // 
            existenciasDataGridViewTextBoxColumn.DataPropertyName = "Existencias";
            existenciasDataGridViewTextBoxColumn.HeaderText = "Existencias";
            existenciasDataGridViewTextBoxColumn.Name = "existenciasDataGridViewTextBoxColumn";
            existenciasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ConsultarInventarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 437);
            Controls.Add(InventarioDataGridView);
            Name = "ConsultarInventarioForm";
            Text = "ConsultarInventarioForm";
            ((System.ComponentModel.ISupportInitialize)InventarioDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)videojuegosXTiendaEntidadBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView InventarioDataGridView;
        private BindingSource videojuegosXTiendaEntidadBindingSource;
        private DataGridViewTextBoxColumn Tienda;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Videojuego;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn existenciasDataGridViewTextBoxColumn;
    }
}