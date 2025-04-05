using System;
class Program
{
    static void Main(string[] args)
    {
        float Sum = 0;
        int Count = int.Parse(Console.ReadLine());
        for(int i = 0; i < Count; i++)
        {
            float Grade = float.Parse(Console.ReadLine());
            Sum += Grade;
        }
        if (Count > 0)
        {
            float avg = Sum / Count;
            Console.WriteLine(avg);
            if(avg >= 3.0f)
            {
                Console.WriteLine("Uczeń zdał.");
            }
            else
            {
                Console.WriteLine("Uczeń nie zdał.");
            }
        }
    }
}