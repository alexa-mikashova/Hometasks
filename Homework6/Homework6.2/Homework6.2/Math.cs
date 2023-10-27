namespace Homework6._2
{
    public class Math
    {
        public void Add(double firstNumber, double secondNumber)
        {
            double sum = firstNumber + secondNumber;
            Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
        }
        public void Subtract(double firstNumber, double secondNumber)
        {
            double difference = firstNumber - secondNumber;
            Console.WriteLine($"{firstNumber} - {secondNumber} = {difference}");
        }
        public void Multiply(double firstNumber, double secondNumber)
        {
            double product = firstNumber * secondNumber;
            Console.WriteLine($"{firstNumber} * {secondNumber} = {product}");
        }
        public void Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber != 0)
            {
                double quotient = firstNumber / secondNumber;
                Console.WriteLine($"{firstNumber} : {secondNumber} = {quotient}");
            }
            else
            {
                Console.WriteLine("Делить на нуль нельзя!");
            }
        }
    }
}
