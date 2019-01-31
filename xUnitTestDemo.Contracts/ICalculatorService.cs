namespace xUnitTestDemo.Contracts
{
    /// <summary>
    /// Calculator service to demonstrate basic unit testing 
    /// </summary>
    public interface ICalculatorService
    {
        /// <summary>
        /// Add two integer numbers and returns an integer value
        /// </summary>
        /// <param name="a">first value</param>
        /// <param name="b">second value</param>
        /// <returns>Addition of the first and second value </returns>
        int Add(int a, int b);

        /// <summary>
        /// Substract numbers and returns an integer value
        /// </summary>
        /// <param name="a">first value</param>
        /// <param name="b">second value</param>
        /// <returns>Substraction of the first and second value </returns>
        int Substract(int a, int b);

        /// <summary>
        /// Multiply two integer numbers and returns an integer value
        /// </summary>
        /// <param name="a">first value</param>
        /// <param name="b">second value</param>
        /// <returns>Multiplication of the first and second value </returns>
        int Multiply(int a, int b);

        /// <summary>
        /// Divide two integer numbers and returns an integer value
        /// </summary>
        /// <param name="a">first value</param>
        /// <param name="b">second value</param>
        /// <returns>Divition of the first and second value </returns>
        int Divide(int a, int b);
    }
}
