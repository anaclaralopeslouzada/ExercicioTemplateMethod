using System; 

namespace ExercicioTemplateMethod
{ 
    public class ComparadorUltimaLetra : ComparadorPalavraBase
    {
        protected override int CompararCriterioPrincipal(string? x, string? y)
        {
            if ( x == null || y == null) return 0;

            char ultimaLetraX = x[x.Length -1];
            char ultimaLetraY = y[y.Length -1];

            return ultimaLetraX.CompareTo(ultimaLetraY);
        }
    }
}