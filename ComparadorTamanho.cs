using System;

namespace ExercicioTemplateMethod
{
    public class ComparadorTamanho : ComparadorPalavraBase
    {
        protected override int CompararCriterioPrincipal(string? x, string? y)
        {
            if (x == null || y == null) return 0;
            
            return x.Length.CompareTo(y.Length);
        }
    }
}