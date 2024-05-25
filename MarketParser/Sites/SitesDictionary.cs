using MarketParser.Models;

namespace MarketParser.Sites
{
    internal class SitesDictionary
    {
        public Dictionary<string,Site> DictionaryofSites { get; set; }

        public SitesDictionary()
        {
            DictionaryofSites = new Dictionary<string, Site>();
        }


        public void FillSitesDictionary()
        {
            Site _site = new Site();
            _site.Name = NamesOfSites.Citilink;
            _site.SearchUrl = "https://www.citilink.ru/search/?text=";
            _site.SortingBy.Add(NamesOfSortingTypes.PriceUp, "&sorting=price_asc");
            _site.SortingBy.Add(NamesOfSortingTypes.PriceDown, "&sorting=price_desc");
            _site.SortingBy.Add(NamesOfSortingTypes.Rating, "&sorting = rating_desc");
            DictionaryofSites.Add(NamesOfSites.Citilink, _site);
        }
    }
}
