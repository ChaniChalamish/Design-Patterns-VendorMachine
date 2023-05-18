using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    public class HotDrinkBuilder : DrinkBuilder
    {
        

        public override void AddIngredient()
        {
            
            var ingredient = ChooseIngredientFromEnum();
            drink.AddIngredient(ingredient);
            // Add other hot drink-specific ingredients
        }

        public override void Pour()
        {
            throw new NotImplementedException();
        }

        //public override DrinkBuilder SetName(string name)
        //{
        //   return drink.Name = name;
        //}

        //public override DrinkBuilder SetPrice(decimal price)
        //{
        //    throw new NotImplementedException();
        //}

        private Ingredient ChooseIngredientFromEnum()
        {
            var ingredients = Enum.GetValues(typeof(Ingredient)).Cast<Ingredient>().ToList();

            // Create a list of ingredient names for display in the MessageBox
            var ingredientNames = ingredients.Select(ing => ing.ToString()).ToList();

            // Prompt the user to select an ingredient
            var result = MessageBox.Show("Select an ingredient:", "Choose Ingredient",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1, 0,
                string.Join(Environment.NewLine, ingredientNames));

            if (result == DialogResult.OK)
            {
                // Retrieve the selected ingredient from the enum based on the index
                var selectedIndex = MessageBoxOptions.RtlReading.Equals(MessageBoxOptions.RtlReading)
                    ? ingredientNames.Count - 1
                    : 0;

                var selectedIngredient = ingredients[selectedIndex];
                return selectedIngredient;
            }

            // If the user canceled or closed the dialog, return a default ingredient
            return Ingredient.CocoaPowder; // Or any other suitable default value
        }


    }
}
