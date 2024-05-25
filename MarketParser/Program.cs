namespace MarketParser
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Parser parser = new Parser();

            await parser.StartBrowser();
            await parser.GetContent();
            await parser.CloseBrowser();

        }
    }
}