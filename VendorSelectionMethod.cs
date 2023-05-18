using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    public class VendorSelectionMethod : IState
    {

        public Product SelectProduct(string pro, Stock stock, bool bag, bool gift)
        {

            ProductType productType;
            Enum.TryParse(pro, out productType);

            return stock.GetProduct(productType);

        }
        public decimal ProcessPayment(Product product, decimal paymentAmount, Stock stock)
        {
            Console.WriteLine("Payment is not allowed without selecting a product.");
            return 0;
        }

        public Product ProcessProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}