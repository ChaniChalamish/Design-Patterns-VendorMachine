using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{

    public abstract class DrinkBuilder
    {
        protected Drink drink;

        public DrinkBuilder()
        {
            drink = new Drink();
        }

        //public abstract void SetName();

        public abstract void SetPrice();
        public abstract void Pour();
        public abstract void AddIngredient();

        public Drink GetDrink()
        {
            return drink;
        }
    }
}

