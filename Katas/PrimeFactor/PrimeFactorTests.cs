using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Ploeh.AutoFixture.Xunit;
using Xunit.Extensions;

namespace Katas.PrimeFactor
{
    public class PrimeFactorTests
    {
        [Theory]
        [InlineAutoData(new int[]{})]
        public void EmptySequence_ReturnsAllZeros(
            int[] sequence, 
            SequanceAnalyzer sut)
        {
            var actual = sut.Analyze(sequence);
            actual.Should().Be(new SequenceAnalysisResult());
        }


        // Could be database or excel file
        public static IEnumerable<object[]> MyProp
        {
            get
            {
                yield return new object[] {new int[] {1}, new SequenceAnalysisResult(1, 1, 1, 1), new SequanceAnalyzer()};
            }
        }
            
            
        [Theory]
        [PropertyData("MyProp")]
        public void AtomicSequence_ReturnsAllSameValues(
            int[] sequence,
            SequenceAnalysisResult expected,
            SequanceAnalyzer sut)
        {
            var actual = sut.Analyze(sequence);
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineAutoData(new int[] { 6, 9, 15, -2, 92, 11 })]
        public void PredefinedSequence_ReturnsCorrectResult(
            int[] sequence,
            SequanceAnalyzer sut)
        {
            var actual = sut.Analyze(sequence);

            var expectedAvarage = sequence.Sum() / 6.0;

            var expected = new SequenceAnalysisResult{
                                    MinValue = -2, 
                                    MaxValue = 92, 
                                    SequenceLength = 6,
                                    AvarageValue = expectedAvarage};

            actual.ShouldBeEquivalentTo(expected);
        }
    }
}
