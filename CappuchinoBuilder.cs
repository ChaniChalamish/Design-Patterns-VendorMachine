using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    internal class CappuchinoBuilder : DrinkBuilder
    {
        public override void AddIngredient()
        {
            drink.Description += $"adding capuchino flavor";
        }

        public override void Pour()
        {
            drink.Description += $"Pouting Hot Water";
        }

        //public override void SetName()
        //{
        //    drink.Name="Cappuchino";
            
        //}

        public override void SetPrice()
        {
            drink.Price=17.5m;
            
        }
    }
}
