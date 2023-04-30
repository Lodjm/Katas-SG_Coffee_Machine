using Coffee_Machine_MenuDisplay.Models;

namespace Coffe_Machine_MenuDisplayTests
{
    public class IngredientCounterTests
    {
        [Theory]
        [InlineData("", 1)]
        [InlineData("test", 0)]
        public void IngredientCounter_Should_Be_Invalid(string name, int count)
        {
            Assert.False(new IngredientCounter(name, count).IsValid);
        }

        [Theory]
        [InlineData("test", 1)]
        public void Ingredient_Should_Be_valid(string name, int count)
        {
            Assert.True(new IngredientCounter(name, count).IsValid);
        }
    }
}
