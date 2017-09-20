using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject.Models
{
    class Vehicle
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }


        public void LoadVehicleData(string vehicleID)
        {
            throw new NotImplementedException();
        }
    }
}
