using System;

namespace M11_01_04_Exceptions_ComTratamentoDeExcepcaoEspecífica
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
            catch (FormatException ex)
            {
                Console.WriteLine($"Erro Formatação!!! -> {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro!!!! -> {ex.Message}");
            }
            Console.ReadKey();

            /*
             * 15.a - Observo que ouve a excepeção não está a ser utilizada
             * 16.a - O código agora é corrido no terminal
             * 16.b - Agora aparce o Erro Formatação no terminal
             * 16.c - O código reconhce o primeiro catch e mostra o 
             */
        }
    }
}