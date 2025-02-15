using LogicaNegocio;
using Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Presentacion
{
    public partial class TiendaForm : Form
    {
        private TiendaLN logica;
        public TiendaForm(TiendaLN tiendaLN, AdministradorLN administradorLN)
        {
            InitializeComponent();
            logica = tiendaLN;
            AdministradorComboBox.DataSource = administradorLN.Obtener();
            AdministradorComboBox.Format += new ListControlConvertEventHandler(AdministradorComboBox_Format);
            ActivaComboBox.DataSource = BoolComboBoxItem.ObtenerItems();
        }

        private void AdministradorComboBox_Format(object? sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is PersonaEntidad persona)
            {
                e.Value = $"{persona.Nombre} {persona.PrimerApellido} {persona.SegundoApellido}";
            }
        }

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AdministradorComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ActivaComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar si la tienda está activa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var tienda = new TiendaEntidad
                {
                    Id = (int)IdNumericUpDown.Value,
                    Nombre = NombreTextBox.Text,
                    Administrador = (AdministradorEntidad)AdministradorComboBox.SelectedItem,
                    Direccion = DireccionTextBox.Text,
                    Telefono = TelefonoTextBox.Text,
                    Activa = (bool)ActivaComboBox.SelectedValue
                };
                logica.AgregarTienda(tienda);
                Limpiar();
                MessageBox.Show("Tienda registrada correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            AdministradorComboBox.SelectedIndex = -1;
            DireccionTextBox.Clear();
            TelefonoTextBox.Clear();
            ActivaComboBox.SelectedIndex = -1;
        }
    }
}
