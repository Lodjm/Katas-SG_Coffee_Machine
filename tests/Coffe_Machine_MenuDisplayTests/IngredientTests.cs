using Coffee_Machine_MenuDisplay.Models;

namespace Coffe_Machine_MenuDisplayTests
{
    public class IngredientTests
    {
        [Theory]
        [InlineData("", 0.1)]
        [InlineData("test", -0.1)]
        public void Ingredient_Should_Be_Invalid(string name, decimal price)
        {
            Assert.False(new Ingredient(name, price).IsValid);
        }

        [Theory]
        [InlineData("test", 0.0)]
        [InlineData("test", 0.1)]
        public void Ingredient_Should_Be_valid(string name, decimal price)
        {
            Assert.True(new Ingredient(name, price).IsValid);
        }
    }
}
