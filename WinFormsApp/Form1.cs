using MarketParser;
using MarketParser.Sites;
using MarketParser.Models;

using System.Text.Json;
using System.Text.Json.Serialization;

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
            //�������� � ���������� ������� ������
            SitesDictionary _sd = new SitesDictionary();
            _sd.FillSitesDictionary();

            //�������� ������ �������
            List<Product> _product = new List<Product>();

            if (CitilinkCheckBox.Checked)
            {
                //�������� � ������ �������
                Parser _parser = new Parser();
                _product.AddRange( _parser.GetProducts(_sd.DictionaryofSites[NamesOfSites.Citilink], inputTextBox.Text, NamesOfSortingTypes.PriceDown));
            }
            if (YandexCheckBox.Checked)
            {
                //�������� � ������ �������
                Parser _parser = new Parser();
                _product.AddRange(_parser.GetProducts(_sd.DictionaryofSites[NamesOfSites.YandexMarket], inputTextBox.Text, NamesOfSortingTypes.PriceDown));
            }
            if (WbCheckBox.Checked)
            {
                //�������� � ������ �������
                Parser _parser = new Parser();
                _product.AddRange(_parser.GetProducts(_sd.DictionaryofSites[NamesOfSites.Wildberries], inputTextBox.Text, NamesOfSortingTypes.PriceDown));
            }

            //������� ������ �������
            ProductDataGridView.Rows.Clear();

            //����� ������ � ������� � ��������
            foreach (Product p in _product)
            {
                ProductDataGridView.Rows.Add(p.Description, p.Price, p.URL);
            }
            string json = JsonSerializer.Serialize(_product);
            File.WriteAllText(@"D:\path.json", json);
        }

    }
}
