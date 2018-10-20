using System;

namespace CodingChallenge.Data.Classes
{
    /// <summary>
    /// Rectángulo
    /// </summary>
    public class Rectangulo : FormaGeometrica
    {
        /// <summary>
        /// Altura del rectángulo
        /// </summary>
        protected readonly decimal _altura;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ancho">Ancho de la figura</param>
        /// <param name="altura">Altura de la figura</param>
        public Rectangulo(decimal ancho, decimal altura)
            : base(ancho)
        {
            _altura = altura;
        }

        /// <summary>
        /// Calcula el área del rectángulo
        /// </summary>
        /// <returns>Área</returns>
        public override decimal CalcularArea()
        {
            return Math.Round(_lado * _altura, 2);
        }

        /// <summary>
        /// Calcula el perímetro del rectángulo
        /// </summary>
        /// <returns>Perímetro</returns>
        public override decimal CalcularPerimetro()
        {
            return Math.Round(_lado * 2 + _altura * 2, 2);
        }
    }
}
