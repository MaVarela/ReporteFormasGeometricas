namespace CodingChallenge.Data.Classes.Contadores
{
    /// <summary>
    /// Contadores para la forma geométrica triángulo equilatero
    /// </summary>
    public class ContadorTriangulosEquilateros : IContadorFormaGeometrica
    {
        private static int numeroTriangulosEquilateros = 0;
        private static decimal areaTriangulosEquilateros = 0m;
        private static decimal perimetroTriangulosEquilateros = 0m;
        private static ContadorTriangulosEquilateros instance = null;

        /// <summary>
        /// Retorna el contador, si no está instanciado lo instancia
        /// </summary>
        /// <returns>ContadorTriangulosEquilateros</returns>
        public static ContadorTriangulosEquilateros GetInstance()
        {
            if (instance == null)
                instance = new ContadorTriangulosEquilateros();

            return instance;
        }

        /// <summary>
        /// Realiza la suma de área, perímetro y cantidad de la forma geométrica
        /// </summary>
        /// <param name="forma">Forma geométrica</param>
        public void SumarFormaGeometrica(FormaGeometrica forma)
        {
            numeroTriangulosEquilateros++;
            areaTriangulosEquilateros += forma.CalcularArea();
            perimetroTriangulosEquilateros += forma.CalcularPerimetro();
        }

        /// <summary>
        /// Reinicia los contadores
        /// </summary>
        public void Dispose()
        {
            numeroTriangulosEquilateros = 0;
            areaTriangulosEquilateros = 0m;
            perimetroTriangulosEquilateros = 0m;
        }

        /// <summary>
        /// Retorna la cantidad de la forma geométrica
        /// </summary>
        /// <returns>Cantidad</returns>
        public int getCantidad()
        {
            return numeroTriangulosEquilateros;
        }

        /// <summary>
        /// Retorna el área de las formas geométricas
        /// </summary>
        /// <returns>Área</returns>
        public decimal getArea()
        {
            return areaTriangulosEquilateros;
        }

        /// <summary>
        /// Retorna el perímetro de las formas geométricas
        /// </summary>
        /// <returns>Perímetro</returns>
        public decimal getPerimetro()
        {
            return perimetroTriangulosEquilateros;
        }
    }
}
