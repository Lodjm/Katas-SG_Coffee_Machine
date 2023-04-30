using Coffee_Machine_MenuDisplay.Contracts;

namespace Coffee_Machine_MenuDisplay
{
    public class MenuDisplayService : IMenuDisplayService
    {
        private readonly IRecipientRepository _recipientRepository;
        private readonly IIngredientRepository _ingredientRepository;

        public MenuDisplayService(IRecipientRepository recipientRepository, IIngredientRepository ingredientRepository)
        {
            _recipientRepository = recipientRepository;
            _ingredientRepository = ingredientRepository;
        }



        public string GetPrice(string drinkName)
        {
            var recipient = _recipientRepository.GetRecipients();
            var ingredient = _ingredientRepository.GetIngredients();

            //TODO Get Price :)

            throw new NotImplementedException();
        }
    }
}
