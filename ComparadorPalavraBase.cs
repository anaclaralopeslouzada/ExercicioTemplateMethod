using System;
using System.Collections.Generic;

namespace ExercicioTemplateMethod
{
    public abstract class ComparadorPalavraBase : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            int resultado = CompararCriterioPrincipal(x, y);

            if (resultado == 0)
            {
                return x.CompareTo(y);
            }

            return resultado;
        }

        protected abstract int CompararCriterioPrincipal(string x, string y);
    }
}