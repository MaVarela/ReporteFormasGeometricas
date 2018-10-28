namespace CodingChallenge.Data.Classes.Contadores
{
    /// <summary>
    /// Contadores para la forma geométrica cuadrado
    /// </summary>
    public class ContadorCuadrados : IContadorFormaGeometrica
    {
        private static int numeroCuadrados = 0;
        private static decimal areaCuadrados = 0m;
        private static decimal perimetroCuadrados = 0m;
        private static ContadorCuadrados instance = null;

        /// <summary>
        /// Retorna el contador, si no está instanciado lo instancia
        /// </summary>
        /// <returns>ContadorCuadrados</returns>
        public static ContadorCuadrados GetInstance()
        {
            if (instance == null)
                instance = new ContadorCuadrados();

            return instance;
        }

        /// <summary>
        /// Realiza la suma de área, perímetro y cantidad de la forma geométrica
        /// </summary>
        /// <param name="forma">Forma geométrica</param>
        public void SumarFormaGeometrica(FormaGeometrica forma)
        {
            numeroCuadrados++;
            areaCuadrados += forma.CalcularArea();
            perimetroCuadrados += forma.CalcularPerimetro();
        }

        /// <summary>
        /// Reinicia los contadores
        /// </summary>
        public void Dispose()
        {
            numeroCuadrados = 0;
            areaCuadrados = 0m;
            perimetroCuadrados = 0m;
        }

        /// <summary>
        /// Retorna la cantidad de la forma geométrica
        /// </summary>
        /// <returns>Cantidad</returns>
        public int getCantidad()
        {
            return numeroCuadrados;
        }

        /// <summary>
        /// Retorna el área de las formas geométricas
        /// </summary>
        /// <returns>Área</returns>
        public decimal getArea()
        {
            return areaCuadrados;
        }

        /// <summary>
        /// Retorna el perímetro de las formas geométricas
        /// </summary>
        /// <returns>Perímetro</returns>
        public decimal getPerimetro()
        {
            return perimetroCuadrados;
        }
    }
}
