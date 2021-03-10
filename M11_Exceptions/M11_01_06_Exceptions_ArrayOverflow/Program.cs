using System;

namespace M11_01_06_Exceptions_ArrayOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lista = new string[3];
            lista[0] = "Cão";
            lista[1] = "Gato";
            lista[2] = "Cavalo";

            Console.WriteLine($"O animal na posição na 4 posição do array é: {lista[3]}");

            Console.ReadKey();

            /*
             * 24.a - O codigo da erro
             * 24.b - O codigo está a mostrar uma lista
             * 24.c - O código não esta a executar porque o "lista[3]" não existe
            */
        }
    }
}
