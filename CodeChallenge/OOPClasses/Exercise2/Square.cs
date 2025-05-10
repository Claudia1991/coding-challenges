namespace OOPClasses.Exercise2
{
    public class Square : BaseShape
    {
        public double Length { get; set; }
        public override double CalculateArea()
        {
            return Length * Length;
        }
    }
}
