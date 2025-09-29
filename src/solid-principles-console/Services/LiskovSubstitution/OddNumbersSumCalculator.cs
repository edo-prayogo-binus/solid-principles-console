namespace solid_principles_console.Services.LiskovSubstitution
{
    internal class OddNumbersSumCalculator : SumCalculator
    {
        #region prop and ctor
        public OddNumbersSumCalculator(int[] numbers)
            : base(numbers)
        {
            
        }
        #endregion

        #region main method
        public override int Calculate() => _numbers.Where(x => x % 2 != 0).Sum();
        #endregion
    }
}
