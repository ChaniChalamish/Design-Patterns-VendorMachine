using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    public interface IState
    {

        Product SelectProduct(string pro,Stock stock, bool bag,bool gift);
        decimal ProcessPayment(Product product, decimal paymentAmoun,Stock stock);
        Product  ProcessProduct(Product product);

    }
}
