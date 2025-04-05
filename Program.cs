using System;
class Program
{
    static void Main(string[] args)
    {
        int operand1 = int.Parse(Console.ReadLine());
        int operand2 = int.Parse(Console.ReadLine());
        string oper = Console.ReadLine();
        if (oper == "+")
        {
            Console.WriteLine(operand1 + operand2);
        }
        else if (oper == "-")
        {
            Console.WriteLine(operand1 - operand2);
        }
        else if (oper == "*")
        {
            Console.WriteLine(operand1 * operand2);
        }
        else if (oper == "/")
        {
            if (operand2 == 0)
            {
                Console.WriteLine("Error (x / 0)");
            }
            else
            {
                Console.WriteLine(operand1 / operand2);
            }
        }
        else
        {
            Console.WriteLine("unidentified");
        }
    }
}