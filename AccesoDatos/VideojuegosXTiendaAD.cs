using Entidades;

namespace AccesoDatos
{
    public class VideojuegosXTiendaAD
    {
        private Arreglo<VideojuegosXTiendaEntidad> videojuegoXTiendas = new(20);
        public void AgregarVideojuegoXTienda(VideojuegosXTiendaEntidad videojuegoXTienda)
        {
            videojuegoXTiendas.Agregar(videojuegoXTienda);
        }
        public VideojuegosXTiendaEntidad[] ObtenerVideojuegoXTiendas()
        {
            return videojuegoXTiendas.Valores;
        }
    }
}
