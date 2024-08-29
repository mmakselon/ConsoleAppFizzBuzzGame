using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cześć, zagrajmy w grę Fizz Buzz. Sam spróbuj odgadnąć reguły ;) Podaj dowolną liczbę:");
            var fizzBuzz = new FizzBuzz();

            while (true)
            {
                var number = GetNumber();
                var result = fizzBuzz.CheckNumber(number);
                Console.WriteLine(result);
                Console.WriteLine();

                Console.WriteLine("Podaj kolejną liczbę, lub wyjdź z programu wciskając 'q'");
            }
            Console.WriteLine();
        }

        private static int GetNumber()
        {
            while (true)
            {
                var number = Console.ReadLine();
                if (number.ToLower() == "q")
                {
                    Console.WriteLine("Czy chcesz wcześniej poznać rozwiązanie? [tak/nie]");
                }
               else if (number.ToLower() == "tak")
                {
                    Console.WriteLine("W grze podajesz dowolną liczbę.");
                    Console.WriteLine("Jeżeli liczba będzie podzielna przez 3, otrzymasz komunikat 'Fizz'.");
                    Console.WriteLine("Jeżeli liczba będzie podzielna przez 5, otrzymasz komunikat 'Buzz'.");
                    Console.WriteLine("W przypadku jeśli będzie podzielna przez 3 i przez 5 jednocześnie, otrzymasz komunikat 'FizzBuzz'.");
                    Console.WriteLine("Jeżeli żaden z powyższych warunków nie zostanie spełniony, otrzymasz wpisaną przez siebie liczbę.");
                    Console.WriteLine("Możesz zagrać jeszcze raz podając kolejną liczbę, lub wyjść z programu wciskając 'q'");
                }
                else if (number.ToLower() == "nie")
                    Environment.Exit(0);

                else if (!int.TryParse(number, out int result))
                {
                    Console.WriteLine("Podałeś nieprawidłową wartość! Spróbuj jeszcze raz i podaj kolejną liczbę:");
                    continue;
                }   
                else return result;
            }
        }
    }
}
