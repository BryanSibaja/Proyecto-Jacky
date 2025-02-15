namespace Presentacion
{
    partial class ConsultarAdministradorForm
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
            AdministradorDataGridView = new DataGridView();
            identificacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            primerApellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            segundoApellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaContratacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            administradorEntidadBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)AdministradorDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)administradorEntidadBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AdministradorDataGridView
            // 
            AdministradorDataGridView.AllowUserToAddRows = false;
            AdministradorDataGridView.AllowUserToDeleteRows = false;
            AdministradorDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AdministradorDataGridView.AutoGenerateColumns = false;
            AdministradorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdministradorDataGridView.Columns.AddRange(new DataGridViewColumn[] { identificacionDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, primerApellidoDataGridViewTextBoxColumn, segundoApellidoDataGridViewTextBoxColumn, fechaContratacionDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn });
            AdministradorDataGridView.DataSource = administradorEntidadBindingSource;
            AdministradorDataGridView.Location = new Point(12, 12);
            AdministradorDataGridView.Name = "AdministradorDataGridView";
            AdministradorDataGridView.ReadOnly = true;
            AdministradorDataGridView.Size = new Size(646, 325);
            AdministradorDataGridView.TabIndex = 0;
            // 
            // identificacionDataGridViewTextBoxColumn
            // 
            identificacionDataGridViewTextBoxColumn.DataPropertyName = "Identificacion";
            identificacionDataGridViewTextBoxColumn.HeaderText = "Identificacion";
            identificacionDataGridViewTextBoxColumn.Name = "identificacionDataGridViewTextBoxColumn";
            identificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // primerApellidoDataGridViewTextBoxColumn
            // 
            primerApellidoDataGridViewTextBoxColumn.DataPropertyName = "PrimerApellido";
            primerApellidoDataGridViewTextBoxColumn.HeaderText = "Primer apellido";
            primerApellidoDataGridViewTextBoxColumn.Name = "primerApellidoDataGridViewTextBoxColumn";
            primerApellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // segundoApellidoDataGridViewTextBoxColumn
            // 
            segundoApellidoDataGridViewTextBoxColumn.DataPropertyName = "SegundoApellido";
            segundoApellidoDataGridViewTextBoxColumn.HeaderText = "Segundo apellido";
            segundoApellidoDataGridViewTextBoxColumn.Name = "segundoApellidoDataGridViewTextBoxColumn";
            segundoApellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaContratacionDataGridViewTextBoxColumn
            // 
            fechaContratacionDataGridViewTextBoxColumn.DataPropertyName = "FechaContratacion";
            fechaContratacionDataGridViewTextBoxColumn.HeaderText = "Fecha contratacion";
            fechaContratacionDataGridViewTextBoxColumn.Name = "fechaContratacionDataGridViewTextBoxColumn";
            fechaContratacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha nacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // administradorEntidadBindingSource
            // 
            administradorEntidadBindingSource.DataSource = typeof(Entidades.AdministradorEntidad);
            // 
            // ConsultarAdministradorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 349);
            Controls.Add(AdministradorDataGridView);
            Name = "ConsultarAdministradorForm";
            Text = "Consultar administrador";
            ((System.ComponentModel.ISupportInitialize)AdministradorDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)administradorEntidadBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView AdministradorDataGridView;
        private DataGridViewTextBoxColumn identificacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn primerApellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn segundoApellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaContratacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private BindingSource administradorEntidadBindingSource;
    }
}