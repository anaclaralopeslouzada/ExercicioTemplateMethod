using System;

namespace ExercicioTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = {"Banana", "Uva", "Carambola", "Maça", "Melancia"};
            
            Console.WriteLine("Lista Original");
            Exibir(palavras);

            Console.WriteLine("\n Ordenado por Tamanho");
            Array.Sort(palavras, new ComparadorTamanho());
            Exibir(palavras);

            Console.WriteLine("\n Ordenado por Ultima Letra");
            Array.Sort(palavras, new ComparadorUltimaLetra());
            Exibir(palavras);
        }

        static void Exibir(string[] array)
        {
            foreach (var palavra in array)
            {
                Console.WriteLine(palavra + " ");
            }
            Console.WriteLine();
        }
    }
}