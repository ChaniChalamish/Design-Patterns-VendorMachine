using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    public class Drink : Product
    {
        //public string? Description { get; set; }
        public override string ToString()
        {
            return base.ToString() ;
        }
        //public List<Ingredient> Ingredients { get; set; }

        //public void AddIngredient(Ingredient ingredient)
        //{
        //    Ingredients.Add(ingredient);
        //}
    }
}
