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
            //�������� � ���������� ������� ������
            SitesDictionary _sd = new SitesDictionary();
            _sd.FillSitesDictionary();

            //�������� � ������ �������
            Parser _parser = new Parser();

            //�������� ������ �������
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

            //������� ������ �������
            ProductDataGridView.Rows.Clear();

            //����� ������ � ������� � ��������
            foreach (Product p in _product)
            {
                ProductDataGridView.Rows.Add(p.Description, p.Price);
            }
        }

    }
}
