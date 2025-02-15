using Entidades;
namespace AccesoDatos
{
    public class PersonaAD
    {
        private Arreglo<PersonaEntidad> Personas = new(20);

        public void Agregar(PersonaEntidad persona)
        {
            Personas.Agregar(persona);
        }

        public PersonaEntidad[] Obtener()
        {
            return Personas.Valores.Where(v => v != null).ToArray(); ;
        }
    }
}
