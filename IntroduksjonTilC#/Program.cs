namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tall1 = 1;
            long tall2 = 2048;

            float tall3 = 3.90f;
            decimal tall4 = 3.90m;
            double tall5 = 3.90;

            string tekst1 = "Dette er min tidsmaskin";
            char tekst2 = 'A';
            bool tekst3 = false;

            Console.WriteLine("Hello, Worlddd!");
            Console.WriteLine(AddNumbers(tall1, tall2));
            Console.WriteLine(ReturnNothing());
            Console.WriteLine("Hei, hva heter du?");
            Console.WriteLine(args[0] + " " + args[1] + " " + args[2] + " " + args[3] + " " + args[4]);
            Console.WriteLine("Det er " + args.Length + " ord i 'args'");
            Console.WriteLine(ReturnTrueOrFalse(3, 3));
            Console.WriteLine(ReturnSumIfTrue(3, 2));
            Console.WriteLine(ReturnSumIf30(15, 30));
            Terje5GangerIKonsoll();
            ForEach("test");
            WhileLoopWriteConsle();


            //string navn = Console.ReadLine();
            //Console.WriteLine("Velkommen " + navn);
            Console.ReadLine();
        }
        static int Main1()
        {
            int a = 5;
            decimal b = 3.0m;
            decimal sum = a + b;

            return a;
        }
        static int AddNumbers(int a, decimal b)
        {
            decimal sum = a + b;
            return (int)sum;
        }

        static string ReturnNothing()
        {
            return "Denne metoden returnerer inenting";
        }
        static bool ReturnTrueOrFalse(int tall1, int tall2)
        {
            if (tall1 == tall2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int ReturnSumIfTrue(int tall1, int tall2)
        {
            if (tall1 != tall2)
            {
                return (tall1 + tall2);
            }
            else
            {
                return (tall1 * tall2);
            }
        }
        static bool ReturnSumIf30(int tall1, int tall2)
        {
            if (tall1 == 30 || tall2 == 30 || (tall1 + tall2) == 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Terje5GangerIKonsoll()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Terje er kul");
            }
        }
        static void ForEach(string text1)
        {
            string text = "text";
            char[] myChars = text.ToCharArray();
            foreach (char s in text1)
            {
                Console.WriteLine(s);
            }
        }
        static void WhileLoopWriteConsle()
        {
            int count = 0;
            while (count < 10)
            {
                Console.WriteLine("Runde nummer: " + (count + 1));
                count++;
            }
        }
    }
}