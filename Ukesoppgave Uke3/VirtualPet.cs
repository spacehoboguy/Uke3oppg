namespace Ukesoppgave_Uke3;

public class VirtualPet
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public int Hunger { get; private set; }
    public string FavoriteFood { get; }

    public VirtualPet(string name, string favoriteFood)
    {
        Name = name;
        FavoriteFood = favoriteFood;
    }

    public VirtualPet(string name, int age, int hunger, string favoriteFood)
    {
        Name = name;
        Age = age;
        Hunger = hunger;
        FavoriteFood = favoriteFood;
    }

    public void Feed()
    {
        Console.WriteLine("Takk for maten!");
    }

    public void Feed(string incomingFood)
    {
        Console.WriteLine(incomingFood == FavoriteFood
            ? "WOW! Favoritt Maten min!"
            : "Ikke favoritten min, men det funker! Takk<3");
    }
}