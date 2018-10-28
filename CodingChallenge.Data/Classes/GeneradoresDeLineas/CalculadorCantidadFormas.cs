using CodingChallenge.Data.Classes.Contadores;

namespace CodingChallenge.Data.Classes.GeneradoresDeLineas
{
    /// <summary>
    /// Calculador de cantidad total de formas geométricas
    /// </summary>
    public static class CalculadorCantidadFormas
    {
        /// <summary>
        /// Calcula el total de figuras geométricas
        /// </summary>
        /// <returns>Cantidad total de figuras geométricas</returns>
        public static int CalcularTotal()
        {
            return  ContadorCirculos.GetInstance().getCantidad() +
                    ContadorCuadrados.GetInstance().getCantidad() +
                    ContadorRectangulos.GetInstance().getCantidad() +
                    ContadorTrapecios.GetInstance().getCantidad() +
                    ContadorTriangulosEquilateros.GetInstance().getCantidad();
        }
    }
}
