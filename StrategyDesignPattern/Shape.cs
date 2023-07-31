namespace StrategyDesignPattern
{
    public class Shape
    {
        private readonly ICalculateAreaStrategy _calculateAreaStrategy;

        public Shape(ICalculateAreaStrategy calculateAreaStrategy)
        {
            _calculateAreaStrategy = calculateAreaStrategy;
        }

        public double CalculateArea()
        {
            return Math.Round(_calculateAreaStrategy.CalculateArea(), 2);
        }
    }
}
