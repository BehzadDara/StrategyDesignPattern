namespace StrategyDesignPattern
{
    public class Circle : ICalculateAreaStrategy
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
