namespace Presentacion
{
    partial class TiendaForm
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
            label2 = new Label();
            NombreTextBox = new TextBox();
            label3 = new Label();
            AdministradorComboBox = new ComboBox();
            administradorEntidadBindingSource = new BindingSource(components);
            label4 = new Label();
            DireccionTextBox = new TextBox();
            label5 = new Label();
            TelefonoTextBox = new TextBox();
            ActivaComboBox = new ComboBox();
            boolComboBoxItemBindingSource = new BindingSource(components);
            label6 = new Label();
            RegistrarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)IdNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)administradorEntidadBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boolComboBoxItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // IdNumericUpDown
            // 
            IdNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IdNumericUpDown.Location = new Point(12, 27);
            IdNumericUpDown.Name = "IdNumericUpDown";
            IdNumericUpDown.Size = new Size(84, 23);
            IdNumericUpDown.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // NombreTextBox
            // 
            NombreTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NombreTextBox.Location = new Point(12, 71);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(315, 23);
            NombreTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 4;
            label3.Text = "Administrador";
            // 
            // AdministradorComboBox
            // 
            AdministradorComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AdministradorComboBox.DataSource = administradorEntidadBindingSource;
            AdministradorComboBox.DisplayMember = "Nombre";
            AdministradorComboBox.FormattingEnabled = true;
            AdministradorComboBox.Location = new Point(12, 115);
            AdministradorComboBox.Name = "AdministradorComboBox";
            AdministradorComboBox.Size = new Size(315, 23);
            AdministradorComboBox.TabIndex = 5;
            // 
            // administradorEntidadBindingSource
            // 
            administradorEntidadBindingSource.DataSource = typeof(Entidades.AdministradorEntidad);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Dirección";
            // 
            // DireccionTextBox
            // 
            DireccionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DireccionTextBox.Location = new Point(12, 159);
            DireccionTextBox.Name = "DireccionTextBox";
            DireccionTextBox.Size = new Size(315, 23);
            DireccionTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 8;
            label5.Text = "Teléfono";
            // 
            // TelefonoTextBox
            // 
            TelefonoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TelefonoTextBox.Location = new Point(12, 203);
            TelefonoTextBox.Name = "TelefonoTextBox";
            TelefonoTextBox.Size = new Size(315, 23);
            TelefonoTextBox.TabIndex = 9;
            // 
            // ActivaComboBox
            // 
            ActivaComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ActivaComboBox.DataSource = boolComboBoxItemBindingSource;
            ActivaComboBox.DisplayMember = "Text";
            ActivaComboBox.FormattingEnabled = true;
            ActivaComboBox.Location = new Point(12, 247);
            ActivaComboBox.Name = "ActivaComboBox";
            ActivaComboBox.Size = new Size(315, 23);
            ActivaComboBox.TabIndex = 10;
            ActivaComboBox.ValueMember = "Value";
            // 
            // boolComboBoxItemBindingSource
            // 
            boolComboBoxItemBindingSource.DataSource = typeof(BoolComboBoxItem);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 229);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 11;
            label6.Text = "Activa";
            // 
            // RegistrarButton
            // 
            RegistrarButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RegistrarButton.Location = new Point(252, 359);
            RegistrarButton.Name = "RegistrarButton";
            RegistrarButton.Size = new Size(75, 23);
            RegistrarButton.TabIndex = 12;
            RegistrarButton.Text = "Registrar";
            RegistrarButton.UseVisualStyleBackColor = true;
            RegistrarButton.Click += RegistrarButton_Click;
            // 
            // TiendaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 394);
            Controls.Add(RegistrarButton);
            Controls.Add(label6);
            Controls.Add(ActivaComboBox);
            Controls.Add(TelefonoTextBox);
            Controls.Add(label5);
            Controls.Add(DireccionTextBox);
            Controls.Add(label4);
            Controls.Add(AdministradorComboBox);
            Controls.Add(label3);
            Controls.Add(NombreTextBox);
            Controls.Add(label2);
            Controls.Add(IdNumericUpDown);
            Controls.Add(label1);
            Name = "TiendaForm";
            Text = "Registrar Tienda";
            ((System.ComponentModel.ISupportInitialize)IdNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)administradorEntidadBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)boolComboBoxItemBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown IdNumericUpDown;
        private Label label2;
        private TextBox NombreTextBox;
        private Label label3;
        private ComboBox AdministradorComboBox;
        private Label label4;
        private TextBox DireccionTextBox;
        private Label label5;
        private TextBox TelefonoTextBox;
        private ComboBox ActivaComboBox;
        private Label label6;
        private Button RegistrarButton;
        private BindingSource administradorEntidadBindingSource;
        private BindingSource boolComboBoxItemBindingSource;
    }
}