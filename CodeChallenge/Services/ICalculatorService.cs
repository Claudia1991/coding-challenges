namespace Services
{
    public interface ICalculatorService
    {
        /// <summary>
        /// Add 2 numbers
        /// </summary>
        /// <param name="valueOne"></param>
        /// <param name="valueTwo"></param>
        /// <returns>The result of the addition</returns>
        int Add(int? valueOne, int? valueTwo);

        /// <summary>
        /// Substract 2 numbers
        /// </summary>
        /// <param name="valueOne"></param>
        /// <param name="valueTwo"></param>
        /// <returns>The result of the substraction</returns>
        int Substract(int? valueOne, int? valueTwo);

        /// <summary>
        /// Divide 2 numbers
        /// </summary>
        /// <param name="valueOne"></param>
        /// <param name="valueTwo"></param>
        /// <returns>The result of the division</returns>
        int Divide(int? valueOne, int? valueTwo);

        /// <summary>
        /// Multiply 2 numbers
        /// </summary>
        /// <param name="valueOne"></param>
        /// <param name="valueTwo"></param>
        /// <returns>The result of the multiplication</returns>
        int Multiply(int? valueOne, int? valueTwo);
    }
}
