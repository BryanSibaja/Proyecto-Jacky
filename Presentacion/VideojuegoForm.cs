using Entidades;
using LogicaNegocio;

namespace Presentacion
{
    public partial class VideojuegoForm : Form
    {
        private VideojuegoLN videojuegoLN;

        public VideojuegoForm(VideojuegoLN videojuegoLN, TipoVideojuegoLN tipoVideojuegoLN)
        {
            InitializeComponent();
            this.videojuegoLN = videojuegoLN;
            TipoVideojuegoComboBox.DataSource = tipoVideojuegoLN.ObtenerTipoVideojuegos();
            FisicoComboBox.DataSource = FisicoComboBoxItem.ObtenerFisicoComboBoxItems();
        }

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TipoVideojuegoComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un tipo de videojuego.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (FisicoComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione si el videojuego es físico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                VideojuegoEntidad videojuego = new()
                {
                    Id = (int)IdNumericUpDown.Value,
                    Nombre = NombreTextBox.Text,
                    TipoVideojuego = (TipoVideojuegoEntidad)TipoVideojuegoComboBox.SelectedItem,
                    Desarrollador = DesarrolladorTextBox.Text,
                    Lanzamiento = (int)LanzamientoNumericUpDown.Value,
                    Fisico = (bool)FisicoComboBox.SelectedValue
                };
                videojuegoLN.AgregarVideojuego(videojuego);
                MessageBox.Show("Videojuego registrado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
