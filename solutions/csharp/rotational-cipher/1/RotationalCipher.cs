using System.Text;
public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder result = new StringBuilder();
        shiftKey = shiftKey % 26;

        foreach (char letter in text)
        {
            if (letter >= 'a' && letter <= 'z')
            {
                char newLetter = (char)('a' + (letter - 'a' + shiftKey) % 26);
                result.Append(newLetter);
            }
            else if (letter >= 'A' && letter <= 'Z')
            {
                char newLetter = (char)('A' + (letter - 'A' + shiftKey) % 26);
                result.Append(newLetter);
            }
            else result.Append(letter);
        }
        return result.ToString();
    }
}