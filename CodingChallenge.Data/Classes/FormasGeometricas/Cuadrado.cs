using System;

namespace CodingChallenge.Data.Classes
{
    /// <summary>
    /// Cuadrado
    /// </summary>
    public class Cuadrado : FormaGeometrica
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ancho">Ancho de la figura</param>
        public Cuadrado(decimal ancho)
            : base(ancho)
        {

        }

        /// <summary>
        /// Calcula el área del cuadrado
        /// </summary>
        /// <returns>Área</returns>
        public override decimal CalcularArea()
        {
            return Math.Round(_lado * _lado, 2);
        }

        /// <summary>
        /// Calcula el perímetro del cuadrado
        /// </summary>
        /// <returns>Perímetro</returns>
        public override decimal CalcularPerimetro()
        {
            return Math.Round(_lado * 4, 2);
        }
    }
}
