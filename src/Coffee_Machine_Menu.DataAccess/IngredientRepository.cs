using Coffee_Machine_MenuDisplay.Contracts;
using Coffee_Machine_MenuDisplay.Models;

namespace Coffee_Machine_Menu.DataAccess
{
    public class IngredientRepository : BaseRepository, IIngredientRepository
    {
        internal IngredientRepository() : base("Ingredients.json", "_data")
        {
        }

        public IEnumerable<Ingredient> GetIngredients()
        {
            return GetData<Ingredient>();
        }
    }
}
