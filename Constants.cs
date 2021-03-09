using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InviteCustomers
{
    public static class Constants
    {
        public const string customerListUri = "https://s3.amazonaws.com/intercom-take-home-test/customers.txt";
        public const double officeLatitude = 53.339428;
        public const double officeLongitude = -6.257664;
        public const int maxDistance = 100;
        public const double earthRadius = 6371.009;
    }
}
