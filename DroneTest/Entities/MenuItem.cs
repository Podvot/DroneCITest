namespace DroneTest.Entities;

public class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<Ingredient> Ingredients { get; set; }
    public IList<Recipe> Recipes { get; set; }

}