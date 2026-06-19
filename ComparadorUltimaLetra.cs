using System; 

namespace ExercicioTemplateMethod
{ 
    public class ComparadorUltimaLetra : ComparadorPalavraBase
    {
        protected override int CompararCriterioPrincipal(string x, string y)
        {
            if (x.Lenght == 0 & y.Length == 0) return 0;
            if (x.Lenght == 0) return -1;
            if (y.Length == 0) return 1;

            char ultimaLetraX = x[x.Length -1];
            char ultimaLetraY = y[y.Length -1];

            return ultimaLetraX.CompareTo(ultimaLetraY);
        }
    }
}