namespace AccesoDatos
{
    internal class Arreglo<T>(int cantidad)
    {
        private int Contador = 0;

        public T[] Valores { get; } = new T[cantidad];

        public void Agregar(T dato)
        {
            if(Contador >= Valores.Length)
                throw new InvalidOperationException();

            Valores[Contador] = dato;
            Contador++;
        }
    }
}
