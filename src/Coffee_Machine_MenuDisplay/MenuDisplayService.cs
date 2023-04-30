using Coffee_Machine_MenuDisplay.Contracts;
using Coffee_Machine_MenuDisplay.Models;

namespace Coffee_Machine_MenuDisplay
{
    public class MenuDisplayService : IMenuDisplayService
    {
        private Dictionary<string, decimal> _menu;
        private readonly IRecipientRepository _recipientRepository;
        private readonly IIngredientRepository _ingredientRepository;

        public MenuDisplayService(IRecipientRepository recipientRepository, IIngredientRepository ingredientRepository)
        {
            _recipientRepository = recipientRepository;
            _ingredientRepository = ingredientRepository;
        }


        private void CreateMenu()
        {
            var recipients = _recipientRepository.GetRecipients();
            var ingredients = _ingredientRepository.GetIngredients();
            if (recipients == null || ingredients == null)
            {
                throw new Exception("Menu can not be initialized");
            }

            _menu = new Dictionary<string, decimal>();
            foreach (var recipient in recipients)
            {
                var drink = new Drink(recipient, ingredients, 0.3m);
                if (drink.IsValid)
                {
                    _menu.Add(drink.Name, drink.Price);
                }
            }
        }

        public string GetPrice(string drinkName)
        {
            if (_menu == null)
            {
                CreateMenu();
            }

            if (_menu != null)
            {
                if (_menu.ContainsKey(drinkName))
                {
                    return $"Price of your drink is {_menu[drinkName].ToString("C2")}";
                }

                return $"Drink {drinkName} is not found.";
            }

            return "Menu can not be initialized";
        }
    }
}
