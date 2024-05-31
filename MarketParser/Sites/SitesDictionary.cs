﻿using MarketParser.Models;

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
            _site.Page ="&p=";
            _site.SortingBy.Add(NamesOfSortingTypes.PriceUp, "&sorting=price_asc");
            _site.SortingBy.Add(NamesOfSortingTypes.PriceDown, "&sorting=price_desc");
            _site.SortingBy.Add(NamesOfSortingTypes.Rating, "&sorting = rating_desc");
            _site.PriceSelector = ".e1j9birj0";
            _site.DescriptionSelector = ".app-catalog-9gnskf";
            DictionaryofSites.Add(NamesOfSites.Citilink, _site);

            _site = new Site();
            _site.Name = NamesOfSites.Wildberries;
            _site.SearchUrl = "https://www.wildberries.ru/catalog/0/search.aspx?search=";
            _site.Page = "?page=";
            _site.SortingBy.Add(NamesOfSortingTypes.PriceUp, "&sort=priceup");
            _site.SortingBy.Add(NamesOfSortingTypes.PriceDown, "&&sort=pricedown");
            _site.SortingBy.Add(NamesOfSortingTypes.Rating, "&sort=rate");
            _site.PriceSelector = ".price__lower-price";
            _site.DescriptionSelector = ".product-card__name";
            DictionaryofSites.Add(NamesOfSites.Wildberries, _site);
        }
    }
}