namespace Presentacion
{
    partial class TipoVideojuegoForm
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
            NombreTextBox = new TextBox();
            IdNumericUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            DescripcionTextBox = new TextBox();
            RegistrarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)IdNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // NombreTextBox
            // 
            NombreTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NombreTextBox.Location = new Point(12, 71);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(333, 23);
            NombreTextBox.TabIndex = 0;
            // 
            // IdNumericUpDown
            // 
            IdNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IdNumericUpDown.AutoSize = true;
            IdNumericUpDown.Location = new Point(12, 27);
            IdNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            IdNumericUpDown.Name = "IdNumericUpDown";
            IdNumericUpDown.Size = new Size(120, 23);
            IdNumericUpDown.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Descripción";
            // 
            // DescripcionTextBox
            // 
            DescripcionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescripcionTextBox.Location = new Point(12, 115);
            DescripcionTextBox.Multiline = true;
            DescripcionTextBox.Name = "DescripcionTextBox";
            DescripcionTextBox.Size = new Size(333, 214);
            DescripcionTextBox.TabIndex = 5;
            // 
            // RegistrarButton
            // 
            RegistrarButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RegistrarButton.Location = new Point(270, 335);
            RegistrarButton.Name = "RegistrarButton";
            RegistrarButton.Size = new Size(75, 23);
            RegistrarButton.TabIndex = 6;
            RegistrarButton.Text = "Registrar";
            RegistrarButton.UseVisualStyleBackColor = true;
            RegistrarButton.Click += RegistrarButton_Click;
            // 
            // TipoVideojuegoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 370);
            Controls.Add(RegistrarButton);
            Controls.Add(DescripcionTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(IdNumericUpDown);
            Controls.Add(NombreTextBox);
            Name = "TipoVideojuegoForm";
            Text = "Agregar Tipos de Videojuegos";
            ((System.ComponentModel.ISupportInitialize)IdNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NombreTextBox;
        private NumericUpDown IdNumericUpDown;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox DescripcionTextBox;
        private Button RegistrarButton;
    }
}