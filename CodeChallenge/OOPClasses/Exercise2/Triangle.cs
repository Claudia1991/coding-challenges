namespace OOPClasses.Exercise2
{
    public class Triangle : BaseShape
    {
        private const double BASE_VALUE = 0.5;
        public double Base { get; set; }
        public double Height { get; set; }
        public override double CalculateArea()
        {
            return BASE_VALUE * Base * Height;
        }
    }
}
