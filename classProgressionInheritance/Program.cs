namespace classProgressionInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression a1 = new ArithmeticProgression(1, 3, 5);
            Console.WriteLine(a1.ToString());
            Console.WriteLine(a1.getSumOfAll());
            Console.WriteLine(a1.getSumOfN(3));

            GeomProgression g1 = new GeomProgression(1, 3, 5);
            Console.WriteLine(g1.ToString());
            Console.WriteLine(g1.getSumOfAll());
            Console.WriteLine(g1.getSumOfN(3));
            Console.WriteLine(a1 > g1);
        }
    }
}