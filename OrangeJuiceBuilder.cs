using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    internal class OrangeJuiceBuilder : DrinkBuilder
    {
        public override void AddIngredient()
        {
            drink.Description+="Adding Orange juice";
        }

        public override void Pour()
        {
            drink.Description += "Pouring ice cubes";
        }

        //public override void SetName()
        //{
        //   drink.Name= "OrangeJuice";
        //}

        public override void SetPrice()
        {
            drink.Price = 9.7m;
            
        }
    }
}
