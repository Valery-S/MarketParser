using PuppeteerSharp;

namespace MarketParser
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var browserFetcher = new BrowserFetcher();
            await browserFetcher.DownloadAsync();
            var browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = true
            });

            // Загрузка страницы 
            var page = await browser.NewPageAsync();
            await page.GoToAsync("https://www.citilink.ru/search/?text=%D1%81%D0%BC%D0%B0%D1%80%D1%82%D1%84%D0%BE%D0%BD");

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

            // Сохранение html кода страницы в файл
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
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            // Закрытие браузера
            await browser.CloseAsync();
        }
    }
}