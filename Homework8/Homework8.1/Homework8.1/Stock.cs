namespace Homework8._1
{
    public class Stock
    {
        private List<Product> products;

        public Stock()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product newProduct)
        {
            if (newProduct is null)
            {
                throw new ArgumentNullException(nameof(newProduct));
            }

            products.Add(newProduct);
        }

        public void RemoveProduct(Product product)
        {
            if (product is null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            products.Remove(product);
        }

        public string GetProductInfoByIndex(int index)
        {
            if (index >= 0 && index < products.Count)
            {
                return products[index].ToString();
            }
            return "Продукта с таким индексом на складе нет!";
        }

        public string GetProductInfoByName(string productName)
        {
            foreach (var product in products)
            {
                if (product.ProductName == productName)
                {
                    return product.ToString();
                }
            }
            return "Продукта с таким названием на складе нет!";
        }

        public static decimal operator +(Stock stock)
        {
            decimal totalPrice = 0;
            foreach (var product in stock.products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }
}
