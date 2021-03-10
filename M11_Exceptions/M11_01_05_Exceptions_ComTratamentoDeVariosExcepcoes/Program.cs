using System;

namespace M11_01_05_Exceptions_ComTratamentoDeVariosExcepcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 1;
                int y = 0;
                int z = x / y;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Erro Formatação!!!!! -> {ex.Message}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Erro. Não pode dividir por 0 !");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro!!!! -> {ex.Message}");
            }
            Console.ReadKey();

            /*
             * 19.a - O código é executado
             * 19.b - Desta vez é o segundo catch a ser apanhado
             * 19.c - O´código da erro pois a divisão não é possivel ser feita
             * 21.a - O código é executado
             * 21.b - Desta vez é o segundo catch a ser apanhado
             * 21.c O código mostra que não é possivel dividir por 0
            */
        }
    }
}
