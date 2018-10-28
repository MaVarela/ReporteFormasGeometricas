using System;

namespace CodingChallenge.Data.Classes
{
    /// <summary>
    /// Trapecio
    /// </summary>
    public class Trapecio : FormaGeometrica
    {
        /// <summary>
        /// Altura del trapecio
        /// </summary>
        protected readonly decimal _altura;

        /// <summary>
        /// Ancho menor del trapecio
        /// </summary>
        protected readonly decimal _anchoMenor;

        /// <summary>
        /// Lado izquierdo del trapecio
        /// </summary>
        protected readonly decimal _ladoIzquierdo;

        /// <summary>
        /// Lado derecho del trapecio
        /// </summary>
        protected readonly decimal _ladoDerecho;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ancho">Ancho de la figura</param>
        /// <param name="anchoMenor">Ancho menor de la figura</param>
        /// <param name="altura">Altura de la figura</param>
        public Trapecio(decimal ancho, decimal anchoMenor, decimal altura, decimal ladoIzquierdo, decimal ladoDerecho)
            : base(ancho)
        {
            _altura = altura;
            _anchoMenor = anchoMenor;
            _ladoIzquierdo = ladoIzquierdo;
            _ladoDerecho = ladoDerecho;
        }

        /// <summary>
        /// Calcula el área del trapecio
        /// </summary>
        /// <returns>Área</returns>
        public override decimal CalcularArea()
        {
            return Math.Round((_lado + _anchoMenor) / 2 * _altura, 2);
        }

        /// <summary>
        /// Calcula el perímetro del trapecio
        /// </summary>
        /// <returns>Perímetro</returns>
        public override decimal CalcularPerimetro()
        {
            return Math.Round(_lado + _ladoDerecho + _ladoIzquierdo + _anchoMenor, 2);
        }
    }
}
