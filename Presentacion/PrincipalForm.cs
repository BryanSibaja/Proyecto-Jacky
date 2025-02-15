using LogicaNegocio;

namespace Presentacion
{
    public partial class PrincipalForm : Form
    {
        private TipoVideojuegoLN tipoVideojuegoLN = new();
        private VideojuegoLN videojuegoLN = new();
        private AdministradorLN administradorLN = new();
        private ClienteLN clienteLN = new();
        private TiendaLN tiendaLN = new();
        private InventarioLN inventarioLN = new();

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

        private void RegisrarAdministradorButton_Click(object sender, EventArgs e)
        {
            AdministradorForm administradorForm = new(administradorLN);
            administradorForm.Show();
        }

        private void RegistrarTiendaButton_Click(object sender, EventArgs e)
        {
            TiendaForm tiendaForm = new(tiendaLN, administradorLN);
            tiendaForm.Show();
        }

        private void RegistrarClienteButton_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new(clienteLN);
            clienteForm.Show();
        }

        private void RegistrarInventarioButton_Click(object sender, EventArgs e)
        {
            InventarioForm inventarioForm = new(inventarioLN, tiendaLN, videojuegoLN);
            inventarioForm.Show();
        }

        private void ConsultarTipoButton_Click(object sender, EventArgs e)
        {
            ConsultarTipoVideojuegoForm consultarVideojuegoForm = new(tipoVideojuegoLN);
            consultarVideojuegoForm.Show();
        }

        private void ConsultarVideojuegoButton_Click(object sender, EventArgs e)
        {
            ConsultarVideojuegoForm consultarVideojuegoForm = new(videojuegoLN);
            consultarVideojuegoForm.Show();
        }

        private void ConsultarAdministradorButton_Click(object sender, EventArgs e)
        {
            ConsultarAdministradorForm consultarAdministradorForm = new(administradorLN);
            consultarAdministradorForm.Show();
        }

        private void ConsultarInventarioButton_Click(object sender, EventArgs e)
        {
            ConsultarInventarioForm consultarInventarioForm = new(inventarioLN);
            consultarInventarioForm.Show();
        }
    }
}
