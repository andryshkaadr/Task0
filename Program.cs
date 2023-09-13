namespace Task0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int number1 = r.Next(0,10) - 5, number2 = r.Next(0, 10) - 5;
            int mathDegree = 3;

            if (number1==0 || number2==0) 
            {
                Console.WriteLine("( {0} * {1} )^{2} = 0 ", number1, number2, mathDegree);
            }
            else
            {
                Console.WriteLine("( {0} * {1} )^{2} = {3} ", number1, number2, mathDegree, MultiplicationInDegree(number1, number2, mathDegree));
            }

        }

        /// <summary>
        /// Функция возведения в степень произведения двух целых чисел
        /// </summary>
        /// <param name="number1">множимое</param>
        /// <param name="number2">множитель</param>
        /// <param name="mathDegree">степень</param>
        /// <returns>куб произведения</returns>
        static int MultiplicationInDegree(int number1, int number2, int mathDegree)
        {
            return (int)Math.Pow(number1 * number2, mathDegree);
        }
    }
}