namespace StrategyDesignPattern
{
    public class Square : ICalculateAreaStrategy
    {
        public double SideLength { get; set; }

        public double CalculateArea()
        {
            return Math.Pow(SideLength, 2);
        }
    }
}
