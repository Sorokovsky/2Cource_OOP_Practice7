namespace Task_3;
public static class Program
{
    public static void Main()
    {
        Console.WriteLine($"10 + 2 = {Calculator.Add(10, 2)}");
        Console.WriteLine($"10 - 2 = {Calculator.Subtract(10, 2)}");
        Console.WriteLine($"10 * 2 = {Calculator.Multiply(10, 2)}");
        Console.WriteLine($"10 / 2 = {Calculator.Divide(10, 2)}");
    }
}