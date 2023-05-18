using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    public class VendorMachine
    {

        private Product? product;
        private decimal payed;
        private IState currentState;
        private Stock stock;
        private PaymentHistory paymentHistory;

        public VendorMachine()
        {
            // Initialize with product selection state
            currentState = new VendorSelectionMethod();
            stock = new Stock();
            paymentHistory = new PaymentHistory();
            Initalstock();
        }

        public void SelectProduct(string pro, bool bag, bool gift)
        {

            product = currentState.SelectProduct(pro, stock, bag, gift);
            // Transition to payment state
            currentState = new VendorPaymentMethod();
        }

        public decimal ProcessPayment(decimal paymentAmount)
        {
            payed = paymentAmount;
            decimal change = currentState.ProcessPayment(product, payed, stock);
            // Transition back to product selection state
            currentState = new VendorSelectionMethod();
            return change;
        }
        public Product ProcessProduct()
        {
            product = currentState.ProcessProduct(product);
            currentState = new VendorProcessProductMethod();
            PaymentState paymentState = new() { Date = DateTime.Now, BoughtProduct = product, PayedAmount = payed };
            paymentHistory.AddPaymentState(paymentState);
            SendReport();
            currentState = new VendorSelectionMethod();
            return product;
        }
        public void SendReport()
        {
            string reportType = "text";
            DailyReportBuilder reportBuilder = reportType switch
            {
                "text" => new TextFileReportBuilder(),
                _ => new TextFileReportBuilder(),
            };
            ReportDirector reportDirector = new(reportBuilder, paymentHistory);
            ReportScheduler reportScheduler = new(reportDirector);
            reportScheduler.ScheduleReportSending();
        }
        public void Initalstock()
        {
            Product p = new Product() { Name = "Bisly", Price = 5 };
            Product p1 = new Product() { Name = "Bisly", Price = 5 };
            Product p2 = new Product() { Name = "Bisly", Price = 5 };
            Product p3 = new Product() { Name = "Bisly", Price = 5 };
            Product p4 = new Product() { Name = "Bisly", Price = 5 };
            Product s = new Product() { Name = "Choclate", Price = 7 };
            Product s1 = new Product() { Name = "Choclate", Price = 7 };
            Product s2 = new Product() { Name = "Choclate", Price = 7 };
            Product s3 = new Product() { Name = "Choclate", Price = 7 };
            Product s4 = new Product() { Name = "Choclate", Price = 7 };
            Product s5 = new Drink() { Name="Cocoa" };
            Product s6 = new Drink() { Name = "OrangeJuice" };
            Product s7 = new Drink() { Name = "Tea" };
            Product s8 = new Drink() { Name="Cappucino"};
            Product s9 = new Drink() { Name = "IceCoffee" };
            stock.AddProduct(ProductType.Bisly, p);
            stock.AddProduct(ProductType.Bisly, p1);
            stock.AddProduct(ProductType.Bisly, p2);
            stock.AddProduct(ProductType.Bisly, p3);
            stock.AddProduct(ProductType.Bisly, p4);
            ProviderDetails pd = new() { Name = "Osem" };
            stock.SetProvider(ProductType.Bisly, pd);
            stock.AddProduct(ProductType.Choclate, s);
            stock.AddProduct(ProductType.Choclate, s1);
            stock.AddProduct(ProductType.Choclate, s2);
            stock.AddProduct(ProductType.Choclate, s3);
            stock.AddProduct(ProductType.Choclate, s4);
            ProviderDetails ps = new() { Name = "Osem" };
            stock.SetProvider(ProductType.Choclate, ps);
            stock.AddProduct(ProductType.Cocoa, s5);
            stock.AddProduct(ProductType.OrangeJuice, s6);
            stock.AddProduct(ProductType.Tea, s7);
            stock.AddProduct(ProductType.Cappuchino, s8);
            stock.AddProduct(ProductType.IceCoffee, s9);
            ProviderDetails pa = new() { Name = "Tnuva" };
            ProviderDetails pt = new() { Name = "Semitzki" };
            ProviderDetails pp = new() { Name = "Prigat" };
            stock.SetProvider(ProductType.Tea, pt);
            stock.SetProvider(ProductType.Cocoa, pa);
            stock.SetProvider(ProductType.OrangeJuice, pp);
            stock.SetProvider(ProductType.Cappuchino, pa);
            stock.SetProvider(ProductType.IceCoffee, pa);






        }




    }
}
