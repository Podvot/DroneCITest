using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;
using System.Text.Json.Serialization;
using DroneTest.Entities;
using DroneTest.Service;

namespace  DroneTest
{
    public class Program
    {
        public static void Main()
        {

            var ingredient = new Ingredient
            {
               
                Id = 1,
                Name = "Hot chocolate",
               
            };

            var recipe = new Recipe(1, "Hot chocolate recipe");

            var lists = new Lists()
            {
               
                Ingredients = new List<Ingredient> { ingredient },
                Recipes = new List<Recipe>{ recipe }
               
            };

            JsonUtils jsonUtils = new JsonUtils();
            jsonUtils.Write(lists, "test.json");

            var testsDeserialized = jsonUtils.Read("test.json");
            var testsService = new TestService(testsDeserialized.Ingredients);
            var fetchedIngredient = testsService.GetIngredient(1);
           
            Console.WriteLine(fetchedIngredient);

            var addIngredient = new Ingredient
            {
                Id = 2,
                Name = "Chocolate",
               
            };

            testsService.AddIngredient(addIngredient);
                lists.Ingredients = testsService.Ingredients;
            jsonUtils.Write(lists, "test.json");

        }
    } 
}