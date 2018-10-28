namespace CodingChallenge.Data.Classes.Contadores
{
    /// <summary>
    /// Limpiador de contadores de formas geométricas
    /// </summary>
    public class ContadorCleaner
    {
        /// <summary>
        /// Limpia los contadores de formas geométricas
        /// </summary>
        public void LimpiarContadores()
        {
            ContadorCirculos.GetInstance().Dispose();
            ContadorCuadrados.GetInstance().Dispose();
            ContadorRectangulos.GetInstance().Dispose();
            ContadorTrapecios.GetInstance().Dispose();
            ContadorTriangulosEquilateros.GetInstance().Dispose();
        }
    }
}
