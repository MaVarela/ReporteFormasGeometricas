using CodingChallenge.Data.Classes.Contadores;

namespace CodingChallenge.Data.Classes.GeneradoresDeLineas
{
    /// <summary>
    /// Calculador de perímetro total de formas geométricas
    /// </summary>
    public static class CalculadorPerimetroTotal
    {
        /// <summary>
        /// Calcula el perímetro total de figuras geométricas
        /// </summary>
        /// <returns>Perímetro total de figuras geométricas</returns>
        public static decimal CalcularPerimetroTotal()
        {
            return  ContadorCirculos.GetInstance().getPerimetro() +
                    ContadorCuadrados.GetInstance().getPerimetro() +
                    ContadorRectangulos.GetInstance().getPerimetro() +
                    ContadorTrapecios.GetInstance().getPerimetro() +
                    ContadorTriangulosEquilateros.GetInstance().getPerimetro();
        }
    }
}
