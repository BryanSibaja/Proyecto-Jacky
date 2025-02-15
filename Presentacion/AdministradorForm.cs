using LogicaNegocio;
using Entidades;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class AdministradorForm : PersonaForm
    {
        public AdministradorForm(PersonaLN personaLN) : base(personaLN)
        {
            InitializeComponent();
        }

        protected override PersonaEntidad CrearPersona()
        {
            return new AdministradorEntidad
            {
                Nombre = NombreTextBox.Text,
                PrimerApellido = PrimerApellidoTextBox.Text,
                SegundoApellido = SegundoApellidoTextBox.Text,
                FechaNacimiento = NacimientoDateTimePicker.Value,
                Identificacion = (int)IdNumericUpDown.Value,
                FechaContratacion = ContratacionDateTimePicker.Value
            };
        }

        protected override void LimpiarCampos()
        {
            base.LimpiarCampos();
            ContratacionDateTimePicker.Value = DateTime.Now;
        }
    }
}
