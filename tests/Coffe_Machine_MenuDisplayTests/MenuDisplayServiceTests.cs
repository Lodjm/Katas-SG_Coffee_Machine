using Coffee_Machine_MenuDisplay;
using Coffee_Machine_MenuDisplay.Contracts;
using Coffee_Machine_MenuDisplay.Models;
using Moq;

namespace Coffe_Machine_MenuDisplayTests
{
    public class MenuDisplayServiceTest
    {
        private Mock<IIngredientRepository> _ingredientRepository = new Mock<IIngredientRepository>();
        private Mock<IRecipientRepository> _recipientRepository = new Mock<IRecipientRepository>();

        private MenuDisplayService GetTarget()
        {
            return new MenuDisplayService(_recipientRepository.Object, _ingredientRepository.Object);
        }

        [Fact]
        public void Display_Price_Should_CreateMenu()
        {
            _ingredientRepository.Setup(i => i.GetIngredients()).Returns(new List<Ingredient>{ new Ingredient("test", 1)});
            _recipientRepository.Setup(i => i.GetRecipients()).Returns(new List<Recipient> { new Recipient("test", new List<IngredientCounter>() { new IngredientCounter("test", 1) }) });
            var target = GetTarget();

            var price = target.GetPrice("test");

            Assert.Contains("1,30 €", price);
        }
    }
}