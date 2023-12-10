using System.Text.Json;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Homework10._3
{
    public class Person
    {
        public string Name { get; set; }

        public string Birthday { get; set; }

        public int Height { get; set; }

        public double Weight { get; set; }

        public bool Car { get; set; }

        public List<string> Languages { get; set; }
    }

    public class JsonToXmlConverter
    {
        private List<Person> people;

        public string ConvertJsonToXml(string jsonFilePath)
        {
            string json = File.ReadAllText(jsonFilePath);
            people = JsonSerializer.Deserialize<List<Person>>(json)!;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            StringBuilder xml = new StringBuilder();
            using (XmlWriter writer = XmlWriter.Create(xml))
            {
                serializer.Serialize(writer, people);
            }
            return xml.ToString();
        }

        public string SaveToXmlFile(string xmlString, string xmlFilePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);
            xmlDoc.Save(xmlFilePath);
            return $"Данные сохранены в файл XML по пути: {xmlFilePath}";
        }

        public string PrintPersonData(string name)
        {
            Person person = people.Find(p => p.Name == name)!;
            if (person != null)
            {
                return $"Name: {person.Name};\nBirthday: {person.Birthday};\nHeight: {person.Height};\nWeight: {person.Weight};\nCar: {person.Car};\nLanguages: {string.Join(", ", person.Languages)};";
            }
            else
            {
                return "Человек с данным именем не найден.";
            }
        }

        public string FilterPeopleLanguage(string language)
        {
            List<string> names = new List<string>();
            foreach (Person person in people)
            {
                if (person.Languages.Contains(language))
                {
                    names.Add(person.Name);
                }
            }

            if (names.Count > 0)
            {
                return $"Имена людей владеющие языком {language}: {string.Join(", ", names)}";
            }
            else
            {
                return $"Человек, владеющий языком {language} не найден.";
            }
        }
    }
}
