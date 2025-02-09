using LogicaNegocio;

namespace Presentacion
{
    public partial class PrincipalForm : Form
    {
        private TipoVideojuegoLN tipoVideojuegoLN = new();
        private VideojuegoLN videojuegoLN = new();

        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void RegistrarVideojuegoButton_Click(object sender, EventArgs e)
        {
            VideojuegoForm videojuegoForm = new(videojuegoLN, tipoVideojuegoLN);
            videojuegoForm.Show();
        }

        private void ResgistrarTipoButton_Click(object sender, EventArgs e)
        {
            TipoVideojuegoForm tipoVideojuegoForm = new(tipoVideojuegoLN);
            tipoVideojuegoForm.Show();
        }
    }
}
