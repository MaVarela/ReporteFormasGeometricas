/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */


namespace CodingChallenge.Data.Classes
{
    /// <summary>
    /// Forma geométrica
    /// </summary>
    public abstract class FormaGeometrica
    {
        /// <summary>
        /// Lado de una forma geométrica
        /// </summary>
        protected readonly decimal _lado;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ancho">Ancho de la forma geométrica</param>
        public FormaGeometrica(decimal ancho)
        {
            _lado = ancho;
        }

        /// <summary>
        /// Calcula el área de la figura geométrica
        /// </summary>
        /// <returns>Área</returns>
        public abstract decimal CalcularArea();

        /// <summary>
        /// Calcula el perímetro de la figura geométrica
        /// </summary>
        /// <returns>Perímetro</returns>
        public abstract decimal CalcularPerimetro();
    }
}
