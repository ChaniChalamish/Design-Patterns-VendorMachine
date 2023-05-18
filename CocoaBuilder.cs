﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    internal class CocoaBuilder : DrinkBuilder
    {
        public override void AddIngredient()
        {
           drink.Description+="adding cocoa flavor and sugar";
        }

        public override void Pour()
        {
            drink.Description+="Pouring boiling water";
        }

        //public override void SetName()
        //{
        //    drink.Name="Cocoa";
        //}

        public override void SetPrice()
        {
            drink.Price=6.5m;
        }
    }
}