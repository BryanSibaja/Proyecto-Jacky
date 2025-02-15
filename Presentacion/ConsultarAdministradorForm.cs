using Entidades;
using LogicaNegocio;

namespace Presentacion
{
    public partial class ConsultarAdministradorForm : Form
    {
        public ConsultarAdministradorForm(AdministradorLN administradorLN)
        {
            InitializeComponent();
            var personas = administradorLN.Obtener().Select(a => (AdministradorEntidad) a).ToArray() ;
            //var administradores = personas.OfType<AdministradorEntidad>().ToArray();
            AdministradorDataGridView.DataSource = personas;
            AdministradorDataGridView.CellFormatting += AdministradorDataGridView_CellFormatting;
        }

        private void AdministradorDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var columna = AdministradorDataGridView.Columns[e.ColumnIndex].DataPropertyName;
            if ((columna == "FechaNacimiento" || columna == "FechaContratacion") && e.Value != null)
            {
                e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy");
                e.FormattingApplied = true;
            }
        }
    }
}
