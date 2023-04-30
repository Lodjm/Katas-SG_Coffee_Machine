namespace Coffee_Machine_MenuDisplay.Models
{
    public record Recipient(string RecipientName, IEnumerable<IngredientCounter> Ingredients);
}
