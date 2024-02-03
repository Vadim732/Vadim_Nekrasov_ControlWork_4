namespace Exercise;
public class Cat
{
    public delegate void CatEventHandler(string catName);

    public event CatEventHandler FatCat;
    public event CatEventHandler HungryCat;
    public event CatEventHandler AngryCat;
    public event CatEventHandler UnhappyCat;

    public string Name { get; set; }
    public int Age { get; set; }
    public double SatietyLevel { get; set; }
    public double MoodLevel { get; set; }
    public double HealthLevel { get; set; }

    private void CheckCatConditions()
    {
        if (SatietyLevel > 100)
        {
            FatCat?.Invoke(Name);
        }

        if (SatietyLevel < 10)
        {
            HungryCat?.Invoke(Name);
        }

        if (MoodLevel < 10)
        {
            AngryCat?.Invoke(Name);
        }

        if (HealthLevel < 10)
        {
            UnhappyCat?.Invoke(Name);
        }
    }
}