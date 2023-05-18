using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    public class VendorPaymentMethod : IState
    {
        
        private IStockObserver stockObserver;
        //private MachineState machineState;
        public VendorPaymentMethod()
        {
            stockObserver = new StockObserver();
            //  machineState = MachineState.PaymentInProgress;
        }
        // public MachineState GetMachineState()

        public decimal ProcessPayment(Product product, decimal paymentAmount, Stock stock)
        {
            if (product is Drink) { }

            ProductType p;
            var productType = Enum.TryParse(product.Name, out p);
            int amountLeft = stock.CountProductStock(p, product);
            // Check stock amount and notify provider if it's less than 5
            if (amountLeft < 5)
            {
                ProviderDetails? providerDetails = stock.GetProvider(p);
                if (providerDetails != null)
                {
                    stockObserver.NotifyLowStock(product, providerDetails);
                }

            }
            // machineState = MachineState.ProductSelection; 
            decimal changeAmount = paymentAmount - product.Price;
            return changeAmount;
        }

        public Product ProcessProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product SelectProduct(string pro, Stock stock, bool bag, bool gift)
        {
            throw new NotImplementedException();
        }
        // return machineState;
    }




}






