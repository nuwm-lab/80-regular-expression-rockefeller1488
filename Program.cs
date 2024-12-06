using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string inputText = "Контактні номери: +3(123)-456-7890, +3(987)-654-3210, неправильний номер +3(123)-4567-890";
        
        string pattern = @"\+3\(\d{3}\)-\d{3}-\d{4}";
        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(inputText);

        foreach (Match match in matches)
        {
            Console.WriteLine("Знайдений номер: " + match.Value);
        }
    }
}
