using MarketParser.Models;
using MarketParser.Sites;
using PuppeteerSharp;

namespace MarketParser
{
    internal class Parser
    {
        private static BrowserFetcher? browserFetcher = null;
        private static IBrowser? browser = null;

        public Parser() {}

        //Открытие браузера
        public async Task StartBrowser() 
        {
            browserFetcher ??= new BrowserFetcher();
            await browserFetcher.DownloadAsync();
            browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = true
            });
        }

        //Закрытие браузера
        public async Task CloseBrowser()
        {
            await browser?.CloseAsync();
        }

        //Получение списка товаров
        public List<Product> GetProducts(Site site, string product_name, string sorting_type)
        {
            var products = new List<Product>();

            var page = browser?.NewPageAsync().Result;
            page?.GoToAsync($"{site.SearchUrl}{product_name}{site.SortingBy[sorting_type]}").ConfigureAwait(false).GetAwaiter().GetResult();

            // Получение содержимого страницы
            var content = page?.GetContentAsync().ConfigureAwait(false).GetAwaiter().GetResult();
            SaveHtmlToFile(content);

            // Запрос на нахождение цен товаров
            var jsSelectAllPrices = "Array.from(document.querySelectorAll(\".e1j9birj0\")).map(a => a.innerText);";

            // Запрос на нахождение описаний товаров
            var jsSelectAllDescriptions = "Array.from(document.querySelectorAll(\".app-catalog-9gnskf\")).map(a => a.innerText);";

            // Поиск содержимого по запросу
            var prices = page?.EvaluateExpressionAsync<string[]>(jsSelectAllPrices).ConfigureAwait(false).GetAwaiter().GetResult();

            // Поиск содержимого по запросу
            var descriptions = page?.EvaluateExpressionAsync<string[]>(jsSelectAllDescriptions).ConfigureAwait(false).GetAwaiter().GetResult();

            for (int i = 0; i < prices?.Length; i++)
            {
                Product product = new Product();
                product.Price = Int32.Parse(prices[i].Replace(" ",""));
                product.Description = descriptions[i];
                products.Add(product);
            }

            return products;
        }


        // Сохранение html кода страницы в файл
        void SaveHtmlToFile(string? content)
        {
            try
            {
                StreamWriter sw = new StreamWriter("D:\\Test.html");
                sw.WriteLine(content);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

    }
}
