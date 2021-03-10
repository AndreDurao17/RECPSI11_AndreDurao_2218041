using System;

namespace M11_01_03_Exceptions_ComTratamentoDeExcepcaoGeral
{
    class Program
    {
        static void Main(string[] args)
        {
            string exemplo = "123ab";

            try
            {
                int teste = Int32.Parse(exemplo);
                Console.WriteLine($"Resultado da conversão: {teste}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro!!! -> {ex.Message}");

            }
            Console.ReadKey();

            /* a - O codigo continua a dar erro
             * b - Agora em vez de dizer só que ouve um erro, executa também a 
             * msg de erro
             * c - O código tentou ser executado, mas acabou por ser executado
             * com msg de erro
            */
        }
    }
}
