using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InviteCustomers
{
    public class Customer
    {
        public void SetDistance()
        {
            Distance = Calculations.CalculateCustomerDistance(this);
        }

        [JsonProperty(PropertyName = "user_id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "latitude")]
        public double Latitude { get; set; }
        [JsonProperty(PropertyName = "longitude")]
        public double Longitude { get; set; }
        public double Distance { get; private set; }
    }
}
