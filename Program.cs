using System.Collections.Generic;

namespace InviteCustomers
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerOperations = new CustomerOperations();
            List<Customer> customersToInvite = customerOperations.FilterCustomers(Constants.maxDistance);
            customerOperations.CreateInvitation(customersToInvite);
        }
    }
}
