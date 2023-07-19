using System;
using System.Linq;

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

        
        public string GetAnswerV2(int nb)
        {
            if (nb < 1) throw new ArgumentOutOfRangeException("Nb should be greater or equal to 1");
            
            var answer = string.Empty;
            var digits = nb.ToString().Select(t=>int.Parse(t.ToString())).ToList<int>();
            if(nb % 3 == 0) answer = "Fizz";
            var threes = digits.Where(i => i == 3);
            if (threes.Any()) threes.ToList<int>().ForEach(i => answer += "Fizz");
            if(nb % 5 == 0) answer += "Buzz";
            var fives = digits.Where(i => i == 5);
            if (fives.Any()) fives.ToList<int>().ForEach(i => answer += "Buzz");

            return string.IsNullOrEmpty(answer) ? nb.ToString() : answer;
        }
    }
}
