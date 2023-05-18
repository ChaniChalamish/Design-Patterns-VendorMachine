using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    public class DrinkDirector
    {
        //private DrinkBuilder drinkBuilder;

        //public DrinkDirector(DrinkBuilder builder)
        //{
        //    drinkBuilder = builder;
        //}

        public Product ConstructDrink(DrinkBuilder drinkBuilder)
        {
            //drinkBuilder.SetName();
            drinkBuilder.SetPrice();
            drinkBuilder.Pour();
            drinkBuilder.AddIngredient();
           return drinkBuilder.GetDrink();
        }
    }

}
