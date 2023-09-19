using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyffDataViewer.Classes
{
    public static class SettingsManager
    {
        public static string resourcePath;

        public static void LoadSettings()
        {
            var content = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\Settings.ini");
            foreach (var line in content)
            {
                if(line.Split('=').First() == "resourcePath")
                {
                    resourcePath = line.Split("=").Last();
                }
            }
        }
    }
}
