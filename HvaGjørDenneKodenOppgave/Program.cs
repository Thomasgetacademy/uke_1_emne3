namespace HvaGjørDenneKodenOppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            int totalCount = 0;
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (var character in text ?? string.Empty)
                {
                    var lowerCase = char.ToLower(character);
                    counts[(int)lowerCase]++;
                }
                foreach (var i in counts)
                {
                    totalCount = totalCount + i;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        int percentComplete = (int)Math.Round((double)(100 * counts[i]) / totalCount);

                        Console.WriteLine(character + " - " + counts[i]);
                        Console.WriteLine(character + " % " + percentComplete);
                        
                    }
                }

                totalCount = 0;
            }
        }
    }
}