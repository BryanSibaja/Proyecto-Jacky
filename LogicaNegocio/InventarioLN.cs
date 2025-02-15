using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class InventarioLN
    {
        private VideojuegosXTiendaAD inventarioAD = new();

        public void RegistrarInventario(VideojuegosXTiendaEntidad inventario)
        {
            if(inventarioAD.ObtenerVideojuegoXTiendas().Any(i => i?.Tienda.Id == inventario.Tienda.Id && i?.Videojuego.Id == inventario.Videojuego.Id))
            {
                throw new ArgumentException("El inventario ya existe");
            }
            ValidarInventario(inventario);
            inventarioAD.AgregarVideojuegoXTienda(inventario);            
        }

        public VideojuegosXTiendaEntidad[] ObtenerInventario()
        {
            return inventarioAD.ObtenerVideojuegoXTiendas() ;
        }

        private void ValidarInventario(VideojuegosXTiendaEntidad inventario)
        {
            if (inventario.Existencias <= 0)
            {
                throw new ArgumentException("Cantidad invalida");
            }
        }
    }
}
