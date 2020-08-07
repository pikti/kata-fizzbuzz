using System;
using FizzBuzz.Services;

namespace FizzBuzzServiceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var fb = new FizzBuzzService();
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fb.GetAnswer(i));
            }
        }
    }
}
