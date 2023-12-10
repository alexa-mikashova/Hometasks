using (StreamReader input = new StreamReader("../../../../input_text.txt"))
using (StreamWriter output = new StreamWriter("../../../../output_text.txt"))
{
    char[] characterCeparator = { ' ', ',', '.', ':', ';', '-', '!', '?', '\t', '\n', '\r' };
    string line;
    string lineToLover;
    while ((line = input.ReadLine()) != null)
    {
        if (String.IsNullOrWhiteSpace(line))
        {
            continue;
        }
        lineToLover = line.ToLower();
        var words = lineToLover.Split(characterCeparator);
        var countWord = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (countWord.ContainsKey(word))
            {
                countWord[word]++;
            }
            else
            {
                countWord[word] = 1;
            }
        }

        string mostCommonWord = null;
        int maxCount = 0;
        foreach (var pair in countWord)
        {
            if (pair.Value > maxCount)
            {
                mostCommonWord = pair.Key;
                maxCount = pair.Value;
            }
        }

        output.WriteLine($"{mostCommonWord} {maxCount}");
    }
}