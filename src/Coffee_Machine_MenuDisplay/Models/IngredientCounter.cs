namespace Coffee_Machine_MenuDisplay.Models
{
    public record IngredientCounter(string Name, int Count)
    {
        public bool IsValid
        {
            get
            {
                return !string.IsNullOrEmpty(Name) && Count > 0;
            }
        }
    }
}
