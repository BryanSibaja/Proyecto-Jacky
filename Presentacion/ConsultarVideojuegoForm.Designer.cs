namespace Presentacion
{
    partial class ConsultarVideojuegoForm
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
            VideojuegoDataGridView = new DataGridView();
            videojuegoEntidadBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoVideojuegoNombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            desarrolladorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lanzamientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fisicoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)VideojuegoDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)videojuegoEntidadBindingSource).BeginInit();
            SuspendLayout();
            // 
            // VideojuegoDataGridView
            // 
            VideojuegoDataGridView.AllowUserToAddRows = false;
            VideojuegoDataGridView.AllowUserToDeleteRows = false;
            VideojuegoDataGridView.AutoGenerateColumns = false;
            VideojuegoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VideojuegoDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, tipoVideojuegoNombreDataGridViewTextBoxColumn, desarrolladorDataGridViewTextBoxColumn, lanzamientoDataGridViewTextBoxColumn, fisicoDataGridViewCheckBoxColumn });
            VideojuegoDataGridView.DataSource = videojuegoEntidadBindingSource;
            VideojuegoDataGridView.Location = new Point(12, 12);
            VideojuegoDataGridView.Name = "VideojuegoDataGridView";
            VideojuegoDataGridView.ReadOnly = true;
            VideojuegoDataGridView.Size = new Size(632, 333);
            VideojuegoDataGridView.TabIndex = 0;
            // 
            // videojuegoEntidadBindingSource
            // 
            videojuegoEntidadBindingSource.DataSource = typeof(Entidades.VideojuegoEntidad);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoVideojuegoNombreDataGridViewTextBoxColumn
            // 
            tipoVideojuegoNombreDataGridViewTextBoxColumn.DataPropertyName = "TipoVideojuegoNombre";
            tipoVideojuegoNombreDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoVideojuegoNombreDataGridViewTextBoxColumn.Name = "tipoVideojuegoNombreDataGridViewTextBoxColumn";
            tipoVideojuegoNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // desarrolladorDataGridViewTextBoxColumn
            // 
            desarrolladorDataGridViewTextBoxColumn.DataPropertyName = "Desarrollador";
            desarrolladorDataGridViewTextBoxColumn.HeaderText = "Desarrollador";
            desarrolladorDataGridViewTextBoxColumn.Name = "desarrolladorDataGridViewTextBoxColumn";
            desarrolladorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lanzamientoDataGridViewTextBoxColumn
            // 
            lanzamientoDataGridViewTextBoxColumn.DataPropertyName = "Lanzamiento";
            lanzamientoDataGridViewTextBoxColumn.HeaderText = "Lanzamiento";
            lanzamientoDataGridViewTextBoxColumn.Name = "lanzamientoDataGridViewTextBoxColumn";
            lanzamientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fisicoDataGridViewCheckBoxColumn
            // 
            fisicoDataGridViewCheckBoxColumn.DataPropertyName = "Fisico";
            fisicoDataGridViewCheckBoxColumn.HeaderText = "Fisico";
            fisicoDataGridViewCheckBoxColumn.Name = "fisicoDataGridViewCheckBoxColumn";
            fisicoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ConsultarVideojuegoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 357);
            Controls.Add(VideojuegoDataGridView);
            Name = "ConsultarVideojuegoForm";
            Text = "Consultar videojuego";
            ((System.ComponentModel.ISupportInitialize)VideojuegoDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)videojuegoEntidadBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView VideojuegoDataGridView;
        private BindingSource videojuegoEntidadBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoVideojuegoNombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn desarrolladorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lanzamientoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn fisicoDataGridViewCheckBoxColumn;
    }
}