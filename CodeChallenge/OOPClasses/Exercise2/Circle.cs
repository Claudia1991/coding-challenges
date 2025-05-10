namespace OOPClasses.Exercise2
{
    public class Circle : BaseShape
    {
        private readonly double _pi = Math.PI;
        public double Radius { get; set; }
        public override double CalculateArea()
        {
            return _pi * Radius * Radius;
        }
    }
}
