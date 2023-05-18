using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    internal class VendorProcessProductMethod : IState
    {

        public decimal ProcessPayment(Product product, decimal paymentAmoun, Stock stock)
        {
            throw new NotImplementedException();
        }

        public Product ProcessProduct(Product product)
        {
            if (product != null)
                if (product is Drink)
                {
                    Enum.TryParse(product.Name, out ProductType productType);
                    DrinkBuilder builder;
                    switch (productType)
                    {
                        case ProductType.IceCoffee:
                            builder = new IceCofeeBuilder();
                            break;
                        case ProductType.OrangeJuice:
                            builder = new OrangeJuiceBuilder();
                            break;
                        case ProductType.Cocoa:
                            builder = new CocoaBuilder();
                            break;
                        case ProductType.Cappuchino:
                            builder = new CappuchinoBuilder();
                            break;
                        case ProductType.Tea:
                            builder = new TeaBuilder();
                            break;
                        default:builder= null;
                            break;

                    }
                    DrinkDirector drinkDirector = new DrinkDirector();
                    return drinkDirector.ConstructDrink(builder);
                }
            return product;
        }

        public Product SelectProduct(string pro, Stock stock, bool bag, bool gift)
        {
            throw new NotImplementedException();
        }
    }
}
