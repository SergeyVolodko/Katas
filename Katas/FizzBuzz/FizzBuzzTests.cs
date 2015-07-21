using FluentAssertions;
using Xunit.Extensions;

namespace Katas.FizzBuzz
{
    public class FizzBuzzTests
    {
        [Theory, KatasAutoDataAttribute]
        public void GenerateTwoNumbers_Returns12(FizzBuzzGenerator sut)
        {
            var actaul = sut.Generate(2);
            actaul.Should().StartWith("1 2");
        }

        [Theory, KatasAutoDataAttribute]
        public void GenerateThreeNumbers_Returns12Fizz(FizzBuzzGenerator sut)
        {
            var actaul = sut.Generate(3);
            actaul.Should().StartWith("1 2 Fizz");
        }

        [Theory, KatasAutoDataAttribute]
        public void GenerateFiveNumbers_Returns12Fizz4Buzz(FizzBuzzGenerator sut)
        {
            var actaul = sut.Generate(5);
            actaul.Should().StartWith("1 2 Fizz 4 Buzz");
        }

        [Theory, KatasAutoDataAttribute]
        public void GenerateFifteenNumbers_EndsWithFizzBuzz(FizzBuzzGenerator sut)
        {
            var actaul = sut.Generate(15);
            actaul.Should().StartWith("1 2 Fizz 4 Buzz")
                           .And.EndWith("FizzBuzz");
        }

        [Theory, KatasAutoDataAttribute]
        public void GenerateHandredNumbers_ReturnsCorrectString(FizzBuzzGenerator sut)
        {
            var expected = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz "+
                            "11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz "+
                            "Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz "+
                            "31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz "+
                            "41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz "+
                            "Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz "+
                            "61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz "+
                            "71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz "+ 
                            "Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz "+
                            "91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz";

            var actaul = sut.Generate(100);
            actaul.Should().Be(expected);
        }
    }
}
