namespace Exercise
{
    class Program
    {
        static void Main()
        {
            Menu menu = new Menu();
            Serializer serializer = new Serializer();
            while (true)
            {
                Console.WriteLine("Menu:\n  1. Feed the cat.\n  2. Play with the cat.\n  3. Heal the cat.\n  4. Show all cats.\n  5. Create a cat.\n  6. Save and exit.");
                Console.Write("Enter the number of the selected action: ");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        menu.FeedCat();
                        break;
                    case "2":
                        menu.PlayCat();
                        break;
                    case "3":
                        menu.HealCat();
                        break;
                    case "4":
                        menu.ShowAllCats();
                        break;
                    case "5":
                        menu.CreateCat();
                        break;
                    case "6":
                        serializer.RecordingCats();
                        break;
                    default:
                        Console.WriteLine("Error! Enter the number from 1 to 6.");
                        break;
                }
            }
        }
    }
}