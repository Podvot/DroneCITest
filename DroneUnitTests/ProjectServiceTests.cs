
using DroneTest.Entities;
using DroneTest.Service;

namespace DroneUnitTests;

public class Tests
{
    private TestService _testService;

    [SetUp]
    public void Setup()
    {
        var ingredients = new List<Ingredient>
        {
            new Ingredient
            {
                Id = 1,
                Name = "Hot water",

            }
        };
        _testService = new TestService(ingredients);
    }

    [Test]
    public void CanCreateNewIngredient()
    {
        //Arrange
        var expected = new Ingredient
        {
            Id = 2,
            Name = "Chocolate",
        };
        //Act
        _testService.AddIngredient(expected);
        var actual = _testService.GetIngredient(2);
        //Asset
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CanDeleteIngredient()
    {
        //Arrange
        var expected = _testService.GetIngredient(1);

        //Act
        _testService.DeleteIngredient(1);

        //Assert
        Assert.That(_testService.Ingredients, Has.No.Member(expected));

    }

    [Test]
    public void CanAddIngredient()
    {
        //Arrange
        Recipe recipe = new Recipe(100, "TestForRecipe");
        Ingredient ingredient = new Ingredient();
        //Act
        recipe.AddedIngredients(ingredient);
        //Assert
        CollectionAssert.Contains(recipe.Ingredients, ingredient);
    }


}