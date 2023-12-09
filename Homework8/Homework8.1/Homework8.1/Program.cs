using Homework8._1;
Stock stock = new Stock();
stock.AddProduct(new Product { ProductName = "Молоко", StoreName = "ГИППО", Price = (decimal)1.90 });
stock.AddProduct(new Product { ProductName = "Хлеб", StoreName = "ГИППО", Price = (decimal)1.10 });
Console.WriteLine(stock.GetProductInfoByName("Молоко"));
Console.WriteLine($"Цена всех товаров на складе: {+stock} руб.");