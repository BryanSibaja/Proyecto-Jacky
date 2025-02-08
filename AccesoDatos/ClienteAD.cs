using Entidades;

namespace AccesoDatos
{
    public class ClienteAD
    {
        private Arreglo<ClienteEntidad> clientes = new(20);

        public void AgregarPersona(ClienteEntidad cliente)
        {
            clientes.Agregar(cliente);
        }

        public ClienteEntidad[] ObtenerPersonas()
        {
            return clientes.Valores;
        }
    }
}
