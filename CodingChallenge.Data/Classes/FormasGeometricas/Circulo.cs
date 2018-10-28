using System;

namespace CodingChallenge.Data.Classes
{
    /// <summary>
    /// Círculo
    /// </summary>
    public class Circulo : FormaGeometrica
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ancho">Ancho del círculo</param>
        public Circulo(decimal ancho)
            : base(ancho)
        {

        }

        /// <summary>
        /// Calcula el área del círculo
        /// </summary>
        /// <returns>Área</returns>
        public override decimal CalcularArea()
        {
            return Math.Round((decimal)Math.PI * (_lado / 2) * (_lado / 2), 2);
        }

        /// <summary>
        /// Calcula el perímetro del círculo
        /// </summary>
        /// <returns>Perímetro</returns>
        public override decimal CalcularPerimetro()
        {
            return Math.Round((decimal)Math.PI * _lado, 2);
        }
    }
}
