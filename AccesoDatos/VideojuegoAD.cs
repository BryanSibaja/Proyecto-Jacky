using Entidades;

namespace AccesoDatos
{
    public class VideojuegoAD
    {
        private Arreglo<VideojuegoEntidad> Videojuegos = new(20);

        public void AgregarVideojuego(VideojuegoEntidad videojuego)
        {
            Videojuegos.Agregar(videojuego);
        }

        public VideojuegoEntidad[] ObtenerVideojuegos()
        {
            return Videojuegos.Valores.Where(v => v != null).ToArray(); ;
        }
    }
}
