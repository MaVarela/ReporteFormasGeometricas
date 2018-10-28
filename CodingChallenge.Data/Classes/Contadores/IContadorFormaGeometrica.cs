namespace CodingChallenge.Data.Classes.Contadores
{
    /// <summary>
    /// Interfaz contadora de formas geométricas
    /// </summary>
    public interface IContadorFormaGeometrica
    {
        /// <summary>
        /// Realiza la suma de área, perímetro y cantidad de la forma geométrica
        /// </summary>
        /// <param name="forma">Forma geométrica</param>
        void SumarFormaGeometrica(FormaGeometrica forma);

        /// <summary>
        /// Reinicia los contadores
        /// </summary>
        void Dispose();

        /// <summary>
        /// Retorna la cantidad de la forma geométrica
        /// </summary>
        /// <returns>Cantidad</returns>
        int getCantidad();

        /// <summary>
        /// Retorna el área de las formas geométricas
        /// </summary>
        /// <returns>Área</returns>
        decimal getArea();

        /// <summary>
        /// Retorna el perímetro de las formas geométricas
        /// </summary>
        /// <returns>Perímetro</returns>
        decimal getPerimetro();
    }
}
