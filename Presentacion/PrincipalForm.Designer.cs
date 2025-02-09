namespace Presentacion
{
    partial class PrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ResgistrarTipoButton = new Button();
            RegistrarVideojuegoButton = new Button();
            SuspendLayout();
            // 
            // ResgistrarTipoButton
            // 
            ResgistrarTipoButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ResgistrarTipoButton.Location = new Point(12, 12);
            ResgistrarTipoButton.Name = "ResgistrarTipoButton";
            ResgistrarTipoButton.Size = new Size(272, 23);
            ResgistrarTipoButton.TabIndex = 0;
            ResgistrarTipoButton.Text = "Registrar tipo de videojuego";
            ResgistrarTipoButton.UseVisualStyleBackColor = true;
            ResgistrarTipoButton.Click += ResgistrarTipoButton_Click;
            // 
            // RegistrarVideojuegoButton
            // 
            RegistrarVideojuegoButton.Location = new Point(12, 41);
            RegistrarVideojuegoButton.Name = "RegistrarVideojuegoButton";
            RegistrarVideojuegoButton.Size = new Size(272, 23);
            RegistrarVideojuegoButton.TabIndex = 1;
            RegistrarVideojuegoButton.Text = "Registrar Videojuego";
            RegistrarVideojuegoButton.UseVisualStyleBackColor = true;
            RegistrarVideojuegoButton.Click += RegistrarVideojuegoButton_Click;
            // 
            // PrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 450);
            Controls.Add(RegistrarVideojuegoButton);
            Controls.Add(ResgistrarTipoButton);
            Name = "PrincipalForm";
            Text = "Inventario de 45GAMES4U";
            ResumeLayout(false);
        }

        #endregion

        private Button ResgistrarTipoButton;
        private Button RegistrarVideojuegoButton;
    }
}
