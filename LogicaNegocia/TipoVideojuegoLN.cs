using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class TipoVideojuegoLN
    {
        private TipoVideojuegoAD AccesoDatos = new();

        public void AgregarTipoVideojuego(TipoVideojuegoEntidad tipo)
        {
            if (AccesoDatos.ObtenerTipoVideojuegos().Any(tv => tv?.Id == tipo.Id))
            {
                throw new ArgumentException("El tipo de videojuego ya existe");
            }

            ValidarTipoVideojuego(tipo);

            AccesoDatos.AgregarTipoVideojuego(tipo);
        }

        public TipoVideojuegoEntidad[] ObtenerTipoVideojuegos()
        {
            return AccesoDatos.ObtenerTipoVideojuegos();
        }

        private void ValidarTipoVideojuego(TipoVideojuegoEntidad tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo.Nombre))
            {
                throw new ArgumentException("El nombre del tipo de videojuego no puede estar vacío");
            }
            if (string.IsNullOrWhiteSpace(tipo.Descripcion))
            {
                throw new ArgumentException("La descripción del tipo de videojuego no puede estar vacía");
            }
        }
    }
}
