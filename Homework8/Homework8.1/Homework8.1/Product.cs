namespace Homework8._1
{
    public class Product
    {
        public string ProductName { get; set; }
        public string StoreName { get; set; }
        public decimal Price { get; set; }

        public string ProductInformation()
        {
            return $"Товар {ProductName}, магазин - '{StoreName}', стоимость - {Price} руб.";
        }
    }
}
