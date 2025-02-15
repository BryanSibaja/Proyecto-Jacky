namespace Presentacion
{
    partial class ConsultarTipoVideojuegoForm
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
            TipoDataGridView = new DataGridView();
            tipoVideojuegoEntidadBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)TipoDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tipoVideojuegoEntidadBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TipoDataGridView
            // 
            TipoDataGridView.AllowUserToAddRows = false;
            TipoDataGridView.AllowUserToDeleteRows = false;
            TipoDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TipoDataGridView.AutoGenerateColumns = false;
            TipoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TipoDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn });
            TipoDataGridView.DataSource = tipoVideojuegoEntidadBindingSource;
            TipoDataGridView.Location = new Point(12, 12);
            TipoDataGridView.Name = "TipoDataGridView";
            TipoDataGridView.ReadOnly = true;
            TipoDataGridView.Size = new Size(350, 209);
            TipoDataGridView.TabIndex = 0;
            // 
            // tipoVideojuegoEntidadBindingSource
            // 
            tipoVideojuegoEntidadBindingSource.DataSource = typeof(Entidades.TipoVideojuegoEntidad);
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
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ConsultarTipoVideojuegoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 233);
            Controls.Add(TipoDataGridView);
            Name = "ConsultarTipoVideojuegoForm";
            Text = "Consultar tipos";
            ((System.ComponentModel.ISupportInitialize)TipoDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)tipoVideojuegoEntidadBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TipoDataGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private BindingSource tipoVideojuegoEntidadBindingSource;
    }
}