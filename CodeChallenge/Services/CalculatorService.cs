namespace Services
{
    public class CalculatorService : ICalculatorService
    {
        public int Add(int? valueOne, int? valueTwo)
        {
            if (valueOne.HasValue && valueTwo.HasValue)
            {
                return valueOne.Value + valueTwo.Value;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public int Divide(int? valueOne, int? valueTwo)
        {
            try
            {
                if (valueOne.HasValue && valueTwo.HasValue)
                {
                    return valueOne.Value / valueTwo.Value;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }

        public int Multiply(int? valueOne, int? valueTwo)
        {
            if (valueOne.HasValue && valueTwo.HasValue)
            {
                return valueOne.Value * valueTwo.Value;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public int Substract(int? valueOne, int? valueTwo)
        {
            if (valueOne.HasValue && valueTwo.HasValue)
            {
                return valueOne.Value - valueTwo.Value;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
