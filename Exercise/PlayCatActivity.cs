namespace Exercise;
public class PlayCatActivity : ICatActivity
{
    public void PerformActivity(Cat cat)
    {
        Random random = new Random();
        int random2 = random.Next(1, 12);
        if (random2 >= 1 && random2 <= 10)
        {
            if (cat.Age >= 0 && cat.Age <= 6)
            {
                cat.SatietyLevel -= 10;
                cat.MoodLevel += 20;
            }
            else if (cat.Age >= 6 && cat.Age <= 11)
            {
                cat.SatietyLevel -= 15;
                cat.MoodLevel += 15;
            }
            else
            {
                cat.SatietyLevel -= 20;
                cat.MoodLevel += 5;
            }
        }
        else
        {
            cat.MoodLevel -= 30;
            cat.HealthLevel -= 35;
            Console.WriteLine("While playing with the cat, you accidentally set the cat on fire =(");
        }
    }
}