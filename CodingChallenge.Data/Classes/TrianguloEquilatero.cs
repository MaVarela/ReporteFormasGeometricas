using System;

namespace CodingChallenge.Data.Classes
{
    /// <summary>
    /// Triángulo equilatero
    /// </summary>
    public class TrianguloEquilatero : FormaGeometrica
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ancho">Ancho de la figura</param>
        public TrianguloEquilatero(decimal ancho)
            : base(ancho)
        {

        }

        /// <summary>
        /// Calcula el área del triángulo
        /// </summary>
        /// <returns>Área</returns>
        public override decimal CalcularArea()
        {
            return Math.Round(((decimal)Math.Sqrt(3) / 4) * _lado * _lado, 2);
        }

        /// <summary>
        /// Calcula el perímetro del triángulo
        /// </summary>
        /// <returns>Perímetro</returns>
        public override decimal CalcularPerimetro()
        {
            return Math.Round(_lado * 3, 2);
        }
    }
}
