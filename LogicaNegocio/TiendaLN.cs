using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class TiendaLN
    {
        private TiendaAD AccesoDatos = new();

        public void AgregarTienda(TiendaEntidad tienda)
        {
            if(AccesoDatos.ObtenerTiendas().Any(t => t?.Id == tienda.Id))
            {
                throw new System.ArgumentException("La tienda ya existe");
            }
            ValidarTienda(tienda);
            AccesoDatos.AgregarTienda(tienda);
        }

        public TiendaEntidad[] ObtenerTiendas()
        {
            return AccesoDatos.ObtenerTiendas();
        }

        private void ValidarTienda(TiendaEntidad tienda)
        {
            if (string.IsNullOrWhiteSpace(tienda.Nombre))
            {
                throw new System.ArgumentException("El nombre de la tienda no puede estar vacío");
            }
            if (tienda.Administrador == null)
            {
                throw new System.ArgumentException("El administrador de la tienda no puede ser nulo");
            }
            if (string.IsNullOrWhiteSpace(tienda.Direccion))
            {
                throw new System.ArgumentException("La dirección de la tienda no puede estar vacía");
            }
            if (string.IsNullOrWhiteSpace(tienda.Telefono))
            {
                throw new System.ArgumentException("El teléfono de la tienda no puede estar vacío");
            }
        }
    }
}
