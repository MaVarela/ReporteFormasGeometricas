namespace CodingChallenge.Data.Classes.Contadores
{
    /// <summary>
    /// Contadores para la forma geométrica círculo
    /// </summary>
    public class ContadorCirculos : IContadorFormaGeometrica
    {
        private static int numeroCirculos = 0;
        private static decimal areaCirculos = 0m;
        private static decimal perimetroCirculos = 0m;
        private static ContadorCirculos instance = null;

        /// <summary>
        /// Retorna el contador, si no está instanciado lo instancia
        /// </summary>
        /// <returns>ContadorCirculos</returns>
        public static ContadorCirculos GetInstance()
        {
            if (instance == null)
                instance = new ContadorCirculos();

            return instance;
        }

        /// <summary>
        /// Realiza la suma de área, perímetro y cantidad de la forma geométrica
        /// </summary>
        /// <param name="forma">Forma geométrica</param>
        public void SumarFormaGeometrica(FormaGeometrica forma)
        {
            numeroCirculos++;
            areaCirculos += forma.CalcularArea();
            perimetroCirculos += forma.CalcularPerimetro();
        }

        /// <summary>
        /// Reinicia los contadores
        /// </summary>
        public void Dispose()
        {
            numeroCirculos = 0;
            areaCirculos = 0m;
            perimetroCirculos = 0m;
        }

        /// <summary>
        /// Retorna la cantidad de la forma geométrica
        /// </summary>
        /// <returns>Cantidad</returns>
        public int getCantidad()
        {
            return numeroCirculos;
        }

        /// <summary>
        /// Retorna el área de las formas geométricas
        /// </summary>
        /// <returns>Área</returns>
        public decimal getArea()
        {
            return areaCirculos;
        }

        /// <summary>
        /// Retorna el perímetro de las formas geométricas
        /// </summary>
        /// <returns>Perímetro</returns>
        public decimal getPerimetro()
        {
            return perimetroCirculos;
        }
    }
}
