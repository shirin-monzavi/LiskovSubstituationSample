namespace LiskovSubstituationSample
{
    public class EvenNumbersCalculator : Calculator
    {
        public EvenNumbersCalculator(int[] numbers) : base(numbers)
        {
        }

        public override int Calculate()
        {
            return Numbers.Where(n=>n % 2 ==0).Sum();
        }
    }
}
