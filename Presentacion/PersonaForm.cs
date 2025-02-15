using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PersonaForm : Form
    {
        private PersonaLN logica;

        public PersonaForm()
        {
            InitializeComponent();
            logica = new PersonaLN();
        }
        public PersonaForm(PersonaLN personaLN)
        {
            InitializeComponent();
            logica = personaLN;
        }

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var persona = CrearPersona();
                logica.Agregar(persona);
                LimpiarCampos();
                MessageBox.Show("Registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual PersonaEntidad CrearPersona()
        {
            return new PersonaEntidad
            {
                Nombre = NombreTextBox.Text,
                PrimerApellido = PrimerApellidoTextBox.Text,
                SegundoApellido = SegundoApellidoTextBox.Text,
                FechaNacimiento = NacimientoDateTimePicker.Value,
                Identificacion = (int)IdNumericUpDown.Value
            };
        }

        protected virtual void LimpiarCampos()
        {
            NombreTextBox.Text = string.Empty;
            PrimerApellidoTextBox.Text = string.Empty;
            SegundoApellidoTextBox.Text = string.Empty;
            NacimientoDateTimePicker.Value = DateTime.Now;
            IdNumericUpDown.Value = 0;
        }
    }
}
