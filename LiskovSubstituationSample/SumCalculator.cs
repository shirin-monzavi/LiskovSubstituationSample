namespace LiskovSubstituationSample
{
    public class SumCalculator: Calculator
    {
        public SumCalculator(int[] numbers):base(numbers)
        {
        }

        public override int Calculate()
        {
            return Numbers.Sum();
        }
    }
}
