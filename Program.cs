 namespace control_flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator: ");
            string oper = Console.ReadLine();

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (oper == "+")
            {
                Console.WriteLine($"The sum is {num1 + num2}");
            }
            else if (oper == "-")
            {
                Console.WriteLine($"The result after substraction is {num1 - num2}");
            }
            else if (oper == "*")
            {
                Console.WriteLine($"The product of your input is {num1 * num2}");
            }
            else if (oper == "/")
            {
                Console.WriteLine($"The value after dividing your input is {num1 / num2}");
            }
            else if (oper == "%")
            {
                Console.WriteLine($"The remainder after dividing your input is {num1 % num2}");
            }
            else
            {
                Console.WriteLine("PLEASE ENTER A VALID OPERATOR!!!");
            }







        }
       

       
    }
}