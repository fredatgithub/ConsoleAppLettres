namespace ConsoleAppLettres
{
  internal class Program
  {
    static void Main()
    {
      Action<string> Display = Console.WriteLine;
      Display("lettres de l'alphabet");
      var alphabet = new char[26];
      var reverseAlphabet = new char[26];
      for (int i = 65; i < 65 + 26; i++)
      {
        alphabet[i - 65] = (char)i;
      }

      int count = 0;
      for (int i = 65 + 25; i > 64; i--)
      {
        reverseAlphabet[count] = (char)i;
        count++;
      }

      for (int i = 0; i < 26; i++)
      {
        Display($"{alphabet[i]}{reverseAlphabet[i]}");
      }

      Display("Press any key to exit:");
      Console.ReadKey();
    }
  }
}
