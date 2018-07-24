using HelloWorldProject.Models;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject
{
    public static class GlobalConfig
    {
        public static MobileServiceClient MobileService =
            new MobileServiceClient(
            "https://jkcsi690.azurewebsites.net"
        );


        public static User LoggedInUser;
    }
}
