using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class AdministradorLN : PersonaLN
    {
        protected override void Validar(PersonaEntidad administrador)
        {
            base.Validar(administrador);
            if (((AdministradorEntidad)administrador).FechaContratacion > DateTime.Now)
            {
                throw new ArgumentException("La fecha de contratación no puede ser mayor a la fecha actual");
            }
        }
    }
}
