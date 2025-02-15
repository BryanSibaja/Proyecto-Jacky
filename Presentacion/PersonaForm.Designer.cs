namespace Presentacion
{
    partial class PersonaForm
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
            label6 = new Label();
            SegundoApellidoTextBox = new TextBox();
            RegistrarButton = new Button();
            label4 = new Label();
            NacimientoDateTimePicker = new DateTimePicker();
            PrimerApellidoTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            NombreTextBox = new TextBox();
            IdNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)IdNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 185);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 25;
            label6.Text = "Fecha de nacimiento";
            // 
            // SegundoApellidoTextBox
            // 
            SegundoApellidoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SegundoApellidoTextBox.Location = new Point(12, 159);
            SegundoApellidoTextBox.Name = "SegundoApellidoTextBox";
            SegundoApellidoTextBox.Size = new Size(359, 23);
            SegundoApellidoTextBox.TabIndex = 19;
            // 
            // RegistrarButton
            // 
            RegistrarButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RegistrarButton.Location = new Point(296, 415);
            RegistrarButton.Name = "RegistrarButton";
            RegistrarButton.Size = new Size(75, 23);
            RegistrarButton.TabIndex = 50;
            RegistrarButton.Text = "Registrar";
            RegistrarButton.UseVisualStyleBackColor = true;
            RegistrarButton.Click += RegistrarButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 20;
            label4.Text = "Segundo Apellido";
            // 
            // NacimientoDateTimePicker
            // 
            NacimientoDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NacimientoDateTimePicker.Location = new Point(12, 203);
            NacimientoDateTimePicker.Name = "NacimientoDateTimePicker";
            NacimientoDateTimePicker.Size = new Size(359, 23);
            NacimientoDateTimePicker.TabIndex = 20;
            // 
            // PrimerApellidoTextBox
            // 
            PrimerApellidoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PrimerApellidoTextBox.Location = new Point(12, 115);
            PrimerApellidoTextBox.Name = "PrimerApellidoTextBox";
            PrimerApellidoTextBox.Size = new Size(359, 23);
            PrimerApellidoTextBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 17;
            label3.Text = "Primer Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 16;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 15;
            label1.Text = "Id";
            // 
            // NombreTextBox
            // 
            NombreTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NombreTextBox.Location = new Point(12, 71);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(359, 23);
            NombreTextBox.TabIndex = 14;
            // 
            // IdNumericUpDown
            // 
            IdNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IdNumericUpDown.Location = new Point(12, 27);
            IdNumericUpDown.Name = "IdNumericUpDown";
            IdNumericUpDown.Size = new Size(128, 23);
            IdNumericUpDown.TabIndex = 13;
            // 
            // PersonaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 450);
            Controls.Add(label6);
            Controls.Add(SegundoApellidoTextBox);
            Controls.Add(RegistrarButton);
            Controls.Add(label4);
            Controls.Add(NacimientoDateTimePicker);
            Controls.Add(PrimerApellidoTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NombreTextBox);
            Controls.Add(IdNumericUpDown);
            Name = "PersonaForm";
            Text = "Registrar Persona";
            ((System.ComponentModel.ISupportInitialize)IdNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        protected TextBox SegundoApellidoTextBox;
        protected DateTimePicker NacimientoDateTimePicker;
        protected TextBox PrimerApellidoTextBox;
        protected TextBox NombreTextBox;
        protected NumericUpDown IdNumericUpDown;
        protected Button RegistrarButton;
    }
}