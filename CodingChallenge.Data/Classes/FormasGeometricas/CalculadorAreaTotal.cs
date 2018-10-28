using CodingChallenge.Data.Classes.Contadores;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    /// <summary>
    /// Calculador de área total de formas geométricas
    /// </summary>
    public static class CalculadorAreaTotal
    {
        /// <summary>
        /// Calcula el área total de figuras geométricas
        /// </summary>
        /// <returns>área total de figuras geométricas</returns>
        public static decimal CalcularAreaTotal()
        {
            return  ContadorCirculos.GetInstance().getArea() + 
                    ContadorCuadrados.GetInstance().getArea() + 
                    ContadorRectangulos.GetInstance().getArea() + 
                    ContadorTrapecios.GetInstance().getArea() + 
                    ContadorTriangulosEquilateros.GetInstance().getArea();
        }
    }
}
