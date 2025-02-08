namespace Entidades
{
    public class PersonaEntidad
    {
        public required string Identificacion { get; set; }
        public required string Nombre {  get; set; }
        public required string PrimerApellido { get; set; }
        public required string SegundoApellido { get; set; }
        public required DateTime FechaNacimiento { get; set; }
    }
}
