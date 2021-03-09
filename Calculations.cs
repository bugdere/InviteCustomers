using System;

namespace InviteCustomers
{
    public static class Calculations
    {
        public static double Deg2Rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }
        public static double CalculateCustomerDistance(Customer customer)
        {
            var deltaLambda = customer.Longitude - Constants.officeLongitude;
            double dist = Math.Sin(Deg2Rad(customer.Latitude)) * Math.Sin(Deg2Rad(Constants.officeLatitude)) +
                Math.Cos(Deg2Rad(customer.Latitude)) * Math.Cos(Deg2Rad(Constants.officeLatitude)) *
                Math.Cos(Deg2Rad(deltaLambda));
            dist = Math.Acos(dist);
            dist = Constants.earthRadius * dist;
            return (dist);
        }
    }
}
