using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRPAndDesignPatterns_V1.Models.Interface
{
    public interface IReadableSettings
    {
        Dictionary<string, string> GetSettings();
    }
}
