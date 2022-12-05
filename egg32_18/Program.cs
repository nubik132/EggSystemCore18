using Exploring;
namespace egg32_18
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Exploring.Exploring exploring = new Exploring.Exploring();
                exploring.Solve();
                Console.ReadKey();
                Console.WriteLine();
            }
        }
    }
}