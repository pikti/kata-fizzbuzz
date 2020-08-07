using System;

namespace FizzBuzz.Services
{
    public class FizzBuzzService
    {
        public string GetAnswer(int nb)
        {
            if (nb < 1) throw new ArgumentOutOfRangeException("Nb should be greater or equal to 1");
            
            string answer = string.Empty;
            if(nb % 3 == 0) answer = "Fizz";
            if(nb % 5 == 0) answer += "Buzz";

            return string.IsNullOrEmpty(answer) ? nb.ToString() : answer;
        }
    }
}
