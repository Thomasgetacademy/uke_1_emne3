namespace Ukesoppgave_1
{
    internal class Program
    {
        static string[] hobbies = {
            " is now a magician. Poof, magic",
            " is now a gardening guru. Watch those green thumbs get to work!",
            " is now a cooking connoisseur. Let's whip up some delicious dishes!",
            " is now a photography phenom. Say cheese and capture those memories!",
            " is now a painting Picasso. Brush, brush, brush those colors onto the canvas!",
            " is now a hiking hero. Let's hit the trails and explore the great outdoors!"};

        static void Main(string[] args)
        {
            Console.WriteLine("Who would like a new hobby?");
            string name = Console.ReadLine();

            Random random = new Random();
            int hobbyLength = hobbies.Length;
            int randomHobby = random.Next(0, hobbies.Length);
            string newHobby = name + hobbies[randomHobby];

            Console.WriteLine(newHobby);
            Console.ReadLine();
        }
    }
}