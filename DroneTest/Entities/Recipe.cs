using System.Collections.Generic;

namespace DroneTest.Entities;

public class Recipe
{
    
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<Ingredient> Ingredients { get; set; }

    public Recipe(int id, string name)
    {
        Id = id;
        Name = name;
        Ingredients = new List<Ingredient>();
    }

    public void AddedIngredients(Ingredient ingredient)
    {
        Ingredients.Add(ingredient);
    }
    
}