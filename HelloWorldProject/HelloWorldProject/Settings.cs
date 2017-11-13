using HelloWorldProject.Models;
using Newtonsoft.Json;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject
{
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        private const string UserJson = "";
        private static readonly string UserJsonDefault = "";

        private const string VehicleJson = "";
        private static readonly string VehicleJsonDefault = "";


        public static User UserData
        {
            get
            {
                string data = AppSettings.GetValueOrDefault(UserJson, UserJsonDefault);
                if (String.IsNullOrEmpty(data))
                {
                    return null;
                }
                else
                {
                    return JsonConvert.DeserializeObject<User>(data);
                }
            }
            set
            {
                string data = JsonConvert.SerializeObject(value);
                AppSettings.AddOrUpdateValue(UserJson, data);
            }
        }

        public static Vehicle VehicleData
        {
            get
            {
                string data = AppSettings.GetValueOrDefault(VehicleJson, VehicleJsonDefault);
                if (String.IsNullOrEmpty(data))
                {
                    return null;
                }
                else
                {
                    return JsonConvert.DeserializeObject<Vehicle>(data);
                }
            }
            set
            {
                string data = JsonConvert.SerializeObject(value);
                AppSettings.AddOrUpdateValue(VehicleJson, data);
            }
        }

    }
}
