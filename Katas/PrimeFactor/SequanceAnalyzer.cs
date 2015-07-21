using System.Linq;

namespace Katas.PrimeFactor
{

    public struct SequenceAnalysisResult
    {
        public int MinValue;
        public int MaxValue;
        public int SequenceLength;
        public double AvarageValue;
        
        public SequenceAnalysisResult(int min, int max, int length, double avarage)
        {
            MinValue = min;
            MaxValue = max;
            SequenceLength = length;
            AvarageValue = avarage;
        }
    }

    public class SequanceAnalyzer
    {
        public SequenceAnalysisResult Analyze(int[] sequence)
        {
            if (sequence.Length == 0)
            {
                return new SequenceAnalysisResult();
            }

            return new SequenceAnalysisResult{
                SequenceLength = sequence.Length,
                MinValue = sequence.Min(),
                MaxValue = sequence.Max(),
                AvarageValue = sequence.Average()
            };
        }
    }
}