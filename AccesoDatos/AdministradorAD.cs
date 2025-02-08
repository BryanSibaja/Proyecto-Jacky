using Entidades;

namespace AccesoDatos
{
    public class AdministradorAD
    {
        private Arreglo<AdministradorEntidad> Administradores = new(20);

        public void AgregarAdministrador(AdministradorEntidad administrador)
        {
            Administradores.Agregar(administrador);
        }

        public AdministradorEntidad[] ObtenerAdministradores()
        {
            return Administradores.Valores;
        }
    }
}
