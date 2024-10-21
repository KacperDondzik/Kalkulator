using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w aplikacji KALKULATOR!");

            Console.WriteLine("Podaj proszę 1 liczbę:");


            var number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Jaką operację chcesz wykonać? Możliwe operacje to: '+', '-', '*', '/'.");

            var operation = Console.ReadLine();



        }
    }
}