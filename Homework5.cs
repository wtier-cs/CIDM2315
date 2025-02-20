namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c, d; // used for Q1 and Q2
        // Q1
        Console.WriteLine("Enter Int a:");
        a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter Int b:");
        b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"a = {a}; b = {b}\nThe largest number is: {Q1_method(a, b)}");
        // Q2
        Console.WriteLine("Enter Int a:");
        a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter Int b:");
        b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter Int c:");
        c = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter Int d:");
        d = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"a = {a}; b = {b}; c = {c}; d = {d};\nThe largest number is: {Q2_method(a, b, c, d)}");
        // Q3
        CreateAccount();
    }
    static int Q1_method(int a, int b) {
        return a > b ? a : b;
    }
    static int Q2_method(int a, int b, int c, int d) {
        return Q1_method(Q1_method(a, b), Q1_method(c, d));
    }
    static bool CheckAge(int birth_year){
    	int age = DateTime.Now.Year - birth_year;
        return age >=18;
    }
    static void CreateAccount() {
        Console.WriteLine("Enter Your Username:");
        string? username = Console.ReadLine();
        Console.WriteLine("Enter Your Password:");
        string? password = Console.ReadLine();
        Console.WriteLine("Enter Your Password Again:");
        string? password_again = Console.ReadLine();
        Console.WriteLine("Enter Your Birthyear:");
        int birth_year = Convert.ToInt16(Console.ReadLine());
        if (CheckAge(birth_year))
        {
            if (password == password_again)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
}
