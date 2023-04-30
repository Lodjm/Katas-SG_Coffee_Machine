using Coffee_Machine_MenuDisplay.Models;

namespace Coffee_Machine_MenuDisplay.Contracts
{
    public interface IIngredientRepository
    {
        IEnumerable<Ingredient> GetIngredients();
    }
}
