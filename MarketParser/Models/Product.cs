namespace MarketParser.Models
{
    public class Product
    {
        //Название товара
        public string? Description { get; set; } = "";
        //Цена товара
        public int Price { get; set; }
        //Рейтинг по количеству оценок
        public double Rating { get; set; }
        //Ссылка на изображение
        public string? Image_url { get; set; } = "";

        public Product(){} 
    }
}
