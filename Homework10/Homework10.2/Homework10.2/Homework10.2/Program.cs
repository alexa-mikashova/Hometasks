using System.Text.RegularExpressions;
string uncensoredTextFile = @"E:\\Courses\\Hometasks\\Homework10\\Homework10.2\\uncensored_text.txt";
string text = File.ReadAllText(uncensoredTextFile).ToLower();
string forbiddenWordsFile = @"E:\\Courses\\Hometasks\\Homework10\\Homework10.2\\forbidden_words.txt";
string forbiddenWords = File.ReadAllText(forbiddenWordsFile);
string[] forbiddenWordsArray = forbiddenWords.Split(' ');
foreach (string word in forbiddenWordsArray)
{
    string pattern = word;
    text = Regex.Replace(text, pattern, new string('*', word.Length));
}

Console.WriteLine(text);
