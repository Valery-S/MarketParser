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


        //Получение информации о товаре
        public async Task GetContent()
        {
            // Загрузка страницы 
            var page = await browser?.NewPageAsync();
            await page.GoToAsync("https://www.citilink.ru/search/?text=смартфон&sorting=price_asc&p=3");

            // Получение содержимого страницы
            var content = await page.GetContentAsync();

            // Запрос на нахождение цен товаров
            var jsSelectAllPrices = "Array.from(document.querySelectorAll(\".e1j9birj0\")).map(a => a.innerText);";

            // Поиск содержимого по запросу
            var prices = await page.EvaluateExpressionAsync<string[]>(jsSelectAllPrices);

            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine("{0}", prices[i]);
            }

            SaveHtmlToFile(content);
        }


        // Сохранение html кода страницы в файл
        void SaveHtmlToFile(string? content)
        {
            try
            {
                StreamWriter sw = new StreamWriter("D:\\Test5.html");
                sw.WriteLine(content);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

    }
}
