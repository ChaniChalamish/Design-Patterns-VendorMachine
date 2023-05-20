using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    public class VendorPaymentMethod : State
    {
        
        private IStockObserver stockObserver;
        //private MachineState machineState;
        public VendorPaymentMethod()
        {
            stockObserver = new StockObserver();
            //  machineState = MachineState.PaymentInProgress;
        }
        // public MachineState GetMachineState()

        public override decimal ProcessPayment(Product product, decimal paymentAmount, Stock stock)
        {
          

            
           
            // machineState = MachineState.ProductSelection; 
            decimal changeAmount =  paymentAmount-product.Price;
            if (changeAmount >= 0)
            {
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
                this._vendor.TransitionTo(new VendorProcessProductMethod());
            }
            return changeAmount;
        }

        public override Product ProcessProduct(Product product)
        {
            return null;
        }

        public override Product SelectProduct(string pro, Stock stock, bool bag, bool gift)
        {
            return null;
        }
        // return machineState;
    }




}






