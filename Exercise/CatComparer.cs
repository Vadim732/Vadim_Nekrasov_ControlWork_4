namespace Exercise;
public class CatComparer : IComparer<Cat>
{
    public int Compare(Cat x, Cat y)
    {
        double averageLevelX = (x.SatietyLevel + x.MoodLevel + x.HealthLevel) / 3;
        double averageLevelY = (y.SatietyLevel + y.MoodLevel + y.HealthLevel) / 3;

        if (averageLevelX > averageLevelY)
            return 1;
        else if (averageLevelX < averageLevelY)
            return -1;
        else
            return 0;
    }
}