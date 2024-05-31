using MarketParser.Models;

using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MarketParser
{
    internal class Parser
    {
        private static EdgeDriver driver;

        public Parser()
        {
            var options = new EdgeOptions();
            driver = new EdgeDriver(options);
        }

        //Закрытие браузера
        public void CloseBrowser()
        {
            driver.Quit();
        }

        //Получение списка товаров
        public List<Product> GetProducts(Site site, string product_name, string sorting_type)
        {
            var products = new List<Product>();

            driver.Url = $"{site.SearchUrl}{product_name}{site.SortingBy[sorting_type]}";
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.CssSelector(site.PriceSelector))));

            SaveHtmlToFile(driver.PageSource);

            // Поиск содержимого по запросу
            var prices = driver.FindElements(By.CssSelector(site.PriceSelector));

            // Поиск содержимого по запросу
            var descriptions = driver.FindElements(By.CssSelector(site.DescriptionSelector));

            for (int i = 0; i < prices?.Count; i++)
            {
                Product product = new Product();
                product.Price = Int32.Parse(prices[i].Text.Replace(" ","").Replace("₽",""));
                product.Description = descriptions[i].Text;
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
