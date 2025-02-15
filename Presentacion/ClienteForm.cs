using Entidades;
using LogicaNegocio;

namespace Presentacion
{
    public partial class ClienteForm : PersonaForm
    {
        public ClienteForm(PersonaLN personaLN) : base(personaLN)
        {
            InitializeComponent();
            EnLineaComboBox.DataSource = BoolComboBoxItem.ObtenerItems();
        }

        protected override PersonaEntidad CrearPersona()
        {
            if(EnLineaComboBox.SelectedValue == null)
            {
                throw new ArgumentException("Debe seleccionar si el cliente juega en línea o no");
            }
            return new ClienteEntidad
            {
                Nombre = NombreTextBox.Text,
                PrimerApellido = PrimerApellidoTextBox.Text,
                SegundoApellido = SegundoApellidoTextBox.Text,
                FechaNacimiento = NacimientoDateTimePicker.Value,
                Identificacion = (int)IdNumericUpDown.Value,
                JugadorEnLinea = (bool) EnLineaComboBox.SelectedValue
            };
        }

        protected override void LimpiarCampos()
        {
            base.LimpiarCampos();
            EnLineaComboBox.SelectedIndex = -1;
        }
    }
}
