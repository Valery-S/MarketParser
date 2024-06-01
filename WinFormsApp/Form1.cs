using MarketParser;
using MarketParser.Sites;
using MarketParser.Models;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Создание и заполнение словаря сайтов
            SitesDictionary _sd = new SitesDictionary();
            _sd.FillSitesDictionary();

            //Создание и запуск парсера
            Parser _parser = new Parser();

            //Создание списка товаров
            List<Product> _product = new List<Product>();

            if (CitilinkCheckBox.Checked)
            {
                _product.AddRange( _parser.GetProducts(_sd.DictionaryofSites[NamesOfSites.Citilink], inputTextBox.Text, NamesOfSortingTypes.PriceDown));
            }
            if (YandexCheckBox.Checked)
            {
                _product.AddRange(_parser.GetProducts(_sd.DictionaryofSites[NamesOfSites.YandexMarket], inputTextBox.Text, NamesOfSortingTypes.PriceDown));
            }
            if (WbCheckBox.Checked)
            {
                _product.AddRange(_parser.GetProducts(_sd.DictionaryofSites[NamesOfSites.Wildberries], inputTextBox.Text, NamesOfSortingTypes.PriceDown));
            }

            //Очистка списка товаров
            ProductDataGridView.Rows.Clear();

            //Вывод данных о товарах в терминал
            foreach (Product p in _product)
            {
                ProductDataGridView.Rows.Add(p.Description, p.Price);
            }
        }

    }
}
