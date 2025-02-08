using Entidades;

namespace AccesoDatos
{
    public class TiendaAD
    {
        private Arreglo<TiendaEntidad> tiendas = new(5);

        public void AgregarTienda(TiendaEntidad tienda)
        {
            tiendas.Agregar(tienda);
        }

        public TiendaEntidad[] ObtenerTiendas()
        {
            return tiendas.Valores;
        }
    }
}
