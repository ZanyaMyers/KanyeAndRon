using Newtonsoft.Json.Linq;

namespace KanyeAndRon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enjoy the following spectacle");
            Console.WriteLine(); 
            for(int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    QuoteGenerator.KanyeQuote();
                }
                else
                {
                    QuoteGenerator.RonQuote();
                }
            }
        }
    }
}