namespace Exercise;
public class HealCatActivity : ICatActivity
{
    public void PerformActivity(Cat cat)
    {
        Random random = new Random();
        int random3 = random.Next(1, 12);

        if (random3 >= 1 && random3 <= 10)
        {
            if (cat.Age >= 0 && cat.Age <= 6)
            {
                cat.SatietyLevel -= 10;
                cat.MoodLevel -= 10;
                cat.HealthLevel += 20;
            }
            else if (cat.Age >= 6 && cat.Age <= 11)
            {
                cat.SatietyLevel -= 15;
                cat.MoodLevel -= 15;
                cat.HealthLevel += 15;
            }
            else
            {
                cat.SatietyLevel -= 20;
                cat.MoodLevel -= 20;
                cat.HealthLevel += 10;
            }
        }
        else
        {
            cat.SatietyLevel -= 10;
            cat.MoodLevel += 40;
            cat.HealthLevel -= 35;
            Console.WriteLine("During treatment, the cat drank medical alcohol :(");
        }
    }
}