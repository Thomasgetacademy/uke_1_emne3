namespace SocialMedia
{
    internal class Program
    {
        public class AddUser
        {
            public string Name { get; private set; }
            public string Email { get; private set; }
            public string Password { get; private set; }
            public int Age { get; private set; }
            public string HairColor { get; private set; }
            public string[] Interests { get; private set; }
            public string[] Friends { get; set; }


            public AddUser(string name, string email, string password, int age, string hairColor, string[] interests, string[] friends)
            {
                Name = name;
                Email = email;
                Password = password;
                Age = age;
                HairColor = hairColor;
                Interests = interests;
                Friends = friends;
            }

        }

        static void Main(string[] args)
        {
            string[] interests1 = { "Fishing", "Shopping", "Climbing" };
            string[] interests2 = { "Hiking", "Driving", "Diving" };
            string[] interests3 = { "Surfing", "Watching TV", "Singing" };

            string[] friends1 = { "Timmy", "Jerry" };
            string[] friends2 = { "Jessica", "Lawrence" };
            string[] friends3 = { };

            var user1 = new AddUser("Alex", "Alex@Yahoo.net", "Password", 32, "Blue", interests1, friends1);
            var user2 = new AddUser("Sophie", "Sophie@Yahoo.net", "Password", 22, "Blue", interests2, friends2);
            var user3 = new AddUser("Terje", "Terje@Yahoo.net", "Password", 27, "Blue", interests3, friends3);

            Console.WriteLine("Hello And Welcome " + user1.Name +
                              "\nYour Commands Are 'AddFriend', 'RemoveFriend', 'ShowFriends', 'FriendShowProfile' and 'Commands'");

            /* The loop that runs the program starts here */
            while (true)
            {
                bool validCommand = false;
                var userCommand = "";
                while (!validCommand)
                {
                    Console.Write("Write one of your commands: ");
                    userCommand = Console.ReadLine();
                    validCommand = CheckValueUserInput(userCommand);
                    if (!validCommand)
                    {
                        Console.WriteLine("Please enter a value Command. To see your commands type 'Commands'");
                    }
                    /* The command given by the user is checked here and runs the function associated with the command.  */
                    if (userCommand == "AddFriend")
                    {
                        user1.Friends = AddFriend(user1.Friends, user2.Name, user3.Name);
                    }
                    else if (userCommand == "RemoveFriend")
                    {
                        user1.Friends = RemoveFriend(user1.Friends);
                    }
                    else if (userCommand == "ShowFriends")
                    {
                        ShowFriends(user1.Friends);
                    }
                    else if (userCommand == "Commands")
                    {
                        Console.WriteLine(
                            "Your Commands Are 'AddFriend', 'RemoveFriend', 'ShowFriends', 'FriendShowProfile' and 'Commands'.");
                    }

                }
            }
        }

        static bool CheckValueUserInput(string cmd)
        {
            if (cmd == "AddFriend" || cmd == "RemoveFriend" || cmd == "ShowFriends" || cmd == "FriendShowProfile" || cmd == "Commands")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string[] AddFriend(string[] mainUserFriends, string user2, string user3)
        {
            Console.WriteLine("Who would you like to add? Available options are: " + user2 + ", " + user3 + " or 'Cancel'.");

            string UserAddFriend = Console.ReadLine();
            if (UserAddFriend == user2 || UserAddFriend == user3)
            {
                string[] newFriends1 = new string[mainUserFriends.Length + 1];
                for (int i = 0; i < mainUserFriends.Length; i++)
                {
                    newFriends1[i] = mainUserFriends[i];
                }
                if (UserAddFriend == user2) /* Sophie */
                {
                    newFriends1[newFriends1.Length - 1] = user2;
                    return newFriends1;
                }
                else if (UserAddFriend == user3) /* Terje */
                {
                    newFriends1[newFriends1.Length - 1] = user3;
                    mainUserFriends = newFriends1;
                    return newFriends1;
                }
                else
                {
                    return newFriends1; /* should be fixed to if user is wanting to cancel */
                }
            }
            else
            {
                return mainUserFriends;/* Buggy code */ /* Unnececary return statement, could not figure it out 05.05.2023 */
            }
        }

        static string[] RemoveFriend(string[] mainUserFriends)
        {
            string userFriends = "";
            string[] userFriendsArray = new string[mainUserFriends.Length];
            int i = 0;
            foreach (var friend in mainUserFriends)
            {
                userFriends += friend + ", ";
                userFriendsArray[i] = friend;
                i++;
            }

            Console.WriteLine("Who would you like to remove? Available options are: " + userFriends + "or 'Cancel'.");
            string userChoice = Console.ReadLine();
            if (userFriendsArray.Contains(userChoice))
            {
                userFriendsArray = userFriendsArray.Where(val => val != userChoice).ToArray();
            }
            return userFriendsArray;
        }

        static void ShowFriends(string[] userFriends)
        {
            if (userFriends.Length == 0)
            {
                Console.WriteLine("It seems you have not added any friends. Try the 'AddFriends' command to add a new friend.");
            }
            else
            {
                foreach (var friend in userFriends)
                {
                    Console.WriteLine(friend);
                }
            }
        }
    }
}