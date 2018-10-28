namespace CodingChallenge.Data.Classes.Contadores
{
    public interface IContadorFormaGeometrica
    {
        void SumarFormaGeometrica(FormaGeometrica forma);

        void Dispose();

        int getCantidad();

        decimal getArea();

        decimal getPerimetro();
    }
}
