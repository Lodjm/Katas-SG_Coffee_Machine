namespace Coffee_Machine_MenuDisplay.Models
{
    public record Ingredient(string Name, decimal Price)
    {
        public bool IsValid
        {
           get
            {
                return !string.IsNullOrEmpty(Name) && Price >= 0;
            }
        }
    }
}

