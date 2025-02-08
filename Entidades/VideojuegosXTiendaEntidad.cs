namespace Entidades
{
    public class VideojuegosXTiendaEntidad
    {
        public required TiendaEntidad Tienda { get; set; }
        public required VideojuegoEntidad Videojuego { get; set; }
        public required int Existencias { get; set; }
    }
}
