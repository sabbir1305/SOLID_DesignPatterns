using SRPAndDesignPatterns_V1.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRPAndDesignPatterns_V1.Repository
{
    public class GuestSettings : IReadableSettings
    {
        public Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            settings.Add("GusetName", "John");
            return settings;
        }

        //public string SetSettings(Dictionary<string, string> settings)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
