using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class VideojuegoLN
    {
        private VideojuegoAD AccesoDatos = new();
        public void AgregarVideojuego(VideojuegoEntidad videojuego)
        {
            if (AccesoDatos.ObtenerVideojuegos().Any(v => v?.Id == videojuego.Id))
            {
                throw new ArgumentException("El videojuego ya existe");
            }

            ValidarVideojuego(videojuego);

            AccesoDatos.AgregarVideojuego(videojuego);
        }
        public VideojuegoEntidad[] ObtenerVideojuegos()
        {
            return AccesoDatos.ObtenerVideojuegos();
        }

        private void ValidarVideojuego(VideojuegoEntidad videojuego)
        {
            if (string.IsNullOrWhiteSpace(videojuego.Nombre))
            {
                throw new ArgumentException("El nombre del videojuego no puede estar vacío");
            }
            if (videojuego.TipoVideojuego == null)
            {
                throw new ArgumentException("El tipo de videojuego no puede ser nulo");
            }
            if (string.IsNullOrWhiteSpace(videojuego.Desarrollador))
            {
                throw new ArgumentException("El desarrollador del videojuego no puede estar vacío");
            }
            if (videojuego.Lanzamiento < 1970)
            {
                throw new ArgumentException("El año de lanzamiento del videojuego no puede ser menor a 1970");
            }
        }
    }
}
