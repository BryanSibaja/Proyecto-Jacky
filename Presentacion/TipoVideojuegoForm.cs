using Entidades;
using LogicaNegocio;

namespace Presentacion
{
    public partial class TipoVideojuegoForm : Form
    {
        private TipoVideojuegoLN logica;
        public TipoVideojuegoForm(TipoVideojuegoLN logica)
        {
            InitializeComponent();
            this.logica = logica;
        }

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var tipo = new TipoVideojuegoEntidad
                {
                    Id = (int)IdNumericUpDown.Value,
                    Nombre = NombreTextBox.Text,
                    Descripcion = DescripcionTextBox.Text
                };
                logica.AgregarTipoVideojuego(tipo);
                LimpiarCampos();
                MessageBox.Show("Tipo de videojuego registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            IdNumericUpDown.Value = 1;
            NombreTextBox.Clear();
            DescripcionTextBox.Clear();
        }
    }
}
