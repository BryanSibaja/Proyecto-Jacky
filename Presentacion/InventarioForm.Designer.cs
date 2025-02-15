namespace Presentacion
{
    partial class InventarioForm
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
            label1 = new Label();
            TiendaComboBox = new ComboBox();
            tiendaEntidadBindingSource = new BindingSource(components);
            label2 = new Label();
            CantidadNumericUpDown = new NumericUpDown();
            label3 = new Label();
            VideojuegoDataGridView = new DataGridView();
            videojuegoEntidadBindingSource = new BindingSource(components);
            tipoVideojuegoEntidadBindingSource = new BindingSource(components);
            RegistrarButton = new Button();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TipoVideojuego = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            desarrolladorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lanzamientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tiendaEntidadBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CantidadNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VideojuegoDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)videojuegoEntidadBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tipoVideojuegoEntidadBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Tienda";
            // 
            // TiendaComboBox
            // 
            TiendaComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TiendaComboBox.DataSource = tiendaEntidadBindingSource;
            TiendaComboBox.DisplayMember = "Nombre";
            TiendaComboBox.FormattingEnabled = true;
            TiendaComboBox.Location = new Point(12, 27);
            TiendaComboBox.Name = "TiendaComboBox";
            TiendaComboBox.Size = new Size(541, 23);
            TiendaComboBox.TabIndex = 1;
            // 
            // tiendaEntidadBindingSource
            // 
            tiendaEntidadBindingSource.DataSource = typeof(Entidades.TiendaEntidad);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Cantidad";
            // 
            // CantidadNumericUpDown
            // 
            CantidadNumericUpDown.Location = new Point(12, 71);
            CantidadNumericUpDown.Name = "CantidadNumericUpDown";
            CantidadNumericUpDown.Size = new Size(254, 23);
            CantidadNumericUpDown.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Videojuegos";
            // 
            // VideojuegoDataGridView
            // 
            VideojuegoDataGridView.AllowUserToAddRows = false;
            VideojuegoDataGridView.AllowUserToDeleteRows = false;
            VideojuegoDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VideojuegoDataGridView.AutoGenerateColumns = false;
            VideojuegoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VideojuegoDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, TipoVideojuego, nombreDataGridViewTextBoxColumn, desarrolladorDataGridViewTextBoxColumn, lanzamientoDataGridViewTextBoxColumn });
            VideojuegoDataGridView.DataSource = videojuegoEntidadBindingSource;
            VideojuegoDataGridView.Location = new Point(12, 115);
            VideojuegoDataGridView.Name = "VideojuegoDataGridView";
            VideojuegoDataGridView.ReadOnly = true;
            VideojuegoDataGridView.Size = new Size(541, 254);
            VideojuegoDataGridView.TabIndex = 5;
            // 
            // videojuegoEntidadBindingSource
            // 
            videojuegoEntidadBindingSource.DataSource = typeof(Entidades.VideojuegoEntidad);
            // 
            // tipoVideojuegoEntidadBindingSource
            // 
            tipoVideojuegoEntidadBindingSource.DataSource = typeof(Entidades.TipoVideojuegoEntidad);
            // 
            // RegistrarButton
            // 
            RegistrarButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RegistrarButton.Location = new Point(478, 421);
            RegistrarButton.Name = "RegistrarButton";
            RegistrarButton.Size = new Size(75, 23);
            RegistrarButton.TabIndex = 6;
            RegistrarButton.Text = "Registrar";
            RegistrarButton.UseVisualStyleBackColor = true;
            RegistrarButton.Click += button1_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TipoVideojuego
            // 
            TipoVideojuego.DataPropertyName = "TipoVideojuego";
            TipoVideojuego.HeaderText = "Tipo";
            TipoVideojuego.Name = "TipoVideojuego";
            TipoVideojuego.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
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
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 456);
            Controls.Add(RegistrarButton);
            Controls.Add(VideojuegoDataGridView);
            Controls.Add(label3);
            Controls.Add(CantidadNumericUpDown);
            Controls.Add(label2);
            Controls.Add(TiendaComboBox);
            Controls.Add(label1);
            Name = "InventarioForm";
            Text = "Registrar Inventario";
            ((System.ComponentModel.ISupportInitialize)tiendaEntidadBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)CantidadNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)VideojuegoDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)videojuegoEntidadBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tipoVideojuegoEntidadBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox TiendaComboBox;
        private Label label2;
        private NumericUpDown CantidadNumericUpDown;
        private Label label3;
        private DataGridView VideojuegoDataGridView;
        private BindingSource videojuegoEntidadBindingSource;
        private Button RegistrarButton;
        private BindingSource tiendaEntidadBindingSource;
        private DataGridViewTextBoxColumn tipoVideojuegoDataGridViewTextBoxColumn;
        private BindingSource tipoVideojuegoEntidadBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TipoVideojuego;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn desarrolladorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lanzamientoDataGridViewTextBoxColumn;
    }
}