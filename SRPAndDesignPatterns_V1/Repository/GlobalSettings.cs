using SRPAndDesignPatterns_V1.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRPAndDesignPatterns_V1.Repository
{
    public class GlobalSettings : IReadableSettings,IWritableSettings
    {
        public Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();
            settings.Add("Theme", "Summer");
            return settings;
        }

        public string SetSettings(Dictionary<string, string> settings)
        {
            foreach (var item in settings)
            {
                //save to database
            }

            return "Global settings saved on " + DateTime.Now;
        }
    }
}
