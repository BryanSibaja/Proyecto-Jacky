using Entidades;

namespace AccesoDatos
{
    public class TipoVideojuegoAD
    {
        private Arreglo<TipoVideojuegoEntidad> Videjuegos = new(10);

        public void AgregarTipoVideojuego(TipoVideojuegoEntidad videojuego)
        {
            Videjuegos.Agregar(videojuego);
        }

        public TipoVideojuegoEntidad[] ObtenerTipoVideojuegos()
        {
            return Videjuegos.Valores;
        }
    }
}
