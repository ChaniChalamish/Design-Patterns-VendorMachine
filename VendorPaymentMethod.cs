using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    public class VendorPaymentMethod
    {
        private Stock stock;
        private List<IStockObserver> stockObservers;

        public VendorPaymentMethod(Stock stock)
        {
            this.stock = stock;
            stockObservers = new List<IStockObserver>();
            machineState = MachineState.PaymentInProgress;
        }
        public MachineState GetMachineState()
        {
            return machineState;
        }
        public void AddStockObserver(IStockObserver observer)
        {
            stockObservers.Add(observer);
        }
        public void RemoveStockObserver(IStockObserver observer)
        {
            stockObservers.Remove(observer);
        }
        public decimal ProcessPayment(Product product, decimal paymentAmount)
        {
            // Check stock amount and notify provider if it's less than 5
            if (product is Drink drink)
            {
                fo
                foreach (var ingredient in drink.Ingredients)
                {
                    if (stock.providers.TryGetValue(ingredient, out ProviderDetails provider) &&
                        stock.drinks.ContainsKey(ingredient) && stock.drinks[ingredient].Count < 5)
                    {
                        observer.NotifyLowStock(ingredient);
                        // Notify provider using the provider details for the ingredient
                    }
                }
            }
            else if (product is Snack)
                {
                    if (!stock.snacks.Contains(product))
                    {
                        foreach (var observer in stockObservers)
                        {
                            observer.NotifyLowStock(product);
                        }
                        // Notify provider using the provider details
                    }
                }
            machineState = MachineState.ProductSelection; ;

            return changeAmount;
        }

            // Payment processing logic
        }
    }
