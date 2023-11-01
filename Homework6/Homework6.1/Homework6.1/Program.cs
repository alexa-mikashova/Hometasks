using Homework6._1;
Console.Write("Введите вкус Вашей любимой газировки или НЕТ, если Вы любите газировку без вкуса: ");
string taste = Console.ReadLine();
Soda soda = new(taste);
Console.WriteLine(soda.SodaTaste());