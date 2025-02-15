using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class PersonaLN
    {
        private PersonaAD AccesoDatos = new();

        public void Agregar(PersonaEntidad persona)
        {
            if (AccesoDatos.Obtener().Any(a => a?.Identificacion == persona.Identificacion))
            {
                throw new ArgumentException("El administrador ya existe");
            }
            Validar(persona);
            AccesoDatos.Agregar(persona);
        }

        public PersonaEntidad[] Obtener()
        {
            return AccesoDatos.Obtener();
        }

        protected virtual void Validar(PersonaEntidad administrador)
        {
            if (string.IsNullOrWhiteSpace(administrador.Nombre))
            {
                throw new ArgumentException("El nombre no puede estar vacío");
            }
            if (string.IsNullOrWhiteSpace(administrador.PrimerApellido))
            {
                throw new ArgumentException("El primer apellido no puede estar vacío");
            }
            if (string.IsNullOrWhiteSpace(administrador.SegundoApellido))
            {
                throw new ArgumentException("La segundo apellido no puede estar vacío");
            }
            if (administrador.FechaNacimiento.AddYears(18) > DateTime.Now)
            {
                throw new ArgumentException("Debe ser mayor de 18 años");
            }

        }
    }
}
