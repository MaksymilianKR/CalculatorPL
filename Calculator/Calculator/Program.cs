using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Witaj w Aplikalcji KALULATOR!");
                Console.WriteLine("Wpisz dowolną liczbę:");

                var number1 = int.Parse(Console.ReadLine());


                Console.WriteLine("Co chcesz zrobić? możliwe opacje to: '+' '-' '*' '/'");

                var operation = Console.ReadLine();

                Console.WriteLine("Wpisz proszę drugą liczbę:");

                var number2 = int.Parse(Console.ReadLine());

                var result = 0;

                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        result = number1 / number2;
                        break;
                    default:
                        throw new Exception("Wybrałeś złą operacje");

                }

                Console.WriteLine($"Wynik twojego działania to: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
//done 