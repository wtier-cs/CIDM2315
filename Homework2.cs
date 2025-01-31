namespace Homework2;

class Program
{
    static int GPAPoint(string? letterGrade) // I had to add the `?` to the `letterGrade` parameter because `Console.ReadLine` returns `string?`, which yielded a compiler warning.
    {
        switch (letterGrade)
        {
            case "A":
                return 4;
            case "B":
                return 3;
            case "C":
                return 2;
            case "D":
                return 1;
            case "F":
                return 0;
            default:
                return -1;
        }
    }
    static void Main(string[] args)
    {
        // Q1 Code:
        Console.WriteLine("Please input a letter grade:");
        int gpaPoint = GPAPoint(Console.ReadLine());
        if (gpaPoint == -1)
        {
            Console.WriteLine("Wrong Letter Grade!");
        }
        else
        {
            Console.WriteLine($"GPA point: {gpaPoint}");
        }

        //Q2 Code:
        Console.WriteLine("Please input the first num:");
        int num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the second num:");
        int num2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the third num:");
        int num3 = Convert.ToInt16(Console.ReadLine());
        int smallest = (num3<num1) && (num3<num2) ? num3 : num2<num1 ? num2 : num1;
        Console.WriteLine($"The smallest value is: {smallest}");
        
        //Bonus Question Code:
        Console.WriteLine("Please input a year:");
        int year = Convert.ToInt16(Console.ReadLine());
        if (year%400 == 0 || year%4 == 0 && year%100 != 0)
        {
            Console.WriteLine($"{year} is a Leap Year");
        }
        else
        {
            Console.WriteLine($"{year} is not a Leap Year");
        }
    }
}
