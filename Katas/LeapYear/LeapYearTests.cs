using FluentAssertions;
using Ploeh.AutoFixture.Xunit;
using Xunit.Extensions;

namespace Katas.LeapYear
{
    public class LeapYearTests
    {
        [Theory]
        [InlineAutoData(1996, true)]
        [InlineAutoData(2001, false)]
        [InlineAutoData(1900, false)]
        [InlineAutoData(2000, true)]
        public void leap_year_analyzer_returns_correct_results(
            int year, 
            bool expected,
            YearAnalyzer sut)
        {
            var actual = sut.IsLeapYear(year);
            actual.Should().Be(expected);
        }
    }

    public class YearAnalyzer
    {
        public bool IsLeapYear(int year)
        {
            return IsDevisibleBy4(year) &&
                   (IsDevisibleBy400(year) ||
                   IsNotDevisibleBy100(year));
        }

        private static bool IsDevisibleBy4(int year)
        {
            return year % 4 == 0;
        }

        private static bool IsNotDevisibleBy100(int year)
        {
            return year % 100 != 0;
        }
        
        private static bool IsDevisibleBy400(int year)
        {
            return year % 400 == 0;
        }
    }
}
