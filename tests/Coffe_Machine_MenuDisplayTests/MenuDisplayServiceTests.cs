using Coffee_Machine_MenuDisplay;
using Coffee_Machine_MenuDisplay.Contracts;
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
        public void Test1()
        {

        }
    }
}