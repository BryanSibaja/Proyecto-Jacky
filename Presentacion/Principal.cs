using LogicaNegocio;

namespace Presentacion
{
    public partial class Principal : Form
    {
        private TipoVideojuegoLN tipoVideojuegoLN = new();

        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TipoVideojuegoForm tipoVideojuegoForm = new TipoVideojuegoForm(tipoVideojuegoLN);
            tipoVideojuegoForm.Show();
        }
    }
}
