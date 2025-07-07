using ArithmeticLibrary;
namespace ArithmeticApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Calculate cal = new Calculate();
            int ans = cal.Add(900, 19);
            Console.WriteLine(ans);
            int ans1 = cal.Multiply(90, 2);
            Console.WriteLine(ans1);    
        }
    }
}
