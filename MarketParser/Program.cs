using MarketParser.Sites;
using MarketParser.Models;

namespace MarketParser
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Создание и заполнение словаря сайтов
            SitesDictionary _sd=new SitesDictionary();
            _sd.FillSitesDictionary();

            //Создание и запуск парсера
            Parser _parser = new Parser();
            await _parser.StartBrowser();

            //Создание списка товаров
            List<Product> _product= new List<Product> ();

            //Получение товаров с сайта "Ситилинк" по запросу "Телефон", товары отсортированы по цене
            _product = _parser.GetProducts(_sd.DictionaryofSites[NamesOfSites.Citilink], "телефон", NamesOfSortingTypes.PriceDown);

            //Вывод данных о товарах в терминал
            foreach (Product p in _product)
            {
                Console.WriteLine(p.Description);
                Console.WriteLine(p.Price + "\n");
            }

            //Завершение работы парсера
            await _parser.CloseBrowser();

        }
    }
}