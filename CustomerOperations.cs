using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace InviteCustomers
{
    public class CustomerOperations
    {
        public List<Customer> Customers { get; set; }
        public CustomerOperations()
        {
            Customers = GetCustomerData();
        }
        public List<Customer> GetCustomerData()
        {
            var customers = new List<Customer>();
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(Constants.customerListUri);
            try
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string json = reader.ReadLine();
                        var customer = JsonConvert.DeserializeObject<Customer>(json);
                        customer.SetDistance();
                        customers.Add(customer);
                    }

                }
                return customers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                stream.Close();
            }
        }

        public void CreateInvitation(List<Customer> customersToInvite)
        {
            Console.WriteLine("Invited customers:");
            Console.WriteLine("Id     |Name ");
            foreach (var customer in customersToInvite)
            {
                Console.WriteLine($"{customer.Id}     |{customer.Name} ");
            }
            Console.ReadKey();
        }

        public List<Customer> FilterCustomers( int maxDistance)
        {
            return Customers.Where(c => c.Distance <= maxDistance).OrderBy(c => c.Id).ToList();
        }
    }
}
