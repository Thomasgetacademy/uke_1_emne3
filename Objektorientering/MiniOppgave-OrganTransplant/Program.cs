namespace Objektorientering
{
    public class Hospital
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public int Floor { get; private set; }
        public int RoomNumber { get; private set; }
        public string[] Tools { get; }


        public Hospital(string name, string address, int floor, int roomNumber, string[] tools)
        {
            Name = name;
            Address = address;
            Floor = floor;
            RoomNumber = roomNumber;
            Tools = tools;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tools = { "Scissors", "Tape", "Binoculars" };
            var hospital1 = new Hospital("St.George", "Turnaround 7", 5, 32, tools);
            Console.WriteLine(hospital1.Tools[1]);
        }
    }


}