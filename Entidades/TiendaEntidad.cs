namespace Entidades
{
    public class TiendaEntidad
    {
        public required int Id { get; set; }
        public required string Nombre { get; set; }
        public required AdministradorEntidad Administrador { get; set; }
        public required string Direccion { get; set; }
        public required string Telefono { get; set; }
        public required bool Activa { get; set; }
    }
}
