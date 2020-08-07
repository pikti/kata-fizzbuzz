using System;
using Xunit;
using FizzBuzz.Services;

namespace FizzBuzz.UnitTests.Services
{
    public class FizzBuzzService_GetAnswerShould
    {
        private readonly FizzBuzzService _fizzBuzzService;

        public FizzBuzzService_GetAnswerShould()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-3)]
        public void GetAnswer_InputIsLessThan1_ReturnArgumentOutOfRangeException(int value)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _fizzBuzzService.GetAnswer(value));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(44)]
        public void GetAnswer_InputIsNotAMultipleOf3Or5_ReturnInput(int value)
        {
            var result = _fizzBuzzService.GetAnswer(value);
            Assert.True(int.TryParse(result, out int nb) && nb == value, $"Input: {value} | Result: {result}");
        }

        [Theory]
        [InlineData(3)]
        [InlineData(9)]
        [InlineData(66)]
        public void GetAnswer_InputIsAMultipleOf3_ReturnFizz(int value)
        {
            var result = _fizzBuzzService.GetAnswer(value);
            Assert.True(result == "Fizz", $"Input: {value} | Result: {result}");
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(35)]
        public void GetAnswer_InputIsAMultipleOf5_ReturnBuzz(int value)
        {
            var result = _fizzBuzzService.GetAnswer(value);
            Assert.True(result == "Buzz", $"Input: {value} | Result: {result}");
        }

        [Theory]
        [InlineData(15)]
        [InlineData(45)]
        [InlineData(75)]
        public void GetAnswer_InputIsAMultipleOf3And5_ReturnFizzBuzz(int value)
        {
            var result = _fizzBuzzService.GetAnswer(value);
            Assert.True(result == "FizzBuzz", $"Input: {value} | Result: {result}");
        }
    }
}
