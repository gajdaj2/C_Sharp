using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqTest
{
    public interface IOperation
    {
        float GetAccount(Customer customer);
        float CreateAccount(Customer customer);
        float SubmitPayment(Customer customer, Payment payment);

    }
}
