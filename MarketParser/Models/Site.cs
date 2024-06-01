namespace MarketParser.Models
{
    public class Site
    {
        //Название сайта
        public string Name { get; set; } = "";
        //URL для поиска на сайте
        public string SearchUrl { get; set; } = "";
        //Атрибут для задания страницы поиска
        public string Page { get; set; } = "";
        //Словарь, хранящий название сортировки товаров (по цене или рейтингу)
        //и соотвествующей аргумент для url
        public Dictionary<string, string> SortingBy { get; set; }
        //Селекторы для поиска по html коду
        public string PriceSelector { get; set; } = "";
        public string DescriptionSelector { get; set; } = "";
        public string ImageSelector { get; set; } = "";
        public string URLSelector { get; set; } = "";

        public Site()
        {
            SortingBy = new Dictionary<string, string>();
        }
    }
}
