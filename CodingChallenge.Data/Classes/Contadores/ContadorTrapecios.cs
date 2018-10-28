namespace CodingChallenge.Data.Classes.Contadores
{
    /// <summary>
    /// Contadores para la forma geométrica trapecio
    /// </summary>
    public class ContadorTrapecios : IContadorFormaGeometrica
    {
        private static int numeroTrapecios = 0;
        private static decimal areaTrapecios = 0m;
        private static decimal perimetroTrapecios = 0m;
        private static ContadorTrapecios instance = null;

        /// <summary>
        /// Retorna el contador, si no está instanciado lo instancia
        /// </summary>
        /// <returns>ContadorTrapecios</returns>
        public static ContadorTrapecios GetInstance()
        {
            if (instance == null)
                instance = new ContadorTrapecios();

            return instance;
        }

        /// <summary>
        /// Realiza la suma de área, perímetro y cantidad de la forma geométrica
        /// </summary>
        /// <param name="forma">Forma geométrica</param>
        public void SumarFormaGeometrica(FormaGeometrica forma)
        {
            numeroTrapecios++;
            areaTrapecios += forma.CalcularArea();
            perimetroTrapecios += forma.CalcularPerimetro();
        }

        /// <summary>
        /// Reinicia los contadores
        /// </summary>
        public void Dispose()
        {
            numeroTrapecios = 0;
            areaTrapecios = 0m;
            perimetroTrapecios = 0m;
        }

        /// <summary>
        /// Retorna la cantidad de la forma geométrica
        /// </summary>
        /// <returns>Cantidad</returns>
        public int getCantidad()
        {
            return numeroTrapecios;
        }

        /// <summary>
        /// Retorna el área de las formas geométricas
        /// </summary>
        /// <returns>Área</returns>
        public decimal getArea()
        {
            return areaTrapecios;
        }

        /// <summary>
        /// Retorna el perímetro de las formas geométricas
        /// </summary>
        /// <returns>Perímetro</returns>
        public decimal getPerimetro()
        {
            return perimetroTrapecios;
        }
    }
}
