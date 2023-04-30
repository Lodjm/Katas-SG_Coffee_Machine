using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine_MenuDisplay.Models
{
    public class Drink
    {
        private decimal _margin = 1;

        public Drink(Recipient recipient, IEnumerable<Ingredient> ingredients, decimal margin)
        {
            Price = 0;
            Name = recipient.RecipientName; _margin += margin;
            if (recipient != null && recipient.Ingredients != null && ingredients != null)
            {
                IsValid = true;
                CalculatePrice(recipient, ingredients);
            }
        }
        private void CalculatePrice(Recipient recipient, IEnumerable<Ingredient> ingredients)
        {
            decimal price = 0;
            foreach (var ingredientCounter in recipient.Ingredients)
            {
                var ingredient = ingredients.FirstOrDefault(i => i.Name == ingredientCounter.Name);
                if (ingredient == null) 
                {
                    IsValid = false;
                    break;
                }

                if (ingredient != null)
                {
                    price += ingredient.Price * ingredientCounter.Count;
                }
            }
            if (IsValid)
            {
                Price = price * _margin;
            }
        }

        public string Name { get; }

        public decimal Price { get; private set; }
        public bool IsValid { get; private set; }
    }
}
