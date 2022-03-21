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

                //pobranie liczby od użytkownika
                var number1 = int.Parse(Console.ReadLine());


                //Poproś o podanie działania
                Console.WriteLine("Co chcesz zrobić? możliwe opacje to: '+' '-' '*' '/'");

                //pobieranie wybranego działania od użytkownika
                var operation = Console.ReadLine();

                //prośba o podanie drugiej liczby
                Console.WriteLine("Wpisz proszę drugą liczbę:");

                //pobranie liczby użytkownika
                var number2 = int.Parse(Console.ReadLine());

                var result = 0;

                //Wykonanie obliczeń
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

                //Wyświetlenie wyniku użytkownikowi '
                Console.WriteLine($"Wynik twojego działania to: {result}");
            }
            catch (Exception ex)
            {
                //logowanie do pliku informacji o błędzie
                Console.WriteLine(ex.Message);
            }

        }

    }
}
