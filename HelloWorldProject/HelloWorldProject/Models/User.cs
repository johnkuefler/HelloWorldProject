using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject.Models
{
    class User
    {
        public int ID { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public User()
        {
            this.Vehicles = new List<Vehicle>();
        }

        public void Register()
        {
            throw new NotImplementedException();
        }

        public bool Authenticate()
        {
            throw new NotImplementedException();
        }
    }
}
