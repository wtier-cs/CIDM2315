namespace Homework3;

class Program
{
    static void Q1()
    {
        Console.WriteLine("Input an integer:");
        int number = Convert.ToInt16(Console.ReadLine());
        bool isPrime = true;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            Console.WriteLine("N is prime");
        }
        else
        {
            Console.WriteLine("N is non-prime");
        }
    }
    static void Q2()
    {
        Console.WriteLine("Assign an int value to N:");
        int N = Convert.ToInt16(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write('#');
            }
            Console.WriteLine();
        }
    }
    static void Q3()
    {
        Console.WriteLine("Assign an int value to N:");
        int N = Convert.ToInt16(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }static void Bonus()
    {
        Console.WriteLine("Assign an int value to N:");
        int N = Convert.ToInt16(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= N - i; j++)
            {
                Console.Write(' ');
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        Q1();
        Q2();
        Q3();
        Bonus();
    }
}
