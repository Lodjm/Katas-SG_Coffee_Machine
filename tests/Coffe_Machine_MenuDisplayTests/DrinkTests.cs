using Coffee_Machine_MenuDisplay.Models;

namespace Coffe_Machine_MenuDisplayTests
{
    public class DrinkTests
    {
        [Fact]
        public void Drink_Should_SetPrice_0_And_Name_Of_Recipient()
        {
            var drink = new Drink(new Recipient("test", null), null, 0);

            Assert.Equal(0, drink.Price);
            Assert.Equal("test", drink.Name);
        }

        [Fact]
        public void Drink_Should_SetPrice_IngredientPrice_Multiply_By_Count()
        {
            var ing = new Ingredient("test", 0.3m);
            var ingCount = new IngredientCounter("test", 3);
            var drink = new Drink(new Recipient("test", new List<IngredientCounter>()
            {
                ingCount
            }),
            new List<Ingredient>()
            {
                ing
            },
            0);

            Assert.Equal(0.9m, drink.Price);
        }

        [Fact]
        public void Drink_Should_SetPrice_By_Adding_IngredientCounter()
        {
            var ing = new Ingredient("test", 0.3m);
            var ing2 = new Ingredient("test2", 0.1m);
            var ingCount = new IngredientCounter("test", 3);
            var ingCount2 = new IngredientCounter("test2", 1);
            var drink = new Drink(new Recipient("test", new List<IngredientCounter>()
            {
                ingCount,
                ingCount2
            }),
                new List<Ingredient>()
                {
                ing,
                ing2
                },
            0);

            Assert.Equal(1m, drink.Price);
        }

        [Fact]
        public void Drink_Should_SetPrice_With_Margin()
        {
            var ing = new Ingredient("test", 0.3m);
            var ing2 = new Ingredient("test2", 0.1m);
            var ingCount = new IngredientCounter("test", 3);
            var ingCount2 = new IngredientCounter("test2", 1);
            var drink = new Drink(new Recipient("test", new List<IngredientCounter>()
            {
                ingCount,
                ingCount2
            }),
                new List<Ingredient>()
                {
                ing,
                ing2
                },
            0.3m);

            Assert.Equal(1.3m, drink.Price);
        }
    }
}
