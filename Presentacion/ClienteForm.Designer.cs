namespace Presentacion
{
    partial class ClienteForm
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
            label5 = new Label();
            EnLineaComboBox = new ComboBox();
            boolComboBoxItemBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)IdNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boolComboBoxItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // SegundoApellidoTextBox
            // 
            SegundoApellidoTextBox.Size = new Size(489, 23);
            // 
            // NacimientoDateTimePicker
            // 
            NacimientoDateTimePicker.Size = new Size(489, 23);
            // 
            // PrimerApellidoTextBox
            // 
            PrimerApellidoTextBox.Size = new Size(489, 23);
            // 
            // NombreTextBox
            // 
            NombreTextBox.Size = new Size(489, 23);
            // 
            // IdNumericUpDown
            // 
            IdNumericUpDown.Size = new Size(258, 23);
            // 
            // RegistrarButton
            // 
            RegistrarButton.Location = new Point(426, 415);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 229);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 26;
            label5.Text = "Jugador en linea";
            // 
            // EnLineaComboBox
            // 
            EnLineaComboBox.DataSource = boolComboBoxItemBindingSource;
            EnLineaComboBox.DisplayMember = "Text";
            EnLineaComboBox.FormattingEnabled = true;
            EnLineaComboBox.Location = new Point(12, 247);
            EnLineaComboBox.Name = "EnLineaComboBox";
            EnLineaComboBox.Size = new Size(489, 23);
            EnLineaComboBox.TabIndex = 27;
            EnLineaComboBox.ValueMember = "Value";
            // 
            // boolComboBoxItemBindingSource
            // 
            boolComboBoxItemBindingSource.DataSource = typeof(BoolComboBoxItem);
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 450);
            Controls.Add(EnLineaComboBox);
            Controls.Add(label5);
            Name = "ClienteForm";
            Text = "Registrar Cliente";
            Controls.SetChildIndex(IdNumericUpDown, 0);
            Controls.SetChildIndex(NombreTextBox, 0);
            Controls.SetChildIndex(PrimerApellidoTextBox, 0);
            Controls.SetChildIndex(NacimientoDateTimePicker, 0);
            Controls.SetChildIndex(RegistrarButton, 0);
            Controls.SetChildIndex(SegundoApellidoTextBox, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(EnLineaComboBox, 0);
            ((System.ComponentModel.ISupportInitialize)IdNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)boolComboBoxItemBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private ComboBox EnLineaComboBox;
        private BindingSource boolComboBoxItemBindingSource;
    }
}