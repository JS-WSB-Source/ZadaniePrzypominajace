using System;

class Program
{
    static void Main(string[] args)
    {
        string CorF = Console.ReadLine();
        if (CorF == "C")
        {
            float Celcius = float.Parse(Console.ReadLine());
            float Fahrenheit = Celcius * 1.8f + 32f;
            Console.WriteLine(Celcius + " C = " + Fahrenheit + " F");
        }
        else if (CorF == "F")
        {
            float Fahrenheit = float.Parse(Console.ReadLine());
            float Celcius = (Fahrenheit - 32f) / 1.8f;
            Console.WriteLine(Fahrenheit + " C = " + Celcius + " F");
        }
        else
        {
            Console.WriteLine("unidentified");
        }
    }
}