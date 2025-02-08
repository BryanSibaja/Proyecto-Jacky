namespace Entidades
{
    public class VideojuegoEntidad
    {
        public required int Id { get; set; }
        public required string Nombre { get; set; }
        public required TipoVideojuegoEntidad TipoVideojuego { get; set; }
        public required string Desarrollador { get; set; }
        public required int Lanzamiento {  get; set; }
        public required bool Fisico {  get; set; }

    }
}
