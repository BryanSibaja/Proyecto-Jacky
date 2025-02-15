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
    public partial class ConsultarInventarioForm : Form
    {
        public ConsultarInventarioForm(InventarioLN inventarioLN)
        {
            InitializeComponent();
            InventarioDataGridView.DataSource = inventarioLN.ObtenerInventario();
            InventarioDataGridView.CellFormatting += InventarioDataGridView_CellFormatting;
        }

        private void InventarioDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.Value != null)
            {
                e.Value = ((TiendaEntidad)e.Value).Id.ToString();
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == 1 && e.Value != null)
            {
                e.Value = ((TiendaEntidad)e.Value).Nombre;
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = ((TiendaEntidad)e.Value).Direccion;
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = ((VideojuegoEntidad)e.Value).Id.ToString();
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                e.Value = ((VideojuegoEntidad)e.Value).Nombre;
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                e.Value = ((VideojuegoEntidad)e.Value).TipoVideojuego.Nombre;
                e.FormattingApplied = true;
            }
        }
    }
}
