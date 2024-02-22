namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int x, int y)
        { 
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool d)
        {
            if (d)
            {
                string newValue = (x + y).ToString() + " dollar";
                if (x+y > 1)
                {
                    newValue += "s";
                }
                return newValue;
            } else
            {
                return "You told me not calc anything.";
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine($"1 + 2 = {Add(1, 2)}");
            Console.WriteLine($"1.01 + 2.02 = {Add(1.01m, 2.02m)}");
            Console.WriteLine($"$1 + $0 = {Add(1,0,true)}");
            Console.WriteLine($"$1 + $9 = {Add(1, 9, true)}");
            Console.WriteLine($"$11 + $0 = {Add(11, 0, false)}");
        }
    }
}
