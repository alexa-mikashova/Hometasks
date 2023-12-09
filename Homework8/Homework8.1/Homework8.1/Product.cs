namespace Homework8._1
{
    public class Product
    {
        private string _productName;
        private string _storeName;
        private decimal _price;

        public string ProductName
        {
            get { return _productName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _productName = value;
                }
                else
                {
                    throw new ArgumentException(nameof(value));
                }
            }
        }

        public string StoreName
        {
            get { return _storeName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _storeName = value;
                }
                else
                {
                    throw new ArgumentException(nameof(value));
                }
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentException(nameof(value));
                }
            }
        }

        public override string ToString()
        {
            return $"Товар {_productName}, магазин - '{_storeName}', стоимость - {_price} руб.";
        }
    }
}
