using DroneTest.Entities;

namespace DroneTest.Service;

public class TestService
{
    
    public IList<Ingredient> Ingredients
    {
        get; 
        private set;
    }
    
    public TestService(IList<Ingredient> ingredients)
    {
        Ingredients = ingredients;
    }
    
    public Ingredient GetIngredient(int id)
    {
        return Ingredients.Where(x => x.Id == id).FirstOrDefault();
    }

    public void AddIngredient(Ingredient ingredient)
    {
        Ingredients.Add(ingredient);
    }

    public void DeleteIngredient(int id)
    {
        var ingredient = GetIngredient(id);
        Ingredients.Remove(ingredient);
    }

}