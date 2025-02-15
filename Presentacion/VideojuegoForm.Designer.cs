namespace Presentacion
{
    partial class VideojuegoForm
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
            IdNumericUpDown = new NumericUpDown();
            NombreLabel = new Label();
            NombreTextBox = new TextBox();
            label3 = new Label();
            TipoVideojuegoComboBox = new ComboBox();
            tipoVideojuegoEntidadBindingSource = new BindingSource(components);
            label2 = new Label();
            DesarrolladorTextBox = new TextBox();
            label4 = new Label();
            LanzamientoNumericUpDown = new NumericUpDown();
            FisicoComboBox = new ComboBox();
            label5 = new Label();
            RegistrarButton = new Button();
            boolComboBoxItemBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)IdNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tipoVideojuegoEntidadBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LanzamientoNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boolComboBoxItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // IdNumericUpDown
            // 
            IdNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IdNumericUpDown.Location = new Point(12, 27);
            IdNumericUpDown.Name = "IdNumericUpDown";
            IdNumericUpDown.Size = new Size(151, 23);
            IdNumericUpDown.TabIndex = 1;
            // 
            // NombreLabel
            // 
            NombreLabel.AutoSize = true;
            NombreLabel.Location = new Point(12, 53);
            NombreLabel.Name = "NombreLabel";
            NombreLabel.Size = new Size(51, 15);
            NombreLabel.TabIndex = 2;
            NombreLabel.Text = "Nombre";
            // 
            // NombreTextBox
            // 
            NombreTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NombreTextBox.Location = new Point(12, 71);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(320, 23);
            NombreTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo";
            // 
            // TipoVideojuegoComboBox
            // 
            TipoVideojuegoComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TipoVideojuegoComboBox.DataSource = tipoVideojuegoEntidadBindingSource;
            TipoVideojuegoComboBox.DisplayMember = "Nombre";
            TipoVideojuegoComboBox.FormattingEnabled = true;
            TipoVideojuegoComboBox.Location = new Point(12, 115);
            TipoVideojuegoComboBox.Name = "TipoVideojuegoComboBox";
            TipoVideojuegoComboBox.Size = new Size(320, 23);
            TipoVideojuegoComboBox.TabIndex = 5;
            // 
            // tipoVideojuegoEntidadBindingSource
            // 
            tipoVideojuegoEntidadBindingSource.DataSource = typeof(Entidades.TipoVideojuegoEntidad);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 6;
            label2.Text = "Desarrollador";
            // 
            // DesarrolladorTextBox
            // 
            DesarrolladorTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DesarrolladorTextBox.Location = new Point(12, 159);
            DesarrolladorTextBox.Name = "DesarrolladorTextBox";
            DesarrolladorTextBox.Size = new Size(320, 23);
            DesarrolladorTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 8;
            label4.Text = "Lanzamiento";
            // 
            // LanzamientoNumericUpDown
            // 
            LanzamientoNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LanzamientoNumericUpDown.Location = new Point(12, 203);
            LanzamientoNumericUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            LanzamientoNumericUpDown.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            LanzamientoNumericUpDown.Name = "LanzamientoNumericUpDown";
            LanzamientoNumericUpDown.Size = new Size(151, 23);
            LanzamientoNumericUpDown.TabIndex = 9;
            LanzamientoNumericUpDown.Value = new decimal(new int[] { 1970, 0, 0, 0 });
            // 
            // FisicoComboBox
            // 
            FisicoComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FisicoComboBox.DataSource = boolComboBoxItemBindingSource;
            FisicoComboBox.DisplayMember = "Text";
            FisicoComboBox.FormattingEnabled = true;
            FisicoComboBox.Location = new Point(12, 247);
            FisicoComboBox.Name = "FisicoComboBox";
            FisicoComboBox.Size = new Size(320, 23);
            FisicoComboBox.TabIndex = 10;
            FisicoComboBox.ValueMember = "Value";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 229);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 11;
            label5.Text = "Físico";
            // 
            // RegistrarButton
            // 
            RegistrarButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RegistrarButton.Location = new Point(257, 328);
            RegistrarButton.Name = "RegistrarButton";
            RegistrarButton.Size = new Size(75, 23);
            RegistrarButton.TabIndex = 12;
            RegistrarButton.Text = "Registrar";
            RegistrarButton.UseVisualStyleBackColor = true;
            RegistrarButton.Click += RegistrarButton_Click;
            // 
            // boolComboBoxItemBindingSource
            // 
            boolComboBoxItemBindingSource.DataSource = typeof(BoolComboBoxItem);
            // 
            // VideojuegoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 363);
            Controls.Add(RegistrarButton);
            Controls.Add(label5);
            Controls.Add(FisicoComboBox);
            Controls.Add(LanzamientoNumericUpDown);
            Controls.Add(label4);
            Controls.Add(DesarrolladorTextBox);
            Controls.Add(label2);
            Controls.Add(TipoVideojuegoComboBox);
            Controls.Add(label3);
            Controls.Add(NombreTextBox);
            Controls.Add(NombreLabel);
            Controls.Add(IdNumericUpDown);
            Controls.Add(label1);
            Name = "VideojuegoForm";
            Text = "VideojuegoForm";
            ((System.ComponentModel.ISupportInitialize)IdNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)tipoVideojuegoEntidadBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)LanzamientoNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)boolComboBoxItemBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown IdNumericUpDown;
        private Label NombreLabel;
        private TextBox NombreTextBox;
        private Label label3;
        private ComboBox TipoVideojuegoComboBox;
        private BindingSource tipoVideojuegoEntidadBindingSource;
        private Label label2;
        private TextBox DesarrolladorTextBox;
        private Label label4;
        private NumericUpDown LanzamientoNumericUpDown;
        private ComboBox FisicoComboBox;
        private Label label5;
        private Button RegistrarButton;
        private BindingSource boolComboBoxItemBindingSource;
    }
}