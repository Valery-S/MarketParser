namespace MarketParser.Models
{
    internal class Site
    {
        //Название сайта
        public string Name { get; set; } = "";
        //URL для поиска на сайте
        public string SearchUrl { get; set; } = "";
        //Словарь, хранящий название сортировки товаров (по цене или рейтингу)
        //и соотвествующей аргумент для url
        public Dictionary<string, string> SortingBy { get; set; }

        public Site()
        {
            SortingBy = new Dictionary<string, string>();
        }
    }
}
