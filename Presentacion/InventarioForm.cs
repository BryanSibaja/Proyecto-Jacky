using Entidades;
using LogicaNegocio;

namespace Presentacion
{
    public partial class InventarioForm : Form
    {
        private InventarioLN logica;
        public InventarioForm(InventarioLN inventarioLN, TiendaLN tiendaLN, VideojuegoLN videojuegoLN)
        {
            InitializeComponent();
            logica = inventarioLN;
            TiendaComboBox.DataSource = tiendaLN.ObtenerTiendas().Where(t => t?.Activa == true).ToArray();
            VideojuegoDataGridView.DataSource = videojuegoLN.ObtenerVideojuegos().Where(v => v?.Fisico == true).ToArray();
            VideojuegoDataGridView.CellFormatting += InventarioDataGridView_CellFormatting;
        }

        private void InventarioDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            var columna = VideojuegoDataGridView.Columns[e.ColumnIndex].DataPropertyName;
            if (columna == "TipoVideojuego" && e.Value != null)
            {
                e.Value = ((TipoVideojuegoEntidad)e.Value).Nombre;
                e.FormattingApplied = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TiendaComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una tienda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (VideojuegoDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un videojuego", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var tienda = (TiendaEntidad)TiendaComboBox.SelectedItem;
                foreach (DataGridViewRow row in VideojuegoDataGridView.SelectedRows)
                {
                    var videojuego = (VideojuegoEntidad)row.DataBoundItem;
                    var inventario = new VideojuegosXTiendaEntidad
                    {
                        Videojuego = videojuego,
                        Tienda = tienda,
                        Existencias = (int)CantidadNumericUpDown.Value
                    };
                    logica.RegistrarInventario(inventario);
                }
                Limpiar();
                MessageBox.Show("Inventario registrado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            TiendaComboBox.SelectedIndex = -1;
            CantidadNumericUpDown.Value = 0;
            foreach (DataGridViewRow row in VideojuegoDataGridView.SelectedRows)
            {
                row.Selected = false;
            }
        }
    }
}
