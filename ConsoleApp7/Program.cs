internal class Program
{
    static void Main(string[] args)
    {
        int pages = 464;

        if (pages > 300)
        {
            Console.WriteLine("Long Book");
        }
        else
        {
            Console.WriteLine("Short Book");
        }
    }
}
