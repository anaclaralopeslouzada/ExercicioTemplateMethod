using System;

namespace ExercicioTemplateMethod
{
    public class ComparadorTamanho : ComparadorPalavraBase
    {
        protected override int CompararCriterioPrincipal(string x, string y)
        {
            return x.Length.CompareTo(y.Length;)
        }
    }
}