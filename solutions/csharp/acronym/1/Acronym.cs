public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string[] words = phrase.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].Replace("_", "");
        }
        string result = "";

        foreach (string word in words)
        {
            result += char.ToUpper(word[0]);
        }

        return result;
    }
}