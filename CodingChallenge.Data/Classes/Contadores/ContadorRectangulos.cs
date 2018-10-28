namespace CodingChallenge.Data.Classes.Contadores
{
    /// <summary>
    /// Contadores para la forma geométrica rectángulo
    /// </summary>
    public class ContadorRectangulos : IContadorFormaGeometrica
    {
        private static int numeroRectangulos = 0;
        private static decimal areaRectangulos = 0m;
        private static decimal perimetroRectangulos = 0m;
        private static ContadorRectangulos instance = null;

        /// <summary>
        /// Retorna el contador, si no está instanciado lo instancia
        /// </summary>
        /// <returns>ContadorRectangulos</returns>
        public static ContadorRectangulos GetInstance()
        {
            if (instance == null)
                instance = new ContadorRectangulos();

            return instance;
        }

        /// <summary>
        /// Realiza la suma de área, perímetro y cantidad de la forma geométrica
        /// </summary>
        /// <param name="forma">Forma geométrica</param>
        public void SumarFormaGeometrica(FormaGeometrica forma)
        {
            numeroRectangulos++;
            areaRectangulos += forma.CalcularArea();
            perimetroRectangulos += forma.CalcularPerimetro();
        }

        /// <summary>
        /// Reinicia los contadores
        /// </summary>
        public void Dispose()
        {
            numeroRectangulos = 0;
            areaRectangulos = 0m;
            perimetroRectangulos = 0m;
        }

        /// <summary>
        /// Retorna la cantidad de la forma geométrica
        /// </summary>
        /// <returns>Cantidad</returns>
        public int getCantidad()
        {
            return numeroRectangulos;
        }

        /// <summary>
        /// Retorna el área de las formas geométricas
        /// </summary>
        /// <returns>Área</returns>
        public decimal getArea()
        {
            return areaRectangulos;
        }

        /// <summary>
        /// Retorna el perímetro de las formas geométricas
        /// </summary>
        /// <returns>Perímetro</returns>
        public decimal getPerimetro()
        {
            return perimetroRectangulos;
        }
    }
}
