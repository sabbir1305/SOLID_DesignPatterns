using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SRPAndDesignPatterns_V1.Models.Interface;
using SRPAndDesignPatterns_V1.Repository;

namespace SRPAndDesignPatterns_V1.Controllers
{
    public class SettingsController : Controller
    {
        List<IReadableSettings> readableSettings = new List<IReadableSettings>();
        List<IWritableSettings> writableSettings = new List<IWritableSettings>();
        public SettingsController()
        {
            GlobalSettings g = new GlobalSettings();
            SectionSettings s = new SectionSettings();

            GuestSettings gu = new GuestSettings();
            readableSettings.Add(g);
            readableSettings.Add(s);
      
            readableSettings.Add(gu);
            writableSettings.Add(g);
            writableSettings.Add(s);
    
        }
        public IActionResult Index()
        {
            var allSettings = SettingsHelper.GetAllSettings(readableSettings);
            return View(allSettings);
        }

        public IActionResult Save()
        {
            List<Dictionary<string, string>> newSettings = new List<Dictionary<string, string>>();
            Dictionary<string, string> app = new Dictionary<string, string>();
            app.Add("Theme", "Winter");
            Dictionary<string, string> sec = new Dictionary<string, string>();
            sec.Add("Title", "Music");
            Dictionary<string, string> usr = new Dictionary<string, string>();
            usr.Add("DisplayName", "Tom");
            Dictionary<string, string> gst = new Dictionary<string, string>();
            gst.Add("GuestName", "Jerry");
            newSettings.Add(app);
            newSettings.Add(sec);
            newSettings.Add(usr);
            List<string> model = SettingsHelper.SetAllSettings(writableSettings, newSettings);
            return View(model);
        }
    }
}