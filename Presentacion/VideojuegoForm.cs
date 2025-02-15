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
            FisicoComboBox.DataSource = BoolComboBoxItem.ObtenerItems();
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
                Limpiar();
                MessageBox.Show("Videojuego registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            NombreTextBox.Text = "";
            TipoVideojuegoComboBox.SelectedIndex = -1;
            DesarrolladorTextBox.Text = "";
            LanzamientoNumericUpDown.Value = 1970;
            FisicoComboBox.SelectedIndex = -1;
        }
    }
}
