using Homework10._3;
JsonToXmlConverter converter = new JsonToXmlConverter();
string choice;
string xml;
while (true)
{
    Console.WriteLine();
    Console.WriteLine("Выберите нужное Вам действие:");
    Console.WriteLine("1. Конвертация JSON => XML");
    Console.WriteLine("2. Выход из программы");
    choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            xml = converter.ConvertJsonToXml("../../../../../employees.json");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите нужное Вам действие:");
                Console.WriteLine("1. Сохранить данные в XML-файл");
                Console.WriteLine("2. Получить информацию о человеке по его имени");
                Console.WriteLine("3. Применить к сотрудникам фильтр по изученным языкам");
                Console.WriteLine("4. Выход из программы");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine(converter.SaveToXmlFile(xml, "../../../../../saveXml.xml"));
                        break;
                    case "2":
                        Console.Write("Введите имя сотрудника:");
                        string employeeName = Console.ReadLine();
                        Console.WriteLine(converter.PrintPersonData(employeeName));
                        break;
                    case "3":
                        Console.Write("Введите язык программирования для фильтрации:");
                        string programmingLanguage = Console.ReadLine();
                        Console.WriteLine(converter.FilterPeopleLanguage(programmingLanguage));
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Повторите ввод снова!");
                        break;
                }
            }
            break;
        case "2":
            return;
        default:
            Console.WriteLine("Повторите ввод снова!");
            break;
    }
}