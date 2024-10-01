namespace RecursiveLars;

class Program
{
    static void Main(string[] args)
    {
        recTest rec = new recTest();
        rec.Recursive(1);
        rec.Printumbers();
    }
}
public class recTest
{

    public int Recursive(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        if (n == 24068)
        {
            return 1;
        }
        Console.WriteLine(n);
        return Recursive(n + 1);
    }


    public void Printumbers()
    {
        Console.WriteLine("forloop");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }
    }
}