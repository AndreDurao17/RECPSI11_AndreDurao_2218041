using System;

namespace M11_01_07_Exceptions_RaiseException
{
    class Program
    {
        static void Main(string[] args)
        {
            string NomeUtilizador;
            Console.WriteLine("Como se chama: ");
            NomeUtilizador = Console.ReadLine();

            string IdadeLida;
            Console.Write("\nQual a sua idade: ");
            IdadeLida = Console.ReadLine();

            int IdadeEmInt;

            int.TryParse(IdadeLida, out IdadeEmInt);

            try
            {
                if (IdadeEmInt <= 0)
                {
                    throw new ArgumentOutOfRangeException("Não pode indicar idades iguais ou inferiores a 0");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro!!!! -> {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"\n Olá {NomeUtilizador}!" +
                $"Tens {IdadeEmInt} anos? Não pareces ter um dia acima de 5! ");
            }
            Console.ReadKey();

            /*
             * 28.a) a - O codigo funciona, mas a frase não faz sentido
             *    b) a - O programa não é executado
             *       b - O programa não aceita a idade 0
             *       c - O codigo não consegue ler o 0 pois está fora do seu alcançe
             * 30.c) a - O codigo coree sem erros
             *    d) d - O programa mantem se mas não lê o 0 mostrando esta mensagem "System.ArgumentOutOfRangeException: 
             *           'Specified argument was out of the range of valid values.'"
             *       e -  Desta vez o código não mostra a mensagem erro
             *       f - O código procura a excepção mas não a encontra
             * 32.a - O programa mantem se igual
             *    b - Não observo qualquer mudança
             *    c - A excepção continua igual sem ser alcançada
             */
        }
    }
}
