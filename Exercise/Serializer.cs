using System.Text.Json;
namespace Exercise;
public class Serializer
{
    public List<Cat> catList;
    private string path = "Cats.json";

    public Serializer(List<Cat> catList)
    {
        this.catList = catList;
    }
    public Serializer()
    {
        catList = new List<Cat>();
    }
    public void RecordingCats()
    {
        string jsonString = JsonSerializer.Serialize(catList);
        File.WriteAllText(path, jsonString);
    }
    public void RetrieveCats()
    {
        try
        {
            string jsonString = File.ReadAllText(path);
            List<Cat> loadedCats = JsonSerializer.Deserialize<List<Cat>>(jsonString);
            if (loadedCats != null)
            {
                catList.Clear();
                catList.AddRange(loadedCats);
            }
            else
            {
                Console.WriteLine("Error: You don't have cats..");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: Cats.json file not found.");
        }
    }
}