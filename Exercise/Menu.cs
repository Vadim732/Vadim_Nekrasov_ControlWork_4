using System;
namespace Exercise;
public class Menu
{
    public List<Cat> catList = new List<Cat>();
    public void FeedCat()
    {
        Cat selectedCat = SelectCat();
        ICatActivity feedActivity = new FeedCatActivity();
        feedActivity.PerformActivity(selectedCat);

        UpdateAndDisplayCat(selectedCat, "You fed the cat");
    }
    public void PlayCat()
    {
        Cat selectedCat = SelectCat();
        ICatActivity playActivity = new PlayCatActivity();
        playActivity.PerformActivity(selectedCat);

        UpdateAndDisplayCat(selectedCat, "You played with the cat");
    }
    public void HealCat()
    {
        Cat selectedCat = SelectCat();
        ICatActivity healActivity = new HealCatActivity();
        healActivity.PerformActivity(selectedCat);

        UpdateAndDisplayCat(selectedCat, "You healed the cat");
    }
    public void ShowAllCats()
    {
        List<Cat> sortedCats = new List<Cat>(catList);

        sortedCats.Sort(new CatComparer());
        Console.WriteLine("All Cats:");
        foreach (var cat in sortedCats)
        {
            double averageLevel = (cat.SatietyLevel + cat.MoodLevel + cat.HealthLevel) / 3;
            Console.WriteLine($"Name: {cat.Name}, age: {cat.Age}, satiety level: {cat.SatietyLevel}, mood level: {cat.MoodLevel}, health level: {cat.HealthLevel}");
        }
    }
    public void CreateCat()
    {
        Cat newCat = new Cat();
        Console.Write("Enter the cat's name: ");
        while (true)
        {
            string name = Console.ReadLine();
            if (CorrectName(name))
            {
                newCat.Name = name;
                break;
            }
            else
            {
                Console.Write("Error: Enter the name correctly: ");
            }
        }
        Console.Write("Enter the cat's age: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                newCat.Age = age;
                break;
            }
            else
            {
                Console.Write("Error: Enter the age correctly: ");
            }
        }
        newCat.SatietyLevel = 10;
        newCat.MoodLevel = 10;
        newCat.HealthLevel = 10;

        newCat.FatCat += HandleFatCat;
        newCat.HungryCat += HandleHungryCat;
        newCat.AngryCat += HandleAngryCat;
        newCat.UnhappyCat += HandleUnhappyCat;

        catList.Add(newCat);
        Console.WriteLine($"Cat {newCat.Name} added to the list.");
    }
    private bool CorrectName(string name)
    {
        return !string.IsNullOrWhiteSpace(name) && name.All(char.IsLetter);
    }
    private void UpdateAndDisplayCat(Cat cat, string actionMessage)
    {
        catList.RemoveAll(c => c.Name == cat.Name);
        catList.Add(cat);

        Console.WriteLine($"{actionMessage} {cat.Name}");
        Console.WriteLine($"Characteristics of {cat.Name} - Satiety: {cat.SatietyLevel}, Mood: {cat.MoodLevel}, Health: {cat.HealthLevel}");
    }
    private Cat SelectCat()
    {
        string catName;
        do
        {
            Console.Write("Enter the cat's name: ");
            catName = Console.ReadLine();
            if (!catList.Any(cat => cat.Name == catName))
            {
                Console.WriteLine("Error: You do not have a cat with this name.");
            }
        } while (!catList.Any(cat => cat.Name == catName));
        return catList.First(cat => cat.Name == catName);
    }
    private void HandleFatCat(string catName)
    {
        Console.WriteLine($"Your cat {catName} burst. You're too kind!");
        RemoveCat(catName);
    }
    private void HandleHungryCat(string catName)
    {
        Console.WriteLine($"Your cat {catName} died of hunger. You're a bad owner!");
        RemoveCat(catName);
    }
    private void HandleAngryCat(string catName)
    {
        Console.WriteLine($"Your cat {catName} peed in your shoes. You're a bad owner!");
        RemoveCat(catName);
    }
    private void HandleUnhappyCat(string catName)
    {
        Console.WriteLine($"Your cat {catName} died. You're a bad owner!");
        RemoveCat(catName);
    }
    private void RemoveCat(string catName)
    {
        catList.RemoveAll(c => c.Name == catName);
    }
}