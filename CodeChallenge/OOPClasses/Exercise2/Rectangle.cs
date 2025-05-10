namespace OOPClasses.Exercise2
{
    public class Rectangle : BaseShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
}
