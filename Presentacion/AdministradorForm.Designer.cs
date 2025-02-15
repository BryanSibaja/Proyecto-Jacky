namespace Presentacion
{
    partial class AdministradorForm
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
            label5 = new Label();
            ContratacionDateTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)IdNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // SegundoApellidoTextBox
            // 
            SegundoApellidoTextBox.Size = new Size(393, 23);
            // 
            // NacimientoDateTimePicker
            // 
            NacimientoDateTimePicker.Size = new Size(393, 23);
            // 
            // PrimerApellidoTextBox
            // 
            PrimerApellidoTextBox.Size = new Size(393, 23);
            // 
            // NombreTextBox
            // 
            NombreTextBox.Size = new Size(393, 23);
            // 
            // IdNumericUpDown
            // 
            IdNumericUpDown.Size = new Size(162, 23);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 229);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 26;
            label5.Text = "Fecha de contratación";
            // 
            // ContratacionDateTimePicker
            // 
            ContratacionDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContratacionDateTimePicker.Location = new Point(12, 247);
            ContratacionDateTimePicker.Name = "ContratacionDateTimePicker";
            ContratacionDateTimePicker.Size = new Size(393, 23);
            ContratacionDateTimePicker.TabIndex = 27;
            // 
            // AdministradorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 453);
            Controls.Add(ContratacionDateTimePicker);
            Controls.Add(label5);
            Name = "AdministradorForm";
            Text = "Registrar Administrador";
            Controls.SetChildIndex(IdNumericUpDown, 0);
            Controls.SetChildIndex(NombreTextBox, 0);
            Controls.SetChildIndex(PrimerApellidoTextBox, 0);
            Controls.SetChildIndex(NacimientoDateTimePicker, 0);
            Controls.SetChildIndex(SegundoApellidoTextBox, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(ContratacionDateTimePicker, 0);
            ((System.ComponentModel.ISupportInitialize)IdNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DateTimePicker ContratacionDateTimePicker;
    }
}