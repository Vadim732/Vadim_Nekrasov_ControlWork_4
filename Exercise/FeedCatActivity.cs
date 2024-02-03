namespace Exercise;
public class FeedCatActivity : ICatActivity
{
    public void PerformActivity(Cat cat)
    {
        Random random = new Random();
        int random1 = random.Next(1, 12);

        if (random1 >= 1 && random1 <= 10)
        {
            if (cat.Age >= 0 && cat.Age <= 6)
            {
                cat.SatietyLevel += 20;
                cat.MoodLevel += 20;
            }
            else if (cat.Age >= 6 && cat.Age <= 11)
            {
                cat.SatietyLevel += 15;
                cat.MoodLevel += 15;
            }
            else
            {
                cat.SatietyLevel += 10;
                cat.MoodLevel += 5;
            }
        }
        else
        {
            cat.SatietyLevel -= 10;
            cat.MoodLevel -= 20;
            cat.HealthLevel -= 30;
            Console.WriteLine("While feeding the cat, you accidentally dropped a bag of food on it :с");
        }
    }
}