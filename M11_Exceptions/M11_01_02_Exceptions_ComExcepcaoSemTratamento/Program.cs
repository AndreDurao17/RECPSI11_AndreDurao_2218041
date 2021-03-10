using System;

namespace M11_01_02_Exceptions_ComExcepcaoSemTratamento
{
    class Program
    {
        static void Main(string[] args)
        {
            string exemplo = "123ab";
            int teste = Int32.Parse(exemplo);
            Console.WriteLine($"Resultado da conversão: {teste}");

            Console.ReadKey();

           /* a - O código deu erro
            * b - No exemplo "123ab" tem letras o que não funciona,
            * pois o int so funciona para numeros 
            * c - Ha uma excepção apresentada que não está a ser tratada 
           */
        }
    }
}
