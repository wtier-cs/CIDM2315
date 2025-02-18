namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input an integer:");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Input another integer:");
        int b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"a={a}; b={b}\nThe latgest number is: {Q1_method(a, b)}");
        Console.WriteLine("Input integer N:");
        int N = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Input a shape (left or right):");
        string? shape = Console.ReadLine();
        Q2_method(N, shape);
    }
    static int Q1_method(int a, int b) {
        return a > b ? a : b;
    }
    static void Q2_method(int N, string? shape) {
        Console.WriteLine($"N is: {N}; shape is {shape}");
        for (int i = 1; i <= N; i++)
            {
                if (shape == "right")
                {
                    for (int j = 1; j <= N - i; j++)
                    {
                        Console.Write(' ');
                    }
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine("");
            }
    }
}
