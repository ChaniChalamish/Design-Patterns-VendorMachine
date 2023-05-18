using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    public class DrinkDirector
    {
        private DrinkBuilder drinkBuilder;

        public DrinkDirector(DrinkBuilder builder)
        {
            drinkBuilder = builder;
        }

        public void ConstructDrink()
        {
            drinkBuilder.CreateDrink();
            drinkBuilder.AddIngredients();
        }
    }

}
